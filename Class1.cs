using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Class1
    {
        public Class1()
        {
            //LAB 1 자음과 모음 개수 세기
            int vowel = 0, consonant = 0; //모음과 자음 변수 선언
            string letter = ""; // 입력받을 변수 선언
            while (letter != "#") //종료문자 식별 전까지 반복
            {
                Console.Write("(종료문자 : #)영문자를 입력해주세요 : "); //입력 제시 출력
                letter = Console.ReadLine(); //입력 받을 변수에 입력
                switch (letter) //입력 받을 변수에 따른 모음 자음 개수 분별
                {
                    case "a":   //모음일 경우 모음변수에 ++
                        ++vowel;
                        break;
                    case "e":   //모음일 경우 모음변수에 ++
                        ++vowel;
                        break;
                    case "i":   //모음일 경우 모음변수에 ++
                        ++vowel;
                        break;
                    case "o":   //모음일 경우 모음변수에 ++
                        ++vowel;
                        break;
                    case "u":   //모음일 경우 모음변수에 ++
                        ++vowel;
                        break;
                    case "A":   //대문자 모음일 경우 모음변수에 ++
                        ++vowel;
                        break;
                    case "E":   //대문자 모음일 경우 모음변수에 ++
                        ++vowel;
                        break;
                    case "I":   //대문자 모음일 경우 모음변수에 ++
                        ++vowel;
                        break;
                    case "O":   //대문자 모음일 경우 모음변수에 ++
                        ++vowel;
                        break;
                    case "U":   //대문자 모음일 경우 모음변수에 ++
                        ++vowel;
                        break;
                    case "#":   //종료문자일 경우 탈출
                        break;
                    default:    //그 외의 경우 자음변수에 ++
                        ++consonant;
                        break;
                }
            }

            Console.WriteLine($"모음 : {vowel}"); //모음갯수 출력
            Console.WriteLine($"자음 : {consonant}"); //자음갯수 출력
            //################################################################################
            //LAB 2 숫자 맟추기 게임
            int numbb = 42, inputnum = 0; //정답변수, 입력 받을 변수 선언
            Console.Write("숫자를 제시해주세요 : "); //숫자 제시 출력
            int.TryParse(Console.ReadLine(), out inputnum); //입력 받은 숫자를 변수에 넣기


            while (inputnum != numbb) //정답과 입력값이 다를 경우 반복
            {
                if (inputnum < numbb) //정답이 입렵값보다 큰 경우
                {
                    Console.Write($"{inputnum}보다 높아요!."); //정답이 더 높다는 말 출력
                    Console.Write("숫자를 제시해주세요 : ");
                    int.TryParse(Console.ReadLine(), out inputnum); //다시 입력값을 받기
                }
                else if (inputnum > numbb) //정답이 입력값보다 작은 경우
                {
                    Console.Write($"{inputnum}보다 낮아요!."); //정답이 더 낮다는 말 출력
                    Console.Write("숫자를 제시해주세요 : ");
                    int.TryParse(Console.ReadLine(), out inputnum); //다시 입력값을 받기
                }
            }
            if (inputnum == numbb) //정답과 입력값이 같은 경우
            {
                Console.Write("정답!!"); //정답 출력!
            }
            //################################################################################
            
            //LAB 3 산수 문제 자동 출제
            Random munje = new Random(); //랜덤함수 선언
            int input = 1, result = 0; //입력받을 변수, 정답 변수 선언

            while (result != input) //입력값과 정답이 다를 경우 반복
            {
                int oper1 = munje.Next(0, 100); //0부터100까지 난수 선언
                int oper2 = munje.Next(0, 100); //0부터100까지 난수 선언
                int uhyung = munje.Next(1, 5); // 문제 유형별로 1부터 4까지 난수 선언

                switch (uhyung) //유형별로 랜덤하게 출제
                {
                    case 1:
                        Console.WriteLine("덧셈 문제 출제 나갑니다.");
                        result = oper1 + oper2; //덧셈식
                        Console.WriteLine($"{oper1} + {oper2} = ");

                        Console.Write("답을 써주세요 : ");
                        int.TryParse(Console.ReadLine(), out input); //입력할 변수에 입력하기
                        break;
                    case 2:
                        Console.WriteLine("뺄셈 문제 출제 나갑니다.");
                        result = oper1 - oper2; //뺄셈식
                        Console.WriteLine($"{oper1} - {oper2} = ");

                        Console.Write("답을 써주세요 : ");
                        int.TryParse(Console.ReadLine(), out input); //입력할 변수에 입력하기
                        break;
                    case 3:
                        Console.WriteLine("곱셈 문제 출제 나갑니다.");
                        result = oper1 * oper2; //곱셈식
                        Console.WriteLine($"{oper1} * {oper2} = ");

                        Console.Write("답을 써주세요 : ");
                        int.TryParse(Console.ReadLine(), out input); //입력할 변수에 입력하기
                        break;
                    case 4:
                        if (oper2 == 0) { break; } //난수가 0일경우에 스위치문 탈출
                        if (oper1 == 0) { break; } //난수가 0일경우에 스위치문 탈출
                        Console.WriteLine("나눗셈 문제 출제 나갑니다.");
                        result = oper1 / oper2; //나눗셈 식
                        Console.WriteLine($"{oper1} / {oper2} = ");

                        Console.Write("답을 써주세요 : ");
                        int.TryParse(Console.ReadLine(), out input); //입력할 변수에 입력하기
                        break;
                }
            }
            Console.WriteLine("정다압!!!!"); //정답 출력
        }
    }
}
