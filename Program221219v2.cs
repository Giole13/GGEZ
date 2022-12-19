using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsOperator
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            /**
             * 제어문 소개
             * 프로그램을 이루는 3가지의 중요한 제어 구조에는 순차 구조(순차문), 선택 구조(조건문)
             * 반복 구조(반복문)가 있다,
             * 
             * 순차문
             * 프로그램은 기본적으로 Main() 메서드 시작 지점부터 끝 지점까지 코드가 나열되면 순서대로
             * 실행 후 종료한다.
             * 
             * 제어문
             * 프로그램 실행 순서를 제어하거나 프로그램 내용을 반복하는 작업 등을 처리할 때 사용하는 구문으로
             * 조건문과 반복문으로 구분한다.
             * 
             * 조건문(선택문)
             * 조건의 참 또는 거짓에 따라 서로 다른 명령문을 실행할 수 있는 구조이다. 분기문 또는 비교 판단문이라고
             * 하기도 한다.
             * 
             * 반복문
             * 특정 명령문을 지정된 수만큼 반복해서 실행할 때나 조건식이 참일 동안 반복시킬 때 사용한다.
             */

            /**
             * if / else 문
             * 프로그램 프름을 여러 가지 갈래로 가지치기(Branching)할 수 있는데, 이때 if 문을 사용한다.
             * if 문은 조건을 비교해서 판단하는 구문으로 if, else if, else 세가지 키워드가 있다.
             */

            // 02.3 예제 #1
            // 두개의 정수 중에서 더 큰 수를 찾는 프로그램
            /*
            int numberx, numbery;
            Console.Write("x 값을 입력하시오 : ");
            int.TryParse(Console.ReadLine(), out numberx);
            Console.Write("y 값을 입력하시오 : ");
            int.TryParse(Console.ReadLine(), out numbery);

            if (numbery < numberx)
            {
                Console.WriteLine("x가 y보다 큽니다.");
            }
            else
            {
                Console.WriteLine("y가 x보다 큽니다.");
            }
            */

            /**
             * 02.4 중간점검 1
             * 컵의 사이즈를 받아서 100ml 미만은 small, 100ml 이상 200ml 미안은 medium, 200ml이상은
             * large라고 출력하는 if-else 문을 작성
             */

            /*
            int size1, outsize;
            Console.Write("컵의 사이즈를 입력해주세요 : ");
            int.TryParse(Console.ReadLine(), out size1);

            if (size1 < 100 && size1>=0)
            {
                Console.WriteLine("Small");
            }
            else if (size1 >=100 && size1 < 200)
            {
                Console.WriteLine("medium");
            }
            else if (size1 >= 200)
            {
                Console.WriteLine("large");
            }
            else
            {
                Console.WriteLine("측정불가능");
            }
            */

            //비밀 코드 맞추기
            char secret = 'g';
            char select1 = default;

            Console.Write("비밀코드를 맞춰보세요 : ");
            string select = Console.ReadLine();
            char.TryParse(select, out select1);

            if (select1 == secret)
            {
                Console.WriteLine("정답입니다.");
            }
            else if (select1 < 'g')
            {
                Console.WriteLine("{0}앞에 있음", select1);
            }
            else if (select1 > 'g')
            {
                Console.WriteLine("{0}뒤에 있음", select1);
            }

            //세 개의 정수 중에서 큰 수 찾기
            Console.Write("3개의 정수를 입력하시오 : ");
            string essence = Console.ReadLine();
            string[] essence1 = essence.Split(" ");
            int num1, num2, num3;
            int.TryParse(essence1[0], out num1);
            int.TryParse(essence1[1], out num2);
            int.TryParse(essence1[2], out num3);

            

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("가장 큰 정수는 : {0}",num1);
                }
                else if (num3 > num1)
                {
                    Console.WriteLine("가장 큰 정수는 : {0}", num3);

                }
            }
            
            else if (num2 > num1)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("가장 큰 정수는 : {0}", num2);
                }
                else if (num3 > num2)
                {
                    Console.WriteLine("가장 큰 정수는 : {0}", num3);
                }
            }



        }//Main
        static void Main1(string[] args)
        {
            //LAB 1 최대한도의 사탕사기
            Console.Write("현재 가지고 있는 돈\t\t: ");
            string present_money = Console.ReadLine();
            int money = 0;
            int.TryParse(present_money, out money);
            int buy = money/300;
            int remaining_money = money%300;
            Console.WriteLine("캔디의 가격\t\t\t: 300");
            Console.WriteLine("최대로 살 수 있는 캔디의 개수\t: {0}", buy);
            Console.WriteLine("캔디 구입 후 남은 돈\t\t: {0}\n", remaining_money);

            //LAB 2 화씨온도를 섭씨온도로 바꾸기
            Console.Write("화씨온도 ");
            string f_t = Console.ReadLine();
            int f_t1; 
            float c_t1 = 0;
            int.TryParse(f_t, out f_t1); //(°F − 32) × 5/9 = °C 섭씨 화씨 공식
            c_t1 = (f_t1-32)*5f/9f;
            Console.Write("화씨온도 {0}도는 섭씨온도 {1}도입니다.\n\n",f_t1, c_t1);
            

            //LAB 3 주사위 게임
            int dice1, dice2, alldice;
            Random dice = new Random();
            dice1 = dice.Next(1, 7);
            dice2 = dice.Next(1, 7);
            alldice = dice1 + dice2;
            Console.WriteLine("첫번째 주사위 [{0}]", dice1);
            Console.WriteLine("두번째 주사위 [{0}]", dice2);
            Console.WriteLine("두 주사위의 합 [{0}]", alldice);

        }   //Main
    }
}
