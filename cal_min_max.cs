using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4장_연습문제
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("숫자를 입력해주세요: ");
                num[i] = int.Parse(Console.ReadLine());//배열 num에 숫자 입력받기
            }
            int Max_num = num.Max();//최대값 구하는 메소드 사용
            int Min_num = num.Min();//최소값 구하는 메소드 사용
            Console.WriteLine("가장 큰 수는 : "+ Max_num + " 입니다.");
            Console.WriteLine("가장 작은 수는 : " + Min_num + " 입니다.");
           
        }
    }
}
