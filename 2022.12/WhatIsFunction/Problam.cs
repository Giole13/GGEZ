using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsFunction
{
    internal class Problam
    {
        public static void Main()
        {
            Console.WriteLine(Maximum(5, 12, 32));

            SayHello(2);

            Console.WriteLine(Hypot(5, 13));

            Prime1();

            Console.WriteLine();

            Reversestring();

            //string a = Console.ReadLine();
            //Console.WriteLine(a.Length);
        }

        //세 정수중 최대값을 찾는 함수
        static int Maximum(int x, int y, int z)
        {
            int result = 0;

            if (x < y)
            {
                if (z < y)
                {
                    result = y;
                }
                else if (y < z)
                {
                    result = z;
                }
            }
            else if (y < x && z < x)
            {
                result = x;
            }
            else { /*Do noting*/}

            return result;
        }

        //화면에 Hello를 출력하는 함수
        static void SayHello(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Hello");
            }
        }

        //다른 두 변이 주어 졌을 때 직각 삼각형의 빗변을 계산하는 함수
        static double Hypot(double baseLine, double lengthLine)
        {
            double hypotSqare;
            hypotSqare = ((baseLine * baseLine) + (lengthLine * lengthLine));

            return Math.Sqrt(hypotSqare);
        }

        //주어진 숫자가 소수인지 여부를 찾는 함수
        //2~100 사이의 숫자를 입력했다면 소수만 출력하게 만들어라..
        //static void Prime(int primeNumber)
        //{
        //    for (int i = 2; i <= primeNumber; i++)
        //    {
        //        for (int index = 2; index <= i; index++)
        //        {
        //            if ((primeNumber / index == 1) && (primeNumber % index == 0))
        //            {
        //                if (primeNumber % i)
        //                {
        //                    Console.WriteLine(primeNumber);
        //                    break;
        //                }
        //            }

        //        }
        //    }
        //}

        static void Prime1()
        {
            for (int index = 2; index <= 100; index++)
            {
                if (FindPrime(index))
                {
                    Console.Write("{0} ", index);
                }
            }
        }

        static bool FindPrime(int number)
        {
            bool isPrime = true;

            for (int i = number - 1; 2 <= i; i--)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
                else { continue; }
            }

            return isPrime;
        }


        //사용자가 입력하는 전화번호에서 소괄호를 삭제한 형태로 출력하는 프로그램을 작성
        //static void PhoneParentheses()
        //{
        //    string result = "";
        //    bool quit = true;

        //    while (quit)
        //    {
        //        Console.Write("전화번호를 입력해주세요 : ");
        //        result = Console.ReadLine();

        //        if (result == "quit") { quit = false; }
        //        else { /*Do nothing*/}

        //        for (int i = 0; i < result.Length; i++)
        //        {
        //            if (result[i] == ')')
        //            {

        //            }
        //        }

        //    }
        //}

        //사용자가 문자를 입력하면 좌우로 뒤집어서 출력하는 프로그램
        static void Reversestring()
        {
            Console.Write("문자를 입력해주세요 : ");
            string userInput = Console.ReadLine();

            char[] result = new char[userInput.Length];
            int maxLength = userInput.Length;


            for(int i = 0; i < userInput.Length; i++)
            {
                result[i] = userInput[maxLength-(i+1)];
                Console.Write(result[i]);
            }
        }




    }
}
