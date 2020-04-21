using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class PackingM : Machine
    {
        public PackingM()
        {
        }

        public void AddPartPackingList(Part part, List<Part> parts)
        {
            int weight = part.Weight;
            int height = part.Height;
            string brand = part.Brand;
            int width = part.Width;
            string material = part.Material;
            string type = part.Type;

            parts.Add(new Part(weight, height, width, type, brand, material));
        }

        public string PackingcheckMemory(List<Part> parts)
        {
            int parts_quantity = parts.Count();
            string answer;

            if (parts_quantity >= 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Packer memory full, please reboot Machine");
                Console.ForegroundColor = ConsoleColor.White;
                answer = "yes";
                return answer;
            }
            else
            {
                Console.WriteLine("Memory not yet full");
                answer = "no";
                return answer;
            }
        }

        public string ShowInfo(Part part)
        {
            return part.Type + " " + part.Brand + " " + part.Material;
        }
        public override void TurnOff()
        {
            Console.WriteLine("Workday finished, turnning of Assembler");
        }
        public override void TurnOn()
        {
            Console.WriteLine("It's time, Packer machine working");
        }
        public override void Reboot(List<Part> parts)
        {
            parts.Clear();
        }
    }
}
