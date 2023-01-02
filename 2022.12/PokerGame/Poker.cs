using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    internal class Poker
    {
        string[] cardMark = new string[4] { "♠", "♣", "♥", "◆" };
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
            deck.Sort();
            foreach (int i in deck)
            {
                ShowCard(i);
                Console.Write(" ");
            }
        }


        #region 한장을 보여주는 함수
        //한장을 보여주는 함수
        public void ShowCard(int deck)
        {
            string mark;
            string cardNum = ReturnCard(deck, out mark);
            Console.Write(mark);
            Console.Write(cardNum);
        }
        #endregion

        //카드 1장 뽑기!
        public int DrawCard(List<int> deck, int num)
        {
            int result = deck[num];
            return result;
        }

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
                Console.WriteLine("\n다시 골라주세요!");
            }
            changeCard = InputNum;

            InputNum = -1;
            while (InputNum > 2 || 1 > InputNum)
            {
                Console.Write("\n2장의 카드 중에서 바꿀 카드를 골라주세요 : ");
                int.TryParse(Console.ReadLine(), out InputNum);
                if (1 <= InputNum && InputNum <= 2)
                {
                    break;
                }
                Console.WriteLine("\n다시 골라주세요!");
            }
            selectCard = InputNum;
        }
        #endregion

        //조합의 종류를 알려주는 함수
        public int CardCombination(List<int> deck)
        {
            int result = 0;
            string[] mark = new string[5];
            string[] value = new string[5];


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
                                result = 8;
                                break;
                            }

                        }
                    }
                }       //포커

                //플러쉬 조건
                if (mark[0] == mark[1] && mark[1] == mark[2] && mark[2] == mark[3] && mark[3] == mark[4])
                {   //마크가 모두 일치하면 플러쉬! (포커 밑임
                    result = 6;
                    break;
                }
                else
                {
                    /*Do nothing*/
                }       //플러쉬

                //스트레이트 조건
                int straightCnt = 0;
                int[] straight = ReturnValue(deck);
                for (int index = 0; index <= 1; ++index)
                {
                    for (int i = 0, x = 4; i < 5; ++i, --x)
                    {
                        if ((straight[i] += x) == straight[x])
                        {
                            ++straightCnt;
                        }

                        if (straightCnt == 5)
                        {   //숫자가 연속된다면 ! 스트레이트!
                            result = 5;
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
                if(result > 4) { break; }   //결과값이 4보다 크면 일단 탈출

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
                                break;
                            }

                        }
                    }
                }

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
                                break;
                            }

                        }
                    }
                }

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
                                break;
                            }

                        }
                    }
                }
                result = 1;
                break;
            }       //while문
            return result;
        }

        //자신의 덱에 있는 카드를 바꿔주는 함수
        public List<int> Exchange(List<int> deck, int changeNum, int num)
        {
            deck[changeNum] = num;
            return deck;
        }



        //비교하는 함수
        //public void CardCompare(List<int> Player, List<int> Computer)
        //{
        //}



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

        //List를 받아서 숫자배열로 내보내자
        private int[] ReturnValue(List<int> deck)
        {
            int[] result = new int[5];
            double temp;
            for(int i = 0; i < 5; ++i)
            {
                temp = Math.Ceiling(deck[i] % 13.1);
                result[i] = Convert.ToInt32(temp);
            }


            return result;
        }


    }       //class Poker
}
