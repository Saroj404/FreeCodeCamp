
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
            //Madlib();
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

            /* Console.Write("Enter day number:");
             int x = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Today is: "+GetDay(x));*/  //This is switch  example

            // While_Loop();
            //Mul2();
            Guess();
           
            Console.ReadLine();
            }

        static void Madlib()
        {
            Console.WriteLine("Enter color");
            string color = Console.ReadLine();
            Console.WriteLine("Enter noun");
            string noun = Console.ReadLine();
            Console.WriteLine("Enter celebrity name");
            string celeb = Console.ReadLine();
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(noun + " are blue");
            Console.WriteLine("i love " + celeb);
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
            else if (num2 >= num1 && num2 >= num3)
            {
                Maxx = num2;
            }
            
            else
            {
                Maxx = num3;
            }

            return Maxx;
        }

        static string GetDay(int num)
        {
            string Dayname;

            switch(num)
            {
                case 0:
                    Dayname = "Sunday";
                    break;
                case 1:
                    Dayname = "Monday";
                    break;
                case 2:
                    Dayname = "Tuesday";
                    break;
                case 3:
                    Dayname = "Wednesday";
                    break;
                default:

                    Dayname="Invalid number";
                    break;
            }
                
            return Dayname;
        }
        static void While_Loop()
        {
            int index = 1;
            while(index<=5)
            {
                Console.WriteLine(index);
                index++;
            }
            

            /*do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5); */


        }

        static void Mul2()
        {
            int index = 2;
            while(index <= 20)
            {

                if (index % 2 == 0)
                {
                    Console.WriteLine(index);
                }
                index++;

            } 
        }

        static void Guess()
        {
            Console.WriteLine("Hint: Its an animal");
            string secret = "cat";
            string guess="";
            int guesscount = 0;
            int guesslimit = 5;
            bool outofguesses = false;
            while(guess !=secret && outofguesses==false)  //!outofguesses and outofguesses=false is same
            {
                if (guesscount < guesslimit)
                {
                    Console.Write("Enter your guess:");
                    guess = Console.ReadLine();
                    guesscount++;
                }
                else
                {
                    outofguesses = true;
                }
            }
            if (!outofguesses)
            {
                Console.WriteLine("Congratulations! You guessed correctly.");
             }
            else
            {
                Console.WriteLine("Sorry! You lost the game.");
            }
            Console.ReadLine();
        }


        
    }
}