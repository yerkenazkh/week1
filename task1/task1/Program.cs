using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static public bool Prime(int b) // Function, which determine the prime number
        {
            if (b == 1) return false;

            for (int i = 2; i < b; i++)
            {
                if (b % i == 0) return false;// if the number will have reminder 0, when it divide to number between 2 and b, it is false 
            }
            return true;


        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());// Insert string and convert to int
            int[] a = new int[n]; // Create massive
            int cnt = 0; // counter equal to 0
            for (int i = 0; i < n; i++) //cycle to fill massive             
            {
                int b = Convert.ToInt32(Console.ReadLine());
                a[i] = b;
            }
            for (int i = 0; i < n; i++) //if it is a prime number, counter increase to 1 and show these numbers
            {
                if (Prime(a[i]))
                {
                    cnt++;// the number of prime numbers
                }
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < n; i++)
            {
                if (Prime(a[i]))
                {
                    Console.Write(a[i] + " ");// the prime numbers
                }
            }
        }
    }
}
