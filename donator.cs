using System;

public class Donator{
  
  public Donator(){
  }

  public string name{get;set;};
  public int age{get;set;};
  public Address address = new Address();
}