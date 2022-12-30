using System;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //슬라이딩 퍼즐 만들기
            //1, 2, 3, 4, 5, 6, 7, 8 순으로 퍼즐이 정렬이 된다면 클리어!
            //각각 2차원 int 배열에 할당을 할 것이고 맵은 3x3으로 하겠음!
            //순서는 맵을 먼저 출력을 해주고
            //방향키를 받고
            //그 결과를 출력할것이다.
            //플레이어를 8값으로 정할것이고 나머지 맵은 숫자로 하겠음
            //랜덤으로 넣는것은 중복이슈문제로 아직 불가능..

            string way;
            Random mapTileRand = new Random();


            bool gameLife = true;                   //게임의 루프를 위한 변수
            const int GAME_MAP_Y = 3;               //맵 y축
            const int GAME_MAP_X = 3;               //맵 x축 크기
            bool sKeyIssue = false, gameClear = false; //s키 이슈 및 게임클리어 조건 bool
            int gameMoveCount = 0;                      //몇번 움직였는지 카운트하는 변수


            //게임 현재 맵 배열
            int[,] gameMap = new int[GAME_MAP_Y, GAME_MAP_Y] { { 3, 5, 2 }, { 9, 1, 4 }, { 8, 6, 7 } };
            //정답 배열
            int[,] gameClearMap = new int[GAME_MAP_Y, GAME_MAP_Y] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };




            Console.WriteLine("Press Any Key !!");
            Console.ReadLine();
            Console.Clear();

            while (gameLife)
            {
                Console.WriteLine("=========================");
                for (int y = 0; y < GAME_MAP_Y; y++)
                {
                    for (int x = 0; x < GAME_MAP_X; x++)
                    {
                        if (gameMap[y, x] == 9)
                        {
                            if (x == 0) { Console.Write("=\t"); }
                            Console.Write("X ");
                            if (x == GAME_MAP_X - 1) { Console.Write("\t\t="); }
                        }        //플레이어 표시
                        else
                        {
                            if (x == 0) { Console.Write("=\t"); }
                            Console.Write("{0} ", gameMap[y, x]);               //맵 표시
                            if (x == GAME_MAP_X - 1) { Console.Write("\t\t="); }

                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("=========================");
                Console.WriteLine("총 움직인 횟수 : {0}", gameMoveCount);
                Console.Write("방향키를 입력해주세요 : ");
                way = Console.ReadLine();                       //키값 받기
                Console.WriteLine("=========================");
                switch (way)                                    //캐릭터를 움직이는 switch문
                {
                    case "w":
                        for (int y = 0; y < GAME_MAP_Y; y++)
                        {
                            for (int x = 0; x < GAME_MAP_X; x++)
                            {

                                if (gameMap[y, x] == 9)
                                {
                                    if (0 < y)                  //w는 1이상 에서만 움직임
                                    {
                                        gameMap[y, x] = gameMap[y - 1, x];
                                        gameMap[y - 1, x] = 9;
                                        ++gameMoveCount;        //무브 카운터는 w문이 실행했을때만 카운트 됨
                                        break;
                                    }
                                    else { break; }
                                }


                            }
                        }
                        break;

                    case "a":
                        for (int y = 0; y < GAME_MAP_Y; y++)
                        {
                            for (int x = 0; x < GAME_MAP_X; x++)
                            {
                                if (gameMap[y, x] == 9)             
                                {
                                    if (0 < x)                  //a는 1이상 에서만 움직임
                                    {
                                        gameMap[y, x] = gameMap[y, x - 1];
                                        gameMap[y, x - 1] = 9;
                                        ++gameMoveCount;        //무브 카운터는 a키가 실행했을때만 카운트 됨
                                        break;
                                    }
                                    else { break; }
                                }
                            }
                        }
                        break;

                    case "s":
                        for (int y = 0; y < GAME_MAP_Y; y++)        //벽 이슈 아직 해결 안됨
                        {
                            for (int x = 0; x < GAME_MAP_X; x++)
                            {
                                if (gameMap[y, x] == 9)
                                {
                                    if (y < GAME_MAP_X - 1)         //s키는 게임맵x -1 이하에서만 움직임
                                    {
                                        if (sKeyIssue == false)
                                        {

                                            sKeyIssue = true;
                                            gameMap[y, x] = gameMap[y + 1, x];
                                            gameMap[y + 1, x] = 9;
                                            ++gameMoveCount;        //무브 카운터는 s키가 실행했을때만 카운트 됨
                                            break;

                                        }
                                    }
                                    else { break; }
                                }
                            }
                        }
                        sKeyIssue = false;
                        break;

                    case "d":
                        for (int y = 0; y < GAME_MAP_Y; y++)
                        {
                            for (int x = 0; x < GAME_MAP_X; x++)
                            {
                                if (gameMap[y, x] == 9)
                                {
                                    if (x < GAME_MAP_X - 1)             //d키는 GAME_MAP_X - 1 의 값 이하에서만 작동함
                                    {
                                        gameMap[y, x] = gameMap[y, x + 1];
                                        gameMap[y, x + 1] = 9;
                                        ++gameMoveCount;            //무브 카운터는 d키가 실행했을때만 카운트 됨
                                        break;
                                    }
                                    else { break; }
                                }
                            }
                        }
                        break;
                }       //switch문

                Console.Clear();        //콘솔을 비워주는 함수

                //게임 클리어를 검사하는 반복문
                int gameClearCount = 0;
                for (int y = 0; y < GAME_MAP_Y; y++)
                {
                    for (int x = 0; x < GAME_MAP_X; x++)
                    {
                        if (gameMap[y, x] == gameClearMap[y, x])
                        {
                            gameClearCount++;
                            if (gameClearCount == 9)
                            {
                                gameClear = true;
                            }
                        }
                    }
                }

                if (gameClear) { Console.WriteLine("게임을 클리어 하셨습니다!"); break; }
            }       //loop: gameLife문
        }       //Main()
    }       //Class
}