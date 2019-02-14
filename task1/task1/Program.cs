using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1                 
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//Convert string into int
            string[] s = Console.ReadLine().Split();//read the line as a string and split it be space
            int[] a = new int[n];//create a new array with integers
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(s[i]);
            }//this cycle need to place string into array
            int prime = 0;//size of new array with integers
            int[] ans = new int[n];//new array for prime numbers
            for (int i = 0; i < n; i++)
            {
                int del = 0;//counter for divider
                for (int j = 1; j <= a[i]; j++)
                {
                    if (a[i] % j == 0)
                    del++;
                }
                if (del == 2)
                {
                    ans[prime] = a[i];
                    prime++;
                }
            }
            Console.WriteLine(prime);
            for (int i = 0; i < prime; i++)
                Console.Write(ans[i] + " ");
            

        }
    }
}
