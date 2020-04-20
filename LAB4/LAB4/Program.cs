using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LAB4
{
    class Program
    {
        static void Main(string[] args)
        {           
            AssemblingM assemblingMachine = new AssemblingM();
            CheckM CheckerMachine = new CheckM();
            PackingM PackingMachine = new PackingM();
            ReceiverM ReceiverMachine = new ReceiverM();
            StorageM storageMachine = new StorageM();

            List<Part> AssemblerPartList = new List<Part>();
            List<Part> CheckerPartList = new List<Part>();
            List<Part> ReceiverPartList = new List<Part>();
            List<Part> StoragePartList = new List<Part>();
            List<Part> PackerPartList = new List<Part>();
            List<Part> GeneralPartList = new List<Part>();


            Part part1 = new Part(20, 10, 20, "cross", "construct", "steel");
            Part part2 = new Part(30, 10, 20, "rod", "army", "steel");
            Part part3 = new Part(10, 20, 30, "nut", "ironx", "steel");
            Part part4 = new Part(10, 20, 30, "nut", "ironx", "steel");
            Part part5 = new Part(120, 120, 120, "plank", "construct", "wood");
            Part part6 = new Part(120, 120, 120, "plank", "construct", "wood");
            Part part7 = new Part(5, 5, 50, "pipe", "elemental", "plastic");
            Part part8 = new Part(3, 3, 40, "pipe", "elemental", "plastic");
            Part part9 = new Part(2, 2, 7, "screw", "hardeness", "steel");
            Part part10 = new Part(2, 2, 7, "screw", "hardeness", "steel");
            Part part11 = new Part(4, 4, 9, "nail", "buildd", "steel");
            Part part12 = new Part(4, 4, 9, "nail", "buildd", "steel");

            GeneralPartList.Add(part1);
            GeneralPartList.Add(part2);
            GeneralPartList.Add(part3);
            GeneralPartList.Add(part4);
            GeneralPartList.Add(part5);
            GeneralPartList.Add(part6);
            GeneralPartList.Add(part7);
            GeneralPartList.Add(part8);
            GeneralPartList.Add(part9);
            GeneralPartList.Add(part10);
            GeneralPartList.Add(part11);
            GeneralPartList.Add(part12);



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome \n");
            Console.ForegroundColor = ConsoleColor.White;

            double time = 8;

            while (time < 20 )
            {
                
                if (time < 10)
                {
                    Console.WriteLine("Waiting for 10 o clock, actual time:" + time);
                    Thread.Sleep(1000);
                    time++ ;

                }
                else if (time >= 10 )
                {
                    Console.WriteLine("Actual time " + time + " working \n");
                    foreach (var parts in GeneralPartList)
                    {


                        string statusReceiver = ReceiverMachine.ReceivercheckMemory(ReceiverPartList);
                        string statusStorage = storageMachine.StoragecheckMemory(StoragePartList);
                        string statusAssembler = assemblingMachine.AcheckMemory(AssemblerPartList);
                        string statusCheck = CheckerMachine.CcheckMemory(CheckerPartList);
                        string statusPacker = PackingMachine.PackingcheckMemory(PackerPartList);

                        if (statusReceiver == "no")
                        {
                            ReceiverPartList.Add(parts);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Added to receiver: " + ReceiverMachine.ShowInfo(parts) + "\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(3000);

                        }
                        else if (statusReceiver == "yes")
                        {
                            Console.WriteLine("Reeboting Receiver machine. . . \n");
                            ReceiverMachine.Reboot(ReceiverPartList);
                            Thread.Sleep(3000);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("||Receiver memory empty|| \n");
                            Console.ForegroundColor = ConsoleColor.White;


                        }
                        //Thread.Sleep(4000);

                        ////////////////////////////////////////////////////////////////
                        if (statusStorage == "no")
                        {
                            StoragePartList.Add(parts);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Added to storage: " + storageMachine.ShowInfo(parts) + "\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(3000);

                        }
                        else if (statusStorage == "yes")
                        {
                            Console.WriteLine("Reeboting storage machine. . . \n");
                            storageMachine.Reboot(StoragePartList);
                            Thread.Sleep(3000);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("||Storage memory empty|| \n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        
                        //Thread.Sleep(4000);
                        ////////////////////////////////////////////////////////////////
                        if (statusAssembler == "no")
                        {
                            AssemblerPartList.Add(parts);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Added to assembler: " + assemblingMachine.ShowInfo(parts) + "\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(3000);

                        }
                        else if (statusAssembler == "yes")
                        {
                            Console.WriteLine("Reeboting assembler machine. . . \n");
                            assemblingMachine.Reboot(AssemblerPartList);
                            Thread.Sleep(3000);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("||Assembler memory empty|| \n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        //Thread.Sleep(4000);
                        ////////////////////////////////////////////////////////////////
                        if (statusCheck == "no")
                        {
                            CheckerPartList.Add(parts);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Added to checker: " + CheckerMachine.ShowInfo(parts) + "\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(3000);

                        }
                        else if (statusCheck == "yes")
                        {
                            Console.WriteLine("Reeboting checker machine. . . \n");
                            CheckerMachine.Reboot(CheckerPartList);
                            Thread.Sleep(3000);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("||Checker memory empty|| \n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        //Thread.Sleep(4000);
                        ////////////////////////////////////////////////////////////////
                        if (statusPacker == "no")
                        {
                            PackerPartList.Add(parts);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Added to packer: " + PackingMachine.ShowInfo(parts) + "\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(3000);

                        }
                        else if (statusPacker == "yes")
                        {
                            Console.WriteLine("Reeboting Packer machine. . . \n");
                            assemblingMachine.Reboot(PackerPartList);
                            Thread.Sleep(3000);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("||Packer memory empty|| \n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }




                    }
                    
                }
                

            }

            
        }
    }
}
