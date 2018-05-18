using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_calcolator
{
    class Program
    {
        static void Main(string[] args)
        {
        
            //variables :
            
            double number1;
            double number2;
            string operater;
            double theresult = 0;
            int choice;
            string fontcolorchoice;
            string backgroungcolorchoice;
         

            //cammands :
            Console.Title = ("Basic calcolator  : V. 1.0 Alpha ");
            Console.WriteLine(" # welcome to the basic calcolator # v. 1.0 alpha ");
            Console.WriteLine(" ");

            Console.WriteLine("1- start. ");
            Console.WriteLine("2- open settings. ");
            Console.WriteLine("3- about the programme.");
            
            Console.WriteLine(" ");
            Console.WriteLine("what do you want to do :: ");
            choice = Convert.ToInt32(Console.ReadLine());
           

            if (choice == 1)
            {
                Console.Clear();
                Console.WriteLine("Enter number1 : ");
                number1 = int.Parse(Console.ReadLine());


                Console.WriteLine("choose the operater :: ");
                Console.WriteLine(" => + ");
                Console.WriteLine(" => - ");
                Console.WriteLine(" => / ");
                Console.WriteLine(" => X ");
                operater = Console.ReadLine();

                Console.WriteLine("Enter number2 : ");
                number2 = Convert.ToInt32(Console.ReadLine());

                if (operater == "+")
                {
                    theresult = number1 + number2;
                    Console.WriteLine("the eqaution : " + number1 + operater + number2 + "=" + theresult);
                }
                if (operater == "-")
                {
                    theresult = number1 - number2;
                    Console.WriteLine("the eqaution : " + number1 + operater + number2 + "=" + theresult);
                }
                if (operater == "/")
                {
                    theresult = number1 / number2;
                    Console.WriteLine("the eqaution : " + number1 + operater + number2 + "=" + theresult);
                }
                if (operater == "X")
                {
                    theresult = number1 * number2;
                    Console.WriteLine("the eqaution : " + number1 + operater + number2 + "=" + theresult);
                }


                Console.ReadKey();
            }
            if (choice == 2)
            {
                
                Console.Clear();
                Console.WriteLine("1- change font color.");
                Console.WriteLine("2- change background color.");
                Console.WriteLine("3- go back.");
                Console.WriteLine(" ");
                Console.WriteLine("choose what ou want to do :: ");
                choice = int.Parse(Console.ReadLine());
               

                if (choice == 1)
                {
                    Console.ReadKey();
                    Console.Clear();
                    
                    Console.WriteLine("black");
                    Console.WriteLine("red");
                    Console.WriteLine("yellow");
                    Console.WriteLine("green");
                    Console.WriteLine("blue");
                    Console.WriteLine("white");
                    Console.WriteLine(" ");
                    Console.WriteLine("choose the color of the font :: ");
                    fontcolorchoice = Console.ReadLine();
                    Console.ReadKey();

                    switch (fontcolorchoice)
                    {
                        case "black":
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "red":
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "yellow":
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "green":
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "blue":
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                reviewmainmenu();

                            }
                            break;

                        case "white":
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;
                    }
                    
                }
                if(choice == 2)
                {
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("black");
                    Console.WriteLine("red");
                    Console.WriteLine("yellow");
                    Console.WriteLine("green");
                    Console.WriteLine("blue");
                    Console.WriteLine("white");
                    Console.WriteLine(" ");
                    Console.WriteLine("choose the color of the background :: ");
                    backgroungcolorchoice = Console.ReadLine();
                    Console.ReadKey();

                    switch (backgroungcolorchoice)
                    {
                        case "black":
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "red":
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "yellow":
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "green":
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "blue":
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                reviewmainmenu();

                            }
                            break;

                        case "white":
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;
                    }
                }
                if(choice == 3)
                {
                    Console.Clear();
                    reviewmainmenu();
                }
            }
            if(choice == 3)
            {
                //Console.Clear();
                Console.WriteLine("this is a basic calcolator wroted in c# in the console.");
                Console.WriteLine("the creator :: ABDALLAH F. AFANDY ");
                Console.WriteLine("kind :: OPEN SOURCE PROJECT");
                Console.ReadKey();
                    
            }
            
         
            Console.ReadKey();

        }
        static void reviewmainmenu()
        {
            double number1;
            double number2;
            string operater;
            double theresult = 0;
            int choice;
            string fontcolorchoice;
            string backgroungcolorchoice;

            Console.Title = ("Basic calcolator  : V. 1.0 Alpha ");
            Console.WriteLine(" # welcome to the basic calcolator # v. 1.0 alpha ");
            Console.WriteLine(" ");

            Console.WriteLine("1- start. ");
            Console.WriteLine("2- open settings. ");
            Console.WriteLine("3- about the programme.");

            Console.WriteLine(" ");
            Console.WriteLine("what do you want to do :: ");
            choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {
                Console.Clear();
                Console.WriteLine("Enter number1 : ");
                number1 = int.Parse(Console.ReadLine());


                Console.WriteLine("choose the operater :: ");
                Console.WriteLine(" => + ");
                Console.WriteLine(" => - ");
                Console.WriteLine(" => / ");
                Console.WriteLine(" => X ");
                operater = Console.ReadLine();

                Console.WriteLine("Enter number2 : ");
                number2 = Convert.ToInt32(Console.ReadLine());

                if (operater == "+")
                {
                    theresult = number1 + number2;
                    Console.WriteLine("the eqaution : " + number1 + operater + number2 + "=" + theresult);
                }
                if (operater == "-")
                {
                    theresult = number1 - number2;
                    Console.WriteLine("the eqaution : " + number1 + operater + number2 + "=" + theresult);
                }
                if (operater == "/")
                {
                    theresult = number1 / number2;
                    Console.WriteLine("the eqaution : " + number1 + operater + number2 + "=" + theresult);
                }
                if (operater == "X")
                {
                    theresult = number1 * number2;
                    Console.WriteLine("the eqaution : " + number1 + operater + number2 + "=" + theresult);
                }


                Console.ReadKey();
            }
            if (choice == 2)
            {

                Console.Clear();
                Console.WriteLine("1- change font color.");
                Console.WriteLine("2- change background color.");
                Console.WriteLine("3- go back.");
                Console.WriteLine(" ");
                Console.WriteLine("choose what ou want to do :: ");
                choice = int.Parse(Console.ReadLine());


                if (choice == 1)
                {
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("black");
                    Console.WriteLine("red");
                    Console.WriteLine("yellow");
                    Console.WriteLine("green");
                    Console.WriteLine("blue");
                    Console.WriteLine("white");
                    Console.WriteLine(" ");
                    Console.WriteLine("choose the color of the font :: ");
                    fontcolorchoice = Console.ReadLine();
                    Console.ReadKey();

                    switch (fontcolorchoice)
                    {
                        case "black":
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "red":
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "yellow":
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "green":
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "blue":
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "white":
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                reviewmainmenu();

                            }
                            break;
                    }

                }
                if (choice == 2)
                {
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("black");
                    Console.WriteLine("red");
                    Console.WriteLine("yellow");
                    Console.WriteLine("green");
                    Console.WriteLine("blue");
                    Console.WriteLine("white");
                    Console.WriteLine(" ");
                    Console.WriteLine("choose the color of the background :: ");
                    backgroungcolorchoice = Console.ReadLine();
                    Console.ReadKey();

                    switch (backgroungcolorchoice)
                    {
                        case "black":
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "red":
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "yellow":
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "green":
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;

                        case "blue":
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                reviewmainmenu();

                            }
                            break;

                        case "white":
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Clear();
                                reviewmainmenu();
                            }
                            break;
                    }
                }
                if (choice == 3)
                {
                    Console.Clear();
                    reviewmainmenu();
                }
            }
            if (choice == 3)
            {
                //Console.Clear();
                Console.WriteLine("this is a basic calcolator wroted in c# in the console.");
                Console.WriteLine("the creator :: ABDALLAH F. AFANDY ");
                Console.WriteLine("kind :: OPEN SOURCE PROJECT");
                Console.ReadKey();

            }


            Console.ReadKey();
        }
        
    }
}
