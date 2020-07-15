using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MendozaP5
{
    public class Address
    {
        public string City { get; set; }
       

        public string State { get; set; }

        public string Street { get; set; }

        public string  ZipCode { get; set; }
        
        public override string ToString()
        {
            return City + State + Street + ZipCode;
        }

    }
}