using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchToCenti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inch 를 cm 로 변환하는 프로그램 입니다.");
            double Inch = 2.54;//1 inch = 2.54cm
            Console.WriteLine("inch 를 입력해주세요 : ");
            double readInch = double.parse(Console.ReadLine());//inch 입력
            double Centi = readInch * Inch;//센티로 변환
            Console.WriteLine(Centi + "cm 입니다.");
        }
    }
}
