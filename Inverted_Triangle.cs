﻿using System;
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
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            for(b = a; b>=1; b--)//총층수
            {
                for(c = a; c >= b; c--)//띄어쓰기
                {
                    Console.Write(" ");
                }
                for(c = 1; c<=b*2-1; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
 