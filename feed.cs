using System;
using System.Collections.Generic;

abstract class Feed
{

    private List<Donation> Donation = new List<Donation>();

    public List<Donation> getDonation()
    {
        return this.DOnation;
    }

    public void addPublication(Donation dnt)
    {
        if (dnt.adOpen = true)
        {
            this.Donation.add(new Donation())
        }

    }

}