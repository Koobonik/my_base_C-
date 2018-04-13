using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_season
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("달을 입력해주세요 : ");
            int season = int.Parse(Console.ReadLine()); //달 입력 받기
            switch(season)
            {
                case 12://겨울은 12월 ~ 2월
                case 1:
                case 2:
                    Console.WriteLine("겨울 입니다.");
                    break;
                case 3://봄은 3월 ~  5월
                case 4:
                case 5:
                    Console.WriteLine("봄 입니다.");
                    break;
                case 6://여름은 6월 ~ 8월
                case 7:
                case 8:
                    Console.WriteLine("여름 입니다.");
                    break;
                case 9://가을은 9월 ~ 11월
                case 10:
                case 11:
                    Console.WriteLine("가을 입니다.");
                    break;
                default:
                    Console.WriteLine("다시 입력해주세요.");
                    break;
            }
        }
    }
}
