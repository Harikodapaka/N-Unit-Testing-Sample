using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_QA
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
        }
        public void Go()
        {
            string type;
            Console.WriteLine("1. Create default (1*1) rectangle");
            Console.WriteLine("2. Create Custom rectangle");
            do
            {
                Console.Write("Enter Your choise: ");
                type = Console.ReadLine();
            } while (!IsvalidType(type));
            Rectangle rectangle = CreateReactangle(type);
            Console.WriteLine("Your Rectangle is {0} * {1} Units", rectangle.GetLength(), rectangle.GetWidth());
            string action;
            do
            {
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Set Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Set Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");
                Console.Write("Enter action:");
                action = Console.ReadLine();
                if (action != "7" && IsValidAction(action))
                {
                    PerformAction(action, rectangle);
                }
                 
            } while (action != "7");
             
            Console.WriteLine("Program Exicution Completed, Press any key to Exit");
            Console.ReadKey();
        }

        private void PerformAction(string action, Rectangle rectangle)
        {
                switch (action)
                {
                    case "1":
                        Console.WriteLine("Length of the Rectangle is: {0}", rectangle.GetLength());
                        break;
                    case "2":
                        string length;
                        do
                        {
                            Console.Write("Enter New Length:");
                            length = Console.ReadLine();
                        } while (!IsValidNumber(length));
                        Console.WriteLine("New Rectangle Units are: {0} * {1}", rectangle.SetLength(int.Parse(length)),rectangle.GetWidth());
                        break;
                    case "3":
                        Console.WriteLine("Width of the Rectangle is: {0}", rectangle.GetWidth());
                        break;
                    case "4":
                        string width;
                        do
                        {
                            Console.Write("Enter New Width:");
                            width = Console.ReadLine();
                        } while (!IsValidNumber(width));
                        Console.WriteLine("New Rectangle Units are: {0} * {1}", rectangle.GetLength(), rectangle.SetWidth(int.Parse(width)));
                        break;
                    case "5":
                        Console.WriteLine("Perimeter of the Rectangle is: {0}", rectangle.GetPerimeter());
                        break;
                    case "6":
                        Console.WriteLine("Area of the Rectangle is: {0}", rectangle.GetArea());
                        break;
                    default:
                        break;
                }
        }

        private bool IsValidAction(string action)
        {
            bool result = int.TryParse(action, out int n);
            if (!result)
            {
                Console.WriteLine("This is not a valid input, Please try again!!");
                return false;
            }
            else if (n < 1 || n > 7)
            {
                Console.WriteLine("Invalid option!!");
                return false;
            }
            return true;
        }

        private Rectangle CreateReactangle(string type)
        {
            if (type == "1")
            {
                return new Rectangle();
            }
            else
            {
                string length;
                do
                {
                    Console.Write("Enter Rectangle Length:");
                    length = Console.ReadLine();
                } while (!IsValidNumber(length));
                string width;
                do
                {
                    Console.Write("Enter Rectangle Width:");
                    width = Console.ReadLine();
                } while (!IsValidNumber(width));
                return new Rectangle(int.Parse(length), int.Parse(width));
            }
        }

        public bool IsValidNumber(string num)
        {
            bool res =  int.TryParse(num, out int n);
            if (!res || n <= 0)
            {
                Console.WriteLine("Invalid input, please enter number ( > 0) only..");
                return false;
            }
            return res;
        }
        public bool IsvalidType(string num)
        {
            bool result =  int.TryParse(num, out int n);
            if (!result)
            {
                Console.WriteLine("This is not a valid input, Please try again!!");
                return false;
            }else if (n < 1 || n > 2)
            {
                Console.WriteLine("Invalid option!!");
                return false;
            }
            return true;
        }
    }
}
