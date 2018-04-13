using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFtoSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("학년을 입력하세요 : ");
            int level = int.Parse(Console.ReadLine());//학년 입력 받기

            switch(level)
            {
                case 1://1학년일때
                    Console.WriteLine("수강해야 하는 전공 학점: 12학점");
                    break;
                case 2://2학년일때
                    Console.WriteLine("수강해야 하는 전공 학점: 18학점");
                    break;
                case 3://3학년일때
                    Console.WriteLine("수강해야 하는 전공 학점: 10학점");
                    break;
                case 4://4학년일때
                    Console.WriteLine("수강해야 하는 전공 학점: 18학점");
                    break;
                default://그 외의 수 (장난식)
                    Console.WriteLine("미래의 의사 응원합니다.");
                    break;
            }
        }
    }
}
