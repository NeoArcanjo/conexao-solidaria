using System;
using System.Collections.Generic;

namespace ConexaoSolidaria
{
  public class Menu{
    public Menu(){}

    List<Donation> donations;
    List<Donator> donators;
    List<Organization> organizations;

    // public void ListInit()

    public int DisplayMenu()
    {   
      Console.WriteLine("Seja bem-vindo ao Conexão Solidária. \nNo menu abaixo, selecione a ação desejada: ");
      Console.WriteLine();
      Console.WriteLine("1. Cadastrar Organização");
      Console.WriteLine("2. Cadastrar Doação");
      Console.WriteLine("3. Cadastrar Doador");
      Console.WriteLine("4. Doar");
      Console.WriteLine("5. Sair");
      Console.WriteLine();
      // var result = Console.ReadLine();
      // int result = Convert.ToInt32(Console.ReadLine());
      // return Convert.ToInt32(result);
      // return result;
    }

    // public void RegistryOrganization()
    // {
    //   Console.WriteLine("Enter a team to be added: ");
    //   string userinput = Console.ReadLine();
    //   if (teams.Count < 10)
    //   {
    //    if (userinput != "Colchester")
    //     {
    //       teams.Add(userinput);
    //       foreach (var item in teams)
    //       Console.Write(item.ToString() + " ");
    //      }
    //     else
    //       Console.Write("NOT ALLOWED");
    //      }
    //    else
    //      Console.Write("MAXIMUM LIMIT REACHED");
    //   }


    // public void DisplayTeams()
    // {
    //  foreach(var item in teams)
    //  Console.Write(item.ToString() + " ");
    // }

    // public void TeamSearch()
    // {
    //  Console.WriteLine("Please enter the team you wish to search for: ");
    //  string userinput = Console.ReadLine();
    //  if (teams.Contains(userinput))
    //  Console.WriteLine("Success, team " + userinput);
    // }

    // public void Delete()
    // {
    //   Console.WriteLine("Enter a team you wish to delete: ");
    //   string userinput = Console.ReadLine();
    //   teams.Remove(userinput);
    //   foreach (var item in teams)
    //   Console.Write(item.ToString() + " ");
    // }
  }
}