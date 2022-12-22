using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhaIsArray
{
    internal class Class1
    {
        static void Main2(string[] args)
        {
            Random base_ = new Random();
            string baseball;
            int out_ = 0, ball_ = 0, strike = 0, count=0;
            int one = 0, two = 0, three = 0;



            int jung1 = base_.Next(0, 10); //랜덤 함수
            int jung2 = base_.Next(0, 10);
            int jung3 = base_.Next(0, 10);

            while ((jung1 == jung2) || (jung1 == jung3)) //중복 방지
            {
                jung1 = base_.Next(0, 10);
            }
            while ((jung2 == jung3) || (jung2 == jung1)) //중복 방지
            {
                jung2 = base_.Next(0, 10);
            }


            for (int index = 1; index <= 9; index++)
            //정답은 랜덤 함수
            {
                Console.Write("첫번째 수를 입력해주세요 : ");
                int.TryParse(Console.ReadLine(), out one);
                Console.Write("두번째 수를 입력해주세요 : ");
                int.TryParse(Console.ReadLine(), out two);
                Console.Write("세번째 수를 입력해주세요 : ");
                int.TryParse(Console.ReadLine(), out three);

                if(jung1 == one) //같을 경우 스트라이크
                {
                    ++strike;
                }
                else if ((jung1 == two)||(jung1 == three)) //둘중 하나가 있을경우 볼
                {
                    ++ball_;
                }
                else //모두 아닌경우 아웃
                {
                    ++out_;
                }

                if (jung2 == two) //같을 경우 스트라이크
                {
                    ++strike;
                }
                else if ((jung2 == one) || (jung2 == three)) //둘중 하나가 있을경우 볼
                {
                    ++ball_;
                }
                else //모두 아닌경우 아웃
                {
                    ++out_;
                }

                if (jung3 == three) //같을 경우 스트라이크
                {
                    ++strike;
                }
                else if ((jung3 == one) || (jung3 == two)) //둘중 하나가 있을경우 볼
                {
                    ++ball_;
                }
                else //모두 아닌경우 아웃
                {
                    ++out_;
                }

                Console.WriteLine("=====================================");
                Console.WriteLine($"=[{out_}] 아웃!  [{ball_}] 볼!  [{strike}] 스트라이크!=");
                Console.WriteLine("=====================================");
                Console.WriteLine($"{index}번 째 진행\n\n"); //횟수 출력

                out_ = 0;  //카운터들 초기화
                ball_ = 0; 
                strike = 0;

                bool clear = ((one == jung1) && (two == jung2) && (three == jung3));
                if (clear)
                {
                    Console.WriteLine("정답!");
                    break;
                }

                ++count; //횟수 카운트
            }

            bool fail = count > 8; //횟수 초과시 판별해서 패배 출력
            if (fail)
            {
                Console.WriteLine("==========================");
                Console.WriteLine("=게임에서 패배하였습니다!=");
                Console.WriteLine("==========================");
                Console.WriteLine($"정답은 {jung1} {jung2} {jung3} 입니다!");
            }


        }
    }
}
