using System.Runtime.ExceptionServices;

namespace Test11
{
    internal class Class1
    {
        public static void Main()
        {
            //나란히 입력받을때
            string word = Console.ReadLine();
            string[] numberWord = word.Split(' ');
            int[] num = new int[3];
            int result = 0;

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(numberWord[i]);
            }

            bool allSame = num[0] == num[1] && num[1] == num[2];
            bool twoSame1 = num[0] == num[1] || num[0] == num[2];
            bool twoSame2 = num[1] == num[0] || num[1] == num[2];
            bool twoSame3 = num[2] == num[0] || num[2] == num[1];
            int bignum=0;
            if (num[0] < num[1])
            {
                if (num[2] < num[1])
                {
                    bignum = num[1];
                }
                else if (num[1] < num[2])
                {
                    bignum = num[2];
                }
            }
            else if (num[1] < num[0])
            {
                if (num[0] < num[2])
                {
                    bignum = num[2];
                }
                else 
                    { bignum = num[0]; }
            }
            else { /*Do noting*/}



            if (allSame)
            {
                result = 10000 + num[0] * 1000;
            }
            else if (twoSame1)
            {
                result = 1000 + num[0] * 100;
            }
            else if (twoSame2)
            {
                result = 1000 + num[1] * 100;
            }
            else if (twoSame3)
            {
                result = 1000 + num[2] * 100;
            }
            else
            {
                result = bignum * 100;
            }

            Console.WriteLine(result);


            //띄어서 입력 받을때
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());

           



        }
    }
}
