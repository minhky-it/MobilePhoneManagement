using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Project
{
    public class PlaceOrders_Object
    {
        private string name;

        public PlaceOrders_Object(string name)
        {
            this.name = name;
        }

        public string get_Name
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
    }
}
