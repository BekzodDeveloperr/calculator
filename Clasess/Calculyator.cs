using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Calculator.Clasess
{
    public class Calculyator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; } 
        public string Operation { get; set; } 
// Nimadir nimadir
        public void GetInputs()
        {
            Console.WriteLine("Type 1st number: ");
            FirstNumber = Convert.ToInt32(Console.ReadLine);

            Console.WriteLine("Enter operation(+,-,*,/,%): ");
            Operation = Console.ReadLine();

            Console.WriteLine("Type 2st number: ");
            SecondNumber =System.Convert.ToInt32(Console.ReadLine);
        }
        public bool IsFirstNumberPositive()
        {
                return FirstNumber >=0;
        }
        public void CompareInputs()
        {
                if (FirstNumber > SecondNumber)
                {
                    Console.WriteLine($"1st number is greater than 2nd number!");
                }
                else if (FirstNumber == SecondNumber)
                {
                    Console.WriteLine($"1st number is equal to 2nd number!");
                }
                else
                {
                    Console.WriteLine($"1st number is less than 2nd number!");
                }
        }
        public string Calculate()
        {
            return Operation switch
            {
                "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
                "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
                "*" => $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}",
                "/" => $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
                  _ =>  " Operation Not Found!"
                };
        }
        public void PrintevenFirstNumber()
        {  Console.WriteLine("Printing  even number till  first input....");
           int counter=2;
        while (counter < FirstNumber)
           {
            Console.WriteLine(counter);
            counter+=2;
           }
        }
        public void PrintMultiplicationTable()
        {
            for (int i = 1;i <= 10; i++ )
            {
               for (int j = 1;j <= 10; j++ ) 
               {
                Console.WriteLine($"{i} x {j} = {i*j}");
               } 
               Console.WriteLine();
            }
        }
    }
}