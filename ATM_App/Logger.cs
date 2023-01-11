using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    internal class Logger : ILogger
    {
        public void EndOfTheDayReadFile()
        {
            string filePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Log\" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string log = sr.ReadLine();

            while (log != null)
            {
                Console.WriteLine(log);
                log = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
        }

        public void WriteFile(string message)
        {
            string filePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Log\" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(filePath, message + Environment.NewLine);
        }
    }
}
