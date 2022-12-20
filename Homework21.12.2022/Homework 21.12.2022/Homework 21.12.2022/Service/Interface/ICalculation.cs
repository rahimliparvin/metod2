using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Homework_21._12._2022.Service.Interface
{
    internal interface ICalculation 
    {
            void Calculate(int num1, int num2 , string operation )
        {
            Console.WriteLine();
        }
    }
}
