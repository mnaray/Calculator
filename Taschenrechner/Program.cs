using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            string wahl = "spacefiller";
            Console.WriteLine("Willkommen zum Rechner...");
            while (wahl.ToLower() != "exit") //Beendung des Programmes durch "exit"
            {
                Console.WriteLine("Geben Sie die erste Zahl ein:");
                int ersteZahl = 0;


                // prüft Korrektheit der ersten Eingabe bis korrekt
                bool inkorrekt = true;
                while (inkorrekt)
                {
                    try
                    {
                        ersteZahl = Int32.Parse(Console.ReadLine());
                        inkorrekt = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Bitte geben Sie nur natürliche Zahlen ein.");
                        Console.WriteLine("--------------------------------------------");
                    }
                }


                // Schleife mit "fehleingabenvariable" für prüfung der Korrektheit des Operators
                Console.WriteLine("Wählen Sie die Operation: \n + \n - \n * \n : \n x^2 \n % \n sin \n cos \n tan \n bin \n hex ");
                Console.WriteLine("--------------------------------------------");
                bool fehleingabe = false;
                do
                {
                    string operation = Console.ReadLine();
                    Console.WriteLine("--------------------------------------------");
                    int zweiteZahl = 0;

                    switch (operation)
                    {
                        case "+":
                        case "-":
                        case "*":
                        case ":":
                        case "%":
                            Console.WriteLine("Geben Sie die zweite Zahl ein:");
                            bool inkorrekt2 = true;
                            while (inkorrekt2)
                            {
                                try
                                {
                                    zweiteZahl = Int32.Parse(Console.ReadLine());
                                    inkorrekt2 = false;
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Bitte geben Sie nur natürliche Zahlen ein.");
                                    Console.WriteLine("--------------------------------------------");
                                }
                            }
                            break;
                        default:
                            break;
                    }

                    string resText = "Das Resultat ist: ";
                    switch (operation)
                    {
                        case "+":   // plus
                            Console.WriteLine(resText + additionOperation(ersteZahl, zweiteZahl));    // passen Sie das Programm so an das jede Operation funktioniert
                            break;
                        case "-":   // minus
                            Console.WriteLine(resText + subtraktionOperation(ersteZahl, zweiteZahl)); // erstellen Sie jede fehlende Funktion mit paramtern sofern nötig...
                            break;
                        case "*":   // mal
                            Console.WriteLine(resText + multiplikationOperation(ersteZahl, zweiteZahl));
                            break;
                        case ":":   // geteilt
                            Console.WriteLine(resText + divisionOperation(ersteZahl, zweiteZahl));
                            break;
                        case "x^2": // hoch 2 oder x * x
                            Console.WriteLine(resText + zweierPpotenzOperation(ersteZahl));
                            break;
                        case "%":   // Modulo
                            Console.WriteLine(resText + moduloOperation(ersteZahl, zweiteZahl));
                            break;
                        case "sin": // Sinus
                            Console.WriteLine(resText + sinusOperation(ersteZahl));
                            break;
                        case "cos": // Cosinus
                            Console.WriteLine(resText + cosinusOperation(ersteZahl));
                            break;
                        case "tan": // Tangens
                            Console.WriteLine(resText + tangensOperation(ersteZahl));
                            break;
                        case "bin": // Binär
                            Console.WriteLine(resText + binOperation(ersteZahl));
                            break;
                        case "hex": // Hexadezimal
                            Console.WriteLine(resText + hexOperation(ersteZahl));
                            break;
                        default:
                            Console.WriteLine("Ihre Eingabe entspricht keiner der Optionen.");
                            Console.WriteLine("Bitte versuchen Sie es noch einmal.");
                            fehleingabe = true;
                            break;
                    }
                } while (fehleingabe == true);

                Console.WriteLine("Drücken Sie eine beliebige Taste und Enter, um fortzufahren oder geben Sie 'exit' ein.");
                wahl = Console.ReadLine();
            }
        }


        // Funktionen ab hier
        public static double additionOperation(double summand1, double summand2)
        {
            return summand1 + summand2;
        }

        public static double subtraktionOperation(double subtrahend, double minuend)
        {
            return subtrahend - minuend;
        }

        public static double multiplikationOperation(double faktor1, double faktor2)
        {
            return faktor1 * faktor2;
        }

        public static double divisionOperation(double dividend, double divisor)
        {
            return dividend / divisor;
        }

        public static double zweierPpotenzOperation(double basis)
        {
            return basis * basis;
        }

        public static double moduloOperation(double dividend, double divisor)
        {
            return dividend % divisor;
        }

        public static double sinusOperation(double winkel)
        {
            return Math.Sin(winkel);
        }
        public static double cosinusOperation(double winkel)
        {
            return Math.Cos(winkel);
        }

        public static double tangensOperation(double winkel)
        {
            return Math.Tan(winkel);
        }

        public static string binOperation(int decimalZahl)
        {
            return Convert.ToString(decimalZahl, 2);
        }

        public static string hexOperation(int decimalZahl)
        {
            return Convert.ToString(decimalZahl, 16);
        }
    }
}
