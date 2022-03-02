using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearlModelation
{
    interface IPearlNecklace
    {
        public IPearl this[int idx] { get; }
         public  int Count();
          public void Sort();
        public int Count(TypeOfPearl pearls);

        public decimal Price { get; }

        public int IndexOf(IPearl pearl);
    }
}
