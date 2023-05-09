using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitayskaya_prerepreva.Classes
{
    internal class Daughter : Unit
    {
        public override bool IsSailor => false;

        protected override bool isBeater => false;

        public override string ToString() => "Daughter";

    }
}
