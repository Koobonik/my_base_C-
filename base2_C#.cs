using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4장예제
{
    class Program
    {

        static void Main(string[] args)
        {
            //코드 복붙하면
            Console.WriteLine("출력");
            Console.WriteLine("출력");
            Console.WriteLine("출력");
            Console.WriteLine("출력");
            Console.WriteLine("출력");

            //반복문 사용하면
            for (int i = 0; i < 10; i++)
                Console.WriteLine("반복문 출력");


            //배열 생성
            int[] intArray = { 52, 273, 32, 65, 103 };

            //배열의 요소를 변경 합니다.
            intArray[0] = 0;

            //요소 출력
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);


            //코드 4-3 기본적인 배열 생성 방법
            long[] longArray = { 52, 273, 32, 65, 103 };
            float[] floatArray = { 1.0F, 2.0F, 3.0F, 4.0F, 5.0F };
            double[] doubleArray = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            char[] charArray = { '가', '나', '다', '라', '마' };
            string[] stringArray = { "윤인성", "연하진", "윤아린" };

            //코드 배열의 Lenght 속성
            Console.WriteLine(intArray.Length);

            int[] arrayA = new int[100];
            Console.WriteLine(arrayA[99]);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            string input;
            do
            {
                Console.WriteLine("exit를 입력하면 종료 : ");
                input = Console.ReadLine();
            } while (input != "exit");

            int output = 0;
            for (int i = 0; i <= 100; i++)
                output += i;
            Console.WriteLine(output);

            //한글 전부 출력하기
            for (int i = '가'; i <= '힣'; i++)
            {
                Console.Write((char)i);
            }

            long start = DateTime.Now.Ticks;
            long count = 0;

            while (start + (1000000) > DateTime.Now.Ticks)
                count++;

            Console.WriteLine(count + " 만큼 반복했어요~");
            Console.WriteLine();

            //goto 키워드
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("외부 반복문");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("내부 반복문");
                    goto doNotUse;
                }
            }
        doNotUse:
            Console.WriteLine("goto 키워드");
            Console.WriteLine();

            //기본예제 간단변경
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(1);
            }

            for (int i = intArray.Length - 1; i >= 0; i--)
                Console.WriteLine(intArray[i]);

            string[] fruit = { "사과", "배", "딸기", "포도", "바나나" };
            foreach (string item in fruit)
            {
                Console.WriteLine(item);
            }

            for (int i =0; i<10; i++)
            {
                for(int j=0; j<i; j++)
                    Console.Write('*');
                Console.WriteLine("");
                
            }
            for (int i=0; i<10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                    Console.Write(' ');
                for (int j = 0; j < i + 1; j++)
                    Console.Write('*');
                Console.Write("\n");
            }
            while(true)
            {
                Console.WriteLine("짝수를 입력하면 종료됩니다.");
                int inputNum = int.Parse(Console.ReadLine());
                if (inputNum % 2 == 0)
                    break;
            }
            for(int i=1; i<10; i++)
            {
                if(i%2 ==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            //대문자화 소문자화
            string str = "Potato Tomato";
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());

            //문자열 자르기
            string str2 = "구본익 김승훈 안기환 조권식";
            string[] inputs = str2.Split(new char[] { ' ' });

            foreach (var item in inputs)
                Console.WriteLine(item);


            //문자열 양 옆의 공백 제거
            input = "  tset             \n";
            Console.WriteLine("::" + input.Trim() + "::");
            Console.Read();

            string[] hase = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(",", hase));

            string hello = Console.ReadLine();//바로 꺼지지 말라고...
        }
    }
}
