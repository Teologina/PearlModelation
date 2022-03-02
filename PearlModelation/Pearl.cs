using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearlModelation
{
    internal class Pearl: IPearl
    {

        public int Size { get; set; }
        public string Color { get; set; }
        public string Shape { get; set; }

        public const decimal BasePrice = 25M;
        public const int MinPrice = 5;
        public const decimal MaxPrice = 25;
        public decimal Price
        {
            get {
                var price = Size * BasePrice;
                if (PearlType == TypeOfPearl.Sweetwater)
                {
                    price *= 2;
                }
                return price;
                    
                    }
        }

        public TypeOfPearl PearlType { get; set; }
        public override string ToString() => $"Type: {GetType().Name} is a {Size}mm in diameter, {Shape} {PearlType} pearl and has the color of {Color}";

        public void RandomInit()
        {
            var rnd = new Random();
            bool bAllOK = false;
            while (!bAllOK)
            {
                try
                {

                    string[] _shapes = "Oval Round Chipped Flawless".Split(' ');
                    int[] _sizes = { 25, 20, 15, 10, 5 };
                    string[] _colors = "Purple Green Blue Orange Red".Split(' ');
                    this.Size = _sizes[rnd.Next(0, _sizes.Length)];
                    this.Color = _colors[rnd.Next(0, _colors.Length)];
                    this.Shape = _shapes[rnd.Next(0, _shapes.Length)];

                    this.PearlType = (TypeOfPearl)rnd.Next((int)TypeOfPearl.Sweetwater, (int)TypeOfPearl.Freshwater + 1);

                    bAllOK = true;
                }
                catch { }
            }
        }

        public int CompareTo(IPearl other)
        {
            if (Size != other.Size)
                return Size.CompareTo(other.Size);
            if (Color != other.Color)
                return Color.CompareTo(other.Color);

            if (Shape != other.Shape)
                return Shape.CompareTo(other.Shape);


            return PearlType.CompareTo(other.PearlType);
        }

        public bool Equals(IPearl other) => (this.Size, this.Shape, this.Color, this.PearlType) ==
    (other.Size, other.Shape, other.Color, other.PearlType);

        // legacy .NET compliance
        public override bool Equals(object obj) => Equals(obj as IPearl);
        public override int GetHashCode() => (this.Size, this.Shape, this.Color, this.PearlType).GetHashCode();
        internal static class Factory
        {
            internal static IPearl CreateWithRandomData()
            {
                var pearl = new Pearl();
                pearl.RandomInit();
                return pearl;
            }
        }
        public Pearl()
        {

        }

    }
}
