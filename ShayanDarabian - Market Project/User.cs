using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShayanDarabian___Market_Project
{
    public class User : Person
    {
        private string code;
        public string GetCode() { return code; }
        public void SetCode(string code) { this.code = code; }
        public User(string n, string c, int p, string e, string a)
        {
            name = n;
            code = c;
            phone = p;
            email = e;
            Address = a;
        }

        public User()
        {

        }
    }
}
