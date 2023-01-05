using System;

namespace WhatIsFarameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Description desc = new Description();

            int number1 = 10;
            int number2 = 20;

            //바로가기 형태의 ref 타입으로 넘기면 원본에 접근이 가능하다.
            desc.RefTypeParam(ref number1, ref number2);

            Console.WriteLine("[Main] first: {0}, second: {1}", number1, number2);

            int number;
            desc.OutTypeParam(out number);
            Console.WriteLine("[Main] number : {0}", number);

            desc.FlexibleTypePram(1, 2, 3, 10, 20, 111, 123 , 516);
        }
    }
}