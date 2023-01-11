using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public static class EndOfTheDay
    {
        public static void TransactionLog()
        {
            string writeText = "İşlem Gerçekleşti, İşlem Günlüğü Olarak Kaydediliyor.";
            string fileName = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Log\EOD_" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(fileName, writeText + Environment.NewLine);
        }

        public static void FraudDetected()
        {
            string writeText = "Geçersiz Kayıt, Dolandırıcılık Tespiti Olarak Günlüğe Kaydetme.";
            string fileName = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Log\EOD_" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(fileName,writeText + Environment.NewLine);
        }
    }
}
