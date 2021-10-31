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

            var alfabet = "abcdefghijklmnopqrstuvqxyz";
            alfabet = alfabet.Replace("a", "A").Replace("e", "E").Replace("i", "I").Replace("d", "D").Replace("h", "H").Replace("j", "J");
            char[] arrayalfabet = alfabet.ToCharArray();
            char[] letterhonestarray = new char[honestarraywithoutzero.Length];
            char[] letteroddarray = new char[oddarraywithoutzero.Length];
            for (int i = 0; i < honestarraywithoutzero.Length; i++)
            {
                int cellValue = honestarraywithoutzero[i] - 1;
                for (int letternumb = 0; letternumb < arrayalfabet.Length; letternumb++)
                {
                    if (letternumb == cellValue)
                    {
                        letterhonestarray[i] = arrayalfabet[letternumb];
                        Console.WriteLine(letterhonestarray[i]);
                    }
                }
            }

            for (int i = 0; i < oddarraywithoutzero.Length; i++)
            {
                int cellValue = oddarraywithoutzero[i] - 1;
                for (int letternumb = 0; letternumb < arrayalfabet.Length; letternumb++)
                {
                    if (letternumb == cellValue)
                    {
                        letteroddarray[i] = arrayalfabet[letternumb];
                        Console.WriteLine(letteroddarray[i]);
                    }
                }
            }

            /*foreach (var i in arrayRandom)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}
