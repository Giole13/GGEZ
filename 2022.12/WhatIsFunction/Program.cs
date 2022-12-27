﻿using System;

namespace WhatIsFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int sum = 100;
            //Console.WriteLine(sum);
            //sum=  Hi();
            //Console.WriteLine(sum);

            //Hi("안녕하세요오오");
            //ShowMessage("헬로");

            //string returnValue = GetString();
            //Console.WriteLine(returnValue);

            int r = SquareFunction(7);
            Console.WriteLine(r);

            int sumnumber = PlusNumber(5, 2);
            Console.WriteLine(sumnumber);

            Console.WriteLine("32와 54를 비교해서 더 큰 수를 내보내는 함수 : {0}",BigNumber(32, 54));
            Console.WriteLine("32와 54를 비교해서 더 작은 수를 내보내는 함수 : {0}",SmallNumber(32, 54));
            Console.WriteLine("-32의 절대 값을 내보내는 함수 : {0}",AbsoluteValue(-32));
            Console.WriteLine("81의 절대 값을 내보내는 함수 : {0}",AbsoluteValue(81));



        }       //Main()

        // Hello world 출력하는 사용자 정의 함수

        static void Show()
        {
            Console.WriteLine("Hello world!");

            /**
             * 함수(Function) 또는 메서드(Method)는 재사용을 목적으로 만든 특정 작업을 수행하는 코드 블록이다.
             * 함수를 부르는 다양한 명칭
             * 함수(Function)
             * 메서드(Method)
             * 프로시저(Procedure)
             * 서브루틴(Subroutine)
             * 서브모듈(Submodule)
             * 
             * 메서드는 클래스 멤버를 말하는것. 클래스 밖에 있다면 다름.
             * 
             * 프로그래밍을 하다 보면 같은 유형의 코드를 반복할 때가 많다. 이 코드들을 매번 입력하면 불편하고
             * 입력하다 실수도 할 수 있다. 이때 '함수'를 사용한다.
             * 
             * 프로그래밍 언어에서 함수는 어떤 동작 및 행위를 표현한다. 함수의 사용 목적은 코드 재사용에 있다.
             * 한 번 만들어 놓은 함수는 프로그램에서 한 번 이상 사용할 수 있다.
             * 지금까지 사용한 Main() 메서드는 C#의 시작 지점을 나타내는 특수한 목적의 함수로 볼 수 있다.
             * 또, Console 클래스의 WriteLine() 메서드도 함수로 볼 수 있다.
             * 
             *  - 함수란 어떤 값을 받아서 그 값을 가지고 가공을 거쳐 어떤 결과값을 반환시켜 주는 코드이다.
             *  - 함수는 프로그램 코드 내에서 특정한 기능을 처리하는 독립적인 하나의 단위 또는 모듈을 가리킨다.
             *  
             *  입력 -> 처리 -> 출력
             *  
             *  함수의 종류(내장 함수와 사용자 정의 함수)
             *  함수에는 내장 함수와 사용자 정의 함수가 있다. 내장 함수는 C#이 자주 사용하는 기능을 미리 만들어서
             *  제공하는 함수로, 특정 클래스의 함수로 표현된다.
             *  내장 함수도 그 용도에 따라 문자열 관련 함수, 날짜 및 시간 관련 함수, 수학 관련 함수, 형식 변환 관련 함수
             *  등으로 나눌 수 있다. 이런한 내장 함수를 API(Application Programming Interface)로 표현한다.
             *  사용자 정의 함수는 내장 함수와 달리 프로그래머가 필요할 때마다 새롭게 기능을 추가하여 사용하는 함수이다.
             *  
             *  함수 정의하고 사용하기
             *  함수 정의(Define)는 함수를 만드는 작업이다. 함수 호출(Call)은 함수를 사용하는 작업니다. 함수 생성 및
             *  호출은 반드시 소괄호가 들어간다. 함수를 정의하는 형태는 지금까지 사용한 Main() 메서드와 유사하다.
             *  다음 코드는 함수를 만드는 가장 기본적인 형태를 보여준다.
             *  
             *  static void [함수이름] ()
             *  {
             *      함수내용
             *  }
             *  
             *  만든 함수를 호출하는 형태는 다음 세 가지가 있다.
             *  [함수이름]();
             *  [함수이름](매개변수);
             *  변수(결과값) = [함수이름](매개변수);
             */

            /**
             * 함수를 만들고 반복해서 사용하기
             * 함수를 만드는 목적 중 하나는 반복 사용에 있다. 함수를 만들고 여러 번 호출해서 사용하는 방법을 알아보자.
             */

            /**
             * 이 함수는 가장 간단한 형태의 함수로, 매개변수(Parameter)도 없고 반환값(Return value)도
             * 없는 형태이다.
             */
        }

        // 안녕하세요 출력하는 함수
        static int Hi()
        {
            Console.WriteLine("안녕하세요");
            return 0;
        }

        //오버로딩으로 함수를 만들었음
        static int Hi(string text)      //함수 오버로딩 (같은 이름이라도 매개변수가 다르다! 그렇기에 만들 수 있음
        {             //여기가 매개번수
            Console.WriteLine(text);

            return 0;
        }

        //! 매개변수와 반환값 설명
        static void ParameterAndReturn()
        {
            /**
             * 함수를 만들어 놓고 기능이 동일한 함수만 사용하지는 않는다. 호출할 때마다 조금씩 다른 기능을 적용할 때는
             *  함수의 매개변수를 달리하여 호출할 수 있다. 매개변수(인자, 파라미터)는 함수에 어떤 정보를 넘겨주는 데이터를
             *  나타낸다. 이러한 매개변수 콤마를 기준으로 여러 개 설정할 수 있으며, 문자열과 숫자 등 모든 데이터 형식을
             *  사용할 수 있다.
             * 
             * 매개변수(인자, 파라미터)가 없는 함수가 있고 매개변수도 없고 반환값도 없는 함수 형태는 가장 단순한 형태의 함수이다.
             *  앞에서 사용한 함수 중에서 모든 변수에 있는 값을 문자열로 변환시키는 ToString() 메서드처럼 빈 괄호만 있는
             *  함수 형식을 나타낸다.
             * 
             * 매개변수가 있는 함수: 특정 함수에 인자 값을 1개 이상 전달하는 방식이다. 정수형, 실수형, 문자형, 문자열형,
             *  개체형 등 여러가지 데이터 형식을 인자 값으로 전달할 수 있다.
             * 
             * 반환값이 있는 함수(결과값이 있는 함수): 함수의 처리 결과를 함수를 호출한 쪽으로 반환할 때는 return 키워드를
             *  사용하여 데이터를 돌려줄 수 있다.
             *  
             * 매개변수가 가변(여러 개)인 함수: C#에서는 클래스 하나에 매개변수의 형식과 개수를 달리하여 이름이 동일한
             *  함수를 여러 개 만들 수 있다. 이를 가리켜 함수 중복 또는 함수 오버로드(Overload)라고 한다.
             *  
             *  
             */


        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        static string GetString()
        {
            return "반환값(Return Value)";
        }

        static int SquareFunction(int x)
        {
            int r = x * x;
            return r;
        }

        static int PlusNumber(int x, int y)
        {
            return x + y;
        }

        static int BigNumber(int x,int y)
        {
            if (x < y)
            {
                return y;
            }
            else if (y < x)
            {
                return x;
            }
            else
            {
                return 0;
            }
        }       //더 큰 수를 반환하는 함수

        static int SmallNumber(int x, int y)
        {
            if(x< y)
            {
                return x;
            }
            else if (y < x)
            {
                return y;
            }
            else
            {
                return 0;
            }
        }       //더 작은 수를 반환 하는 함수

        static int AbsoluteValue(int x)
        {
            int returnValue = 0;
            if (x < 0)
            {
                return x * -1;
            }
            else
            {
                return x;
            }
            
        }       //절대값을 반환하는 함수 ( 0을 넣으면 0이 반환됨
    }       //Class
}