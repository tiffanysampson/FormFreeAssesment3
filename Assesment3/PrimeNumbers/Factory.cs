using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbers
{
    public static class Factory
    {
        public static IPrimeNumberProcessor CreatePrimeNumberProcessor()
        {
            return new PrimeNumberProcessor();
        }
        public static IFileWrap CreateReadFileWrap()
        {
            return new ReadFileWrap();        
        }

    }
}
