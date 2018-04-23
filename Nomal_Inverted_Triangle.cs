using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("몇줄의 역삼각형을 만드시겠습니까?");
            a = int.Parse(Console.ReadLine());

            for(b = a; b>=1; b--)
            {
                for(c = 1; c<=b; c++)//별표 출력부분
                {
                    Console.Write("*");
                }
                Console.WriteLine();//줄바꾸기 코드
            }
            Console.ReadLine();//바로 꺼짐 방지 코드
        }
    }
}
