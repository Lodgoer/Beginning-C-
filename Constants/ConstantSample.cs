using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace _03.Constants
{
    class ConstntSample
    {
    const string Saturday = "Sat";
    const string Sunday = nameof(Sunday);
    }
}
Console.WriteLine(string.Saturday);