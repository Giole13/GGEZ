using System;
using System.Collections.Generic;

namespace PokerGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  노페어, 원페어, 투페어, 트리플, 포카드, 플러쉬, 스트레이트 까지 구현완료
            //  같은 조합이 나왔을때 숫자먼저 비교하고 그다음 문자끼리 비교하는것까지 완료
            //  근데 노페어 상태에서 컴퓨터가 가장 최고의 패를 고르는것은 구현 실패
            //  베팅 구현완료
            //  승리, 패배 구현완료
            //  
            //  

            //타이틀
            Console.WriteLine("포커 게임!");
            Console.WriteLine("Press Any Key!!");
            Console.ReadKey();

            bool playerLife = true;
            
            //베팅 금액 설정
            int batMoney = 0, allMoney = 10000;





            while (playerLife)
            {
                //카드셋업
                Poker poker = new Poker();
                List<int> cardDeck = poker.SetUpCard();

                //컴퓨터 5장 뽑기!
                List<int> computerDeck = poker.ComputerDraw(cardDeck);
                Console.Write("컴퓨터 덱 : ");
                poker.ShowCard(computerDeck);

                Console.WriteLine();

                //플레이어 5장 뽑기!
                List<int> playerDeck = poker.PlayerDraw(cardDeck);
                Console.Write("플레이어 덱 : ");
                poker.ShowCard(playerDeck);



                //플레이어가 카드를 2장 뽑기!
                int cardnum1 = cardDeck[15];
                int cardnum2 = cardDeck[16];


                //뽑은 카드 출력해주기!
                Console.Write("\n뽑은 카드 : ");
                poker.ShowCard(cardnum1);
                Console.Write(" ");
                poker.ShowCard(cardnum2);


                //바꿀 카드 선택하기
                int changeCard, selectCard;     //체인지가 당신의 덱에서 바꿀 카드, 셀렉트가 당신이 고른 카드
                poker.SelectCard(out changeCard, out selectCard);


                //자신의 덱에서 카드 바꿔주기
                if (selectCard == 1) { playerDeck = new List<int>(poker.Exchange(playerDeck, changeCard - 1, cardnum1)); }
                else if (selectCard == 2) { playerDeck = new List<int>(poker.Exchange(playerDeck, changeCard - 1, cardnum2)); }
                else { /*Do nothing*/ }
                playerDeck.Sort();      //카드 정렬


                //디버그: 바뀐 카드를 확인 (이상없음
                //foreach(int i in playerDeck)
                //{
                //    Console.WriteLine(i);
                //}





                //금액 보여주는 함수
                poker.PresentMoney(allMoney);
                Console.WriteLine("batMoney를 설정해주세요!");
                int.TryParse(Console.ReadLine(), out batMoney);

                while (allMoney < batMoney)
                {
                    poker.PresentMoney(allMoney);
                    Console.WriteLine("batMoney를 다시 설정해주세요! :");
                    int.TryParse(Console.ReadLine(), out batMoney);
                }


                //컴퓨터가 카드를 2장 뽑고 나서 조합까지 생각해서 가장 최고의 수 내놓기
                //int computerBest = poker.ComputerConclusion(computerDeck, cardDeck[5], cardDeck[6]);
                Console.WriteLine("디버그 모드");
                poker.ShowCard(computerDeck);
                Console.WriteLine("아레가 바뀐거");

                List<int> computerBestDeck = new List<int>();
                int computerBest = poker.ComputerConclusion(computerDeck, cardDeck[5], cardDeck[6], out computerBestDeck);
                poker.ShowCombi(computerBest);

                Console.WriteLine(" ");
                //노페어, 원페어, 투페어, 트리플, 포카드, 플러쉬, 스트레이트
                //카드가 어떤 조합인지 구별하는 함수
                int playerBest = poker.CardCombination(playerDeck);
                poker.ShowCard(playerDeck);
                poker.ShowCombi(playerBest);

                Console.WriteLine(" ");


                //비교해서 돈을 조절해주는 함수
                //이곳으로는 같은 값이 들어갈수가 없음
                if (playerBest == computerBest)
                {   //플레이어가 이긴거면 100을 진거라면 0을 리턴
                    playerBest = poker.SameCardOutcome(playerDeck, computerBestDeck);
                }
                allMoney += poker.GameOutcome(playerBest, computerBest, batMoney);
                poker.PresentMoney(allMoney);

                if (100_000 <= allMoney)
                {
                    Console.WriteLine("10만원을 모두 모아서 승리!");
                    break;
                }
                else if (allMoney <= 0)
                {
                    Console.WriteLine("빵원이 되어서 패배..");
                    break;
                }


                Console.ReadKey();
                Console.WriteLine("\n이어서 진행하기!");
                Console.ReadLine();
                Console.Clear();

            }       // while(playerLife)
        }       // Main()
    }
}