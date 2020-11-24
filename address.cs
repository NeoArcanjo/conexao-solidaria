using System;
using System.Collections.Generic;

namespace ConexaoSolidaria
{
    public class Address
    {
        public string street { get; set; }
        public string neightborhood { get; set; }
        public string city { get; set; }
        public int number { get; set; }
        public Address(string s, string n, string c, int num)
        {
            this.street = s;
            this.neightborhood = n;
            this.city = c;
            this.number = num;
        }


    }
}