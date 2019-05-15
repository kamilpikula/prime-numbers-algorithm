using System;
using System.Numerics;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] tablica = {100913, 1009139, 10091401, 100914061, 1009140611, 10091406133, 100914061337, 1009140613399};
            long counter = 0;
            Console.WriteLine("lp,number,IsPrimeCounter,IsPrimeFasterCounter");
            for (int i = 0; i < tablica.Length; i++)
            {
                bool IsPrime(BigInteger Num)
                {
                    counter = 1;
                    if (Num < 2) return false;
                    else if (Num < 4) return true;
                    else if (Num % 2 == 0) return false;
                    else for (BigInteger u = 3; u < Num / 2; u += 2)
                        {
                            if (Num % u == 0) return false;
                            counter += 1;
                        }
                    return true;
                }
                IsPrime(tablica[i]);
                Console.Write("{0},{1},{2},", i+1, tablica[i], counter);

                bool IsPrimeFaster(BigInteger Num)
                {
                    counter = 1;
                    if (Num < 2) return false;
                    else if (Num < 4) return true;
                    else if (Num % 2 == 0) return false;
                    else for (BigInteger u = 3; u * u < Num; u += 2)
                    {
                            if (Num % u == 0) return false;
                            counter += 1;
                    }
                    return true;
                }
                IsPrimeFaster(tablica[i]);
                Console.WriteLine("{0}", counter);
            }
            Console.ReadKey();
        }
    }
}
