using System;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 선택문인 switch 문은 값에 따라 다양한 제어를 처리할 수 있다. 조건을 처리할 내용이 많은 경우 유용하다.
             * switch, case, default 키워드를 사용하여 조건을 처리한다.
             */

            //Console.Write("정수 1, 2, 3 중에 하나를 입력하시오 : ");
            //int switchnumber = 0;
            //int.TryParse(Console.ReadLine(), out switchnumber);

            //예시)
            //switch (switchnumber)
            //{
            //    case 1:
            //        Console.WriteLine("1을(를) 입력했습니다.");
            //        break;
            //    case 2:
            //        Console.WriteLine("2을(를) 입력했습니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine("3을(를) 입력했습니다.");
            //        break;
            //    default:
            //        Console.WriteLine("처리하지 않은 예외 입력입니다.");
            //        break;
            //        //switch
            //}

            /**
             * 02.5 중간점검
             * 1. case 절에서 break 문을 생략하면 어떻게 되는가?
             * case 안에 스테이트가 비어있으면 에러는 발생하지 않는다.
             * 
             * switch문에서 goto 를 쓴다면 로직을 잘 못 설계한것이다.(일반적으로 잘 사용하지 않는다.)
             */

            //예시)
            //Console.WriteLine("가장 좋아하는 프로그래밍 언어는?");
            //Console.Write("1. c\t");
            //Console.Write("2. c++\t");
            //Console.Write("3. c#\t");
            //Console.Write("4. Java\t");

            //int chice = Convert.ToInt32(Console.ReadLine());

            //switch (chice)
            //{
            //    case 1:
            //        Console.WriteLine("C 선택");
            //        break;
            //    case 2:
            //        Console.WriteLine("C++ 선택");
            //        break;
            //    case 3:
            //        Console.WriteLine("C# 선택");
            //        break;
            //    case 4:
            //        Console.WriteLine("Java 선택");
            //        break;
            //    default:
            //        Console.WriteLine("예외입력");
            //        break;
            //}

            //예시) 케이스에 문자열을 넣는것도 가능함
            //Console.WriteLine("오늘의 날씨는 어떤가요? (맑음, 흐림, 비, 눈, ...)");
            //string weather = Console.ReadLine();

            //switch (weather)
            //{
            //    case "맑음":
            //        Console.WriteLine("오늘 날씨는 맑군요");
            //        break;
            //    case "흐림":
            //        Console.WriteLine("오늘 날씨는 흐리군요");
            //        break;
            //    case "비":
            //        Console.WriteLine("오늘 날씨는 비가 오네요");
            //        break;
            //    case "눈":
            //        Console.WriteLine("오늘 날씨는 눈이와 눈이와");
            //        break;
            //    default:
            //        Console.WriteLine("예외입니다.");
            //        break;
            //}

            // While 문은 조건식이 참일 동안 문장을 반복 실행한다.

            //while 문은 반복문인데 5번 실행 예정
            //int loopcounter = 0;
            //while(loopcounter < 5)
            //{
            //    Console.WriteLine("{0}반복문이 정말로 5번이나???", loopcounter +1 ); ;
            //    loopcounter++;
            //        //loop : 5번만 도는 루프
            //}

            ////10 ~ 1 카운트 후 발사 출렧하는 프로그램 작성
            //loopcounter = 10;
            //while (loopcounter>0)
            //{
            //    Console.WriteLine("{0}", loopcounter);
            //    loopcounter -= 1;
            //}   //loop

            // 예시 #3 - 구구단 출력하는 프로그램 작성, User Input 받아서 해당 단을 출력
            //int usergugudan = 0;
            //Console.Write("구구단 중에서 출력하고 싶은 단 입력 : ");
            //int.TryParse(Console.ReadLine(), out usergugudan);

            //const int GUGU_LOOP_COUNT = 9;
            //int guguloopidx = 1;
            //while(guguloopidx <= GUGU_LOOP_COUNT)
            //{
            //    Console.WriteLine("{0}*{1}={2}", usergugudan, guguloopidx, usergugudan * guguloopidx);
            //    guguloopidx++;
            //}

            //문제 1 ==================================================================================
            //int essence = 0;
            //Console.Write("양의 정수를 입력해주세요 : ");
            //int.TryParse(Console.ReadLine(), out essence);


            //if (essence > 0)
            //{
            //    while (essence > 0)
            //    {
            //        Console.WriteLine("Hello Wolrd");
            //        essence--;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("음수이거나 0입니다.");
            //}

            ////문제 2 keep
            //int essence2 = 0, multiple2 = 1;
            //const int THREE = 3;
            //Console.Write("양의 정수를 입력해주세요 : ");
            //int.TryParse(Console.ReadLine(), out essence2);

            //while (essence2 > 0)
            //{
            //    Console.Write("{0}, ", THREE * multiple2);
            //    --essence2;
            //    ++multiple2;
            //}
            //Console.WriteLine("");

            ////문제 3
            //int essence3 = 1, allint = 0;

            //while (essence3 > 0)
            //{
            //    if (essence3 > 0)
            //    {
            //        Console.Write("정수를 입력해주세요 : ");
            //        int.TryParse(Console.ReadLine(), out essence3);
            //        allint += essence3;
            //    }
            //}

            //if (essence3 == 0)
            //{
            //    Console.WriteLine("모든 정수의 합 : {0}", allint);
            //}

            //else if (essence3 < 0)
            //{
            //    Console.WriteLine("음의 정수입니다.");
            //}

            ////문제 4
            //int essence4 = 0, count = 9;
            //Console.Write("숫자를 입력해주세요 : ");
            //int.TryParse(Console.ReadLine(), out essence4);

            //while (count > 0)
            //{
            //    Console.Write("{0}, ", essence4 * count);
            //    count--;
            //}
            //Console.WriteLine("");

            ////문제 5
            //int loop5 = 0, essence5, allint5 = 0;
            //double average = 0;
            //Console.Write("반복할 숫자를 입력해주세요 : ");
            //int.TryParse(Console.ReadLine(), out loop5);
            //int count5 = loop5;

            //while (loop5 > 0)
            //{
            //    Console.Write("평균을 구할 정수를 입력해주세요 : ");
            //    int.TryParse(Console.ReadLine(), out essence5);
            //    allint5 += essence5;
            //    loop5--;
            //}

            //average = (double)allint5 / (double)count5;
            //Console.WriteLine("평균 값은 : {0}입니다.", average);

            // 문제 6
            //float compare1, compare2;
            //Console.Write("실수를 입력해주세요 : ");
            //float.TryParse(Console.ReadLine(), out compare1);
            //Console.Write("실수를 입력해주세요 : ");
            //float.TryParse(Console.ReadLine(), out compare2);

            //if (compare1 == compare2)
            //{
            //    Console.WriteLine("같은 값입니다.");
            //}
            //else if (compare1 != compare2)
            //{
            //    Console.WriteLine("다른 값입니다.");
            //}

            /**
             * for 문은 일정한 횟수만큼 반복할 때 유용하다.
             * 초기식을 실행한 후에 조건식이 참일 동안, 문장을 반복한다. 한번 반복이 끝날 때마다 증감식이
             * 실행된다.
             */

            ////1~10 까지 정수의 합
            //int sumnumber = 0;
            ////                 
            //// 1,2,3,4 순으로 돌아감, 초기식은 처음 한번만 실행된다.
            //// 1.초기식  2.조건식(참일경우 실행) 4.증감식
            //for(int index = 1; index <= 10; index++)
            //{
            //    sumnumber += index; //3.문장
            //}
            //Console.WriteLine($"1부터 10까지의 정수의 합 = {sumnumber}");

            //문제 7 1~100 까지의 3의 배수를 제외한 수의 합

            //int allresult=0; //결과값

            //for(int multiple7=1; multiple7 <= 100; multiple7++) //반복문
            //{
            //    if(0 == multiple7%3)
            //    {
            //        allresult -= multiple7;
            //    }
            //    allresult += multiple7; //반복문을 더하는 식
            //}
            //Console.WriteLine($"결과값 : {allresult}");

            /**
             * break문
             * break문은 반복 루프를 벗어나기 위해서 사용한다. break 문이 실행되면 반복 루프는 즉시 중단되고
             * 반복 루프 다음에 있는 문장이 실행된다.
             * 
             * continue 문
             * continue 문은 현재 수행하고 있는 반복 과정의 나머지를 건너뛰고 다음 반복 과정을 강제적으로 시작하게
             * 만든다. 반복 루프에서 continue 문을 만나게 되면 continue 문 다음에 있는 후속 코드들은
             * 실행되지 않고 건너뛰게 된다.
             */

            //문제 7 1~100 까지의 3의 배수를 제외한 수의 합

            //int allresult = 0; //결과값

            //for (int multiple7 = 1; multiple7 <= 100; multiple7++) //반복문
            //{
            //    if (0 == multiple7 % 3)
            //    {
            //        continue;
            //    }
            //    allresult += multiple7; //반복문을 더하는 식
            //}
            //Console.WriteLine($"결과값 : {allresult}");

            //for (int index = 1; index <= 10; index++)
            //{
            //    if (index == 4) { break; } // 4번째에서 브레이크 문으로 인해 for문을 탈출
            //    Console.WriteLine("현재 인덱스 : {0}", index);
            //}   // loop: 10번 도는 루프

            //LAB 1 자음과 모음 개수 세기
            //int vowel = 0, consonant = 0; //모음과 자음 변수
            //string letter = ""; // 입력받을 변수
            //while (letter != "#")
            //{
            //    Console.Write("(종료문자 : #)영문자를 입력해주세요 : ");
            //    letter = Console.ReadLine();
            //    switch (letter)
            //    {
            //        case "a":
            //            ++vowel;
            //            break;
            //        case "e":
            //            ++vowel;
            //            break;
            //        case "i":
            //            ++vowel;
            //            break;
            //        case "o":
            //            ++vowel;
            //            break;
            //        case "u":
            //            ++vowel;
            //            break;
            //        case "A":
            //            ++vowel;
            //            break;
            //        case "E":
            //            ++vowel;
            //            break;
            //        case "I":
            //            ++vowel;
            //            break;
            //        case "O":
            //            ++vowel;
            //            break;
            //        case "U":
            //            ++vowel;
            //            break;
            //        case "#":
            //            break;
            //        default:
            //            ++consonant;
            //            break;
            //    }
            //}

            //Console.WriteLine($"모음 : {vowel}");
            //Console.WriteLine($"자음 : {consonant}");

            //LAB 2 숫자 맟추기 게임
            //int numbb = 42, inputnum = 0;
            //Console.Write("숫자를 제시해주세요 : ");
            //int.TryParse(Console.ReadLine(), out inputnum);


            //while (inputnum != numbb)
            //{
            //    if (inputnum < numbb)
            //    {
            //        Console.Write($"{inputnum}보다 높아요!.");
            //        Console.Write("숫자를 제시해주세요 : ");
            //        int.TryParse(Console.ReadLine(), out inputnum);
            //    }
            //    else if (inputnum > numbb)
            //    {
            //        Console.Write($"{inputnum}보다 낮아요!.");
            //        Console.Write("숫자를 제시해주세요 : ");
            //        int.TryParse(Console.ReadLine(), out inputnum);
            //    }
            //}
            //if (inputnum == numbb)
            //{
            //    Console.Write("정답!!");
            //}

            //LAB 2.1 숫자 맟추기 게임 어려움 못 품
            //int correct = 50;
            //int low=1, high=100, mid=50;
            //Console.Write("1부터 100까지 맞춰야 할 숫자를 정해주세요 : ");
            //Console.ReadLine();

            //Console.WriteLine($"{correct}이 정답인가요?");
            //Console.Write("1에서 100 중 높은지 낮은지 알려주세요 : ");
            //string updown = Console.ReadLine();

            //while (updown != "yes")
            //{


            //        if (updown == "up")
            //        {
            //            mid = (mid+high)/2;// 60 -> 50 -> 75 -> 62 -> 56 -> 58
            //            low = mid;
            //            Console.WriteLine($"{mid}이 정답인가요?");
            //            Console.Write("1에서 100 중 높은지 낮은지 알려주세요 : ");
            //            updown = Console.ReadLine();

            //        }
            //        else if (updown == "down")
            //        {
            //            mid = (mid+high) / 2;
            //        high = mid;
            //            Console.WriteLine($"{mid}이 정답인가요?");
            //            Console.Write("1에서 100 중 높은지 낮은지 알려주세요 : ");
            //            updown = Console.ReadLine();

            //        }
            //        else
            //        {
            //            Console.WriteLine("up 또는 down 또는 yes 으로만 알려주세요.");
            //            updown = Console.ReadLine();
            //        }


            //}
            //if (updown == "yes")
            //{
            //    Console.Write("맞췄다!");
            //}

            //LAB 3 산수 문제 자동 출제
            //Random munje = new Random();
            //int input=1 , result = 0;

            //while (result != input)
            //{
            //    int oper1 = munje.Next(0, 100);
            //    int oper2 = munje.Next(0, 100);
            //    int uhyung = munje.Next(1, 5);

            //    switch (uhyung) {
            //        case 1:
            //            Console.WriteLine("덧셈 문제 출제 나갑니다.");
            //            result = oper1 + oper2;
            //            Console.WriteLine($"{oper1} + {oper2} = ");

            //            Console.Write("답을 써주세요 : ");
            //            int.TryParse(Console.ReadLine(), out input);
            //            break;
            //        case 2:
            //            Console.WriteLine("뺄셈 문제 출제 나갑니다.");
            //            result = oper1 - oper2;
            //            Console.WriteLine($"{oper1} - {oper2} = ");

            //            Console.Write("답을 써주세요 : ");
            //            int.TryParse(Console.ReadLine(), out input);
            //            break;
            //        case 3:
            //            Console.WriteLine("곱셈 문제 출제 나갑니다.");
            //            result = oper1 * oper2;
            //            Console.WriteLine($"{oper1} * {oper2} = ");

            //            Console.Write("답을 써주세요 : ");
            //            int.TryParse(Console.ReadLine(), out input);
            //            break;
            //        case 4:
            //            if (oper2 == 0) { break; }
            //            if (oper1 == 0) { break; }
            //            Console.WriteLine("나눗셈 문제 출제 나갑니다.");
            //            result = oper1 / oper2;
            //            Console.WriteLine($"{oper1} / {oper2} = ");

            //            Console.Write("답을 써주세요 : ");
            //            int.TryParse(Console.ReadLine(), out input);
            //            break;
            //    }
            //}
            //Console.WriteLine("정다압!!!!");

            /**
             * foreach 문은 배열(Array)이나 컬렉션(Collection) 같은 값을 여러 개 담고 있는 데이터 구조에서
             * 각각의 데이터가 들어 있는 만큼 반복하는 반복문이다. 테이터 개수나 반복 조건을 처리할 필요가 없다.
             */

            //string 에서 글자를 하나씩 출력
            //string stringtext = "Hello World!";
            //int loopcount = 0;

            //foreach(char onecharactor in stringtext)
            //{
            //    Console.Write($"{onecharactor} ");
            //    loopcount++;
            //}   // loop : stringtext의 길이만큼 도는 루프
            //Console.Write($"Loop Count : {loopcount} , StringText's length{stringtext.Length}");

            //문제8 1~100 숫자 중에서 3의 배수이면서 4의 배수인 정수 합 구하기
            //int multi3_=0;
            //for (int loopcount=1; loopcount <= 100; loopcount++)
            //{
            //    if(0 == (loopcount % 3))
            //    {
            //        if(0 == (loopcount % 4))
            //        {
            //            multi3_ += loopcount;
            //        }
            //    }
            //}
            //Console.WriteLine($"정수의 합은 : {multi3_}");

            //문제9 두개의 정수를 입력 받아서 두 수의 차를 출력하는 프로그램 작성
            //int numb_1=0, numb_2=0, result=0;
            //Console.Write("정수를 입력해주세요 : ");
            //int.TryParse(Console.ReadLine(), out numb_1);
            //Console.Write("정수를 입력해주세요 : ");
            //int.TryParse(Console.ReadLine(), out numb_2);

            //if (numb_1 > numb_2) {
            //    result = numb_1 - numb_2;
            //}
            //else if (numb_2 > numb_1)
            //{
            //    result = numb_2 - numb_1;
            //}
            //Console.WriteLine($"두 수의 차는 : {result}");

            //문제 10 구구단을 출력하되 짝수(2단,4단,6단,8단)만 출력되도록 하는 프로그램 작성.
            //int gugudan_ = 1, result = 0, index = 0;

            //for (gugudan_ = 1; gugudan_ < 9; gugudan_++)
            //{
            //    for (index = 1; index < 9; index++)
            //    {
            //        result = gugudan_ * index;
            //        Console.Write($"{result} ");
            //        if (gugudan_ == index)
            //        {
            //            break;
            //        }

            //    }
            //    Console.WriteLine();

            //문제 11 다음 식을 만족하는 모든 A와 Z를 구하는 프로그램 작성
            int A = 1;
            int Z = 9;
            int result1=0, result2 = 0;

            result1 = A + Z;
            result2 = A + Z;

            Console.WriteLine(result1+result2);


            }
        }       // Main()
    }
}   
