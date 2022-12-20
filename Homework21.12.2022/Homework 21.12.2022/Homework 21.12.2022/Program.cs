using Homework_21._12._2022.Service;
using Homework_21._12._2022.Service.Interface;
using System;

#region Calculate
Calculate();
static void Calculate()
{
    Calculation calculator = new Calculation();

    Console.WriteLine("Add first number :");

Number1: string number1 = Console.ReadLine();
    int checkedNum1;
    bool isParseNum1 = int.TryParse(number1, out checkedNum1);



    if (!isParseNum1)
    {
        Console.WriteLine("Please add correct format number  1");
        goto Number1;
    }


    Console.WriteLine(" Add operation :");
    string operation = Console.ReadLine();


    Console.WriteLine("Add second number :");

Number2: string number2 = Console.ReadLine();
    int checkedNum2;
    bool isParseNum2 = int.TryParse(number2, out checkedNum2);

    if (!isParseNum2)
    {
        Console.WriteLine("Plesae add correct format number 2");
        goto Number2;
    }

    var result = calculator.Calculate(checkedNum1, checkedNum2, operation);

    Console.WriteLine(result);
}

#endregion


#region AccountService

AccountService sign1 = new AccountService("Pervin097", "Pervin9876");

sign1.Login();

#endregion