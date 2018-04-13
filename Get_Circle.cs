using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("원의 둘레와 넓이를 구하는 프로그램 입니다.\n반지름만 입력하시면 됩니다.");
            double pi = 3.14;//파이는 3.14
            Console.WriteLine("원의 반지름을 입력해주세요 : ");
            double Cricle_half_lenght = double.parse(Console.ReadLine()); //double 값 입력
            double Circle_Lenght = 2 * pi * Cricle_half_lenght;//원의 길이 구하기
            double Circle_area = Cricle_half_lenght * Cricle_half_lenght * pi;//원의 넓이 구하기

            Console.WriteLine("원의 둘레는 " + Circle_Lenght + "이며\n넓이는 " + Circle_area + " 입니다.");
        }
    }
}