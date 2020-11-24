using System;
using System.Collections.Generic;

namespace ConexaoSolidaria
{

    public class Donation
    {

        public Donation(string a, string ad, bool ado, int v)
        {
            this.ad = a;
            this.adDescription = ad;
            this.adOpen = true;
            this.value = v;
        }

        public string ad { get; set; };
        public string adDescription { get; set; };
        public bool adOpen { get; set; };

        private double value { get; set; };

        private Organization organization { get; set; };

    }