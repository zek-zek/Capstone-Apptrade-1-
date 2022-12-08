using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Apptrade.BackEnd
{
    
    public class createAccount
    {
        private string email, password, username, address, fname, lname, role;
        private int status;

        public createAccount(string _email, string _password, string _username, string role, string _fname, string _lname, int _status)
        {
            this.Fname = _fname;
            this.Lname = _lname;
            this.Email = _email;
            this.Username = _username;
            this.Password = _password;
            this.Role = role;
            this.Status = _status;
        }

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public string Address { get => address; set => address = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public int Status { get => status; set => status = value; }
        public string Role { get => role; set => role = value; }
    }
}
