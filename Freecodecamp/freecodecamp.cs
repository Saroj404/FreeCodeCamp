
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
            #region functions
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
            // Guess();
            //for_loop();
            //for_array();
            //Console.WriteLine("The output is: "+GetPow(4,2));   //this is exponent example
            // exp0f2darr();
            //exceptionhandling();
            //MyMethod(child1:"saroj",child2:"sanjay",child3:"sam");
            //MyMethod2("child2");

            /*int z = Overload(5, 6);                 //These are functions for overloading example
            double c = Overload(7, 8);                  
            Console.WriteLine("Int: " + z);        
            Console.WriteLine("Double: " + c);*/
            #endregion
            //Book();
            //BookConstr();
            Movie();
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

        static void for_loop()
        {
            int i = 1;
            for(i=1;i<=5;i++)
            {
                Console.WriteLine(i);
            }
        }
        
        static void for_array()
        {
            int i;
            int[] arrnum = { 1, 4, 5, 2, 6, 8, 10 };
            for(i=0;i<arrnum.Length;i++)
            {
                Console.WriteLine(arrnum[i]);
            }
        }

        static int GetPow(int Basenum,int Pownum)
        {
            int result = 1;
            for(int i=0;i<Pownum;i++)
            {
                result = result *Basenum;
            }
            return result;
            
        }

        static void exp0f2darr()
        {
            int[,] number =
            {
                {1,2 },
            { 2,2},
            {3,3 }
            };
            Console.WriteLine(number[2, 1]);

           /* int[,,] numg = new int[3,3,3];
            foreach(int i in numg[])
            {

            }*/

        }

        static void exceptionhandling()

        {
                Console.WriteLine("Simple Dividor");
            bool cont = true;

            try
            {
                while (cont)
                {
                    Console.Write("Enter first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double div = num1 / num2;
                    Console.WriteLine(div);
                    Console.WriteLine("Press \"1\" to continue || \"2\" to exit");
                    int i = Convert.ToInt32(Console.ReadLine());
                    if (i == 1)
                    {
                        cont = true;
                    }

                    else if (i == 2)
                    {
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option");
                    }

                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                exceptionhandling();
            }


        }

        static void MyMethod(string child1,string child2,string child3)
        {
            Console.WriteLine("The first child is "+child2+" The second child is "+child1+" The third child is "+child3);
        }

        static void MyMethod2(string child1="saroj", string child2="sanjay", string child3="sam")
        {
            Console.WriteLine("The first child is " + child2);
        }

        static int Overload(int x,int y)
        {
            return x + y;
        }
        static double Overload(double x, double y)
        {
            return x + y;
        }

        static void Book()
        {
            book book1 = new book();
            book1.title = "Game of Thrones";
            book1.author = "JJ Martin";
            book1.pages = 1000;
                                                                        //book.cs class
            book book2 = new book();
            book2.title = "Lacasa De Papel";
            book2.author = "Loronzo Rodriguez";
            book2.pages = 700;

            Console.WriteLine("i love both " + book1.title + " & " + book2.title);


        }

        static void BookConstr()
        {

            BookConstr book1 = new BookConstr("Game of Thrones", "JJ Martin",1000);
            BookConstr book2 = new BookConstr("Lacasa De Papel", "Loronzo Rodriguez",700);

            Console.WriteLine(" i love both " + book1.title +" && "+book2.title);
        }

        static void Movie()
        {
            Movie Marvel = new Movie("Avengers", "Saroj", "PG-13");
            Movie Shrek = new Movie("Shrek5", "Sanjay", "Damn");

            Console.WriteLine(Shrek.Rating);

        }

    }
}