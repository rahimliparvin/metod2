using Homework_21._12._2022.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_21._12._2022.Service
{
    internal class AccountService : IAccountService
    { 

        public string Name;
        public string Password;

        public AccountService(string name, string password)
        {
            this.Name = name;
            this.Password = password;

        }

        internal void Login()
        {
            if (Name == "Pervin997" && Password == "Pervin0123")
            {
                Console.WriteLine("Entry is successful");
            }
            else
            {
                Console.WriteLine("Please correct  enter  username and password");
            }
        }

        void IAccountService.Login()
        {
        }
    }
}
