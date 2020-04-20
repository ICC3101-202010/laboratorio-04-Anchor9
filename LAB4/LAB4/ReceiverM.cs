using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class ReceiverM : Machine
    {
        public ReceiverM()
        {
        }

        public void AddPartReceiverList(Part part, List<Part> parts)
        {
            int weight = part.Weight;
            int height = part.Height;
            string brand = part.Brand;
            int width = part.Width;
            string material = part.Material;
            string type = part.Type;

            parts.Add(new Part(weight, height, width, type, brand, material));
        }

        public string ShowInfo(Part part)
        {
            return part.Type + " " + part.Brand + " " + part.Material;
        }

        public string ReceivercheckMemory(List<Part> parts)
        {
            int parts_quantity = parts.Count();
            string answer;

            if (parts_quantity >= 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Receiver memory full, please reboot Machine");
                Console.ForegroundColor = ConsoleColor.White;
                answer = "yes";
                return answer;
            }
            else
            {
                Console.WriteLine("Receiver Memory not yet full");
                answer = "no";
                return answer;
            }
        }
        public override void TurnOff()
        {
            Console.WriteLine("Workday finished, turnning of Receiver");
        }
        public override void TurnOn()
        {
            Console.WriteLine("It's time, Receiver machine working");
        }
        public override void Reboot(List<Part> parts)
        {
            parts.Clear();
        }
    }
}
