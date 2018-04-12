using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        
        static void IntegerBasic()
        {
            Console.WriteLine("IntegerBasic");
            Console.WriteLine(1 + 2);
            Console.WriteLine(1 - 2);
            Console.WriteLine(1 * 2);
            Console.WriteLine(1 / 2);
            Console.WriteLine(1 % 2 + "\n");
        }
        static void RealNumberBasic()
        {
            Console.WriteLine("RealNumberBasic");
            Console.WriteLine(1.0 + 2.0);
            Console.WriteLine(1.0 - 2.0);
            Console.WriteLine(1.0 * 2.0);
            Console.WriteLine(1.0 / 2.0 + "\n");
        }
        static void CharacterBasic()
        {
            Console.WriteLine("CharacterBasic");
            Console.WriteLine('A');
            Console.WriteLine('가');
            Console.WriteLine("나\n");
        }
        static void EscapeCharacter()
        {
            Console.WriteLine("EscapeCharacter");
            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");
            Console.WriteLine("\"\"\"\n");
        }
        static void StringConnection()
        {
            Console.WriteLine("StringConnection");
            Console.WriteLine("가나다" + "라마" + "바사아\n");
        }
        static void StringSelectior()
        {
            Console.WriteLine("StringSelectior");
            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[1]);
            Console.WriteLine("안녕하세요"[3]);
        }
        static void BoolBasic()
        {
            Console.WriteLine("\nBoolBasic");
            Console.WriteLine(52 < 273);
            Console.WriteLine(52 > 273);
        }
        static void LogicalNot()
        {
            Console.WriteLine("\nLogicalNot");
            Console.WriteLine(!true);
            Console.WriteLine(!false);
            Console.WriteLine(!(52 < 273));
            Console.WriteLine(!(52 > 273));
        }
        static void LogicalOperator()
        {
            Console.WriteLine("\nLogicalOperator");
            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
            Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);
        }
        static void IntegerVariable()
        {
            int a = 273;
            int b = 52;
            Console.WriteLine("\nIntegerVariable");
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }
        static void OverFlow()
        {
            Console.WriteLine("\nOverFlow");
            int a = 2000000000;
            int b = 1000000000;
            Console.WriteLine(a + b);
        }
        static void RealNumberVariable()
        {
            double a = 52.273;
            double b = 103.32;
            Console.WriteLine("\nRealNumberVariable");
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }
        static void CharacterVariable()
        {
            Console.WriteLine("\nCharacterVariable");
            char a = 'a';
            Console.WriteLine(a);
        }
        static void StringVariable()
        {
            Console.WriteLine("\nStringVariable");
            string massage = "안녕하세요";

            Console.WriteLine(massage + "!");
            Console.WriteLine(massage[0]);
            Console.WriteLine(massage[1]);
            Console.WriteLine(massage[2]);

        }
        static void BoolVariable()
        {
            Console.WriteLine("\nBoolVariable");
            bool one = 10 < 0;
            bool other = 20 > 100;
            Console.WriteLine(one);
            Console.WriteLine(other);
        }
        static void AssignmentOperator()
        {
            Console.WriteLine("\nAssignmentOperator");
            int output = 0;
            output += 52;
            output += 273;
            output += 103;
            Console.WriteLine(output);
        }
        static void IncrementOperator()
        {
            Console.WriteLine("\nIncrementOperator");
            int number = 10;
            number++;
            Console.WriteLine(number);
            number--;
            Console.WriteLine(number);
        }
        static void IncrementOperatorPosition()
        {
            Console.WriteLine("\nIncrementOperatorPosition");
            //전위
            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(number++);
            Console.WriteLine(number--);
            Console.WriteLine(number);

            //후위
            //int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(++number);
            Console.WriteLine(--number);
            Console.WriteLine(number);
        }
        static void TypeCheck()
        {
            Console.WriteLine("\nTypeCheck");
            //변수 선언
            int _int = 273;
            long _long = 522731033265;
            float _float = 52.273F;
            double _double = 52.273;
            char _char = '글';
            string _string = "문자열";

            // 출력
            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());
        }
        static void DirectTypeCheck()
        {
            Console.WriteLine("\nDirectTypeCheck");
            Console.WriteLine((273).GetType());
            Console.WriteLine((522731033265L).GetType());
            Console.WriteLine((52.273F).GetType());
            Console.WriteLine((52.273).GetType());
            Console.WriteLine(('자').GetType());
            Console.WriteLine(("문자열").GetType());
        }
        static void Input()
        {
            Console.WriteLine("\nInput");
            string str = Console.ReadLine();
            Console.WriteLine("input : " + str);
        }
        static void ExplicitConversion()
        {
            Console.WriteLine("\nExplicitConversion");
            // log 자료형을 int 자료형으로 변환
            long longNumber = 2147483647L + 2147483647L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);
        }
        static void NumberLost()
        {
            Console.WriteLine("\nNumberLost");
            // long 자료형을 int 자료형으로 변환
            long longNumber = 2147483647L + 2147483647L;
            int intToint = (int)longNumber;
            Console.WriteLine(intToint);

            // double 자료형을 int 자료형으로 변환
            double doubleNumber = 52.27310332;
            int doubleToInt = (int)doubleNumber;
            Console.WriteLine(doubleToInt);
        }
        static void ImplicitConversion()
        {
            Console.WriteLine("\nImplicitConversion");
            // int 자료형의 숫자를 생성합니다.
            int intNumber = 2147483647;

            // int 자료형을 long 자료형으로 자동 변환
            long intToLong = intNumber;
            Console.WriteLine(intToLong);

            // int 자료형을 double 자료형으로 자동 변환
            double intToDouble = intNumber;
            Console.WriteLine(intToDouble);
        }
        static void StringTo()
        {
            Console.WriteLine("\nStringTo");
            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("273"));
            Console.WriteLine(float.Parse("52.273"));
            Console.WriteLine(double.Parse("103.32"));

            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(long.Parse("273").GetType());
            Console.WriteLine(float.Parse("52.273").GetType());
            Console.WriteLine(double.Parse("103.32").GetType());
        }
        static void  ToStringBasic()
        {
            Console.WriteLine("\nToStringBasic");
            Console.WriteLine((52).ToString());
            Console.WriteLine((52.273).ToString());
            Console.WriteLine(('a').ToString());
            Console.WriteLine((true).ToString());
            Console.WriteLine((false).ToString());

            Console.WriteLine((52).ToString().GetType());
            Console.WriteLine((52.273).ToString().GetType());
            Console.WriteLine(('a').ToString().GetType());
            Console.WriteLine((true).ToString().GetType());
            Console.WriteLine((false).ToString().GetType());
        }
        static void DoubleToString()
        {
            Console.WriteLine("\nDoubleToString");
            double number = 52.273103;
            Console.WriteLine(number.ToString("0.0"));
            Console.WriteLine(number.ToString("0.00"));
            Console.WriteLine(number.ToString("0.000"));
            Console.WriteLine(number.ToString("0.0000"));
        }
        static void StringPlusNumber()
        {
            Console.WriteLine("\nStringPlusNumber");
            Console.WriteLine(52 + 273);
            Console.WriteLine("52" + 273);
            Console.WriteLine(52 + "273");
            Console.WriteLine("52" + "273");
        }
        static void StringToBool()
        {
            Console.WriteLine("\nStringToBool");
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("False"));
            Console.WriteLine(bool.Parse("false"));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("input : Hello World!\n");

            IntegerBasic();
            RealNumberBasic();
            CharacterBasic();
            EscapeCharacter();
            StringConnection();
            StringSelectior();
            BoolBasic();
            LogicalNot();
            LogicalOperator();
            IntegerVariable();
            OverFlow();
            RealNumberVariable();
            CharacterVariable();
            StringVariable();
            BoolVariable();
            AssignmentOperator();
            IncrementOperator();
            IncrementOperatorPosition();
            TypeCheck();
            DirectTypeCheck();
            Input();
            ExplicitConversion();
            NumberLost();
            ImplicitConversion();
            StringTo();
            ToStringBasic();
            DoubleToString();
            StringPlusNumber();
            StringToBool();
            Console.ReadLine();
        }

    }
}
