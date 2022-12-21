﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhaIsArray
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            /**
             * 컬렉션
             * 이름 하나로 데이터 여러 개를 담을 수 있는 자료 구조를 컬렉션(Collection) 또는
             * 컨테이너(Container) 라고 한다. C#에서 다루는 컬렉션은 배열(Array), 리스트(List),
             * 사전(Dictinaty) 등이 있다.
             * 
             * 배열
             * 배열(Array)은 같은 종료의 데이터들이 순차적으로 메모리에 저장되는 자료 구조이다. 각각의 데이터들은
             * 인덱스(번호)를 사용하여 독립적으로 접근된다. 배열을 사용하면 편리하게 데이터를 모아서 관리할 수 있다.
             * 
             * 배열의 특징들
             * 1. 배열 하나에는 데이터 형식 한 종류만 보관할 수 있다.
             * 2. 배열은 메모리의 연속된 공간을 미리 할당하고, 이를 대괄호([])와 0부터 시작되는 정수형 인덱스를
             *      사용하여 접근할 수 있다.
             * 3. 배열을 선언할 때는 new 키워드로 배열을 생성한 후 사용할 수 있다.
             * 4. 배열에서 값 하나는 요소(Element) 또는 항목(Item)으로 표현한다.
             * 5. 필요한 데이터 개수를 정확히 정한다면 메모리를 적게 사용하여 프로그램 크기가 작아지고 성능이
             *      향상된다.
             *      
             * 배열에는 세 가지 종류가 있다.
             * 1차원 배열 : 배열의 첨자를 하나만 사용하는 배열
             * 다차원 배열 : 첨자 2개 이상을 사용하는 배열 (2차원, 3차원, ... n차원 배열)
             * 가변(Jagged) 배열 : '배열의 배열' 이라고도 하며, 이름 하나로 다양한 차원의 배열을 표현할 때 사용한다.
             */

            // 배열의 선언과 초기화
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int number5 = 5;

            Console.WriteLine(numbers);

            //for (int index = 0; index < numbers.Length; index++)
            //{
            //    Console.Write(numbers[index]);
            //}

            //numbers배열에서 element에 순서대로 대입하는 것을 반복
            //foreach (int element in numbers)
            //{
            //    Console.Write($"{element} ");
            //}




        }   //Main()
    }
}