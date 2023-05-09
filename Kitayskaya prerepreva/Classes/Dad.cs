using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitayskaya_prerepreva.Classes
{
    internal class Dad : Unit
    {
        public override bool IsSailor => true;

        protected override bool isBeater => true;

        public override bool isConflictBlocker(Unit u) => u is Mom;

        public override bool isConflictUnit(Unit u) => u is Daughter;
        public override string ToString() => "Dad";


    }
}
