using System;   //시스템에서 여러것들을 가져와 쓸 거라는 선언문

namespace WhaIsArray    //내 프로그램 이름이다. 내가 정했다!
{
    internal class Program  //클래스라는 것인데 C#에서는 모든 요소들이 클레스 안에 있어야함.
    { 
        static void Main1(string[] args) //무조건 1개는 있어야함. -> C# 콘솔(검은 창)을 사용할 때
        {
            //프로그램은 여기서부터 읽기 시작한다.

            //3의 배수를 제외한 수
            //int sumofnumber = 0;


            //for (int variable_ = 1; variable_ <= 100; variable_++)
            //{
            //    bool isrealmultipleofthree = (variable_ % 3 == 0);
            //    Console.WriteLine($"{variable_} -> 3의 배수? { isrealmultipleofthree}");
            //    //(variable_ % 3 == 0)


            //    if (isrealmultipleofthree == false)
            //    {
            //        // 3의 배수가 아닌건 다 여기로 오겠네 ?
            //        sumofnumber += variable_;
            //        Console.WriteLine($"잘 더해지고 있나? : {sumofnumber}\n");
            //        //조건문은 여기서 끝난다.
            //    }
            //    else
            //    {
            //        //저 조건문이 거짓(false)이면 여기로 옴.
            //        //조건문은 여기서부터 읽기 시작한다.
            //        //조건문은 여기서 끝난다.
            //    }
            //}   //100번 도는 루프
            //    // 루프가 끝나면 여기로 오니까 다 끝날 때까지는 더해서 마지막 값을 눈으로 보고 싶으니까

            //Console.WriteLine("\n\n\n\n");
            //Console.WriteLine("=================================");
            //Console.WriteLine("총 더한 갯수 : {0}", sumofnumber);
            //Console.WriteLine("=================================");


            //for(int index = 1; index <= 50; index++)
            //{
            //    Console.WriteLine();
            //}

            //// 프로그램 사용자로부터 양의 정수를 하나 입력 받아서,
            //// 그 수만큼 "Hello World" 를 출력하는 프로그램 작성
            //int someNumber = 100;
            //bool isPositiveInteger = (0 < someNumber);

            ///**
            // * 프로그램 사용자로부터 계속해서 정수를 입력 받는다.
            // * 그리고 그 값을 계속해서 더해 나간다. 이러한 작업은
            // * 프로그램 사용자가 0을 입력할 때까지 계속되어야 하며,
            // * 0이 입력되면 입력된 모든 정수의 합을 출력하고 프로그램 종료.
            // */

            //bool isNumberZero = (someNumber == 0);

            // 프로그램 사용자로부터 입력 받은 숫자에 해당하는 구구단을 출력하되,
            // 역순으로
            //int userInputNumber = 3;
            //for(int index = 9; index >= 1; index--)
            //{
            //    Console.WriteLine("{0} x {1} = {2}",
            //        userInputNumber, index, userInputNumber * index);
            //}

            ///**
            // * 
            // */
            //char userInputAlphabet = 'c', secertCode = 'y';
            //bool isSmallAlphabet =
            //    ('a' <= userInputNumber && userInputNumber <= 'z');

            //bool isAlphabetFront = (userInputNumber <= secertCode);
            //bool isAlphabetBack = (userInputNumber >= secertCode);

            //if (isSmallAlphabet) { /*Do nothing*/}
            //else
            //{
            //    Console.WriteLine("{0} {1}",
            //        "asdf",
            //        "asdf");
            //}

            //if (isAlphabetFront)
            //{
            //    Console.WriteLine("시크릿 코드는 앞에 있어요");
            //}
            //else { /*Do nothing*/}

            //if (isAlphabetBack)
            //{
            //    Console.WriteLine("시크릿 코드는 뒤에 있어요");
            //}
            //else { /*Do nothing*/}

            ////@@@@@@@@@3의 배수 4의 배수 더하는 프로그램
            //int somNumber =100;
            //bool isMultipleOfThree = (somNumber % 3 == 0);
            //bool isMultipleOfFour = (somNumber % 4 == 0);

            //bool isSatisfyCondition = isMultipleOfThree && isMultipleOfFour;

            //if (isSatisfyCondition)
            //{
            //    somNumber += somNumber;
            //    // if : 3의 배수이면서 4의 배수이면
            //}

            ////별을 100번 찍는 법
            //Console.WriteLine("{0} {1} {2} {3} {4}",
            //    "**********", "**********", "**********", "**********", "**********");

            //for(int index = 1; index <= 100; index++)
            //{
            //    Console.Write("* ");
            //}

            //Console.WriteLine("\n\n\n###################################");
            //for (int index=1;index <= 10; index++)
            //{
            //    Console.WriteLine();
            //    for (int index2 = 1; index2 <= 10; index2++)
            //    {
            //        Console.Write("* ");
            //    }   // loop : 이건 밖의 루프가 1번 돌 동안 10번 도는 루프
            //}   // loop : 이건 10번 도는 루프

            //Console.WriteLine("\n\n\n###################################");

            //int hundredCount = 0;
            //for (int index = 1; index <= 10; index++)
            //{
            //    Console.WriteLine();
            //    for (int index2 = 1; index2 <= 10; index2++)
            //    {
            //        for (int index3 = 1; index3 <= 10; index++)
            //        {
            //            hundredCount++;
            //            if(100 < hundredCount) { break; } else { /*Do nothing*/}

            //            // 여기가 별을 찍는 지점
            //            Console.Write("* ");


            //            //여기서 10번마다 한줄을 띄어 줄거임
            //            if (hundredCount % 10 ==0)
            //            {
            //                Console.WriteLine();
            //            }   // if: 별을 10번 찍을 때마다 한 줄 띄어주는 문
            //        }   // loop : 1번 루프가 10번 2번 루프가 10번 그동안 10번도는 루프
            //    }   // loop : 이건 밖의 루프가 1번 돌 동안 10번 도는 루프
            //}   // loop : 이건 10번 도는 루프


            //유저 입력 받아서 1~20줄 이내로 입력 받음. 유저 입력은 줄, 단의 개수 임.
            //등차 수열로 한 단이 내려갈 때마다 별 1개 씩 추가로 증가하는 프로그램 작성


            //int jul, mainjul, index= 1, index2, full;
            //Console.Write("표시할 줄을 입력해주세요 : ");
            //int.TryParse(Console.ReadLine(), out mainjul);

            //jul = mainjul;
            //int two = 2;

            ////입력한 숫자만큼 삼각형 만들기
            //for (index = jul; index > 0; index--)
            //{
            //    for (index2 = jul; index2 > 0; index2--)
            //    {
            //        Console.Write("*");
            //        if (index == index2)
            //        {
            //            break;
            //        }
            //    }
            //    Console.WriteLine();
            //}

            ////역삼각형
            //while (index <= jul)
            //{
            //    for (index2 = 1; index2 <= jul; index2++)
            //    {
            //        //if (index == index2) { break; }
            //        Console.Write("*");
            //    }
            //    jul--;
            //    Console.WriteLine(" ");
            //}







            // 마름모 모양 만들기 
            //for (index = 1; index < jul; index++)
            //{
            //    for (index2 = 1; index2 < jul; index2++)
            //    {
            //        if (space > 0)
            //        {
            //            Console.Write("/");
            //            --space;
            //        }
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}

            /** 별을 7개
             *    *   
             *   ***  
             *  ***** 
             * *******
             *  ***** 
             *   ***  
             *    *   
             */


            //full = jul / 2;
            //for (index = jul; index > 0; index--)
            //{
            //    for (index2 = jul; index2 > 0; index2--)
            //    {
            //        if (index == full)
            //        {
            //            for (int index3 = jul; index3 > 0; index3--)
            //            {
            //                Console.Write("*");
            //                break;
            //            }
            //        }
            //        if (full == index2)
            //        {
            //            Console.Write("*");

            //        }
            //        Console.Write("/");
            //    }

            //    Console.WriteLine();
            //}

            //문제 11 다음 식을 만족하는 모든 A와 Z를 구하는 프로그램을 작성.
            //      A Z
            //    + Z A
            // --------------
            //      9 9






            //조건문을 실행했으면 이제 다시 여기서부터 프로그램 시작한다.
            //프로그램은 여기서 끝난다.
        }   //Main()
    }
}