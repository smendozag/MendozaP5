using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MendozaP5
{
    public class SteelSprocket : Sprocket
    {
        public SteelSprocket()
        {
        }

        public SteelSprocket(int newItemID, int newNumItems, int newNumTeeth) : base(newItemID, newNumItems, newNumTeeth)
        {

        }

        protected override void Calc()
        {
            //steel price logic
            Price = NumItems * NumTeeth * 0.05M;

        }

        public override string ToString()
        {
            return "Material selected was \"Steel\"";

        }
    }
}