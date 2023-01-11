//ATM uygulaması
//Uygulama ilk çalıştığında kullanıcıdan yamak istediği işlemi öğrenmelidir. Bunlar ATM üzerinden yapılabilecek temem işlemledir. Para çekme, para yatırma, ödeme yapma vs.. İsteğe bağlı olarak genişletilebilir. Öncelikle ATM ye giriş yapan kullanıcın sistemde kayıtlı bir kullanıcı olduğundan emin olunmalıdır.

//Uygulamada bir de gün sonu seçeneği olmalıdır. Gün sonu alınmak istendiğinde, gün içerisinde yapılan transaction ların logları ve fraud olabilecek yani hatalı giriş denemeleri log gösterilmelidir. Aynı client'ın bilgisayarında belirlenen bir lokasyona EOD_Tarih(DDMMYYY formatında).txt adında bir dosyaya yazılmalıdır.

//Kullanılması gereken teknikler:

//Dosyaya Yazma
//Dosyadan Okuma
//İşlem listesi pre-defined olarak kullanılabilir.

using ATM_App;

User user = new User();
user.UserId = 1;
user.CardNumber = "1";
user.Password = "1";
Signing.Users.Add(user);
Logger logger = new Logger();
if (Signing.UserCheck())
{
    System.Console.WriteLine("Hangi işlemi yapmak istersiniz?");
    System.Console.WriteLine("Para Çekmek için 1'e, Ödeme için 2'ye ve Para Yatırma için 3'e basınız.");
    string operation = Console.ReadLine();
    Business Atm = new Business();
    if (operation == "1") Atm.Withdrawal();
    else if (operation == "2") Atm.Payment();
    else if (operation == "3") Atm.Deposit();
}
System.Console.WriteLine("Gün sonu log kayıtlarını kontrol etmek ister misiniz?");
System.Console.WriteLine("Evet için 1'e, Hayır için 2'ye basınız.");
string choice = Console.ReadLine();
if (choice == "1")
{
    logger.EndOfTheDayReadFile();
}
else System.Console.WriteLine("Bankamızı kullandığınız için teşekkürler.");