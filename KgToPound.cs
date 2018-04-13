using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KgToPound
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kg 를 pound 로 변환하는 프로그램 입니다.");
            double Kg = 2.20462262;
            Console.WriteLine("kg 를 입력해주세요 : ");
            double ReadKg = double.parse(Console.ReadLine());//kg 입력
            double Pound = Kg * readKg;// 파운드로 변환
            Console.WriteLine(Pound + "pound 입니다.");
        }
    }
}
