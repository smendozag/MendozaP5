using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MendozaP5
{
    public class SprocketOrder
    {

        //public SprocketOrder(Address address, String newCustomerName, Sprocket newItem)
        //{
        //    Address = address;
        //    CustomerName = newCustomerName;
        //    //TotalPrice = newTotalPrice;


        //}

        public SprocketOrder(string customerName, Address address, ObservableCollection<Sprocket> items)
        {
            CustomerName = customerName;
            Address = address;
            this.items = items;

        }

        public SprocketOrder() : this("TBD", null, new ObservableCollection<Sprocket>())
        {

        }



        public string CustomerName { get; set; }
        public Decimal TotalPrice { get; private set; }

        public Address Address { get; set;  }
        
        public ObservableCollection<Sprocket> items;
        public ObservableCollection<Sprocket> Items
        {
            get { return items; }
            set { items = value; Calc(); }
        }


        //public SprocketOrder() { }


      

      

        public void Add(Sprocket item)
        {
            //Add an item from the list
            items.Add(item);
            Calc();


        }

        private void Calc()
        {
            //calc the prices in the list together to get the final price
            TotalPrice = 0; 
            foreach ( var i in items)
            {
                TotalPrice += i.Price;
            }

        }

        public void Remove(Sprocket item)
        {
            //remove an item from the list
            items.Remove(item);
            Calc();
        }

        public override string ToString()
        {
            string summary = "";
            summary =  "Customer Name: " + CustomerName
                + "\nNumber Of items: " + items.Count
                + "\nTotal Price: " + TotalPrice
                + "\nAddress: " + Address;
            if(Address != null)
            {
                summary += "\nShip to Address" + Address;
            }
            else
            {
                summary += "\nLocal Pickup!";

            }
            return summary;
        }
    }
}