using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MendozaP5
{
    public class PlasticSprocket : Sprocket
    {
        public PlasticSprocket()
        {
        }

        public PlasticSprocket(int newItemID, int newNumItems, int newNumTeeth) : base(newItemID,  newNumItems, newNumTeeth)
        {
        }


        protected override void Calc()
        {
            //Logic for Plastc Sprockets   
            Price = NumItems * NumTeeth * 0.02M;
        }

        public override string ToString()
        {
            return "Material selected was \"Plastic\" ";
        }
    }
}