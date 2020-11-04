using System.Collections.Generic;

namespace PrimeNumbers
{
    public interface IPrimeNumberProcessor
    {
        List<DataNumberModel> GetData(string path);
        public List<int> ProcessData(int number);
        public void FactorList(List<int> factors);
    }
}