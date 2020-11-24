using System;
using System.Collections.Generic;

namespace ConexaoSolidaria
{
    abstract class Feed
    {

        private List<Donation> Donation = new List<Donation>();

        public List<Donation> getDonation()
        {
            return this.Donation;
        }

        public void addPublication(Donation dnt)
        {
            if (dnt.adOpen == true)
            {
                // precisa passar os parametros de inicializaçao da classe Donation
                this.Donation.Add(new Donation());
            }

        }
    }
}