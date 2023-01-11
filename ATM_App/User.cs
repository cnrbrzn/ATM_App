using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class User
    {
        private int userId;
        private string cardNumber;
        private string password;
        public int UserId { get => userId; set => userId = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public string Password { get => password; set => password = value; }
    }
}
