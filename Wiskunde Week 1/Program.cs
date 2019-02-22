using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Wiskunde_Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> getallen = new List<int>();
            for(int i = 0; i <= 120; i++)
            {
                getallen.Add(i);

            }
            foreach (int i in getallen.ToList())
            {
                if (i % 2 == 0)
                {
                    getallen.Remove(i);
                }
            }
            foreach (int i in getallen.ToList())
            {
                if (i % 3 == 0)
                {
                    getallen.Remove(i);
                }
            }
            foreach (int i in getallen.ToList())
            {
                if (i % 5 == 0)
                {
                    getallen.Remove(i);
                }
            }
            foreach (int i in getallen.ToList())
            {
                if (i % 7 == 0)
                {
                    getallen.Remove(i);
                }
            }
            getallen.RemoveAt(0);
            getallen.InsertRange(0, new int[] {2, 3, 5, 7 });
            foreach(int i in getallen)
            { 
                Console.Write(i + ", ");
            }
            Console.WriteLine(getallen.Count + "aantal priemgetallen");
            Console.Read();
            

        }
     
       
    }
}
