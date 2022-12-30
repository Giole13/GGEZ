using System;
using System.Threading;
using System.Threading.Tasks;

namespace Work221226
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //과제 1
            //5x5 보드(사이즈 줘도 o)
            //□□□□□
            //□. . .□
            //□.옷 .□
            //□. . .□
            //□□□□□
            //(닷)은 빈 곳, □는 벽을 의미

            //빈 곳중에 아무곳이나 사람(이모티콘 또는 옷) 을 초기화해서
            //w, a, s, d 입력 받아서 빈 곳을 자유롭게 이동하는 프로그램 작성.
            // - 사람은 빈 곳을 다닐 수 있음.
            // - 사람은 벽을 넘어다닐 수 없음.

            //$ 코인 랜덤 생성 및 먹은 개수 출력

            //Task.Delay(300).Wait(); //0.3초 기다리는 딜레이



            /**
             * gameBoard에 0이면 빈 공간, 1은 플레이어, 2는 벽으로 설정
             * 
             */


            //bool blinking = false;
            //char i = ' ';
            //while (blinking == false)
            //{
            //    Task.Delay(1000).Wait(); //0.3초 기다리는 딜레이
            //    Console.WriteLine("Press Any Key!");
            //    Task.Delay(1000).Wait(); //0.3초 기다리는 딜레이
            //    Console.Clear();
            //}
            //    blinking = char.TryParse(Console.ReadLine(), out i);
            Console.WriteLine("Press Any Key!");
            Console.ReadKey();
            Console.Clear();

            const int BOARD_SIZE_X = 10;                         //맵 x (세로축 개수)
            const int BOARD_SIZE_Y = 10;                         //맵 y (가로축 개수)
            int[,] gameBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];    //맵의 크기를 배열로 정의
            bool playerLife = true;                             //플레이어의 목숨 (false가 되면 게임오버)
            bool jumpToFor = false;                             //s키를 입력시 y + 1의 이슈 해결방안
            int coinCount = 0;                                  //코인 먹은 개수 출력
            int moveCount = 0;                                  //움직인 횟수

            Random randCoin = new Random();





            //맵을 초기화 하고 플레이어를 추가해주는 구문
            for (int y = 0; y < BOARD_SIZE_Y; y++)
            {
                for (int x = 0; x < BOARD_SIZE_X; x++)
                {
                    gameBoard[y, x] = 0;                        //맵 전체를 빈 공간으로 초기화함
                }
            }       //loop: 맵을 초기화하는 루프


            for (int y = 0; y < BOARD_SIZE_Y; y++)
            {
                for (int x = 0; x < BOARD_SIZE_X; x++)
                {
                    if (y == 0)                                 //맵 맨 첫줄에 벽 생성
                    {
                        gameBoard[y, x] = 2;
                    }
                    if (y == BOARD_SIZE_Y - 1)                    //맵 맨 아랫줄에 벽 생성
                    {
                        gameBoard[y, x] = 2;
                    }
                    if (x == 0)                                 //맵 맨 왼쪽에 벽 생성
                    {
                        gameBoard[y, x] = 2;
                    }
                    if (x == BOARD_SIZE_X - 1)                    //맵 맨 오른쪽에 벽 생성
                    {
                        gameBoard[y, x] = 2;
                    }
                }
            }       //loop: 맵에 벽을 만드는 루프


            gameBoard[BOARD_SIZE_Y / 2, BOARD_SIZE_Y / 2] = 1;  //맵의 정가운데에 1(플레이어)를 대입
            string direction = "";      //움직이는 방향 키값

            int coinNumber = 0;
            int maxCoin = 0;


            //랜덤코인 생성기
            //bool coinFatory = true;
            //while (coinFatory)
            //{
            //    int yRand = randCoin.Next(1, BOARD_SIZE_Y - 1);
            //    int xRand = randCoin.Next(1, BOARD_SIZE_X - 1);
            //    gameBoard[yRand, xRand] = 3;
            //    ++coinNumber;
            //    if (coinNumber == 5)coinFatory = false;
            //}


            //여기까지가 맵 생성 단계
            //이 아래부터는 플레이어 상호작용 단계
            //게임 시작전에 맵에 5개의 코인 생성!
            for (int index = 0; index<5; index++)
            {
                for (int y = 0; y < BOARD_SIZE_Y; y++)              //맵을 화면에 출력해주는 구문
                {
                    for (int x = 0; x < BOARD_SIZE_X; x++)
                    {
                        switch (gameBoard[y, x])
                        {
                            case 0:
                                Console.Write(". ");               //배열의 값이 0이면 공백 .을 출력
                                break;
                            case 1:
                                Console.Write("옷");                //배열의 값이 1이면 플레이어를 출력
                                break;
                            case 2:
                                Console.Write("■");                //배열의 값이 2이면 벽을 출력
                                break;
                            case 3:
                                //Task.Delay(10).Wait(); //0.3초 기다리는 딜레이
                                Console.Write("$ ");                //코인을 만들어서 코인을 출력하겠다!
                                break;
                            default:                                //예외값은 패스
                                break;
                        }

                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\n총 10개를 먹으면 클리어~");

                Console.WriteLine("\n움직인 횟수 : {0}", moveCount);

                Console.WriteLine("\n먹은 코인 개수 : {0}", coinCount);

                Console.Write("\n움직일 방향을 입력해주세요 : ");    //캐릭터를 움직일 키값 받기

                if (maxCoin < 5) { Task.Delay(400).Wait(); } //0.3초 기다리는 딜레이
                                                             //코인 생성기
                                                             //if (direction == "w" || direction == "a" || direction == "s" || direction == "d")
                for (int i = 0; i < 5; ++i)
                {
                    if (maxCoin < 5)
                    {
                        int yRand = randCoin.Next(1, BOARD_SIZE_Y - 1);
                        int xRand = randCoin.Next(1, BOARD_SIZE_X - 1);
                        if (gameBoard[yRand, xRand] == 1 || gameBoard[yRand, xRand] == 3) { continue; }
                        //Task.Delay(1000).Wait(); //0.3초 기다리는 딜레이
                        gameBoard[yRand, xRand] = 3;
                        ++coinNumber;
                        ++maxCoin;
                        break;
                    }
                }

                Console.Clear();
            }

            while (playerLife)                                          //플레이어의 목숨이 true인 경우 반복
            {
                if (direction == "a")                                //"a"키를 받을 경우 난 왼쪽으로 플레이어를 옮기겠다.
                {
                    for (int y = 0; y < BOARD_SIZE_Y; y++)
                    {
                        for (int x = 0; x < BOARD_SIZE_X; x++)
                        {
                            if (gameBoard[y, x] == 1)               //플레이어가 식별된 경우 실행
                            {
                                if (gameBoard[y, x - 1] == 2)       //플레이어의 왼쪽에 벽이 있으면 어떤 행동도 못함
                                {
                                    break;
                                }
                                else if (gameBoard[y, x - 1] == 3) { coinCount++; --maxCoin; }
                                gameBoard[y, x] = 0;                //식별되 곳은 0(공백)으로 처리
                                gameBoard[y, x - 1] = 1;            //식별된 곳의 왼쪽에 1(플레이어)을 대입
                                ++moveCount;
                                break;                              //조건을 달성했으니 탈출
                            }
                        }
                    }
                }       //플레이어를 옮기는 루프

                if (direction == "s")                                //"s"키를 받을 경우 난 아래쪽으로 플레이어를 옮기겠다.
                {
                    for (int y = 0; y < BOARD_SIZE_Y; y++)
                    {
                        for (int x = 0; x < BOARD_SIZE_X; x++)
                        {
                            if (gameBoard[y, x] == 1)               //플레이어가 식별된 경우 실행
                            {
                                if (gameBoard[y + 1, x] == 2)       //플레이어의 아래에 벽이 있으면 어떤 행동도 못함
                                {
                                    jumpToFor = true;
                                    break;
                                }
                                else if (gameBoard[y + 1, x] == 3) { coinCount++; --maxCoin; }
                                gameBoard[y, x] = 0;                //식별되 곳은 0(공백)으로 처리
                                gameBoard[y + 1, x] = 1;            //식별된 곳의 아래쪽에 1(플레이어)을 대입
                                jumpToFor = true;                   //y를 한번 더 식별하지 않기 위해서 탈출 조건을 추가
                                ++moveCount;
                                break;                              //조건을 달성했으니 탈출 (이슈 발생 y + 1 을 할경우
                            }

                        }
                        if (jumpToFor)                              //탈출 조건이 true 일 경우
                        {
                            jumpToFor = false;                      //다시 s를 받기 위해서 false로 초기화
                            break;                                  //드디어 탈출
                        }
                    }
                }       //플레이어를 옮기는 루프

                if (direction == "d")                                //"d"키를 받을 경우 난 오른쪽으로 플레이어를 옮기겠다.
                {
                    for (int y = 0; y < BOARD_SIZE_Y; y++)
                    {
                        for (int x = 0; x < BOARD_SIZE_X; x++)
                        {
                            if (gameBoard[y, x] == 1)               //플레이어가 식별된 경우 실행
                            {
                                if (gameBoard[y, x + 1] == 2)       //플레이어의 오른쪽에 벽이 있으면 어떤 행동도 못함
                                {
                                    break;
                                }
                                else if (gameBoard[y, x + 1] == 3) { coinCount++; --maxCoin; }
                                gameBoard[y, x] = 0;                //식별되 곳은 0(공백)으로 처리
                                gameBoard[y, x + 1] = 1;            //식별된 곳의 오른쪽에 1(플레이어)을 대입
                                ++moveCount;
                                break;                              //조건을 달성했으니 탈출
                            }
                        }
                    }
                }       //플레이어를 옮기는 루프

                if (direction == "w")                                //"w"키를 받을 경우 난 위쪽으로 플레이어를 옮기겠다.
                {
                    for (int y = 0; y < BOARD_SIZE_Y; y++)
                    {
                        for (int x = 0; x < BOARD_SIZE_X; x++)
                        {
                            if (gameBoard[y, x] == 1)               //플레이어가 식별된 경우 실행
                            {
                                if (gameBoard[y - 1, x] == 2)       //플레이어의 위쪽에 벽이 있으면 어떤 행동도 못함
                                {
                                    break;
                                }
                                else if (gameBoard[y - 1, x] == 3) { coinCount++; --maxCoin; }
                                gameBoard[y, x] = 0;                //식별되 곳은 0(공백)으로 처리
                                gameBoard[y - 1, x] = 1;            //식별된 곳의 위쪽에 1(플레이어)을 대입
                                ++moveCount;
                                break;                              //조건을 달성했으니 탈출
                            }
                        }
                    }
                }       //플레이어를 옮기는 루프

                Console.Clear();




                for (int y = 0; y < BOARD_SIZE_Y; y++)              //맵을 화면에 출력해주는 구문
                {
                    for (int x = 0; x < BOARD_SIZE_X; x++)
                    {
                        switch (gameBoard[y, x])
                        {
                            case 0:
                                Console.Write(". ");               //배열의 값이 0이면 공백 .을 출력
                                break;
                            case 1:
                                Console.Write("옷");                //배열의 값이 1이면 플레이어를 출력
                                break;
                            case 2:
                                Console.Write("■");                //배열의 값이 2이면 벽을 출력
                                break;
                            case 3:
                                //Task.Delay(10).Wait(); //0.3초 기다리는 딜레이
                                Console.Write("$ ");                //코인을 만들어서 코인을 출력하겠다!
                                break;
                            default:                                //예외값은 패스
                                break;
                        }

                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\n총 10개를 먹으면 클리어~");

                Console.WriteLine("\n움직인 횟수 : {0}", moveCount);

                Console.WriteLine("\n먹은 코인 개수 : {0}", coinCount);

                Console.Write("\n움직일 방향을 입력해주세요 : ");    //캐릭터를 움직일 키값 받기

                if (maxCoin < 5) { Task.Delay(600).Wait(); } //0.3초 기다리는 딜레이
                //코인 생성기
                //if (direction == "w" || direction == "a" || direction == "s" || direction == "d")
                for (int i = 0; i < 5; ++i)
                {
                    if (maxCoin < 5)
                    {
                        int yRand = randCoin.Next(1, BOARD_SIZE_Y - 1);
                        int xRand = randCoin.Next(1, BOARD_SIZE_X - 1);
                        if (gameBoard[yRand, xRand] == 1 || gameBoard[yRand, xRand] == 3) { continue; }
                        //Task.Delay(1000).Wait(); //0.3초 기다리는 딜레이
                        gameBoard[yRand, xRand] = 3;
                        ++coinNumber;
                        ++maxCoin;
                        break;
                    }
                }

                direction = " ";                                     //입력키는 항상 받고나선 초기화 해주어야함 ( 그렇지 않으면 이동한 흔적이 생김

                Console.Clear();                                    //화면을 비워주는 함수



                for (int y = 0; y < BOARD_SIZE_Y; y++)              //맵을 화면에 출력해주는 구문
                {
                    for (int x = 0; x < BOARD_SIZE_X; x++)
                    {
                        switch (gameBoard[y, x])
                        {
                            case 0:
                                Console.Write(". ");               //배열의 값이 0이면 공백 .을 출력
                                break;
                            case 1:
                                Console.Write("옷");                //배열의 값이 1이면 플레이어를 출력
                                break;
                            case 2:
                                Console.Write("■");                //배열의 값이 2이면 벽을 출력
                                break;
                            case 3:
                                //Task.Delay(10).Wait(); //0.3초 기다리는 딜레이
                                Console.Write("$ ");                //코인을 만들어서 코인을 출력하겠다!
                                break;
                            default:                                //예외값은 패스
                                break;
                        }

                    }
                    Console.WriteLine();
                }       //맵을 화면에 출력해주는 루프



                Console.WriteLine("\n총 10개를 먹으면 클리어~");

                Console.WriteLine("\n움직인 횟수 : {0}", moveCount);

                Console.WriteLine("\n먹은 코인 개수 : {0}", coinCount);

                Console.Write("\n움직일 방향을 입력해주세요 : ");    //캐릭터를 움직일 키값 받기


                //Task.Delay(300).Wait(); //0.3초 기다리는 딜레이
                direction = Console.ReadLine();

                if (coinCount == 10) { break; }
            }       //게임오버가 될 때 까지 계속되는 루프

            Console.WriteLine("축하합니다! 코인을 다 먹어서 게임을 클리어 했어요!");


        }       //Main()
    }       //Class
}       //namespace