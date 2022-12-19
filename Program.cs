using System;

namespace WhatIsOperator
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            
            /*Console.WriteLine("Hello, World!");

            Console.Write("");
            string stringNumber = Console.ReadLine();
            int intnumber = Convert.ToInt32(stringNumber);
            Console.WriteLine(); */

            string stringBinary = Convert.ToString(10, 2);
            Console.WriteLine(stringBinary);
            int intbinary = Convert.ToInt32("0111",2);
            Console.WriteLine(intbinary);

            /**
             * 연산자
             * 데이터로 연산 작업을 수행할 때는 연산자(Operator)를 사용한다. 연산자는 기능에 따라 대입, 산술,
             * 관계, 논리, 증강, 조건, 비트, 시프트 연산자 등으로 나누며, 이용 형태에 따라 항 1개로 연산을 하는
             * 단항(Unary) 연산자와 항 2개로 연산을 하는 이항(Binary) 연산자, 항 3개로 연산을 하는 삼항(Ternary)
             * 연산자로 나눈다.
             * 
             * 단항 연산자
             * 단항 연산자는 연산자와 피연산자 하나로 식을 처리한다.
             * ex) [연산자] [피연산자]
             * + 연산자 : 특정 정수형 변수 값을 그대로 출력한다.
             * - 연산자 : 특정 정수형 변수 값을 음수로 변경하여 출력한다. 음수값이 들어 있다면 양수로 변환해서
             *          반환한다.
             * 
             * 이항 연산자
             * 이항 연산자는 연산자와 피연산자 2개로 식을 처리한다.
             * ex) [피연산자] [연산자] [피연산자2]
             * 
             * 삼항 연산자
             * 삼항 연산자는 식 1개의 항(Expression)과 그 결과에 따른 피연산자 각 1개씩 총 2개 항으로 식을 처리한다.
             * ex) (식) ? 피연산자1 : 피연산자2
             * 
             * 식과 문
             * 값 하나 또는 연산을 진행하는 구문의 계산식을 식(Expression) 또는 표현식이라고 한다. 표현식을 사용하여
             * 명령 하나를 진행하는 구문을 문(Statement) 또는 문장이라고 한다.
             */

            // 단항 연산자
            const int PLUS_FIVE = +5;
            const int MINUS_FIVE = -5;

            // 이항 연산자
            const int PLUS_TEN = 5 + 5;

            // 삼항 연산자               식 1개                2항                      3항
            string compareTen = (PLUS_FIVE > 10) ? "{0}은(는) 10 보다 크다" : "{0}은(는) 10보다 크지 않다";
            Console.WriteLine(compareTen,PLUS_FIVE);

            // 변환 연산자
            // () 기호를 사용하여 특정 값을 원하는 데이터 형식으로 변환할 수 있다.
            const int PI_INT = (int)3.141592;
            const float PI_FLOAT = (float)3.141592;

            Console.WriteLine("PI_INT : {0}, PI_FLOAT : {1}", PI_INT, PI_FLOAT);

            /**
             * 산술, 관계, 논리, 증감, 조건, 비트, 시프트 연산자
             * 
             * 산술 연산자
             * 더하기(Add), 빼기(Subtract), 곱하기(Multiply), 나누기(Divide), 나머지(Remainder, Modules) 등
             * 수학적 연산을 하는 데 사용한다. 보통 정수 형식와 실수 형식의 산술 연산에 사용한다.
             * ex) +, -, *, /, %
             * 
             * 문자열 연결 연산자
             * 산술 연산자 중 하나인 + 연산자는 피연산자의 데이터 타입에 따라 산술 연산 또는 문자열 연결 연산을 수행한다.
             * 
             * +연산자 : 두 항이 숫자일 때는 산술(+) 연산 가능, 문자열일 때는 문자열 연결 가능
             */

            string addMessage = "string " + "plus " + "string";
            Console.WriteLine(addMessage);

            /**
             * 할당 연산자
             * 할당 연산자(Assignment operator)는 변수에 데이터를 대입하는 데 사용한다. 할당 연산자를 대입 연산자
             * 라고도 한다. C#에서 = 기호는 같다는 의미가 아니라 오른쪽에 있는 값 또는 식의 결과를 왼쪽 변수에
             * 할당하라고 지시하는 것이다.
             * 
             * ex) =,+=, -=, *=, /=, %=
             * 
             * 증감 연산자(Increment / Decrement operator)
             * 변수 값을 1 증가시키거나 1 감소시키는 연산자이다. 증감 연산자가 변수 앞에 위치하느냐, 뒤에 위치하느냐에
             * 따라 연산 처리 우선순위가 결정된다.
             * 
             * ++(증가 연산자) : 변수 값에 1을 더한다.
             * --(감소 연산자) : 변수 값에 1을 뺀다.
             * 
             * 증감 연산자가 앞에 붙으면 전위 증감 연산자라고 하며, 변수 뒤에 붙으면 후위 증감 연산자라고 한다.
             * 
             * 전위(Prefix) 증감 연산자 : 정수형 변수 앞에 연산자가 위치하여 변수 값을 미리 증감한 후 나머지 연산을
             *                          수행한다.
             * 후위(postfix) 증강 연산자 : 정수형 변수 뒤에 연산자가 위치하여 연산식(대입)을 먼저 실행한 후 나중에
             *                          변수 값을 증감한다.
             */

            int number = 0;
            number++;
            Console.WriteLine(number);

            /**
             * 관계형 연산자
             * 관계형 연산자(Relational operator) 또는 비교 연산자(Comarative operator)는 두 항이 큰지, 작은지
             * 또는 같은지 등을 비교하는 데 사용한다. 관계형 연산자의 결과값은 논리 데이터 형식인 참(True), 또는
             * 거진(False)으로 출력된다.
             * ex) <, <=, >, >=, ==, !=
             * 
             * 논리 연산자
             * 논리 연산자(Logical operator)는 논리곱(AND), 논리합(OR), 논리부정(NOT)의 조건식에 대한 논리 연산을
             * 수행한다. 연산의 결과값은 참 또는 거짓의 bool 형식으로 반환되어 Boolean 연산자라고도 한다.
             * ex) &&(논리곱), ||(논리합), !(논리부정)
             * 
             * 비트 연산자
             * 비트 연산자(Bit operator)는 정수형 데이터의 값을 이진수 비트 단위로 연산을 수행할 때 사용한다.
             * ex) &, |, ^, ~
             * 
             * 시프트 연산자
             * 시프트 연산자(Shift operator)는 정수 데이터가 담겨 있는 메모리에 비트를 왼쪽 또는 오른쪽으로 지정한
             * 비트만큼 이동시킨다. 암호화쪽에서 많이 쓰임
             * 
             * ex) <<, >>
             * 
             * 조건 연산자
             * 조건 연산자(conditional operator)는 조건에 따라서 참일 때와 거짓일 때 결과를 다르게 반환하며,
             * (조건식) ? (식1 또는 값1) : (식2 또는 값2) 형태의 연산자이다. if~else 문의 축약형이기도 하다.
             */

            bool isBigger = false;
            isBigger = (5 == 10) || (5 < 10);
            Console.WriteLine(isBigger);

            isBigger = !isBigger;
            Console.WriteLine(isBigger);

            int bitNumber = 10;
            int bitResult = 0;
            bitResult = bitNumber & 1;
            Console.WriteLine(bitResult);

            // 나열(콤마) 연산자
            // 콤마를 구분자로 하여 한 문장에 변수 여러 개를 선언할 때 사용한다.
            int intNumber1, intNumber2, intNumber3;

            /**
             * sizeof 연산자
             * sizeof 연산자는 단항 연산자로 데이터 형식 자체의 크기를 구하는 데 사용한다.
             * sizeof([데이터 타입]) 형태로 사용하며, 운영 체제와 CPU 아키텍쳐의 종류에 따라 결과값이
             * 다르게 나올 수 
             */

            Console.WriteLine("int의 메모리 크기는 {0} 바이트 입니다.", sizeof(Int32));

            /**
             * 연산자 우선순위
             * 연산자 여러 개를 함께 사용할 때는 연산자 우선순위(Precedence)에 따라 계산된다.
             * 연산자 우선순위를 잘 모를 때는 일단 괄호 연산자부터 잘 사용하도록 연습하는게 좋다.
             */

            /* 과제 코딩
            Console.Write("주어 : ");
            string subject = Console.ReadLine();
            Console.Write("동사 : ");
            string verb = Console.ReadLine();
            Console.Write("목적어 : ");
            string direct_object = Console.ReadLine();

            Console.WriteLine(subject + " " + verb + " " + "a " + direct_object);

            Console.Write("나이 : ");
            string age1 = Console.ReadLine();
            int age = 0;
            int.TryParse(age1, out age);
            Console.WriteLine("10년 후에는 {0}이 됩니다.", age + 10);

            Console.Write("첫 번째 변 : ");
            string first1 = Console.ReadLine();
            Console.Write("두 번째 변 : ");
            string second1 = Console.ReadLine();

            int first = 0, second = 0;
            double third = 0;
            int.TryParse(first1, out first);
            int.TryParse(second1, out second);
            third = (first * first) + (second * second);
            third = Math.Sqrt(third);
            Console.WriteLine("빗변길이 : {0}", third);
            

            Console.Write("길이 : ");
            string length = Console.ReadLine();
            Console.Write("너비 : ");
            string width = Console.ReadLine();
            Console.Write("높이 : ");
            string height = Console.ReadLine();

            int length1, width1, height1;
            int.TryParse(length, out length1);
            int.TryParse(width, out width1);
            int.TryParse(height, out height1);

            int volume = length1 * width1 * height1;
            int area = ((length1 * width1) * 2) + ((length1 * height1) * 4);

            Console.WriteLine("상자의 부피 : {0}\n상자의 표면적 : {1}", volume, area);


            Console.Write("평 : ");
            string pyeong = Console.ReadLine();

            float pyeongmeter = 0;
            float.TryParse(pyeong, out pyeongmeter);
            pyeongmeter = 3.3058f * pyeongmeter;

            Console.WriteLine("평방미터 : {0}m^2", pyeongmeter);
            
            int hour, minute, second, allsecond;

            Console.Write("시 : ");
            int.TryParse(Console.ReadLine(), out hour);
            Console.Write("분 : ");
            int.TryParse(Console.ReadLine(), out minute);
            Console.Write("초 : ");
            int.TryParse(Console.ReadLine(), out second);

            allsecond = second + (minute * 60) + (hour * 3600);
            Console.WriteLine("전체 초 : {0}", allsecond);
            
            int score1, score2, score3, score4, score5, allscore;
            
            Console.Write("퀴즈\t#1\t성적 : ");
            int.TryParse(Console.ReadLine(), out score1);
            Console.Write("퀴즈\t#2\t성적 : ");
            int.TryParse(Console.ReadLine(), out score2);
            Console.Write("퀴즈\t#3\t성적 : ");
            int.TryParse(Console.ReadLine(), out score3);
            Console.Write("중간고사#4\t성적 : ");
            int.TryParse(Console.ReadLine(), out score4);
            Console.Write("기말고사#5\t성적 : ");
            int.TryParse(Console.ReadLine(), out score5);

            allscore = score1 + score2 + score3 + score4 + score5;

            Console.WriteLine("==============================");
            Console.WriteLine("성적 총합 : {0}", allscore);
            Console.WriteLine("==============================");
            */




        }
    }
}