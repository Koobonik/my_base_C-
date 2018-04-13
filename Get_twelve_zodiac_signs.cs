using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_twelve_zodiac_signs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("몇 년도에 태어나셨나요? : ");
            String S_Born_year = Console.ReadLine();
            int Born_year = int.parse(Console.ReadLine());
            int get_signs = Born_year % 12;//입력받은 년도를 12로 나누어서 나머지를 이용해 띠를 구한다.
            switch(get_signs) 
            {
                case 0:
                    Console.WriteLine("원숭이 띠 입니다.");
                    break;
                case 1:
                    Console.WriteLine("닭 띠 입니다.");
                    break;
                case 2:
                    Console.WriteLine("개 띠 입니다.");
                    break;
                case 3:
                    Console.WriteLine("돼지 띠 입니다.");
                    break;
                case 4:
                    Console.WriteLine("쥐 띠 입니다.");
                    break;
                case 5:
                    Console.WriteLine("소 띠 입니다.");
                    break;
                case 6:
                    Console.WriteLine("범 띠 입니다.");
                    break;
                case 7:
                    Console.WriteLine("토끼 띠 입니다.");
                    break;
                case 8:
                    Console.WriteLine("용 띠 입니다.");
                    break;
                case 9:
                    Console.WriteLine("뱀 띠 입니다.");
                    break;
                case 10:
                    Console.WriteLine("말 띠 입니다.");
                    break;
                case 11:
                    Console.WriteLine("양 띠 입니다.");
                    break;
                default:
                    Console.WriteLine("다시 입력해주세요.");
                    break;
            }
        }
    }
}
