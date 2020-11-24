using System;

class Address{

  public string Address(string s, string n, string c, int n){
    this.street = s;
    this.neightborhood = n;
    this.city = c;
    this.number = n;
  }

  public string street{get;set;};
  public string neightborhood{get;set;};
  public string city{get;set;};
  public int number{get;set;};
}