using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearlModelation
{
    internal class PearlNecklace: IPearlNecklace
    {
        List <IPearl> _pearls = new List <IPearl>();
        public IPearl this[int idx] {get {return _pearls[idx];}}    
       public int Count() => _pearls.Count;


        public decimal Price
        {
            get { var price = 0M;
                foreach (var item in _pearls)
                {
                    price += item.Price;
                }
            return price;
            }
        }

        public override string ToString()
        {
            string sRet = "Necklace has the following pearls:\n";
            foreach (var item in _pearls)
            {
                sRet += $"{item}\n";
            }
            return $"{sRet}" ;
        }

        internal static class Factory
        {
            internal static IPearlNecklace CreateWithRandomData(int NrOfItems)
            {
                var memberlist = new PearlNecklace();
                for (int i = 0; i < NrOfItems; i++)
                {

                        memberlist._pearls.Add(Pearl.Factory.CreateWithRandomData());


                }
                return memberlist;
            }
        }
     public void Sort() => _pearls.Sort();

      public int Count(TypeOfPearl pearls)
        {
            int c = 0;

            foreach (var pearl in _pearls)
            {
                if (pearls == pearl.PearlType)
                {
                    c++;
                }
            }
            return c;
        }
        public int IndexOf(IPearl pearl)
        {
            int found = _pearls.IndexOf(pearl);

            if (found == -1)
            { Console.WriteLine($"Pearl not found"); }
            else
                Console.WriteLine($"Found pearl at index {found}");
            return found;
        }
    
    }
}
