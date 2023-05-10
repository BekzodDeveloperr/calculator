using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Clasess
{
    public class Security
    {
       public void CheckPassword()
       {
             string password = "";
                do{
                 Console.Write("Enter password: ");
                password = Console.ReadLine();
                 }while(password != "Pas");               
       }
    
    }
}