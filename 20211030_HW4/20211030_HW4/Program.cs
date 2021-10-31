using System;

namespace HW4
{
    /// <summary>
    /// Main program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Messeg into console.
        /// </summary>
        /// <param name="args">console call params.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int sizearray = int.Parse(Console.ReadLine());
            int[] arrayRandom = new int[sizearray];
            int[] honestarray = new int[sizearray];
            int[] oddarray = new int[sizearray];
            Random rmd = new Random();
            var min = 1;
            var max = 26;
            for (int i = 0; i < arrayRandom.Length; i++)
            {
                arrayRandom[i] = rmd.Next(min, max);
            }

            string a = string.Join(" ", arrayRandom);
            Console.WriteLine(a);
            for (int i = 0; i < arrayRandom.Length; i++)
            {
                if (arrayRandom[i] % 2 == 0)
                {
                    honestarray[i] = arrayRandom[i];
                }
                else
                {
                    oddarray[i] = arrayRandom[i];
                }
            }

            int[] honestarraywithoutzero = Array.FindAll(honestarray, i => i > 0);
            foreach (var i in honestarraywithoutzero)
            {
                Console.WriteLine(i);
            }

            int[] oddarraywithoutzero = Array.FindAll(oddarray, i => i > 0);
            foreach (var i in oddarraywithoutzero)
            {
                Console.WriteLine(i);
            }

            /*foreach (var i in arrayRandom)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}
