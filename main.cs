using System;
// using System.Collections.Generic;

namespace ConexaoSolidaria
{
    class MainClass
    {
        public static void Main(string[] args)
        {
          Menu action = new Menu();
          int userInput = 0;

          // action.ListInit();
          
          while(userInput!=5){
            userInput = action.DisplayMenu();
          };
        }
    }
}

// https://www.caelum.com.br/apostila-csharp-orientacao-objetos/encapsulamento-e-modificadores-de-acesso/#para-saber-mais-visibilidade-internal