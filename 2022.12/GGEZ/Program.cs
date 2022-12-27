using System;


namespace AdventureStory
{
    public class Enemy
    {

        public int fightScore;
        public void Believers()
        {

        }
    }
    internal class Program
    {
        static bool Playerfight(int player, int enemy)
        {
            float playerFightScore = (float)player;

            string select;
            Random fightrand = new Random();
            float outputFightScore = fightrand.Next(1, 201);

            Console.WriteLine("현재 나의 전투력 : {0}", playerFightScore);
            Console.WriteLine("현재 적의 전투력 : {0}", enemy);
            Console.WriteLine("1. 1~200까지의 전투력 변수를 고르겠다.");
            Console.WriteLine("2. 현재 전투력으로 싸우겠다.");
            Console.Write("선택 : ");
            select = Console.ReadLine();
            Console.WriteLine("");

            if (select == "1")
            {
                Console.WriteLine("현재 전투력 : {0}", outputFightScore / 100 * playerFightScore);
                Console.WriteLine("현재 적의 전투력 : {0}", enemy);
                playerFightScore = outputFightScore / 100 * playerFightScore;
            }
            else if (select == "2")
            {
                Console.WriteLine("현재 전투력 : {0}", playerFightScore);
                Console.WriteLine("현재 적의 전투력 : {0}", enemy);
                playerFightScore = playerFightScore;
            }

            Console.WriteLine("");
            bool outcome = playerFightScore > enemy;
            return outcome;
        }
        static void Main(string[] args)
        {
            //클래스 정의 모음
            Random statRand = new Random();         //스탯을 랜덤으로 추가하기 위한 클래스
            Random sceneRand = new Random();        //씬을 랜덤으로 호출하기 위한 클래스

            //플레이어 관련 변수
            int addgold;                            //골드를 추가할때 쓰는 변수
            int playerHealth = 4, playerMental = 5; // 플레이어 체력 멘탈
            int str = statRand.Next(5, 10); // 힘 스탯 1에서 6까지 랜덤분배
            int agil = statRand.Next(5, 10); // 민첩
            int intell = statRand.Next(5, 10); // 지능
            int charisma = statRand.Next(5, 10); // 카리스마
            int health = statRand.Next(5, 10); // 건강
            int wisdom = statRand.Next(5, 10); // 지혜
            int playerExp = 0, levelupExp = 10; // 현재레벨과 레벨업 시 필요한 량
            int gold = 0;                      // 플레이어의 골드
            int playerFightScore = 11;          // 플레이어의 전투력 설정

            //씬과 관련된 변수
            string select;                      // 선택문을 받는 변수
            bool fightResult;                   // 전투결과 bool타입
            int sceneRandom;                    // 씬을 랜덤으로 돌리기 위한 변수

            //아이템 관련 변수
            string[] weapon = new string[1] { "우드 스태프" };       //무기배열
            string[] armor = new string[1] { "패드 아머" };         //방어구배열
            string[] characteristics = new string[1] { "통뼈" };  //특성배열
            string[] inventory = new string[10] { "", "", "", "", "", "", "", "", "", "" };  //인벤토리 배열

            //적 관련 변수
            Enemy beliver = new Enemy();    //신자를 적 클래스로 정의
            beliver.fightScore = 10;        //신자의 전투력을 10으로 설정

            //플레이어의 스탯을 보여주는 함수
            void Stat()
            {
                Console.WriteLine($"현재 캐릭터의 체력 : {playerHealth}");
                Console.WriteLine($"현재 캐릭터의 정신력 : {playerMental}\n");

                Console.WriteLine($"현재 스탯\n힘 : {str} \t\t민첩 : {intell} \t지능 : {intell} " +
                    $"\n카리스마 : {charisma} \t건강 : {health} \t지혜 : {wisdom}\n");

                Console.WriteLine($"현재 골드 : {gold}");
                //string result = String.Join(separator, value); 

                Console.WriteLine($"현재 인벤토리 : " +
                    $"\n[{inventory[0]}] [{inventory[1]}] [{inventory[2]}] [{inventory[3]}] [{inventory[4]}]" +
                    $"\n[{inventory[5]}] [{inventory[6]}] [{inventory[7]}] [{inventory[8]}] [{inventory[9]}]");

                Console.WriteLine($"현재 경험치 : {playerExp} / {levelupExp}\n");
                Console.WriteLine("");
            }



            //모험가 이야기 타이틀 씬
            bool startSelect = false; //roop: 만약 시작화면에서 다른 선택지를 할경우 반복
            while (startSelect == false)
            {

                Console.WriteLine("#############################");
                Console.WriteLine("\t모험가 이야기");
                Console.WriteLine("#############################\n");

                Console.Write("TAP TO START\n");
                Console.ReadLine();
                Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");

                Console.WriteLine("1. 무작위 시작");
                Console.WriteLine("2. 모험가 커스텀\n");
                Console.Write("선택지를 골라주세요 : ");
                select = Console.ReadLine();
                Console.WriteLine("\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");

                //무작위 시작을 할 경우
                if (select == "1") //1. 무작위 시작 
                {
                    Stat();

                    addgold = statRand.Next(10, 21);
                    Console.WriteLine($"+ 골드 {addgold}");
                    gold += addgold;
                    Console.WriteLine($"+ {weapon[0]}");
                    inventory[0] = weapon[0];
                    Console.WriteLine($"+ {armor[0]}");
                    inventory[1] = armor[0];
                    Console.WriteLine($"+ {characteristics[0]}");
                    inventory[2] = characteristics[0];
                    Console.WriteLine("");
                    Console.Write($" - 모험 시작!");
                    Console.ReadLine();
                    startSelect = true;
                }
                else if (select == "2")
                {


                    startSelect = true;
                }
                else { startSelect = false; }
            }


            //스토리 진행 씬
            while (playerHealth != 0 && playerMental != 0)
            {
                sceneRandom = sceneRand.Next(1, 3);
                switch (sceneRandom)
                {
                    case 1: //모험가 이야기의 케이스 1번 스토리
                        {
                            Console.Clear();
                            Console.WriteLine("\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
                            Stat();

                            Console.WriteLine("\"당신이 섬기는 신의 이름을 말해보시오.. 내가 축복해드리오리다..\"\n"); //스토리문

                            Console.Write
                                ("1. 하..라드?\n2. 아무도 섬기지 않는다. \n3. 대충 아무 신을 댄다.\n선택 : "); //선택지
                            select = Console.ReadLine();


                            Console.WriteLine("\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");

                            if (select == "1")
                            {
                                Console.WriteLine("\"샬라 샬라 블라 블라\"\n"); //1번 선택시
                                Console.WriteLine
                                    ("1. 기도를 올린다.\n2. 기도하지 않는다.\n3. 세뇌마법을 푼다.\n"); //2번 선택지
                                select = Console.ReadLine();
                                Console.WriteLine("\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");

                                if (select == "1")
                                {
                                    Console.WriteLine("\"오...그대여 축복을 받으시오.. \"\n"); //1번 선택시
                                    Console.WriteLine($"지혜 +1 상승!");
                                    ++wisdom;
                                }
                                else if (select == "2")
                                {
                                    Console.WriteLine("신자는 아무말이 없다.\n 그냥 갈 길을 가기로 했다.");
                                }
                                else if (select == "3")
                                {
                                    Console.WriteLine("신자는 깜짝놀라며 도망갔다. \n그가 도망치면서 무언가를 흘렸다.");
                                    Console.WriteLine("+ 매직 로브");
                                }


                            }
                            else if (select == "2") //2번 선택시
                            {
                                Console.WriteLine("\"!@!@#$%\"");
                                Console.WriteLine("신자는 그렇게 말하며 화를 내며 떠나갔다.");
                                Console.WriteLine("정신력 -1");
                                --playerMental;
                            }
                            else if (select == "3")
                            {
                                Console.WriteLine("그런 신을 섬기다니! 용서할수 없소!!\n");

                                fightResult = Playerfight(playerFightScore, beliver.fightScore);

                                if (fightResult == true)
                                {
                                    Console.WriteLine($"전투 승리!\n신자는 쓰러졌다.\n경험치 +1\n골드 +10");
                                    ++playerExp;
                                    gold += 10;
                                }
                                else
                                {
                                    Console.WriteLine($"전투 패배!\n다신 나타나지 마시오!\n당신의 현재 체력이 1 줄었다!");
                                    --playerHealth;
                                }
                            }
                            else { /*Do nothing*/ }
                            break;
                        }

                    case 2: //모험가 이야기의 케이스 2번 스토리
                        
                        break;



                }       





            }   // loop: 플레이어 체력이나 멘탈이 0이 되면 끝나는 반복문

            Console.WriteLine("\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            Console.WriteLine("당신은 죽었습니다!"); //죽을경우 호출되는 문장
            Console.WriteLine("\n당신의 스탯\n");
            Stat();
        }   //Main() 함수
    }
}