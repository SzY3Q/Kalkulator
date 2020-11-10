using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFunctions;
//using System.Windows.Forms;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz opcje");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Kalkulator Prosty");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2. Kalkulator Naukowy");
            Console.ForegroundColor = ConsoleColor.White;
            int number = int.Parse(Console.ReadLine());

            if (number == 1 || number == 2)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Wybrałeś kalkulator prosty");
                        Console.WriteLine("Wybierz działanie: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("1. Dodawanie");
                        Console.WriteLine("2. Odejmowanie");
                        Console.WriteLine("3. Mnożenie");
                        Console.WriteLine("4. Dzielenie");
                        Console.ForegroundColor = ConsoleColor.White;
                        int option = int.Parse(Console.ReadLine());
                        if (option > 0 && option < 5)
                        {
                            switch (option)
                            {
                                case 1:
                                    Console.WriteLine("Wybrałeś dodawanie. Podaj a: ");
                                        float a_Addition = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj b: ");
                                    float b_Addition = float.Parse(Console.ReadLine());
                                    double Addition = Functions.Addition(a_Addition, b_Addition);
                                    Console.WriteLine("Wynik wynosi: "+Functions.Addition(a_Addition, b_Addition));

                                    break;
                                case 2:
                                    Console.WriteLine("Wybrałeś odejmowanie. Podaj a: ");
                                    float a_Subtraction = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj b: ");
                                    float b_Subtraction = float.Parse(Console.ReadLine());
                                    double Subtraction = Functions.Subtraction(a_Subtraction, b_Subtraction);
                                    Console.WriteLine("Wynik wynosi: " + Functions.Subtraction(a_Subtraction, b_Subtraction));
                                    break;
                                case 3:
                                    Console.WriteLine("Wybrałeś mnożenie. Podaj a: ");
                                    float a_Multiplication = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj b: ");
                                    float b_Multiplication = float.Parse(Console.ReadLine());
                                    double Multiplication = Functions.Multiplication(a_Multiplication, b_Multiplication);
                                    Console.WriteLine("Wynik wynosi: " + Functions.Multiplication(a_Multiplication, b_Multiplication));
                                    break;
                                case 4:
                                    Console.WriteLine("Wybrałeś dzielenie. Podaj a: ");
                                    float a_Division = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj b: ");
                                    float b_Division = float.Parse(Console.ReadLine());
                                    double Division = Functions.Division(a_Division, b_Division);
                                    Console.WriteLine("Wynik wynosi: " + Functions.Division(a_Division, b_Division));
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Kalkulator prosty nie posiada więcej funkcji");
                        }
                        break;
                    case 2:
                      //  richbox.Select(naukowy);
                       // richbox.SelectionColor = Color.Red;
                        Console.WriteLine("Wybrałeś kalkulator"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("naukowy") ;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Wybierz działanie: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("1. Delta");
                        Console.ForegroundColor = ConsoleColor.White;
                        int option_scientific = int.Parse(Console.ReadLine());
                        if (option_scientific > 0)
                        { 
                            switch (option_scientific)
                            { 
                                case 1:
                                Console.WriteLine("Wybrałeś deltę. Podaj a");
                                float a_Delta = float.Parse(Console.ReadLine());
                                Console.WriteLine("Podaj b");
                                float b_Delta = float.Parse(Console.ReadLine());
                                Console.WriteLine("Podaj c");
                                float c_Delta = float.Parse(Console.ReadLine());
                                Console.WriteLine("Delta wynosi: " + Functions.Delta(a_Delta, b_Delta, c_Delta));
                                    if (Functions.Delta(a_Delta, b_Delta, c_Delta) > 0)
                                    {
                                        Console.WriteLine("Miejsce zerowe X1 wynosi: " + (((b_Delta * -1)-(Math.Sqrt(Functions.Delta(a_Delta, b_Delta, c_Delta)))) / (2 * a_Delta)));
                                        Console.WriteLine("Miejsce zerowe X2 wynosi: " + (((b_Delta * -1) + (Math.Sqrt(Functions.Delta(a_Delta, b_Delta, c_Delta)))) / (2 * a_Delta)));


                                    }
                                    else if (Functions.Delta(a_Delta, b_Delta, c_Delta) == 0)
                                    {
                                        Console.WriteLine("Miejsce zerowe X0 wynosi: " + (b_Delta * -1)/(2 * a_Delta));
                                    }
                                    else
                                    {
                                        Console.WriteLine("Brak miejsc zerowych");
                                    }

                                break;
                            }

                        
                        }
                        else
                        {
                                Console.WriteLine("Nie ma takiej opcji");    
                        }


                        break;
                }
            }
            else
            {
                Console.WriteLine("Wybierz poprawny numer");
            }


        }
    }
}

