using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2__Satyam
{
    public class Program
    {
        //Display menu to the user
         int menuCreated()
            {
            int input;
            Console.WriteLine("----------------Menu------------------");
            Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");
            Console.WriteLine("--------------------------------");

            //asking user for input
            Console.Write("Enter number from 1 to 7 : ");
            input = Convert.ToInt32(Console.ReadLine());
            //return the input
            return input;
        }
        
        public static void Error()
        {
            Console.WriteLine("Invalid entry!");
        }

        //main loop
        static void Main(string[] args)
            {
           
                Rectangle rectangle = new Rectangle();
                Program program = new Program();
                int menu;


            initialMenu:
            try
            {
                //Taking the input from the user
                Console.Write("Enter length of Rectangle : ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter width of Rectangle : ");
            int width = Convert.ToInt32(Console.ReadLine());
            
                if (length > 0 && width > 0)
                {
                    do
                    {
                        menu = program.menuCreated();
                        Console.WriteLine("***************Output***************");
                        //entering the switch case
                        switch (menu)
                        {
                            
                            case 1:
                                Console.WriteLine("Length of Rectangle is : {0}", rectangle.GetLength());
                                break;
                            case 2:
                                Console.WriteLine("Enter new Rectangle length : ");
                                int newLength = Convert.ToInt32(Console.ReadLine());

                                //check for wrong input
                                if (newLength < 0)
                                {
                                    //calling the error func
                                    Error();
                                }
                                rectangle.SetLength(newLength);
                                break;
                            case 3:
                                Console.WriteLine("Width of Rectangle is : {0}", rectangle.GetWidth());
                                break;
                            case 4:
                                Console.WriteLine("Enter new Rectangle width : ");
                                int newWidth = Convert.ToInt32(Console.ReadLine());

                                //check for wrong input
                                if (newWidth < 0)
                                {
                                    //calling the error func
                                    Error();
                                }
                                rectangle.SetWidth(newWidth);
                                break;
                            case 5:
                                Console.WriteLine("Perimeter of Rectangle is : {0}", rectangle.GetPerimeter());
                                break;
                            case 6:
                                Console.WriteLine("Area of Rectangle is : {0}", rectangle.GetArea());
                                break;
                            case 7:
                                System.Environment.Exit(0);
                                break;
                        }
                        //Console.WriteLine("Press any key to continue");
                    } while (menu != 7); 
                   }
                else
                {
                    Console.WriteLine("Please enter correct input!");
                }
                Console.ReadLine();
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please enter correct input!",ex.Message);
            }
            goto initialMenu;
        }
    }
}
