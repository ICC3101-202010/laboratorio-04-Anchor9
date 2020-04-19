using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class Computer
    {
        private string name;

        public Computer()
        {
        }

        public string Name { get => name; set => name = value; }


        public void GetAdviceAssembly(string memory_answer, AssemblingM assembling, List<Part> parts) 
        {
            
            if (memory_answer == "yes")
            {
                assembling.Reboot(parts);
            }
            else if(memory_answer =="no")
            {
                Console.WriteLine("Continue working");
            }
        }
        public void GetAdviceCheck(string memory_answer, CheckM check, List<Part> parts)
        {

            if (memory_answer == "yes")
            {
               check.Reboot(parts);
            }
            else if (memory_answer == "no")
            {
                Console.WriteLine("Continue working");
            }
        }
        public void GetAdvicePacking(string memory_answer, PackingM packing, List<Part> parts)
        {

            if (memory_answer == "yes")
            {
                packing.Reboot(parts);
            }
            else if (memory_answer == "no")
            {
                Console.WriteLine("Continue working");
            }
        }
        public void GetAdviceReceiver(string memory_answer, ReceiverM receiver, List<Part> parts)
        {

            if (memory_answer == "yes")
            {
                receiver.Reboot(parts);
            }
            else if (memory_answer == "no")
            {
                Console.WriteLine("Continue working");
            }
        }
        public void GetAdviceStorage(string memory_answer, StorageM storage, List<Part> parts)
        {

            if (memory_answer == "yes")
            {
                storage.Reboot(parts);
            }
            else if (memory_answer == "no")
            {
                Console.WriteLine("Continue working");
            }
        }




    }
}
