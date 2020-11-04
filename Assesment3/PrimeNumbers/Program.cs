using System;
using System.Collections.Generic;
using PrimeNumbers;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Path of file:");
            string path = Console.ReadLine();
            if (!String.IsNullOrEmpty(path))
            {
                List<DataNumberModel> allnumbers = new List<DataNumberModel>();

                IPrimeNumberProcessor pp = Factory.CreatePrimeNumberProcessor();
                allnumbers = pp.GetData(path);

                foreach (var num in allnumbers)
                {
                    List<int> primeFactors = pp.ProcessData(num.data);
                    pp.FactorList(primeFactors);
                }
            }
            else
            {
                Console.WriteLine("File name was not supplied.");
            }
            Console.ReadLine();
        }
    }
}
