using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;


namespace StoreWPF
{
    public class User
    {
        public static bool checkAuthorization = false;
        public static bool checkAdmin = false;
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public User(int id, string login, string password)
        {
            this.Id = id;
            this.Login = login;
            this.Password = password;
        }
        
    }
}
