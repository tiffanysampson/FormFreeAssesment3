using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbers
{
    public class DataNumberModel : IDataNumberModel
    {
        /// <summary>
        /// Holds the interger from txt file
        /// </summary>
        public int data { get; set; }
        /// <summary>
        /// Constructor - Initialzing data
        /// </summary>
        public DataNumberModel()
        {
            data = 0;
        }
    }
}
