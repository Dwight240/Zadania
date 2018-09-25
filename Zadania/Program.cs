using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Program
    {
        static int counter = 0;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            List<string> collection = new List<string> { "A", "B", "C","D" };
            NumberString(3, collection);
            Console.WriteLine(counter);
            string x = "a";
            Console.WriteLine(x);
            string y = x;
            Console.WriteLine(y);
            x = "c";
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.ReadKey();
        }

        public static void NumberString(int n, List<string> set, string number ="" )
        {
            if (n == 0)
            {
                //Console.WriteLine("Koniec");
                Console.WriteLine(number);
                counter++;
            }
            else
            {
                foreach (var item in set)
                {
                    List<string> newCollection = new List<string>(set);
                    newCollection.Remove(item);
                    
                    
                    NumberString(n-1,newCollection,number+item);
                }
            }
        }
    }
}
