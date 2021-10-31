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
            Random rmd = new Random();
            var min = 1;
            var max = 26;
            for (int i = 0; i < arrayRandom.Length; i++)
            {
                arrayRandom[i] = rmd.Next(min, max);
            }

            string a = string.Join(" ", arrayRandom);
            Console.WriteLine(a);
            /*foreach (var i in arrayRandom)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}
