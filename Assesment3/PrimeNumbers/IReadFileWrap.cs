using System.Collections.Generic;

namespace PrimeNumbers
{
    public interface IFileWrap
    {
        List<string> ReaddesignatedFile(string path);
    }
}