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
            List<Part> ReceiverrPartList = new List<Part>();
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




            Console.WriteLine("Welcome");

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
                    Console.WriteLine("Actual time"+ time + "working");
                    foreach (var parts in GeneralPartList) 
                    {
                        AssemblerPartList.Add(parts);
                        assemblingMachine.AcheckMemory(AssemblerPartList);
                        Console.WriteLine("Added: " + assemblingMachine.ShowInfo(parts));
                        Thread.Sleep(3000);
                    }
                    
                }
                

            }

            
        }
    }
}
