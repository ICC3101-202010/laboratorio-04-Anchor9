using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class Part
    {
        private int weight;
        private int height;
        private int width;
        private string type;
        private string brand;
        private string material;
        private List<Part> parts;

        public Part(int Weight, int Height, int Width, string Type, string Brand, string Material)
        {
            weight = Weight;
            height = Height;
            width = Width;
            type = Type;
            brand = Brand;
            material = Material;
        }

        public int Weight { get => weight ; set => weight = value; }
        public int Width { get => width; set => width = value; }
        public string Type { get => type; set => type = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Material { get => material; set => material = value; }
        public int Height { get => Height; set => Height = value; }




    }
}
