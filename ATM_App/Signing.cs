using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class Signing
    {
        public static List<User> Users = new List<User>();
        public static bool UserCheck()
        {
            Console.WriteLine("- Lütfen kart numaranızı giriniz: ");
            string cardNumber = Console.ReadLine();
            Console.WriteLine("- Lütfen şifrenizi giriniz: ");
            string password = Console.ReadLine();
            Logger logger = new Logger();
            foreach(var user in Users)
            {
                if (cardNumber == user.CardNumber && password == user.Password)
                {
                    Console.WriteLine("***** Giriş Başarılı! *****");
                    return true;
                }
                else
                {
                    string message = "Geçersiz giriş, lütfen Kartınızı kaydedin.";
                    System.Console.WriteLine(message);
                    string message1 = "1 Dolandırıcılık İşlemi Tespit Edildi.";
                    logger.WriteFile(message1);
                    EndOfTheDay.FraudDetected();
                    RegisterCard();
                    return true;
                }
            }
            return false;
        }
        public static void RegisterCard()
        {
            Console.WriteLine("- Lütfen kart numaranızı giriniz: ");
            User user = new User();
            user.CardNumber = Console.ReadLine();
            Console.WriteLine("- Lütfen şifrenizi giriniz: ");
            user.Password = Console.ReadLine();
            user.UserId = (Users.Count() + 1);
            Users.Add(user);
            Console.WriteLine("***** Kayıt Başarılı! *****");
        }
    }
}
