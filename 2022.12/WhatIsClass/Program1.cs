using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsClass
{
    internal class Program1
    {
        public static void Main()
        {
            /**
             * C#의 모든 코드에 반드시 들어가는 클래스(Class) 알아보자.
             * 
             * 클래스 소개하기
             * 클래스는 지금까지 작성한 모든 예제에서 기본이 되는 C#의 핵심 코드이다.
             * public class [클래스 이름]
             * {
             *      - 무언가 내용
             * }
             * 같은 코드 블록을 사용하여 정의할 수 있다. 클래스를 정의하는 전반적인 내용과 클래스 내부 또는
             * 외부에 올 수 있는 구성 요소는 다음 장에서 살펴볼 것.
             * 
             * 클래스의 구성 요소는 많지만, 그중 속성과 메서드를 가장 많이 사용한다. 속성은 데이터를 다루고,
             * 메서드는 로직을 다룬다.
             * - 클래스
             *  - 속성: 데이터
             *  - 메서드: 로직
             * 
             * 클래스는 그 의미에 따라, 이미 닷넷 프레임워크에서 만들어 놓은 내장 형식(built-in type)과 사용자가
             * 직접 클래스 구조를 만드는 사용자 정의 형식(User defined type)으로 구분할 수 있다. 예를 들어
             * Console, String, Math 등 클래스는 내장 형식이다. 그리고 class 키워드로 Product, Note,
             * User, Group 처럼 새로운 형식(기존에 제공되지 않는)을 정의할 수 있는데, 이를 사용자 데이터 형식
             * 이라고 한다.
             * 
             * 클래스 만들기
             * 클래스를 정의하면 다음과 같다.
             *  - 클래스는 개체를 생성하는 틀(템플릿)이다.
             *  - 클래스는 무엇인가를 만들어 내는 설계도이다.
             *  
             * 클래스는 C# 프로그래밍의 기본 단위로 새로운 개체(실체)를 생성하는 설계도(청사진) 역할을 한다.
             * 예를 들어 자동차라는 개체(Object)를 만들려면 자동차 설계도가 필요하다. 이와 마찬가지로
             * 프로그래밍에서도 설계도가 필요한데, 이 역할을 하는 것이 클래스(class)이다. 즉, 클래스는
             * 개체를 생성하는 틀(템플릿)이며, 더 간단히 말하자면 "무엇인가를 만들어 내는 설계도"이다.
             * 
             * 클래스 선언하기
             *  - 클래스 이름은 반드시 대문자로 시작한다.
             *  
             *  public class [클래스 이름]
             *  {
             *      // 클래스 내용을 구현
             *      - 속성    -> 변수
             *      - 메서드   -> 함수
             *  }
             */


            /**
             * 클래스를 여러 개 사용할 때는 public 키워드를 써야 한다.  public 키워드가 붙은 클래스는
             * 클래스 외부에서 해당 클래스를 바로 호출해서 사용할 수 있도록 공개되었다는 의미이다.
             * 반대 의미는 private 키워드를 사용한다.
             * 
             * static과 정적 메서드
             * C#에서는 static을 정적으로 표현한다. 의미가 같은 다른 말로 표현하면 공유(Shared)이다.
             * static이 붙는 클래스의 모든 멤버는 해당 클래스 내에서 누구나 공유해서 접근할 수 있다.
             * 메서드에 static이 붙는 메서드를 정적 메서드라고 하는데, 이를 공유 메서드(Shared method)라고도
             * 한다.
             * 
             * 정적 메서드와 인스턴스 메서드
             * 닷넷의 많은 API처럼 우리가 새롭게 만드는 클래스는 메서드를 포함한 각 멤버의 static 키워드
             * 유무에 따라 정적 또는 인스턴스 멤버가 될 수 있다.
             */

            //ClassNote classNote = new ClassNote();      // 인스턴스 화 한 것이다.
            //classNote.InstanceMethod();                 // 메모리에 ClassNote라는 객체를 할당한것이다. 이게 인스턴스다.

            /**
             * 클래스 시그니처
             * 클래스는 다음 시그니처를 가진다.
             * 
             * public class car {}
             * 
             * public 액세스 한정자를 사용하면 기본값인 internal을 갖는데 internal은 해당 프로그램 내에서
             * 언제든지 접근 가능하다. 하지만 학습 단계에서는 클래스에 public만 사용해도 괜찮다. 그리고 class
             * 키워드 다음에 클래스 이름이 오는데, 클래스 이름은 대문자로 시작하는 명사를 사용한다.
             * 클래스 본문 또는 몸통(Class Body)을 표현하는 중괄호 안에는 지금까지 배운 메서드와 앞으로 다룰
             * 필드, 속성, 생성자, 소멸자 등이 올 수 있는데, 이 모두를 가리켜 클래스 멤버라고 한다.
             * 
             * 클래스 이름 짓기
             * 클래스 이름은 의미 있는 이름을 사용하면 좋다. 이름은 명사를 사용하며, 첫 글자는 꼭 대문자여야한다.
             * 또 클래스 이름을 지을 때는 축약형이나 특정 접두사, 언더스코어(_) 같은 특수문자는 쓰지 않는다.
             *  - 클래스 이름은 누구나 알기 쉽게
             *  - 간단하고 명확하게 한다
             *  
             * 클래스의 주요 구성 요소
             * 클래스의 시작과 끝, 즉 클래스 블록 내에는 다음 용어(개념)들이 포함될 수 있다. 일반적으로 
             * 클래스 구성 요소를 가리킬 때 클래스 멤버라는 용어와 혼용해서 사용한다.
             * 
             * - 필드(Field): 클래스의 부품 역할을 한다. 클래스 내에 선언된 변수나 데이터를 담는 그릇으로,
             *                개체 상태를 저장한다.
             * - 메서드(Method): 개체 동작이나 기능을 정의한다.
             * - 생성자(Constructor): 개체 필드를 초기화 한다. 즉, 객체를 생성할 때 미리 수행해야 할 기능을
             *                       정의한다.
             * - 소멸자(Destructor): 개체를 모두 사용한 후 메모리에서 소멸될 때 실행한다.
             * - 속성(Property): 개체의 색상, 크기, 형태 등을 정의한다.
             * 
             * 액세스 한정자
             * 클래스를 생성할 때 public, private, internal, abstract, sealed 같은 키워드를 붙일 수 있다.
             * 이를 액세스 한정자라고 한다. 액세스 한정자는 클래스에 접근할 수 있는 범위를 결정하는 데 도움이 된다.
             * 특별히 지정하지 않는 한 기본적으로 public 액세스 한정자를 사용하면 된다.
             */

            //RockPaperScissorsGame RpsGame = new RockPaperScissorsGame();
            //RpsGame.Game();


            //TrumpCard trumpCard = new TrumpCard();
            //trumpCard.SetupTrumpCard();
            //trumpCard.ReRollCard();

            //Description one = new Description(123);
            //one.ValueTypeAndRefferenceType();

            //for (int i = 0; i < 100; i++)
            //{
            //}


            //TrumpCard card = new TrumpCard();
            //card.RollCard();

            //Parent parent = new Parent();
            //parent.Print();

            Slime monsterSlime = new Slime();
            Zombie monsterZombie = new Zombie();
            Wolf monsterWolf = new Wolf();
            BattleSystem battleSystem = new BattleSystem(); //배틀 시스템 클래스
            bool playerLife = true;     //플레이어의 생명
            bool gameoutcome = false;   //플레이어가 승리했는지 패배했는지 알려주는 변수
            Random rand = new Random(); //랜덤클래스
            int randomMonster = 0;

            Console.WriteLine("Press Any Key!");
            Console.ReadLine();
            Console.Clear();

            Console.Write("당신의 이름을 입력해주세요! : ");

            Player playernum1 = new Player(Console.ReadLine()); //플레이어 이름 설정

            Console.WriteLine("당신의 이름은 {0}입니다!", playernum1.name);

            playernum1.hp = 1000;                       //플레이어 체력
            playernum1.damage = 50;                     //플레이어 데미지
            playernum1.inventory = new string[20];      //인벤토리 공간 개수 지정




            while (playerLife)      //플레이어의 생명이 false 되면 게임 오버
            {
                Console.Clear();
                Console.WriteLine("인벤토리\n");
                foreach (string item in playernum1.inventory)
                {
                    Console.WriteLine(item);
                }

                randomMonster = rand.Next(1, 3 + 1);

                switch (randomMonster)
                {
                    case 1:
                        gameoutcome = battleSystem.BattleResult(playernum1.name, playernum1.hp, playernum1.damage,
                            monsterSlime.name, monsterSlime.hp, monsterSlime.damage, out playernum1.hp);
                        if (gameoutcome == true)    //플레이어 승리!
                        {
                            playernum1.AcquiredItem(monsterSlime.HpCheck());
                        }
                        break;
                    case 2:
                        gameoutcome = battleSystem.BattleResult(playernum1.name, playernum1.hp, playernum1.damage,
                            monsterZombie.name, monsterZombie.hp, monsterZombie.damage, out playernum1.hp);
                        if (gameoutcome == true)    //플레이어 승리!
                        {
                            playernum1.AcquiredItem(monsterZombie.HpCheck());
                        }
                        break;
                    case 3:
                        gameoutcome = battleSystem.BattleResult(playernum1.name, playernum1.hp, playernum1.damage,
                            monsterWolf.name, monsterWolf.hp, monsterWolf.damage, out playernum1.hp);
                        if (gameoutcome == true)    //플레이어 승리!
                        {
                            playernum1.AcquiredItem(monsterWolf.HpCheck());
                        }
                        break;
                    default:
                        break;
                }

                if (gameoutcome == false)  //플레이어 패배
                {
                    playerLife = false;
                }




            }

            Console.Clear();
            Console.WriteLine("당신은 사망했습니다");






        }       //Main()
    }       //Class Program1

    public class ClassNote
    {
        public static void StaticMethod()
        {
            Console.WriteLine("ClassNote 클래스의 staticMethod");
        }

        public void InstanceMethod()
        {
            Console.WriteLine("ClassNote 클래스의 InstanceMethod");
        }       // InstanceMethod()
    }

    public class Lotto
    {
        int[] lottoNumbers;
        public void MakeLottoNumber()
        {

            //Random lottoRand = new Random();
            //int[] resultNum = new int[6];

            //for (int i = 0; i < resultNum.Length; ++i)  //랜덤 난수를 입력
            //{
            //    resultNum[i] = lottoRand.Next(1, 45 + 1);
            //}

            //for (int first = 0; first < resultNum.Length; ++first)
            //{
            //    for (int second = 0; second < resultNum.Length; ++second)
            //    {
            //        if (resultNum[first] == resultNum[second])
            //        {
            //            if (first != second)
            //            {
            //                resultNum[first] = lottoRand.Next(1, 45 + 1);
            //            }
            //            else { /*Do nothing*/}
            //        }
            //    }
            //}

            //for(int index = 0; index < 6; index++)
            //{
            //    Console.Write("{0} ", resultNum[index]);
            //}

            //for (int i = 0; i < resultNum.Length; ++i)
            //{
            //    Console.WriteLine("로또 번호는 {0} 입니다!", resultNum[i]);
            //}


            lottoNumbers = new int[45];
            for (int index = 0; index < 45; index++)
            {
                lottoNumbers[index] = index + 1;
            }       //로또 번호를 순서대로 초기화 하는 루프

            for (int index = 0; index < 100; ++index)
            {
                lottoNumbers = shuffleOnce(lottoNumbers);
            }
            for (int index = 0; index < 6; index++)
            {
                Console.Write("{0} ", lottoNumbers[index]);
            }
        }       //MakeLottoNumber

        //! 배열을 1번 섞는 함수
        private int[] shuffleOnce(int[] lottoNumbers_)
        {
            Random random = new Random();
            int sourIndex = random.Next(0, lottoNumbers_.Length);
            int destIndex = random.Next(0, lottoNumbers_.Length);

            int tempVarible = lottoNumbers_[sourIndex];
            lottoNumbers_[sourIndex] = lottoNumbers_[destIndex];
            lottoNumbers_[destIndex] = tempVarible;

            return lottoNumbers_;
        }

    }       //Lotto Class

    public class RockPaperScissorsGame
    {
        public void Game()
        {
            string userInput = "";
            bool nexttime = true;
            while (nexttime)
            {
                Console.Write("가위, 바위, 보 중 한가지를 입력하세요 : ");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "가위":
                        nexttime = false;
                        break;
                    case "바위":
                        nexttime = false;
                        break;
                    case "보":
                        nexttime = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("다시 입력해주세요 !!");
                        break;
                }
            }

            string computerInput = "";
            string winner = "";

            computerInput = ComputerTurn();
            winner = Umpire(userInput, computerInput);


            Console.WriteLine("컴퓨터는 {0} 를 냈습니다!", computerInput);
            Console.WriteLine("당신은 {0} 를 냈습니다!", userInput);

            if (winner == "무승부")
            {
                Console.WriteLine("아 아쉽게도 무승부가 나왔네요!");
            }
            else
            {
                Console.WriteLine("{0}의 승리!", winner);
            }
        }

        //가위바위보 중 하나를 만들어 내는 함수 컴퓨터 용
        private string ComputerTurn()
        {
            string result = "";
            Random Rps = new Random();
            int Rpsnum = Rps.Next(1, 3 + 1);

            switch (Rpsnum)
            {
                case 1:
                    result = "가위";
                    break;
                case 2:
                    result = "바위";
                    break;
                case 3:
                    result = "보";
                    break;
                default:
                    break;
            }
            return result;
        }

        //
        private string Umpire(string user, string com)
        {
            string result = "";

            if (user == com)
            {
                result = "무승부";
            }
            else if (user == "가위")
            {
                switch (com)
                {
                    case "바위":
                        result = "컴퓨터";
                        break;
                    case "보":
                        result = "당신";
                        break;
                }
            }
            else if (user == "바위")
            {
                switch (com)
                {
                    case "보":
                        result = "컴퓨터";
                        break;
                    case "가위":
                        result = "당신";
                        break;
                }

            }
            else// if (user == "보")
            {
                switch (com)
                {
                    case "가위":
                        result = "컴퓨터";
                        break;
                    case "바위":
                        result = "당신";
                        break;
                }
            }

            return result;
        }
    }
}

