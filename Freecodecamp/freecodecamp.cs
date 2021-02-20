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
            PassPara("Saroj Shrestha",24);
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

    }
}