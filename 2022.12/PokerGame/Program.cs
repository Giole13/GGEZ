using System;
using System.Collections.Generic;

namespace PokerGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //타이틀
            Console.WriteLine("포커 게임!");
            Console.WriteLine("Press Any Key!!");
            Console.ReadKey();

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

            //컴퓨터가 카드를 2장 뽑기!
            computerDeck.Add(poker.DrawCard(cardDeck, 5));
            computerDeck.Add(poker.DrawCard(cardDeck, 6));

            //플레이어가 카드를 2장 뽑기!
            int cardnum1 = poker.DrawCard(cardDeck, 15);
            int cardnum2 = poker.DrawCard(cardDeck, 16);

            //뽑은 카드 출력해주기!
            Console.Write("\n뽑은 카드 : ");
            poker.ShowCard(cardnum1);
            poker.ShowCard(cardnum2);

            //바꿀 카드 선택하기
            int changeCard, selectCard;     //체인지가 당신의 덱에서 바꿀 카드, 셀렉트가 당신이 고른 카드
            poker.SelectCard(out changeCard, out selectCard);

            //자신의 덱에서 카드 바꿔주기
            if(selectCard == 1) { playerDeck = poker.Exchange(playerDeck, changeCard-1, cardnum1); }
            else if(selectCard == 2) { playerDeck = poker.Exchange(playerDeck, changeCard-1, cardnum2); }
            else { /*Do nothing*/ }
            playerDeck.Sort();      //카드 정렬

            //디버그: 바뀐 카드를 확인 (이상없음
            //foreach(int i in playerDeck)
            //{
            //    Console.WriteLine(i);
            //}

            //노페어, 원페어, 투페어, 트리플, 포카드, 플러쉬, 스트레이트
            //카드가 어떤 조합인지 구별하는 함수
            poker.CardCombination(playerDeck);

            //비교하는 함수




            //승패결정 함수
            Console.WriteLine("에엥 져버렸네요!");
            Console.WriteLine("에엥 이겼네요!");



        }
    }
}