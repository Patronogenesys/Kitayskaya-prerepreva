using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitayskaya_prerepreva.Classes
{
    internal class Mom : Unit
    {
        public override bool IsSailor => true;

        protected override bool isBeater => true;

        public override bool isConflictBlocker(Unit u) => u is Dad;

        public override bool isConflictUnit(Unit u) => u is Son;

        public override string ToString() => "Mom";

    }
}
