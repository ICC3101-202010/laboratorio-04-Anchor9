using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
                
                Console.WriteLine("Reeboting Assembler machine. . . \n");
                assembling.Reboot(parts);
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("||Assembler memory empty|| \n");
                Console.ForegroundColor = ConsoleColor.White;
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
               Console.WriteLine("Reeboting Checker machine. . . \n");
               check.Reboot(parts);
               Thread.Sleep(3000);
               Console.ForegroundColor = ConsoleColor.Cyan;
               Console.WriteLine("||Checker memory empty|| \n");
               Console.ForegroundColor = ConsoleColor.White;
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
                Console.WriteLine("Reeboting Packer machine. . . \n");
                packing.Reboot(parts);
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("||Packer memory empty|| \n");
                Console.ForegroundColor = ConsoleColor.White;
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
                Console.WriteLine("Reeboting Receiver machine. . . \n");
                receiver.Reboot(parts);
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("||Receiver memory empty|| \n");
                Console.ForegroundColor = ConsoleColor.White;
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
                Console.WriteLine("Reeboting Storage machine. . . \n");
                storage.Reboot(parts);
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("||Storage memory empty|| \n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (memory_answer == "no")
            {
                Console.WriteLine("Continue working");
            }
        }




    }
}
