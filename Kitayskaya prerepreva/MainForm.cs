using Kitayskaya_prerepreva.Classes;

namespace Kitayskaya_prerepreva
{
    public partial class MainForm : Form
    {
        private bool IsBoatOnLeft => btnLeftToBoat.Enabled;
        private bool IsBoatOnRight => btnRightToBoat.Enabled;
        public MainForm()
        {
            InitializeComponent();

            lbLeftBeach.Items.Add(new Policeman());
            lbLeftBeach.Items.Add(new Bandit());

            lbLeftBeach.Items.Add(new Mom());
            lbLeftBeach.Items.Add(new Daughter());
            lbLeftBeach.Items.Add(new Daughter());

            lbLeftBeach.Items.Add(new Dad());
            lbLeftBeach.Items.Add(new Son());
            lbLeftBeach.Items.Add(new Son());

            lError.Text = "";
        }

        private void btnLeftToBoat_Click(object sender, EventArgs e)
        {
            int index = lbLeftBeach.SelectedIndex;
            if (lbBoat.Items.Count >= 2 || index == -1)
                return;
            MoveAtIndex(ref lbLeftBeach, index, ref lbBoat);
        }


        private void btnBoatToRight_Click(object sender, EventArgs e)
        {
            if (IsBoatOnLeft && !TrySail(lbBoat))
            {
                lError.Text = "There is no sailor in the boat";
                return;
            }
            if (TryFindConflict(lbLeftBeach, lbBoat, lbRightBeach, out Unit? beater, out Unit? beaten))
            {
                lError.Text = $"{beater} is beating {beaten}!!! (╯‵□′)╯︵┻━┻";
                MoveAll(ref lbBoat, ref lbLeftBeach);
                return;
            }
            MoveAll(ref lbBoat, ref lbRightBeach);

            lError.Text = "";
            btnLeftToBoat.Enabled = false;
            btnRightToBoat.Enabled = true;
            CheckVictory();
        }


        private void btnRightToBoat_Click(object sender, EventArgs e)
        {
            int index = lbRightBeach.SelectedIndex;
            if (lbBoat.Items.Count >= 2 || index == -1)
                return;
            MoveAtIndex(ref lbRightBeach, index, ref lbBoat);
        }

        private void btnBoatToLeft_Click(object sender, EventArgs e)
        {
            if (IsBoatOnRight && !TrySail(lbBoat))
            {
                lError.Text = "There is no sailor in the boat";
                return;
            }
            if (TryFindConflict(lbRightBeach, lbBoat, lbLeftBeach, out Unit? beater, out Unit? beaten))
            {
                lError.Text = $"{beater} is beating {beaten}!!! (╯‵□′)╯︵┻━┻";
                MoveAll(ref lbBoat, ref lbRightBeach);
                return;
            }
            MoveAll(ref lbBoat, ref lbLeftBeach);
            lError.Text = "";
            btnRightToBoat.Enabled = false;
            btnLeftToBoat.Enabled = true;
        }


        private void MoveAtIndex(ref ListBox lbFrom, int fromIndex, ref ListBox lbTo)
        {
            Unit unit = lbFrom.Items[fromIndex] as Unit;
            if (unit == null) return;
            lbTo.Items.Add(unit);
            lbFrom.Items.RemoveAt(fromIndex);
        }

        private void MoveAll(ref ListBox from, ref ListBox to)
        {
            for (int index = from.Items.Count - 1; index >= 0; index--)
                MoveAtIndex(ref from, index, ref to);
        }

        private bool TryFindConflict(ListBox lbStatic, ListBox lbBoat, ListBox lbUpdating, out Unit? beaterUnit, out Unit? beatenUnit)
        {
            List<Unit> place = new();
            foreach (var item in lbStatic.Items)
                if (item is Unit unit)
                    place.Add(unit);
            foreach (var unit in place)
            {
                if (unit.TryFindConflict(place, out beatenUnit))
                {
                    beaterUnit = unit;
                    return true;
                }
            }

            place.Clear();

            foreach (var item in lbBoat.Items)
                if (item is Unit unit)
                    place.Add(unit);
            foreach (var item in lbUpdating.Items)
                if (item is Unit unit)
                    place.Add(unit);

            foreach (var unit in place)
            {
                if (unit.TryFindConflict(place, out beatenUnit))
                {
                    beaterUnit = unit;
                    return true;
                }
            }

            beaterUnit = null;
            beatenUnit = null;
            return false;
        }

        private bool TrySail(ListBox boat)
        {
            foreach (var item in boat.Items)
            {
                if (item is Unit unit && unit.IsSailor)
                    return true;
            }
            return false;
        }
        private void CheckVictory()
        {
            if (lbLeftBeach.Items.Count <= 0 && lbBoat.Items.Count <= 0)
            {
                MessageBox.Show("Yo won! 你贏了!");
                Application.Exit();
            }
        }
    }

}