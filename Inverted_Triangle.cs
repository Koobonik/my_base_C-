using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;//a는 몇층나타낼지 b는 현재의 층수 c는 *
            Console.WriteLine("몇층 역피라미드를 만드시겠습니까? : ");
            a = int.Parse(Console.ReadLine());
            for(b = a; b >= 1; b--)//b 에 입력받은 a (층수) 대입 ; b는 점점 줄어들어 1 과 같거나 클때만 동작
            {
                for(c = a; c > b; c--)//C 에 층수 대입 ; c 또한 점차 줄어들어 b보다 클때만 동작 이부분은 띄어쓰기
                {
                    Console.Write(" ");
                }
                for(c = 1; c <= b*2-1; c++)//별표 표시부분
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }  
            Console.ReadLine();//바로 꺼지기 방지용 코드 ^^;
        }
    }
}
