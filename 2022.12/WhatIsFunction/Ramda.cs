using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    internal class Ramda
    {
        public static void Main()
        {
            Hi();
            Multiply(5, 4);
        }

        static void Hi() => Console.WriteLine("안녕하세요");                 //람다식 표현
        static void Multiply(int a, int b) => Console.WriteLine(a * b);    //람다식 표현
    }
}
