using System;
namespace ConsoleApp1
{
    //class Program
    //{
    //    public static bool isprime(int num)
    //    {
    //        bool flag = true;
    //        for (int i = 2; i <= num ; i++)
    //        {

    //            if (num % i == 0)
    //            {
    //                flag = false;
    //                break;
    //            }
    //            if (i == 2)
    //            {
    //                flag = true;
    //                break;
    //            }
    //        }
    //        return flag;
    //    }

    //    private static int[] FindthePrimeNumbers(int num)
    //    {
    //        string numbersFound = string.Empty;
    //        for (int i = 2; i <= num; i++)
    //        {
    //            if (isprime(i))
    //                numbersFound += i;
    //        }
    //        int[] primeNumbers = new int[numbersFound.Length];
    //        for (int j = 0; j < numbersFound.Length; j++)
    //        {
    //            primeNumbers[j] = int.Parse((numbersFound[j] + ""));
    //        }
    //        return primeNumbers;
    //    }
    //    public static void Main(string[] args)
    //    {
    //        int i, j = 0;
    //        int Variable=0;


    //        Console.WriteLine("Weight of the cake:" );
    //        int Weight = Int32.Parse(Console.ReadLine());


    //        int[] arr = FindthePrimeNumbers(Weight);

    //        for (i=0;i<arr.Length;i++)
    //        {
    //            for(j=0;j<arr.Length;j++)
    //            {
    //                if (i + j == Weight)
    //                    Variable = 1;

    //            }
    //        }

    //        if(Variable == 1)
    //            Console.WriteLine("Cake is for A");
    //        else
    //            Console.WriteLine("Cake is for B");
    //    }
    //}

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
