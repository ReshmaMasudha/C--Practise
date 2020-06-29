using System;
namespace ConsoleApp1
{
  
    class Program
    {
        public static void Main()
        {
            //INPUT [uncomment & modify if required]
            while (true)
            {
                int Weight = 0;
                Console.WriteLine("Enter the cake weight");
                Weight = int.Parse(Console.ReadLine());
                var primes = FindthePrimeNumbers(Weight);
                if (primes.Length > 1 && FindSomeOfPairsEqualsToNum(primes, Weight))
                    Console.WriteLine("Cake is for Alex");
                else
                    Console.WriteLine("Cake is for Marty");
                Console.WriteLine("");
            }
        }
        private static bool FindSomeOfPairsEqualsToNum(int[] primes, int num)
        {
            for (int i = 0; i < primes.Length; i++)
            {
                for (int j = 0; j < primes.Length; j++)
                {
                    if (i != j)
                    {
                        if (primes[i] + primes[j] == num)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private static bool IsPrimeNumber(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private static int[] FindthePrimeNumbers(int num)
        {
            string numbersFound = string.Empty;
            for (int i = 2; i <= num; i++)
            {
                if (IsPrimeNumber(i))
                    numbersFound += i;
            }
            int[] primeNumbers = new int[numbersFound.Length];
            for (int j = 0; j < numbersFound.Length; j++)
            {
                primeNumbers[j] = int.Parse((numbersFound[j] + ""));             
            }          
            return primeNumbers;
        }
    } 
}
