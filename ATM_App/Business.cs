using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class Business
    {
        Logger logger = new Logger();
        public void Withdrawal()
        {
            string message = "Parayı başarıyla çektiniz.";
            System.Console.WriteLine(message);
            logger.WriteFile(message);


        }
        public void Payment()
        {
            string message = "Ödemeniz başarıyla yapıldı.";
            System.Console.WriteLine(message);
            logger.WriteFile(message);

        }
        public void Deposit()
        {
            string message = "Para yatırma işleminiz başarıyla tamamlandı.";
            System.Console.WriteLine(message);
            logger.WriteFile(message);
        }
    }
}
