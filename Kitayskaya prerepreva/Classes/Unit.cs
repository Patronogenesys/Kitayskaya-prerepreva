using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitayskaya_prerepreva.Classes
{
    public abstract class Unit
    {
        public abstract bool IsSailor { get; }
        public virtual bool TryFindConflict(List<Unit> place, out Unit? beatenUnit)
        {
            Unit? lastBeatenUnit = null;
            if (!isBeater)
            {
                beatenUnit = null;
                return false;
            }

            foreach (var unit in place)
            {
                if (unit == this)
                    continue;
                if (isConflictBlocker(unit))
                {
                    beatenUnit = null;
                    return false;
                }
                if (isConflictUnit(unit))
                {
                    lastBeatenUnit = unit;
                }

            }
            beatenUnit = lastBeatenUnit;
            return lastBeatenUnit != null;
        }

        protected abstract bool isBeater { get; }
        public virtual bool isConflictBlocker(Unit u) => false;
        public virtual bool isConflictUnit(Unit u) => false;
    }
}
