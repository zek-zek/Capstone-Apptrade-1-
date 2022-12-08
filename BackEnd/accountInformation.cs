using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Apptrade.BackEnd
{
    public class accountInformation
    {
        private string name, email;
        public accountInformation(string _name, string _email)
        {
            this.Name = _name; 
            this.Email = _email;
        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
    }
}
