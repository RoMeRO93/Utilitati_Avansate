using System;

namespace MathUtilityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bun venit in aplicatia utilitara pentru matematica!");

            while (true)
            {
                Console.WriteLine("\nAlegeti una dintre urmatoarele optiuni:");
                Console.WriteLine("1. Calculati media a n numere");
                Console.WriteLine("2. Calculati factorialul unui numar");
                Console.WriteLine("3. Verificati daca un numar este prim");
                Console.WriteLine("4. Iesiti din aplicatie");

                Console.Write("Optiune: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    CalculateAverage();
                }
                else if (input == "2")
                {
                    CalculateFactorial();
                }
                else if (input == "3")
                {
                    CheckPrimeNumber();
                }
                else if (input == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Optiune invalida. Va rugam sa introduceti un numar de optiune valid.");
                }
            }
        }

        static void CalculateAverage()
        {
            Console.Write("Introduceti numarul de elemente: ");
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += numbers[i];
            }

            double average = sum / count;

            Console.WriteLine($"Media numerelor introduse este: {average}");
        }

        static void CalculateFactorial()
        {
            Console.Write("Introduceti un numar: ");
            int number = int.Parse(Console.ReadLine());

            int factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorialul numarului {number} este: {factorial}");
        }

        static void CheckPrimeNumber()
        {
            Console.Write("Introduceti un numar: ");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{number} este un numar prim.");
            }
            else
            {
                Console.WriteLine($"{number} nu este un numar prim.");
            }
        }
        // ...

        static void CalculateSquareRoot()
        {
            Console.Write("Introduceti un numar: ");
            double number = double.Parse(Console.ReadLine());

            double squareRoot = Math.Sqrt(number);

            Console.WriteLine($"Radicalul numarului {number} este: {squareRoot}");
        }

        static void CalculatePower()
        {
            Console.Write("Introduceti baza: ");
            double baseNumber = double.Parse(Console.ReadLine());

            Console.Write("Introduceti exponentul: ");
            double exponent = double.Parse(Console.ReadLine());

            double result = Math.Pow(baseNumber, exponent);

            Console.WriteLine($"{baseNumber} ridicat la puterea {exponent} este: {result}");
        }

        static void GenerateRandomNumber()
        {
            Console.Write("Introduceti limita inferioara: ");
            int minValue = int.Parse(Console.ReadLine());

            Console.Write("Introduceti limita superioara: ");
            int maxValue = int.Parse(Console.ReadLine());

            Random random = new Random();
            int randomNumber = random.Next(minValue, maxValue + 1);

            Console.WriteLine($"Numarul generat aleator intre {minValue} si {maxValue} este: {randomNumber}");
        }

        static void ConvertToBinary()
        {
            Console.Write("Introduceti un numar: ");
            int number = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(number, 2);

            Console.WriteLine($"Reprezentarea binara a numarului {number} este: {binary}");
        }

        static void ReverseString()
        {
            Console.Write("Introduceti un sir de caractere: ");
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);

            Console.WriteLine($"Sirul inversat este: {reversedString}");
        }

        static void CheckPalindrome()
        {
            Console.Write("Introduceti un sir de caractere: ");
            string input = Console.ReadLine();

            string reversedInput = new string(input.ToCharArray().Reverse().ToArray());

            bool isPalindrome = input.Equals(reversedInput, StringComparison.OrdinalIgnoreCase);

            if (isPalindrome)
            {
                Console.WriteLine($"{input} este un palindrom.");
            }
            else
            {
                Console.WriteLine($"{input} nu este un palindrom.");
            }
        }

        // ...

        // ...

        static void CountWords()
        {
            Console.Write("Introduceti un text: ");
            string text = Console.ReadLine();

            int wordCount = text.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;

            Console.WriteLine($"Numarul de cuvinte din text este: {wordCount}");
        }

        static void CalculateFactorialRecursive()
        {
            Console.Write("Introduceti un numar: ");
            int number = int.Parse(Console.ReadLine());

            int factorial = CalculateFactorial(number);

            Console.WriteLine($"Factorialul numarului {number} este: {factorial}");
        }

        static int CalculateFactorial(int number)
        {
            if (number == 0)
                return 1;
            else
                return number * CalculateFactorial(number - 1);
        }

        // ...

        // ...

        static void CheckLeapYear()
        {
            Console.Write("Introduceti un an: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeapYear = DateTime.IsLeapYear(year);

            if (isLeapYear)
            {
                Console.WriteLine($"{year} este un an bisect.");
            }
            else
            {
                Console.WriteLine($"{year} nu este un an bisect.");
            }
        }

        static void CalculateFibonacciSequence()
        {
            Console.Write("Introduceti numarul de elemente din secventa Fibonacci: ");
            int count = int.Parse(Console.ReadLine());

            int[] sequence = new int[count];

            for (int i = 0; i < count; i++)
            {
                if (i == 0 || i == 1)
                {
                    sequence[i] = i;
                }
                else
                {
                    sequence[i] = sequence[i - 1] + sequence[i - 2];
                }
            }

            Console.WriteLine("Secventa Fibonacci este:");
            foreach (int number in sequence)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }

        // ...
        // ...

        static void CalculateGreatestCommonDivisor()
        {
            Console.Write("Introduceti primul numar: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea numar: ");
            int number2 = int.Parse(Console.ReadLine());

            int gcd = CalculateGCD(number1, number2);

            Console.WriteLine($"Cel mai mare divizor comun al numerelor {number1} si {number2} este: {gcd}");
        }

        static int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }

            return a;
        }

        static void ReverseNumber()
        {
            Console.Write("Introduceti un numar: ");
            int number = int.Parse(Console.ReadLine());

            int reversedNumber = ReverseDigits(number);

            Console.WriteLine($"Numarul inversat este: {reversedNumber}");
        }

        static int ReverseDigits(int number)
        {
            int reversedNumber = 0;

            while (number != 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }

            return reversedNumber;
        }

        // ...
        // ...

        static void CalculateFactorialIterative()
        {
            Console.Write("Introduceti un numar: ");
            int number = int.Parse(Console.ReadLine());

            int factorial = CalculateFactorialIter(number);

            Console.WriteLine($"Factorialul numarului {number} este: {factorial}");
        }

        static int CalculateFactorialIter(int number)
        {
            int result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        static void PrintTrianglePattern()
        {
            Console.Write("Introduceti numarul de linii: ");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // ...

    }
}
