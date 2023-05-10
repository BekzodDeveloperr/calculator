using System;
using Calculator.Clasess;

Security security = new Security();
Calculyator calculator = new Calculyator();
security.CheckPassword();
calculator.GetInputs();

    string message = 
        !(calculator.IsFirstNumberPositive())
        ? " 1st number is not positive"
        : " 1st number is not negative";
    Console.WriteLine(message);

calculator.CompareInputs();
string result = calculator.Calculate();
Console.WriteLine(result);
calculator.PrintevenFirstNumber();
calculator.PrintMultiplicationTable();