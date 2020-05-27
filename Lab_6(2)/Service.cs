using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2_
{
     class Service
    {
        double price;

        int type;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }
      /*  public double Price
        {
            get { return price; }
            set { price = value; }
        }*/

        public Service(int type)
        {
                this.type = type;
        }
    }
}
