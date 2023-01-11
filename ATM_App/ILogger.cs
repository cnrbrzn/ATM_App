using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    internal interface ILogger
    {
        public void WriteFile(string message);
        public void EndOfTheDayReadFile();
    }
}
