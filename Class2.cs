using System;
using System.Buffers.Text;
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
            //int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            //int number1 = 1;
            //int number2 = 2;
            //int number3 = 3;
            //int number4 = 4;
            //int number5 = 5;

            //Console.WriteLine(numbers);

            //for (int index = 0; index < numbers.Length; index++)
            //{
            //    Console.Write(numbers[index]);
            //}

            //numbers배열에서 element에 순서대로 대입하는 것을 반복
            //foreach (int element in numbers)
            //{
            //    Console.Write($"{element} ");
            //}

            //int number = 1_0821;
            //Console.WriteLine($"64로 mod 여산 : {number%64}");

            /**
             * 다차원 배열
             * 2차원 배열, 3차원 배열처럼 차원이 2개 이상인 배열을 다차원 배열이라고 한다.
             * C#에서 배열을 선언할 때는 콤마를 기준으로 차원을 구분한다.
             */

            //int[] oneArray = new int[2] { 1, 2 }; //1차원 배열이다.
            //int[,] twoArray = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } }; //2차원 배열이다.
            ////               배열의 개수   배열당 담을수 있는 개수
            //int[,,] threeArray = new int[2, 2, 2] //3차원 배열이다.
            //{ 
            //    { { 1, 2 }, { 3, 4 } }, 
            //    { { 5, 6 }, { 7, 8 } } 
            //};

            //// 3행 3열짜리 배열에서 행과 열이 같으면 1, 다르면 0을 출력

            //twoArray = new int[3, 3];

            //for (int y = 0; y < 3; y++)
            //{
            //    for(int x = 0; x < 3; x++)
            //    {
            //        if (x == y) { twoArray[y, x] = 1; }
            //        else { twoArray[y, x] = 0; }
            //    }
            //}   //loop: 값을 대입하는 루프

            //for (int y = 0; y <= twoArray.GetUpperBound(0); y++)
            //{
            //    for (int x = 0; x <= twoArray.GetUpperBound(1); x++)
            //    {
            //        Console.Write("{0} ", twoArray[y,x]);
            //    }
            //    Console.WriteLine();
            //}   //loop: 값을 출력하는 루프

            /**
             * 가변배열
             * 차원이 2개 이상인 배열은 다차원 배열이고, 배열 길이가 가변 길이인 배열은 가변 배열이라고 한다.
             */

            //int[][] zagArray = new int[2][];
            //zagArray[0] = new int[2] { 1, 2 };
            //zagArray[1] = new int[3] { 3, 4, 5 };

            //for (int y = 0; y < 2; y++)
            //{
            //    for (int x = 0; x < zagArray[y].Length; x++)
            //    {
            //        Console.Write("{0} ", zagArray[y][x]);
            //    }
            //    Console.WriteLine();
            //}

            //int[] intArray;             // int 형 데이터 타입의 intArray 라는 배열을 메모리에 선언
            //intArray = new int[3];      // int 형 데이터 타입의 변수를 3개 메모리에 할당

            //intArray[0] = 1;            // intArray 0번째 인덱스에 1이라는 정수값을 대입
            //intArray[1] = 2;            // intArray 1번째 인덱스에 2이라는 정수값을 대입
            //intArray[2] = 3;            // intArray 2번째 인덱스에 3이라는 정수값을 대입

            //// 배열 직접 출력해본다.
            //for (int index=0; index<3; index++)
            //{
            //    Console.WriteLine("{0} 번째 인덱스의 값 -> {1}", index, intArray[index]);
            //}   //loop: 3번 도는 루프
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            //// intArray 배열에서 int 형 데이터 타입의 값을 하나씩 뽑아서 index에 저장 할거임.
            //foreach(int index in intArray)
            //{
            //    Console.WriteLine("intArray 배열에서 뽑아온 값 -> {0}", index);
            //}       //loop: intArray 배열의 길이만큼 도는 루프



            //int[] studentScore = new int[3];
            //int allScore = 0, average = 0, scoreCount = 0;
            //bool[] exception = new bool[3];

            //Console.Write("첫번째 학생의 점수를 입력해주세요 : ");
            //exception[0] = int.TryParse(Console.ReadLine(), out studentScore[0]);
            //Console.Write("두번째 학생의 점수를 입력해주세요 : ");
            //exception[1] = int.TryParse(Console.ReadLine(), out studentScore[1]);
            //Console.Write("세번째 학생의 점수를 입력해주세요 : ");
            //exception[2] = int.TryParse(Console.ReadLine(), out studentScore[2]);

            //bool clear = ((exception[0] == true) || (exception[1] == true)) || exception[2];


            //if (clear)
            //{
            //    for (int index = 0; index < studentScore.Length; index++)
            //    {
            //        if (exception[index] == true)
            //        {
            //            allScore += studentScore[index];
            //            scoreCount++;
            //        }
            //        else { /*Do nothing*/}
            //    }

            //    average = allScore / scoreCount;

            //    Console.WriteLine($"총점은 {allScore}점 이고 평균은 {average}점 입니다!");
            //}

            //else
            //{
            //    Console.WriteLine("잘못된 입력입니다!");
            //}

            //배열에서 최대값 찾기
            //Random landnum = new Random();
            //int[] number = new int[100];
            //int maxNumber = 1;

            //for (int index = 0; index <= 99; index++)
            //{
            //    number[index] = landnum.Next(1, 101);
            //    if (number[index] > maxNumber)
            //    {
            //        maxNumber = number[index];
            //        Console.WriteLine($"{index+1}번째 배열의 최대값 갱신!! : {maxNumber} \n");

            //    }
            //    else { /*Do nothing*/}
            //}

            //Console.WriteLine($"배열중 최대값은 : {maxNumber} ");





            //사과를 제일 좋아하는 사람 찾기
            int[] appleEatPeople = new int[5] { 0, 0, 0, 0, 0 };
            int[] sequencePeople = new int[5];
            Random appleRand = new Random();

            int maxEatApple = 0, minEatApple = 0, maxSequence = 0, minSequence = 0;
            bool clearing = true, sametime;


            for (int index = 0; index < appleEatPeople.Length; index++)
            {
                //Console.Write($"{index + 1}번째 사람이 아침에 먹는 사과 개수를 입력해주세요 : ");
                //clearing = int.TryParse(Console.ReadLine(), out appleEatPeople[index]); //배열에 데이터 입력
                appleEatPeople[index] = appleRand.Next(100, 1001); //랜덤으로 입력

                sametime = 
                switch (sametime)
                {
                    case true:

                        break;
                    case 2:

                        break;
                }


                sequencePeople[index] = index + 1; //몇번째 사람인지를 기록
                if (index == 0) // if문을 사용할때는 항상 else 문을 사용해주자!
                {
                    minEatApple = appleEatPeople[0]; //가장 첫번째 사람을 가장 적게 먹은사람으로 기준
                }
                else { /*Do Nothing*/ } //else 문을 사용하여 다음 if 문이 작동하게 만들수 있음

                if (clearing == false) //if문 시작( 이중에 하나로 들어감)
                {
                    goto outpord; //잘못 입력했을경우 맨 아레 경고 출력
                }
                else if (appleEatPeople[index] > maxEatApple) //index번째 사람이 많이 먹은 값 보다 많이 먹으면 참
                {
                    maxEatApple = appleEatPeople[index];    //가장 많이 먹은 값에 대입
                    maxSequence = index + 1;                //가장 많이 먹은 사람 번호 대입
                }
                else if (appleEatPeople[index] <= minEatApple) //가장 적게 먹을 경우에
                {
                    minEatApple = appleEatPeople[index];
                    minSequence = index + 1;
                }
                else { /*do nothing*/}
            }
            Console.WriteLine($"\n아침에 가장 많이 사과를 먹은 사람은 {maxSequence}번째 사람입니다! 먹은 사과 개수 : {maxEatApple}");
            Console.WriteLine($"\n아침에 가장 적게 사과를 먹은 사람은 {minSequence}번째 사람입니다! 먹은 사과 개수 : {minEatApple}");

            //버블 정렬 로직 시작 부분
            int firstVoid = 0, secondVoid = 0;

            for (int index = 0; index < appleEatPeople.Length - 1; index++)
            {
                for (int index2 = 0; index2 < appleEatPeople.Length - 1; index2++)
                {
                    if (appleEatPeople[index2] > appleEatPeople[index2 + 1]) //1번 배열의 수가 2번 배열의 수보다 클 경우 실행
                    {
                        firstVoid = appleEatPeople[index2]; //1번 배열을 first 변수에 대입
                        appleEatPeople[index2] = appleEatPeople[index2 + 1]; //1번 배열에 2번 배열 재배치
                        appleEatPeople[index2 + 1] = firstVoid; //2번 배열에 first변수 대입

                        secondVoid = sequencePeople[index2]; //위와 동일함
                        sequencePeople[index2] = sequencePeople[index2 + 1];
                        sequencePeople[index2 + 1] = secondVoid;
                    }
                    else {/*Do Nothing*/ }
                } // loop : 먹은 사람 수 -1 만큼 반복
            } // loop : 먹은 사람 수 -1 만큼 반복

            for (int index = 0; index < appleEatPeople.Length; index++) //먹은개수와 사람들 출력 (먹은 개수를 순서대로)
            {
                Console.WriteLine($"\n{appleEatPeople[index]} 개의 사과를 먹은 {sequencePeople[index]} 번째 사람! ");
            }

        outpord:
            if (clearing == false)
            {
                Console.WriteLine("경고!!! 먹은 개수를 입력해주세요 !!");
            }


        }   //Main()
    }
}
