using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class AssemblingM
    {
        private List<Part> parts;

        public AssemblingM()
        {
        }

        public void AddPartsAssemblyList(Part part, List<Part> parts)
        {
            int weight = part.Weight;
            int height = part.Height;
            string brand = part.Brand;
            int width = part.Width;
            string material = part.Material;
            string type = part.Type;

            parts.Add(new Part(weight, height, width, type, brand, material));
        }

        public string AcheckMemory(List<Part> parts) 
        {
            int parts_quantity = parts.Count();
            string answer;

            if (parts_quantity >= 7)
            {
                Console.WriteLine("Assembly memory full, please reboot Machine");
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
        public void AEmptyMemory(List<Part> parts) 
        {
            parts.Clear();
        }

    }

}
