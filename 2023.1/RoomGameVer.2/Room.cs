using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RoomGameVer2
{
    internal class Room
    {
        static private int _coinCount = 0;

        public int RightRoomMap(int[,,] gameBoard, int BOARD_SIZE_Y, int BOARD_SIZE_X, int presentNum, out int thisRoom)
        {
            thisRoom = presentNum;
            gameBoard[presentNum, BOARD_SIZE_Y / 2, 1] = 1;  //맵의 맨 왼쪽에 스폰
            //bool clearRoom = true;
            //int[,,] tempMap = (int[,,])gameBoard.Clone();

            //배열B = (자료형[])배열A.Clone(); //
            //여기에 벽으로 다 감싸는 함수
            //tempMap = WallRoom(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
            //PrintMap(tempMap, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
            //PlayerMove(tempMap, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);


            //맵에서 코인, 적을 모두 초기화 하는 함수

            //gameBoard = AllClearRoom(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
            PrintMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
            return PlayerMove(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);

        }       //RightRoomMap();

        public int LeftRoomMap(int[,,] gameBoard, int BOARD_SIZE_Y, int BOARD_SIZE_X, int presentNum, out int thisRoom)
        {
            thisRoom = presentNum;
            gameBoard[presentNum, BOARD_SIZE_Y / 2, BOARD_SIZE_X - 2] = 1;  //맵의 맨 오른쪽에 플레이어 초기화

            PrintMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
            return PlayerMove(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
        }       //LeftRoomMap0

        public int UPRoomMap(int[,,] gameBoard, int BOARD_SIZE_Y, int BOARD_SIZE_X, int presentNum, out int thisRoom)
        {
            thisRoom = presentNum;
            gameBoard[presentNum, BOARD_SIZE_Y - 2, BOARD_SIZE_X / 2] = 1;  //맵의 맨 아래쪽에 플레이어 스폰

            PrintMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
            return PlayerMove(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
        }       //UPRoomMap();

        public int DownRoomMap(int[,,] gameBoard, int BOARD_SIZE_Y, int BOARD_SIZE_X, int presentNum, out int thisRoom)
        {
            thisRoom = presentNum;
            gameBoard[presentNum, 1, BOARD_SIZE_X / 2] = 1;  //맵의 맨 위쪽에 플레이어 초기화

            PrintMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
            return PlayerMove(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
        }       //UPRoomMap();

        public int MainRoomMap(int[,,] gameBoard, int BOARD_SIZE_Y, int BOARD_SIZE_X, int presentNum, out int thisRoom)
        {
            thisRoom = presentNum;
            gameBoard[presentNum, BOARD_SIZE_Y / 2, BOARD_SIZE_X / 2] = 1;  //맵의 맨 위쪽에 플레이어 초기화

            PrintMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
            return PlayerMove(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
        }       //UPRoomMap();

        private void PrintMap(int[,,] map, int mapY, int mapX, int presentNum)
        {
            //맵을 출력
            Console.Clear();
            for (int y = 0; y < mapY; y++)              //맵을 화면에 출력해주는 구문
            {
                for (int x = 0; x < mapX; x++)
                {
                    switch (map[presentNum, y, x])
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
                            Console.Write("$  ");           //코인
                            break;
                        case 6:
                            Console.Write("★ ");            //파이어볼
                            break;
                        case 10:
                            Console.Write("♬ ");            //적
                            break;
                        default:                                //예외값은 패스
                            break;
                    }
                }
                Console.WriteLine();
            }       //맵을 화면에 출력해주는 루프

        }

        private int[,,] CoinRandomCreate(int[,,] map, int mapY, int mapX, int presentNum)
        {
            Random randCoin = new Random();
            int num1, num2, randCount;

            randCount = randCoin.Next(1, 6 + 2);
            for (int i = 1; i < randCount; ++i)     //랜덤한 수에 맞게 코인 생성
            {
                num1 = randCoin.Next(1, mapY - 1);
                num2 = randCoin.Next(1, mapX - 1);
                if (map[presentNum, num1, num2] == 0)
                {
                    map[presentNum, num1, num2] = 5;
                    //Task.Delay(150).Wait(); //0.3초 기다리는 딜레이
                    //PrintMap(map, mapY, mapX, presentNum);
                }
                else { --i; }
            }
            num1 = randCoin.Next(1, mapY - 1);
            num2 = randCoin.Next(1, mapX - 1);
            if (map[presentNum, num1, num2] == 0)
            {
                map[presentNum, num1, num2] = 10;
            }
            return map;
        }

        //움직이는 함수
        private int PlayerMove(int[,,] gameBoard, int BOARD_SIZE_Y, int BOARD_SIZE_X, int presentNum)
        {
            bool life = true;
            while (life)
            {
                bool jumpToFor = false;
                Console.Write("먹은 코인 개수 : {0}\n", _coinCount);
                Console.Write("c, v키는 파이어볼!\n");
                Console.Write("w, a, s, d 중 하나를 입력해주세요 : ");    //캐릭터를 움직일 키값 받기

                ConsoleKeyInfo cki;

                cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.A:                                //"a"키를 받을 경우 난 왼쪽으로 플레이어를 옮기겠다.
                        for (int y = 0; y < BOARD_SIZE_Y; y++)
                        {
                            for (int x = 0; x < BOARD_SIZE_X; x++)
                            {
                                if (gameBoard[presentNum, y, x] == 1)               //플레이어가 식별된 경우 실행
                                {
                                    if (gameBoard[presentNum, y, x - 1] == 2)       //플레이어의 왼쪽에 벽이 있으면 어떤 행동도 못함
                                    {
                                        break;
                                    }
                                    else if (gameBoard[presentNum, y, x - 1] == 3)
                                    {   //왼쪽 방으로
                                        gameBoard[presentNum, y, x] = 0;
                                        return 4;
                                    }
                                    else if (gameBoard[presentNum, y, x - 1] == 5) { ++_coinCount; }
                                    else if (gameBoard[presentNum, y, x - 1] == 10) { return 0; }
                                    gameBoard[presentNum, y, x] = 0;                //식별되 곳은 0(공백)으로 처리
                                    gameBoard[presentNum, y, x - 1] = 1;            //식별된 곳의 왼쪽에 1(플레이어)을 대입
                                    break;                              //조건을 달성했으니 탈출
                                }
                            }
                        }
                        break;
                    case ConsoleKey.S:                             //"s"키를 받을 경우 난 아래쪽으로 플레이어를 옮기겠다.
                        for (int y = 0; y < BOARD_SIZE_Y; y++)
                        {
                            for (int x = 0; x < BOARD_SIZE_X; x++)
                            {
                                if (gameBoard[presentNum, y, x] == 1)               //플레이어가 식별된 경우 실행
                                {
                                    if (gameBoard[presentNum, y + 1, x] == 2)       //플레이어의 아래에 벽이 있으면 어떤 행동도 못함
                                    {
                                        jumpToFor = true;
                                        break;
                                    }
                                    else if (gameBoard[presentNum, y + 1, x] == 4)
                                    {   //아래쪽 방으로
                                        gameBoard[presentNum, y, x] = 0;
                                        return 3;
                                    }
                                    else if (gameBoard[presentNum, y + 1, x] == 5) { ++_coinCount; }
                                    else if (gameBoard[presentNum, y + 1, x] == 10) { return 0; }
                                    gameBoard[presentNum, y, x] = 0;                //식별되 곳은 0(공백)으로 처리
                                    gameBoard[presentNum, y + 1, x] = 1;            //식별된 곳의 아래쪽에 1(플레이어)을 대입
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
                        break;

                    case ConsoleKey.D:
                        for (int y = 0; y < BOARD_SIZE_Y; y++)
                        {
                            for (int x = 0; x < BOARD_SIZE_X; x++)
                            {
                                if (gameBoard[presentNum, y, x] == 1)               //플레이어가 식별된 경우 실행
                                {
                                    if (gameBoard[presentNum, y, x + 1] == 2)       //플레이어의 오른쪽에 벽이 있으면 어떤 행동도 못함
                                    {
                                        break;
                                    }
                                    else if (gameBoard[presentNum, y, x + 1] == 3)
                                    {   //오른쪽 방으로
                                        gameBoard[presentNum, y, x] = 0;
                                        return 2;
                                    }
                                    else if (gameBoard[presentNum, y, x + 1] == 5) { ++_coinCount; }
                                    else if (gameBoard[presentNum, y, x + 1] == 10) { return 0; }
                                    gameBoard[presentNum, y, x] = 0;                //식별되 곳은 0(공백)으로 처리
                                    gameBoard[presentNum, y, x + 1] = 1;            //식별된 곳의 오른쪽에 1(플레이어)을 대입
                                    break;                              //조건을 달성했으니 탈출
                                }
                            }
                        }
                        break;

                    case ConsoleKey.W:
                        for (int y = 0; y < BOARD_SIZE_Y; y++)
                        {
                            for (int x = 0; x < BOARD_SIZE_X; x++)
                            {
                                if (gameBoard[presentNum, y, x] == 1)               //플레이어가 식별된 경우 실행
                                {
                                    if (gameBoard[presentNum, y - 1, x] == 2)       //플레이어의 위쪽에 벽이 있으면 어떤 행동도 못함
                                    {
                                        break;
                                    }
                                    else if (gameBoard[presentNum, y - 1, x] == 4)
                                    {   //위쪽 방으로
                                        gameBoard[presentNum, y, x] = 0;
                                        return 1;
                                    }
                                    else if (gameBoard[presentNum, y - 1, x] == 5) { ++_coinCount; }
                                    else if (gameBoard[presentNum, y - 1, x] == 10) { return 0; }
                                    gameBoard[presentNum, y, x] = 0;                //식별되 곳은 0(공백)으로 처리
                                    gameBoard[presentNum, y - 1, x] = 1;            //식별된 곳의 위쪽에 1(플레이어)을 대입
                                    break;                              //조건을 달성했으니 탈출
                                }
                            }
                        }
                        break;

                    case ConsoleKey.V:
                        for (int y = 0; y < BOARD_SIZE_Y; y++)
                        {
                            for (int x = 0; x < BOARD_SIZE_X; x++)
                            {
                                if (gameBoard[presentNum, y, x] == 1)               //플레이어가 식별된 경우 실행
                                {
                                    for (int index = 0; index < 5; ++index)
                                    {
                                        if (gameBoard[presentNum, y, x + index + 1] == 0)
                                        {
                                            gameBoard[presentNum, y, x + index + 1] = 6;
                                            PrintMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
                                            Task.Delay(50).Wait();
                                            gameBoard[presentNum, y, x + index + 1] = 0;
                                            PrintMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
                                        }
                                        else if (gameBoard[presentNum, y, x + index + 1] == 10)
                                        {
                                            gameBoard[presentNum, y, x + index + 1] = 5;
                                        }
                                        else { break; }
                                    }
                                }
                            }
                        }
                        break;

                    case ConsoleKey.C:
                        for (int y = 0; y < BOARD_SIZE_Y; y++)
                        {
                            for (int x = 0; x < BOARD_SIZE_X; x++)
                            {
                                if (gameBoard[presentNum, y, x] == 1)               //플레이어가 식별된 경우 실행
                                {
                                    for (int index = 0; index < 5; ++index)
                                    {
                                        if (gameBoard[presentNum, y, x - index - 1] == 0)
                                        {
                                            gameBoard[presentNum, y, x - index - 1] = 6;
                                            PrintMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
                                            Task.Delay(50).Wait(); //0.2초 기다리는 딜레이
                                            gameBoard[presentNum, y, x - index - 1] = 0;
                                            PrintMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
                                        }
                                        else if (gameBoard[presentNum, y, x - index - 1] == 10)
                                        {
                                            gameBoard[presentNum, y, x - index - 1] = 5;
                                        }
                                        else { break; }
                                    }
                                }
                            }
                        }
                        break;

                }

                PrintMap(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum);
                //if (CheckRoom(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, presentNum) == false) { break; }
            }
            return -1;

        }

        public int[,,] MakeMap(int[,,] gameBoard, int BOARD_SIZE_Y, int BOARD_SIZE_X, int maxRoomNum)
        {
            //맵을 초기화 하고 플레이어를 추가해주는 구문
            for (int num = 0; num < maxRoomNum; ++num)
            {
                for (int y = 0; y < BOARD_SIZE_Y; y++)
                {
                    for (int x = 0; x < BOARD_SIZE_X; x++)
                    {
                        gameBoard[num, y, x] = 0;                        //맵 전체를 빈 공간으로 초기화함
                    }
                }       //loop: 맵을 초기화하는 루프
            }

            for (int z = 0; z < maxRoomNum; ++z)
            {
                for (int y = 0; y < BOARD_SIZE_Y; y++)
                {
                    for (int x = 0; x < BOARD_SIZE_X; x++)
                    {
                        if (y == 0)                                  //맵 맨 첫줄에 벽 생성
                        {
                            gameBoard[z, y, x] = 2;
                        }
                        if (y == BOARD_SIZE_Y - 1)                    //맵 맨 아랫줄에 벽 생성
                        {
                            gameBoard[z, y, x] = 2;
                        }
                        if (x == 0)                                  //맵 맨 왼쪽에 벽 생성
                        {
                            gameBoard[z, y, x] = 2;
                        }
                        if (x == BOARD_SIZE_X - 1)                    //맵 맨 오른쪽에 벽 생성
                        {
                            gameBoard[z, y, x] = 2;
                        }
                    }
                }       //loop: 맵에 벽을 만드는 루프
            }

            int wallNum;
            wallNum = Convert.ToInt32(Math.Sqrt(maxRoomNum));
            //문을 만드는 문장
            for (int z = 0; z < maxRoomNum; ++z)
            {
                for (int i = -1; i < 2; ++i)
                {
                    if ((z + 1) % wallNum != 0)
                    {
                        gameBoard[z, BOARD_SIZE_Y / 2 + i, BOARD_SIZE_X - 1] = 3;      //오른쪽 문
                    }
                    else { /**/}
                    if ((z < wallNum) == false)
                    {
                        gameBoard[z, 0, BOARD_SIZE_X / 2 + i] = 4;                     //위쪽 문
                    }
                    else { /**/}
                    if (((maxRoomNum - wallNum) <= z && z < maxRoomNum) == false)
                    {
                        gameBoard[z, BOARD_SIZE_Y - 1, BOARD_SIZE_X / 2 + i] = 4;      //아래 문
                    }
                    else { /**/}
                    if (z % wallNum != 0)
                    {
                        gameBoard[z, BOARD_SIZE_Y / 2 + i, 0] = 3;                     //왼쪽 문
                    }
                    else { /**/}
                }
            }

            for (int num = 0; num < maxRoomNum; ++num)
            {

                CoinRandomCreate(gameBoard, BOARD_SIZE_Y, BOARD_SIZE_X, num);
                //loop: 맵에 코인 생성
            }






            //여기까지가 맵 초기화(만드는 곳)
            return gameBoard;
        }

        //벽으로 다 감싸는 함수
        private int[,,] WallRoom(int[,,] map, int BOARD_SIZE_Y, int BOARD_SIZE_X, int presentNum)
        {
            for (int y = 0; y < BOARD_SIZE_Y; y++)
            {
                for (int x = 0; x < BOARD_SIZE_X; x++)
                {
                    if (y == 0)                                  //맵 맨 첫줄에 벽 생성
                    {
                        map[presentNum, y, x] = 2;
                    }
                    if (y == BOARD_SIZE_Y - 1)                    //맵 맨 아랫줄에 벽 생성
                    {
                        map[presentNum, y, x] = 2;
                    }
                    if (x == 0)                                  //맵 맨 왼쪽에 벽 생성
                    {
                        map[presentNum, y, x] = 2;
                    }
                    if (x == BOARD_SIZE_X - 1)                    //맵 맨 오른쪽에 벽 생성
                    {
                        map[presentNum, y, x] = 2;
                    }
                }
            }       //loop: 맵에 벽을 만드는 루프

            return map;
        }

        //몬스터, 코인을 체크하는 함수
        private bool CheckRoom(int[,,] map, int BOARD_SIZE_Y, int BOARD_SIZE_X, int presentNum)
        {
            bool result = true;
            int coinCount = 0;
            int monsterCount = 0;

            for (int y = 0; y < BOARD_SIZE_Y; y++)
            {
                for (int x = 0; x < BOARD_SIZE_X; x++)
                {
                    if (map[presentNum, y, x] == 5)  //코인이 있다면
                    {
                        ++coinCount;
                    }
                    if (map[presentNum, y, x] == 10)    //몬스터가 있다면
                    {
                        ++monsterCount;
                    }
                }
            }
            if (coinCount == 0 && monsterCount == 0)
            {
                result = false;
            }

            return result;
        }

        //코인, 몬스터를 전부 지워주는 함수
        private int[,,] AllClearRoom(int[,,] map, int BOARD_SIZE_Y, int BOARD_SIZE_X, int presentNum)
        {
            for (int y = 0; y < BOARD_SIZE_Y; y++)
            {
                for (int x = 0; x < BOARD_SIZE_X; x++)
                {
                    if (map[presentNum, y, x] == 5)
                    {
                        map[presentNum, y, x] = 0;
                    }
                    if (map[presentNum, y, x] == 10)
                    {
                        map[presentNum, y, x] = 0;
                    }
                }
            }
            return map;
        }

    }
}
