using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitayskaya_prerepreva.Classes
{
    internal class Policeman : Unit
    {
        public override bool IsSailor => true;

        protected override bool isBeater => false;

        public override string ToString() => "Policeman";
    }
}
