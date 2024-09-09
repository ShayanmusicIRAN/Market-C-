using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShayanDarabian___Market_Project
{
    public class Person
    {
        protected string name;
        public string Getname() { return name; }
        public void Setname(string name) { this.name = name; }


        protected int phone;
        public int Getphone() { return phone; }
        public void Setphone(int phone) { this.phone = phone; }


        protected string Address;
        public string GetAddress() { return Address; }
        public void SetAddress(string Address) { this.Address = Address; }


        protected string email;
        public string Getemail() { return email; }
        public void Setemail(string email) { this.email = email; }
        public Person()
        {

        }
    }
}
