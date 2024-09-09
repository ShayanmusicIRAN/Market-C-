using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShayanDarabian___Market_Project
{
    class Product
    {
        string name;
        int price;
        string producer;
        string barcode;
        string kind;
        string exdate;


        public void set_name(string n)
        {
            name = n;
        }
        public string get_name()
        {
            return name;
        }

        public void set_price(int n)
        {
            price = n;
        }
        public int get_price()
        {
            return price;
        }

        public void set_producer(string n)
        {
            producer = n;
        }
        public string get_producer()
        {
            return producer;
        }

        public void set_barcode(string n)
        {
            barcode = n;
        }
        public string get_barcode()
        {
            return barcode;
        }

        public void set_kind(string n)
        {
            kind = n;
        }
        public string get_kind()
        {
            return kind;
        }

        public void set_exdate(string n)
        {
            exdate = n;
        }
        public string get_exdate()
        {
            return exdate;
        }

        public Product(string n, string b, int p, string pr, string k, string e)
        {
            name = n;
            barcode = b;
            price = p;
            producer = pr;
            kind = k;
            exdate = e;
        }
    }
}
