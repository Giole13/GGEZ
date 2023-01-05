using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RoomGame
{
    internal class Room
    {
        static private int _coinCount = 0;

        public int RightRoomMap(int BOARD_SIZE_Y, int BOARD_SIZE_X)
        {
            //const int BOARD_SIZE_X = 10;                         //맵 x (세로축 개수)
            //const int BOARD_SIZE_Y = 10;                         //맵 y (가로축 개수)
            int[,] gameBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];    //맵의 크기를 배열로 정의
            bool playerLife = true;                             //플레이어의 목숨 (false가 되면 게임오버)
            bool jumpToFor = false;                             //s키를 입력시 y + 1의 이슈 해결방안

            MakeMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);

            gameBoard[BOARD_SIZE_Y / 2, 1] = 1;  //맵의 맨 왼쪽에

            CoinRandomCreate(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);

            //여기까지가 맵 초기화(만드는 곳)

            //4는 왼쪽방
            //3은 아래쪽 방
            //2는 오른쪽 방
            //1은 위쪽방
            while (playerLife)                                          //플레이어의 목숨이 true인 경우 반복
            {
                PrintMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);
                return PlayerMove(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);
            }       //게임오버가 될 때 까지 계속되는 루프

            return 0;   //0이 된다면 게임오버
        }       //RightRoomMap();

        public int LeftRoomMap(int BOARD_SIZE_Y, int BOARD_SIZE_X)
        {
            //const int BOARD_SIZE_X = 10;                         //맵 x (세로축 개수)
            //const int BOARD_SIZE_Y = 10;                         //맵 y (가로축 개수)
            int[,] gameBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];    //맵의 크기를 배열로 정의
            bool playerLife = true;                             //플레이어의 목숨 (false가 되면 게임오버)
            bool jumpToFor = false;                             //s키를 입력시 y + 1의 이슈 해결방안


            MakeMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);

            gameBoard[BOARD_SIZE_Y / 2, BOARD_SIZE_X - 2] = 1;  //맵의 맨 오른쪽에 플레이어 초기화

            CoinRandomCreate(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);

            //여기까지가 맵 초기화(만드는 곳)


            //4는 왼쪽방
            //3은 아래쪽 방
            //2는 오른쪽 방
            //1은 위쪽방
            while (playerLife)                                          //플레이어의 목숨이 true인 경우 반복
            {
                PrintMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);
                return PlayerMove(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);
            }       //게임오버가 될 때 까지 계속되는 루프

            return 0;   //0이 된다면 게임오버

        }       //LeftRoomMap0

        public int UPRoomMap(int BOARD_SIZE_Y, int BOARD_SIZE_X)
        {
            //const int BOARD_SIZE_X = 10;                         //맵 x (세로축 개수)
            //const int BOARD_SIZE_Y = 10;                         //맵 y (가로축 개수)
            int[,] gameBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];    //맵의 크기를 배열로 정의
            bool playerLife = true;                             //플레이어의 목숨 (false가 되면 게임오버)
            bool jumpToFor = false;                             //s키를 입력시 y + 1의 이슈 해결방안


            MakeMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);

            gameBoard[BOARD_SIZE_Y - 2, BOARD_SIZE_X / 2] = 1;  //맵의 맨 아래쪽에 플레이어 스폰


            CoinRandomCreate(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);
            //여기까지가 맵 초기화(만드는 곳)


            //4는 왼쪽방
            //3은 아래쪽 방
            //2는 오른쪽 방
            //1은 위쪽방
            while (playerLife)                                          //플레이어의 목숨이 true인 경우 반복
            {
                PrintMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);
                return PlayerMove(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);
            }       //게임오버가 될 때 까지 계속되는 루프

            return 0;   //0이 된다면 게임오버
        }       //UPRoomMap();

        public int DownRoomMap(int BOARD_SIZE_Y, int BOARD_SIZE_X)
        {
            //const int BOARD_SIZE_X = 10;                         //맵 x (세로축 개수)
            //const int BOARD_SIZE_Y = 10;                         //맵 y (가로축 개수)
            int[,] gameBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];    //맵의 크기를 배열로 정의
            bool playerLife = true;                             //플레이어의 목숨 (false가 되면 게임오버)
            bool jumpToFor = false;                             //s키를 입력시 y + 1의 이슈 해결방안


            MakeMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);

            gameBoard[1, BOARD_SIZE_X / 2] = 1;  //맵의 맨 위쪽에 플레이어 초기화

            CoinRandomCreate(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);

            //여기까지가 맵 초기화(만드는 곳)


            //4는 왼쪽방
            //3은 아래쪽 방
            //2는 오른쪽 방
            //1은 위쪽방
            while (playerLife)                                          //플레이어의 목숨이 true인 경우 반복
            {
                PrintMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);
                return PlayerMove(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);
            }       //게임오버가 될 때 까지 계속되는 루프

            return 0;   //0이 된다면 게임오버
        }       //UPRoomMap();

        public int MainRoomMap(int BOARD_SIZE_Y, int BOARD_SIZE_X)
        {
            //const int BOARD_SIZE_X = 10;                         //맵 x (세로축 개수)
            //const int BOARD_SIZE_Y = 10;                         //맵 y (가로축 개수)
            int[,] gameBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];    //맵의 크기를 배열로 정의
            bool playerLife = true;                             //플레이어의 목숨 (false가 되면 게임오버)
            bool jumpToFor = false;                             //s키를 입력시 y + 1의 이슈 해결방안

            MakeMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);     //맵 생성함수

            gameBoard[BOARD_SIZE_Y / 2, BOARD_SIZE_X / 2] = 1;  //맵의 맨 위쪽에 플레이어 초기화

            CoinRandomCreate(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);

            //여기까지가 맵 초기화(만드는 곳)


            //4는 왼쪽방
            //3은 아래쪽 방
            //2는 오른쪽 방
            //1은 위쪽방
            while (playerLife)                                          //플레이어의 목숨이 true인 경우 반복
            {
                PrintMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);
                return PlayerMove(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);
            }       //게임오버가 될 때 까지 계속되는 루프

            return 0;   //0이 된다면 게임오버
        }       //UPRoomMap();

        private void PrintMap(int[,] map, int mapY, int mapX)
        {
            //맵을 출력
            Console.Clear();
            for (int y = 0; y < mapY; y++)              //맵을 화면에 출력해주는 구문
            {
                for (int x = 0; x < mapX; x++)
                {
                    switch (map[y, x])
                    {
                        case -1:
                            Console.Write("   ");
                            break;
                        case 0:
                            Console.Write(".  ");               //배열의 값이 0이면 공백 .을 출력
                            break;
                        case 1:
                            Console.Write("옷 ");                //배열의 값이 1이면 플레이어를 출력
                            break;
                        case 2:
                            Console.Write("■ ");                //배열의 값이 2이면 벽을 출력
                            break;
                        case 3:
                            Console.Write("□ ");                //배열의 값이 3이면 문을 출력
                            break;
                        case 4:
                            Console.Write("□ ");
                            break;
                        case 5:
                            Console.Write("$  ");
                            break;
                        default:                                //예외값은 패스
                            break;
                    }
                }
                Console.WriteLine();
            }       //맵을 화면에 출력해주는 루프

        }

        private int[,] CoinRandomCreate(int[,] map, int mapY, int mapX)
        {
            Random randCoin = new Random();
            int num1, num2, randCount;

            randCount = randCoin.Next(1, 6 + 2);
            for (int i = 1; i < randCount; ++i)     //랜덤한 수에 맞게 코인 생성
            {
                num1 = randCoin.Next(1, mapY - 1);
                num2 = randCoin.Next(1, mapX - 1);
                if (map[num1, num2] == 0)
                {
                    map[num1, num2] = 5;
                    Task.Delay(150).Wait(); //0.3초 기다리는 딜레이
                    PrintMap(map, mapY, mapX);
                }
                else { --i; }
            }
            return map;
        }

        private int PlayerMove(int[,] gameBoard, int BOARD_SIZE_Y, int BOARD_SIZE_X)
        {
            bool life = true;
            while (life)
            {
                bool jumpToFor = false;
                Console.Write("먹은 코인 개수 : {0}\n", _coinCount);
                Console.Write("w, a, s, d 중 하나를 입력해주세요 : ");    //캐릭터를 움직일 키값 받기
                string direction = Console.ReadLine();

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
                                else if (gameBoard[y, x - 1] == 3)
                                {   //왼쪽 방으로
                                    return 4;
                                }
                                else if (gameBoard[y, x - 1] == 5) { ++_coinCount; }
                                gameBoard[y, x] = 0;                //식별되 곳은 0(공백)으로 처리
                                gameBoard[y, x - 1] = 1;            //식별된 곳의 왼쪽에 1(플레이어)을 대입
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
                                else if (gameBoard[y + 1, x] == 4)
                                {   //아래쪽 방으로
                                    return 3;
                                }
                                else if (gameBoard[y + 1, x] == 5) { ++_coinCount; }
                                gameBoard[y, x] = 0;                //식별되 곳은 0(공백)으로 처리
                                gameBoard[y + 1, x] = 1;            //식별된 곳의 아래쪽에 1(플레이어)을 대입
                                jumpToFor = true;                   //y를 한번 더 식별하지 않기 위해서 탈출 조건을 추가
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
                                else if (gameBoard[y, x + 1] == 3)
                                {   //오른쪽 방으로
                                    return 2;
                                }
                                else if (gameBoard[y, x + 1] == 5) { ++_coinCount; }
                                gameBoard[y, x] = 0;                //식별되 곳은 0(공백)으로 처리
                                gameBoard[y, x + 1] = 1;            //식별된 곳의 오른쪽에 1(플레이어)을 대입
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
                                else if (gameBoard[y - 1, x] == 4)
                                {   //위쪽 방으로
                                    return 1;
                                }
                                else if (gameBoard[y - 1, x] == 5) { ++_coinCount; }
                                gameBoard[y, x] = 0;                //식별되 곳은 0(공백)으로 처리
                                gameBoard[y - 1, x] = 1;            //식별된 곳의 위쪽에 1(플레이어)을 대입
                                break;                              //조건을 달성했으니 탈출
                            }
                        }
                    }
                }       //플레이어를 옮기는 루프

                direction = " ";                                     //입력키는 항상 받고나선 초기화 해주어야함 ( 그렇지 않으면 이동한 흔적이 생김

                PrintMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X);
            }
            return -1;

        }

        private int[,] MakeMap(int[,] gameBoard, int BOARD_SIZE_Y, int BOARD_SIZE_X)
        {
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


            Math.Sqrt(9);
            //문을 만드는 문장
            for (int i = -1; i < 2; ++i)
            {
                gameBoard[BOARD_SIZE_Y / 2 + i, BOARD_SIZE_X - 1] = 3;      //오른쪽 문
                gameBoard[BOARD_SIZE_Y / 2 + i, 0] = 3;                     //왼쪽 문
                gameBoard[BOARD_SIZE_Y - 1, BOARD_SIZE_X / 2 + i] = 4;      //아래 문
                gameBoard[0, BOARD_SIZE_X / 2 + i] = 4;                     //위쪽 문

            }

            //여기까지가 맵 초기화(만드는 곳)
            return gameBoard;
        }



    }
}
