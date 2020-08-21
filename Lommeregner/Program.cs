using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    class Program
    {
        static double taltjek()
        {

            
            double res = 0;
            bool truetjek = false;
            while (truetjek == false)
            {
                truetjek = double.TryParse(Console.ReadLine(), out res);
                if (truetjek == false)
                    Console.WriteLine("Hør her din lille lort det er en lommeregner ikke et work dokument så prøv lige igen");
                
            }

            return res;
        }
        static void Main(string[] args)
        {


            double resualtat; 

           
            
            string strøm = "tændt";
            while (strøm == "tændt")
            {
                Console.WriteLine(" McTonnies Lommeregener");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" Vælg en af føglende");
                Console.WriteLine(" 1) Plus");
                Console.WriteLine(" 2) Minus");
                Console.WriteLine(" 3) Gange");
                Console.WriteLine(" 4) Dividere");
                Console.WriteLine();
                Console.WriteLine(" 9) For at afslutte");
                resualtat = taltjek();
                if (resualtat == 9)
                {
                    strøm = "slukket";
                }
                else
                {
                    switch (resualtat)
                    {
                        case 1:
                            {
                                Console.WriteLine("Skriv det første tal...");
                                double plus1 = taltjek();

                                Console.WriteLine("Skriv det Andet tal...");
                                double plus2 = taltjek();

                                resualtat = plus1 + plus2;


                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Skriv det første tal...");
                                double minus1 = taltjek();

                                Console.WriteLine("Skriv det Andet tal...");
                                double minus2 = taltjek();

                                resualtat = minus1 - minus2;


                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Skriv det første tal...");
                                double gange1 = taltjek();

                                Console.WriteLine("Skriv det Andet tal...");
                                double gange2 = taltjek();

                                resualtat = gange1 * gange2;


                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Skriv det første tal...");
                                double dividere1 = taltjek();

                                Console.WriteLine("Skriv det Andet tal...");
                                double dividere2 = taltjek();

                                resualtat = dividere1 / dividere2;


                                break;
                            }


                        default:
                            {
                                Console.WriteLine("Input er ikke accepteret start forfra");
                                break;
                            }

                    }
                    Console.WriteLine("resualtatet er " + resualtat);
                    Console.Write("Tryk på en vilkårlig knap for at forsætte");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }
    }
}
