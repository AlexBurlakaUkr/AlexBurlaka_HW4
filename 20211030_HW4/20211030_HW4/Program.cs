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
            int[] oddarraywithoutzero = Array.FindAll(oddarray, i => i > 0);
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
                    }
                }
            }

            int count = 0;
            for (int i = 0; i < letterhonestarray.Length; i++)
            {
                char lttr = letterhonestarray[i];
                switch (lttr)
                {
                    case 'A':
                        count += +1;
                        break;
                    case 'E':
                        count += +1;
                        break;
                    case 'I':
                        count += +1;
                        break;
                    case 'D':
                        count += +1;
                        break;
                    case 'H':
                        count += +1;
                        break;
                    case 'J':
                        count += +1;
                        break;
                    default:
                        break;
                }
            }

            int counttwo = 0;
            for (int i = 0; i < letteroddarray.Length; i++)
            {
                char lttr = letteroddarray[i];
                switch (lttr)
                {
                    case 'A':
                        counttwo += +1;
                        break;
                    case 'E':
                        counttwo += +1;
                        break;
                    case 'I':
                        counttwo += +1;
                        break;
                    case 'D':
                        counttwo += +1;
                        break;
                    case 'H':
                        counttwo += +1;
                        break;
                    case 'J':
                        counttwo += +1;
                        break;
                    default:
                        break;
                }
            }

            if (count > counttwo)
            {
                Console.WriteLine("\nMore number of Uppercase in Honest array");
            }
            else if (count < counttwo)
            {
                Console.WriteLine("\nMore number of Uppercase in Odd array");
            }
            else
            {
                Console.WriteLine("\nNumber of Uppercase the same in both arrays");
            }

            string joinhonest = string.Join(" ", letterhonestarray);
            Console.WriteLine("\nHonest array - " + joinhonest);
            string joinodd = string.Join(" ", letteroddarray);
            Console.WriteLine("\nOdd array - " + joinodd);
        }
    }
}
