using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PrimeNumbers
{
    public class ReadFileWrap : IFileWrap
    {
        public List<string> ReaddesignatedFile(string path)
        {
            List<string> alldata = File.ReadAllLines(path).ToList();
            return alldata;
        }
            
    }
}
