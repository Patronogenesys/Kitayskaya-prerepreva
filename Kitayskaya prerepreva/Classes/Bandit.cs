using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitayskaya_prerepreva.Classes
{
    public class Bandit : Unit
    {
        public override bool IsSailor => false;

        protected override bool isBeater => true;

        public override bool isConflictBlocker(Unit u) => u is Policeman;

        public override bool isConflictUnit(Unit u) => u is not Policeman;

        public override string ToString() => "Bandit";
    }
}
