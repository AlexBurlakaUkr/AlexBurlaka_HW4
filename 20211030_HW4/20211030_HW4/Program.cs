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
            int sizeArray = int.Parse(Console.ReadLine());
            int[] arrayRandom = new int[sizeArray];
            int[] evenArray = new int[sizeArray];
            int[] oddArray = new int[sizeArray];
            Random rmd = new Random();
            var min = 1;
            var max = 26;
            for (int i = 0; i < arrayRandom.Length; i++)
            {
                arrayRandom[i] = rmd.Next(min, max);
            }

            int countEvenArray = 0, countOddArray = 0, countEvenArrayWithoutZero = 0, countOddArrayWithoutZero = 0;
            for (int i = 0; i < arrayRandom.Length; i++)
            {
                if (arrayRandom[i] % 2 == 0)
                {
                    countEvenArray += 1;
                    evenArray[i] = arrayRandom[i];
                }
                else
                {
                    countOddArray += 1;
                    oddArray[i] = arrayRandom[i];
                }
            }

            int[] evenArrayWithoutZero = new int[countEvenArray];
            int[] oddArrayWithoutZero = new int[countOddArray];
            for (int i = 0; i < evenArray.Length; i++)
            {
                if (evenArray[i] > 0)
                {
                    evenArrayWithoutZero[countEvenArrayWithoutZero] = evenArray[i];
                    countEvenArrayWithoutZero += 1;
                }
            }

            for (int i = 0; i < oddArray.Length; i++)
            {
                if (oddArray[i] > 0)
                {
                    oddArrayWithoutZero[countOddArrayWithoutZero] = oddArray[i];
                    countOddArrayWithoutZero += 1;
                }
            }

            var alphabet = "AbcDEfgHIJklmnopqrstuvqxyz";
            char[] arrayAlphabet = alphabet.ToCharArray();
            char[] letterEvenArray = new char[evenArrayWithoutZero.Length];
            char[] letterOddArray = new char[oddArrayWithoutZero.Length];
            for (int i = 0; i < evenArrayWithoutZero.Length; i++)
            {
                int cellValue = evenArrayWithoutZero[i] - 1;
                for (int letterNumb = 0; letterNumb < arrayAlphabet.Length; letterNumb++)
                {
                    if (letterNumb == cellValue)
                    {
                        letterEvenArray[i] = arrayAlphabet[letterNumb];
                    }
                }
            }

            for (int i = 0; i < oddArrayWithoutZero.Length; i++)
            {
                int cellValue = oddArrayWithoutZero[i] - 1;
                for (int letterNumb = 0; letterNumb < arrayAlphabet.Length; letterNumb++)
                {
                    if (letterNumb == cellValue)
                    {
                        letterOddArray[i] = arrayAlphabet[letterNumb];
                    }
                }
            }

            int countOne = 0;
            for (int i = 0; i < letterEvenArray.Length; i++)
            {
                char lttr = letterEvenArray[i];
                switch (lttr)
                {
                    case 'A':
                        countOne += 1;
                        break;
                    case 'E':
                        countOne += 1;
                        break;
                    case 'I':
                        countOne += 1;
                        break;
                    case 'D':
                        countOne += 1;
                        break;
                    case 'H':
                        countOne += 1;
                        break;
                    case 'J':
                        countOne += 1;
                        break;
                    default:
                        break;
                }
            }

            int countTwo = 0;
            for (int i = 0; i < letterOddArray.Length; i++)
            {
                char lttr = letterOddArray[i];
                switch (lttr)
                {
                    case 'A':
                        countTwo += 1;
                        break;
                    case 'E':
                        countTwo += 1;
                        break;
                    case 'I':
                        countTwo += 1;
                        break;
                    case 'D':
                        countTwo += 1;
                        break;
                    case 'H':
                        countTwo += 1;
                        break;
                    case 'J':
                        countTwo += 1;
                        break;
                    default:
                        break;
                }
            }

            if (countOne > countTwo)
            {
                Console.WriteLine("\n More number of Uppercase in Even array");
            }
            else if (countOne < countTwo)
            {
                Console.WriteLine("\n More number of Uppercase in Odd array");
            }
            else
            {
                Console.WriteLine("\n Number of Uppercase the same in both arrays or absent at all ");
            }

            string joinEven = string.Join(" ", letterEvenArray);
            Console.WriteLine("\nHonest array - " + joinEven);
            string joinOdd = string.Join(" ", letterOddArray);
            Console.WriteLine("\nOdd array - " + joinOdd);
        }
    }
}
