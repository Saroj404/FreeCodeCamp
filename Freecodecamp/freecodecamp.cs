//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Freecodecamp
//{
//    class Codecamp
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Enter color");
//            string color=Console.ReadLine();
//            Console.WriteLine("Enter noun");
//            string noun = Console.ReadLine();
//            Console.WriteLine("Enter celebrity name");
//            string celeb = Console.ReadLine();
//            Console.WriteLine("Roses are "+color);
//            Console.WriteLine(noun+" are blue");
//            Console.WriteLine("i love "+celeb);
//            Console.ReadLine();
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freecodecamp
{
    class Codecamp
    {
        static void Main(string[] args)
        {
            // Array();
            //SayHi();
            //PassPara("Saroj Shrestha",24);

            //Console.WriteLine(Cube(5));
            //ifexp();
            //Console.WriteLine(GetMax(6,9));

            /*int num1, num2, num3;
            Console.Write("Enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());    These are for same
            Console.Write("Enter third number:");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetMaxx(num1,num2,num3));*/
            
            
            Console.ReadLine();
            }

        static void Array()
        {
            string[] friends = new string[5];
            friends[0] = "Saroj";
            friends[1] = "sanjay";
            Console.WriteLine(friends[1]);
            Console.ReadLine();
            //These are array examples.
        }

        static void SayHi()
        {
            Console.WriteLine("Hello");
        }

        static void PassPara(string name,int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age+" years old");
        }
        static int Cube(int num)
        {
            int cube = num * num * num;
            return cube;
        }

        static void ifexp()
        {
            bool isMale = true;
            bool isTall = false;
            if(isMale && isTall)
            {
                Console.WriteLine("You are tall male");
            }
            else if(isMale && !isTall)
            {
                Console.WriteLine("You are short male");
            }
            else if(!isMale && isTall)
            {
                Console.WriteLine("You are tall female");

            }
            else
            {
                Console.WriteLine("You are short female");
            }
        }

        static int GetMax(int num1,int num2)
        {
            int result;
            if(num1>=num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            
            return result;
        }

        static int GetMaxx(int num1,int num2,int num3)
        {
            int Maxx;
            
            if (num1>=num2 && num1>=num3)
            {
                Maxx = num1;
            }
            else if (num2 > =num1 && num2 >= num3)
            {
                Maxx = num2;
            }
            
            else
            {
                Maxx = num3;
            }

            return Maxx;
        }


    }
}