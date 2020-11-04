using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PrimeNumbers
{
    public class PrimeNumberProcessor : IPrimeNumberProcessor
    {

        public PrimeNumberProcessor()
        {

        }
    
        /// <summary>
        /// Read the user input for file path then gets data from file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<DataNumberModel> GetData(string path)
        {
            List<DataNumberModel> data = new List<DataNumberModel>();
            IFileWrap irp = Factory.CreateReadFileWrap();
            var alllines = irp.ReaddesignatedFile(path);
        
            foreach (var line in alllines)
            {
                data.Add(new DataNumberModel { data = Convert.ToInt32(line) });               
            }

            return data;
        }
        /// <summary>
        /// Process the numbers to get the Prime Numbers
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The list of Prime Numbers</returns>
        public List<int> ProcessData(int number)
        {
               List<int> retval = new List<int>();
                for (int b = 2; number > 1; b++)
                {
                    while (number % b == 0)
                    {
                        number /= b;
                        retval.Add(b);
                    }
                }
            return retval;
        }

        
        /// <summary>
        /// Output factor list to console
        /// </summary>
        public void FactorList(List<int> factors)
        {
            if (factors.Count == 1)
            {
                Console.WriteLine("{0} is Prime", factors[0]);
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < factors.Count; ++i)
                {
                    if (i > 0)
                    {
                        sb.Append(',');
                    }
                    sb.AppendFormat("{0}", factors[i]);
                }
                Console.WriteLine(sb.ToString());
            }
        }       
    }
}
