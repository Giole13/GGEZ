using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    internal class Poker
    {                                     //젤큼 그다음 그다음 막내
        string[] cardMark = new string[4] { "♠", "◆", "♥", "♣" };
        List<int> resultdeck = new List<int>();


        ////카드 셋업
        public List<int> SetUpCard()
        {
            List<int> result = ShuffleCard(MakeCard());
            //디버그 : 섞인 카드 확인 (이상 없음
            //foreach (int number in result)
            //{
            //    Console.WriteLine(number);
            //}
            return result;
        }

        //컴퓨터 5장 뽑기
        public List<int> ComputerDraw(List<int> deck)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < 5; ++i)
            {
                result.Add(deck[i]);
            }
            return result;
        }

        //플레이어 5장 뽑기
        public List<int> PlayerDraw(List<int> deck)
        {
            List<int> result = new List<int>();
            for (int i = 10; i < 15; ++i)
            {
                result.Add(deck[i]);
            }
            return result;
        }

        //자신의 덱에 있는 카드 보여주기
        public void ShowCard(List<int> deck)
        {

            foreach (int i in deck)
            {
                ShowCard(i);
                Console.Write(" ");


            }
            //result.Sort();


        }

        //한장을 정렬하고싶은데..
        public int ShowCardSort(int deck)
        {
            string mark;
            string cardNum = ReturnCard(deck, out mark);
            int result = Convert.ToInt32(Math.Ceiling(deck % 13.1));
            return result;
        }

        #region 한장을 보여주는 함수
        //한장을 보여주는 함수
        public int ShowCard(int deck)
        {
            string mark;
            string cardNum = ReturnCard(deck, out mark);
            Console.Write(mark);
            Console.Write(cardNum);
            int result = Convert.ToInt32(Math.Ceiling(deck % 13.1));
            return result;
        }
        #endregion

        #region 바꿀카드 고르기
        //바꿀카드 고르는 함수
        public void SelectCard(out int changeCard, out int selectCard)
        {
            int InputNum = -1;
            Console.WriteLine("\n0 : 바꾸지 않기 1 ~ 5 : 바꿀 카드 선택");
            while (InputNum > 5 || 0 > InputNum)
            {
                Console.Write("\n당신의 덱에서 바꿀 카드를 골라주세요 : ");
                int.TryParse(Console.ReadLine(), out InputNum);
                if (0 <= InputNum && InputNum <= 5)
                {
                    break;
                }
                else { /*Do nothing*/ }
                Console.WriteLine("\n다시 골라주세요!");
            }
            changeCard = InputNum;

            InputNum = -1;
            while (InputNum > 2 || 0 > InputNum)
            {
                Console.Write("\n2장의 카드 중에서 바꿀 카드를 골라주세요 : ");
                int.TryParse(Console.ReadLine(), out InputNum);
                if (1 <= InputNum && InputNum <= 2)
                {
                    break;
                }
                else if (InputNum == 0)
                {
                    break;
                }
                Console.WriteLine("\n다시 골라주세요!");
            }
            selectCard = InputNum;
        }
        #endregion

        #region 카드의 조합을 알려주는 함수
        //조합의 종류를 알려주는 함수
        public int CardCombination(List<int> deck)
        {
            int result = 0;
            string[] mark = new string[5];
            string[] value = new string[5];
            bool escape = false;

            for (int i = 0; i < 5; ++i)
            {
                value[i] = ReturnCard(deck[i], out mark[i]);
            }



            while (result == 0)
            {
                int sameCnt = 0;
                //포커 조건
                for (int index1 = 0; index1 < 5; ++index1)
                {
                    sameCnt = 0;
                    for (int index2 = 0; index2 < 5; ++index2)
                    {
                        if (value[index2] == value[index1])
                        {
                            if (index2 != index1)
                            {
                                ++sameCnt;
                            }
                            else { /*Do nothing*/}

                            if (sameCnt == 3)
                            {   //숫자가 4개가 일치한다면 포커! (젤 쌤
                                //
                                result = 10;
                                escape = true;
                                break;
                            }
                        }
                    }
                    if (escape) { break; }
                }       //포커
                if (escape)
                {
                    break;
                }
                escape = false;

                //플러쉬 조건
                if (mark[0] == mark[1] && mark[1] == mark[2] && mark[2] == mark[3] && mark[3] == mark[4])
                {   //마크가 모두 일치하면 플러쉬! (포커 밑임
                    result = 8;
                    break;
                }
                else
                {
                    /*Do nothing*/
                }       //플러쉬

                //스트레이트 조건
                int straightCnt = 0;
                List<int> straight = ReturnValue(deck);


                for (int index = 0; index <= 1; ++index)
                {
                    for (int i = 0, x = 4; i < 5; ++i, --x)
                    {
                        if ((straight[i] + x) == straight[x])
                        {
                            ++straightCnt;
                        }
                        if (straightCnt == 5)
                        {   //숫자가 연속된다면 ! 스트레이트!
                            result = 5;
                            escape = true;
                            break;
                        }
                    }   //정상적으로 작은숫자가 연속된다면 작동

                    for (int i = 0; i < 4; ++i)    //여기 해결함 이 상태에서 한번더 돌아주면 위쪽에서 걸릴꺼임
                    {
                        if (straight[i + 1] - straight[i] == 9)
                        {
                            straight[i + 1] -= 8;
                        }

                    }   //13다음으로 연속되는 숫자가 존재한다면
                }
                if (escape) { break; }
                escape = false;

                //트리플 조건
                for (int index1 = 0; index1 < 5; ++index1)
                {
                    sameCnt = 0;
                    for (int index2 = 0; index2 < 5; ++index2)
                    {
                        if (value[index2] == value[index1])
                        {
                            if (index2 != index1)
                            {
                                ++sameCnt;
                            }
                            else { /*Do nothing*/}

                            if (sameCnt == 2)
                            {   //숫자가 3개가 일치한다면 트리플! 4번째임..
                                result = 4;
                                escape = true;
                                break;
                            }

                        }
                    }
                }
                if (escape) { break; }
                escape = false;

                //투페어 조건
                sameCnt = 0;
                for (int index1 = 0; index1 < 5; ++index1)
                {
                    for (int index2 = 0; index2 < 5; ++index2)
                    {
                        if (value[index2] == value[index1])
                        {
                            if (index2 != index1)
                            {
                                ++sameCnt;
                            }
                            else { /*Do nothing*/}

                            if (sameCnt == 4)
                            {   //숫자가 3개가 일치한다면 트리플! 4번째임..
                                result = 3;
                                escape = true;
                                break;
                            }

                        }
                    }
                }
                if (escape) { break; }
                escape = false;

                //원페어 조건
                sameCnt = 0;
                for (int index1 = 0; index1 < 5; ++index1)
                {
                    for (int index2 = 0; index2 < 5; ++index2)
                    {
                        if (value[index2] == value[index1])
                        {
                            if (index2 != index1)
                            {
                                ++sameCnt;
                            }
                            else { /*Do nothing*/}

                            if (sameCnt == 2)
                            {   //숫자가 3개가 일치한다면 트리플! 4번째임..
                                result = 2;
                                escape = true;
                                break;
                            }

                        }
                    }
                }
                if (escape) { break; }

                result = 1;
                break;
            }       //while문
            return result;
        }       //카드콤비네이션();
        #endregion

        //자신의 덱에 있는 카드를 바꿔주는 함수
        public List<int> Exchange(List<int> deck, int changeNum, int num)
        {
            deck[changeNum] = num;
            return deck;
        }

        #region 컴퓨터가 2장을 보고 비교해서 젤 높은걸로 반환하는 함수
        //컴퓨터가 2장을 보고 비교해서 젤 높은걸로 반환하는 함수
        public int ComputerConclusion(List<int> deck, int num1, int num2, out List<int> bestDeck1)
        {
            List<int> test = new List<int>(deck);
            List<int> bestDeck = new List<int>(deck);
            int result = 0;
            int compare1, compare2, compare3;

            result = CardCombination(deck);   //기본형

            for (int i = 0; i < 5; ++i)
            {   //이슈를 찾았어요! 여기에 리스트는 초기화가 안돼요!
                test = new List<int>(deck);
                test[i] = num1;
                compare1 = CardCombination(test);   //num1을 넣은형
                if (result <= compare1) { result = compare1; bestDeck = new List<int>(test); }
            }

            for (int i = 0; i < 5; ++i)
            {
                test = new List<int>(deck);
                test[i] = num2;
                compare2 = CardCombination(test);   //num2을 넣은형
                if (result <= compare2) { result = compare2; bestDeck = new List<int>(test); }
            }

            //두가지 모두 넣고 비교한 형
            for (int index1 = 0; index1 < 5; ++index1)
            {
                for (int index2 = 0; index2 < 5; ++index2)
                {
                    if (index1 != index2)
                    {
                        test = new List<int>(deck);
                        test[index1] = num1;
                        test[index2] = num2;
                        compare3 = CardCombination(test);
                        if (result <= compare3) { result = compare3; bestDeck = new List<int>(test); }
                    }
                    else { /*Do nothing*/}
                }
            }

            //if (result == 1)
            //{
            //    //리스트 반환하는 매개변수 리스트 뽑은카드1 , 2
            //    bestDeck = //여기에 함수!
            //}



            ShowCard(bestDeck);
            bestDeck1 = new List<int>(bestDeck);
            return result;
        }
        #endregion




        //높은 수를 비교해서 베팅금액을 정해주는 함수
        public int GameOutcome(int player, int computer, int batting)
        {
            int result = 0;

            if (computer < player)
            {
                Console.WriteLine("플레이어가 승리했어요!");
                Console.WriteLine("베팅금액의 두배를 줄게요!");
                result = batting * 2;
            }
            else if (computer > player)
            {
                Console.WriteLine("컴퓨터가 승리했어요!");
                Console.WriteLine("베팅금액을 모두 잃었어요!");
                result = batting * -1;
            }
            else { /*Do nothing*/}

            return result;
        }

        public void ShowCombi(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("하이페어!");
                    break;
                case 2:
                    Console.WriteLine("원페어!!");
                    break;
                case 3:
                    Console.WriteLine("투페어!!");
                    break;
                case 4:
                    Console.WriteLine("트리플!!!");
                    break;
                case 5:
                    Console.WriteLine("스트레이트!!!");
                    break;
                case 8:
                    Console.WriteLine("플러시!!!!");
                    break;
                case 10:
                    Console.WriteLine("포커!!!!!!");
                    break;

            }
        }

        //자신의 배팅금액을 보여주는 함수
        public void PresentMoney(int money)
        {
            Console.WriteLine("현재 총 보유 금액 : {0}", money);
        }

        //같은 종류의 콤비네이션이면 서로 비교해주는 함수
        public int SameCardOutcome(List<int> playerDeck, List<int> computerDeck)
        {
            int result = 0;
            List<int> players = ReturnValue(playerDeck);
            List<int> computers = ReturnValue(computerDeck);
            bool same = false;
            List<string> playerMark, computerMark, playerMark1, computerMark1;

            players.Sort();
            players.Reverse();
            computers.Sort();
            computers.Reverse();


            for (int i = 0; i < 5; ++i)
            {
                same = false;
                for (int index1 = 0; index1 < 5; ++index1)
                {
                    if (players[index1] == 1 || computers[index1] == 1)
                    {
                        if (players[index1] == 1 && computers[index1] != 1)
                        {
                            result = 100;
                            return result;
                        }
                        else if (computers[index1] == 1 && players[index1] != 1)
                        {
                            result = 0;
                            return result;
                        }
                    }
                    else { /*Do nothing*/}
                }

                if (players[i] < computers[i])
                {
                    result = 0;
                    break;
                }
                else if (players[i] > computers[1])
                {
                    result = 100;
                    break;
                }
                else
                {   //숫자가 같아면 이제 문자열 비교
                    same = true;
                }
            }

            //만약 숫자가 같다면
            if (same == true)
            {
                //임시로 문자들을 받음
                playerMark1 = ReturnCardMark(players);
                computerMark1 = ReturnCardMark(computers);

                //받은거를 쭉 돌아서 스다하클 순으로 정렬해주는 함수
                playerMark = CardMarkSort(playerMark1);
                computerMark = CardMarkSort(computerMark1);

                for (int index = 0; index < 5; ++index)
                {
                    for (int index2 = 0; index2 < 5; ++index)
                    {
                        if ((playerMark[index2] == cardMark[index]) && (computerMark[index2] != cardMark[index]))
                        {   //플레이어는 스페이드인데 컴퓨터가 스페이드가 아니라면 플레이어 승!
                            //이렇게 순서대로 하자
                            result = 100;
                            return result;
                        }
                        else {/*Do noting*/ }
                    }
                }
            }


            return result;
        }

        
        //문자를 스다하클 순으로 정렬해주는 함수
        private List<string> CardMarkSort(List<string> mark)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < 4; ++i)
            {
                for (int index2 = 0; index2 < 5; ++index2)
                {
                    if (mark[index2] == cardMark[i])
                    {
                        result.Add(mark[i]);
                    }
                    else { /*Do nothing*/}
                }

            }
            return result;
        }
        //카드 만들어주는 함수
        private List<int> MakeCard()
        {
            for (int i = 1; i <= 52; ++i)
            {
                resultdeck.Add(i);
            }

            //디버그 : 확인용 (이상 없음
            //foreach (int number in result)
            //{
            //    Console.WriteLine(number);
            //}
            return resultdeck;      //배열 반환
        }

        //카드 셔플해주는 함수
        private List<int> ShuffleCard(List<int> card)
        {
            int temp = 0;
            Random rand = new Random();
            for (int i = 0; i < 200; ++i)
            {
                int num1 = rand.Next(0, 52);
                int num2 = rand.Next(0, 52);
                temp = card[num1];
                card[num1] = card[num2];
                card[num2] = temp;
            }
            return card;
        }

        //숫자와 마크를 리턴하는 함수
        private string ReturnCard(int deck, out string mark)
        {
            string cardNum = Math.Ceiling(deck % 13.1).ToString();
            switch (cardNum)
            {
                case "11":
                    cardNum = "J";
                    break;
                case "12":
                    cardNum = "Q";
                    break;
                case "13":
                    cardNum = "K";
                    break;
                default:
                    /*Do nothing*/
                    break;
            }       //switch
            mark = cardMark[(deck - 1) / 13];
            return cardNum;
        }

        //받은 리스트의 숫자를 문자열 리스트로 보내주자
        private List<string> ReturnCardMark(List<int> num)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < 5; ++i)
            {
                result[i] = cardMark[(num[i] - 1) / 13];
            }
            return result;
        }


        //List를 받아서 숫자배열로 내보내자
        private List<int> ReturnValue(List<int> deck)
        {
            List<int> result = new List<int>();
            double temp;
            for (int i = 0; i < 5; ++i)
            {
                temp = Math.Ceiling(deck[i] % 13.1);
                result.Add(Convert.ToInt32(temp));
            }
            result.Sort();

            return result;
        }
    }       //class Poker
}
