using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendozaP5
{
    public abstract class Sprocket
    {
        private int numItems;
        private int numTeeth;

        //Constructors
        public Sprocket():this(-1, 1, 1)
        {

        }

        public Sprocket(int newItemID, int newNumItems, int newNumTeeth)
        {
            this.ItemID = newItemID;
            this.numItems = newNumItems;
            this.numTeeth = newNumTeeth;
            Calc();

        }

       //Properties
        public int NumItems
        {
            get { return numItems; }
            set { numItems = value;}
        }

        public int NumTeeth
        {
            get { return numTeeth; }
            set { numTeeth = value;  }
        }

        public decimal Price { get; protected set; }
        public int ItemID { get; private set; }


        //methods
        protected abstract void Calc();
        
        public override string ToString()
        {
            return "Your Order Number is " + ItemID
                + "\nNumber of Teeth: " + numTeeth
                + "\nMaterial Ordered: " + numItems
                + "\nTotal Price: " + Price;
        }
    }
}
