using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace writingfromarraytolistandhashset
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[990001];//intializing the array for 100000
                 Random gen = new Random();//initializing the randon number generator
                 Stopwatch mywatch = new Stopwatch();// initialing the stopwatch
                
                 for (int i = 0; i <= 990000; i++)
                 {
                     int j = (int)(gen.NextDouble() * 1) + (1000 + i);// creating the number from 1000 to .....1000000
   
                     myarray[i] = j;//store the number in the ith array
                     
                    
                 }
                                 
                List<int> mylist = myarray.ToList();//Converting the 1000000 number generated to alist
                 HashSet<int> myhash = new HashSet<int>(myarray);//passing the array in a hashset


                 int q = 0;
                 mywatch.Start();// starts the stopwatch
                 foreach (int k in mylist)// to get the data from the list
                 {
                     q = q + 1;
                     if (q <= 1000)// geting the first 1000
                     {
                         if (k < 5000)// checking if the number is less than 5000
                         {
                             // mylist.Reverse();
                             Console.WriteLine(k);// printing out the first 5000

                         }


                     }

                 }
                 mywatch.Stop();// stopwatch stops

                Console.WriteLine("elapsed time of the list{0}", mywatch.Elapsed);// check the elapsed time
                Console.ReadLine();// press enter to see the hashsets
            
                

               


                 int g = 0;
                 mywatch.Start();// stopwatch starts

                 foreach (int k in myhash)// getting the data from hashset
                 {
                     g = g + 1;
                     if (g <= 1000)// getting the first 1000
                     {
                         if (k < 5000)// checking if its less than 5000
                         {
                             // mylist.Reverse();
                             Console.WriteLine(k);// geting the random number
                         }

                     }

                 }
                 mywatch.Stop();// stowatch stops
                 Console.WriteLine("elapsed time of the hashset{0}", mywatch.Elapsed);// check elapsed time
                 Console.ReadLine();
 
            
        }
        
    }
}
