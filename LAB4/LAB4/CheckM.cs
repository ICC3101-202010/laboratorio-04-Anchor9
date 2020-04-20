using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class CheckM : Machine
    {
        private List<Part> parts;
        public CheckM()
        {
        }

        public void AddPartCheckList(Part part, List<Part> parts)
        {
            int weight = part.Weight;
            int height = part.Height;
            string brand = part.Brand;
            int width = part.Width;
            string material = part.Material;
            string type = part.Type;

            parts.Add(new Part(weight, height, width, type, brand, material));
        }

        public string CcheckMemory(List<Part> parts)
        {
            int parts_quantity = parts.Count();
            string answer;

            if (parts_quantity >= 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Checker memory full, please reboot Machine");
                Console.ForegroundColor = ConsoleColor.White;
                answer = "yes";
                return answer;
            }
            else
            {
                Console.WriteLine("Checker Memory not yet full");
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
            Console.WriteLine("Workday finished, turnning of Checker");
        }
        public override void TurnOn()
        {
            Console.WriteLine("It's time, Checker machine working");
        }
        public override void Reboot(List<Part> parts)
        {
            parts.Clear();
        }
    }

}
