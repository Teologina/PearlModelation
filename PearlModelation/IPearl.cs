using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearlModelation
{
    public enum TypeOfPearl { Sweetwater, Freshwater }

    interface IPearl : IEquatable<IPearl>, IComparable<IPearl>
    {

        public int Size { get; set; }
        public string Color { get; set; }
        public string Shape { get; set; }

        public decimal Price { get;}
        public TypeOfPearl PearlType { get; set; }
        public void RandomInit();

    }
}
