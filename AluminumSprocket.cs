using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MendozaP5
{
    public class AluminumSprocket : Sprocket
    {
        public AluminumSprocket()
        {

        }
        public AluminumSprocket(int newItemID, int newNumItems, int newNumTeeth) : base(newItemID,  newNumItems, newNumTeeth)
        {

        }

        protected override void Calc()
        {
            //Logic for Alumunum sprocket
            Price = NumItems * NumTeeth * 0.04M;

        }

        public override string ToString()
        {
            return "Material selected was \"Aluminum\" ";

        }
    }
}