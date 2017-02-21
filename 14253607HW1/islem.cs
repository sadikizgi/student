using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253607HW1
{
    class islem
    {
        int tavsan;
        int kaplumbaga;
        int tyol;
        int kyol;
       

        public islem (int tavsan = 1 , int kaplumbaga = 1 , int tyol = 1 , int kyol = 1 )
        {
            this.tavsan = tavsan;
            this.kaplumbaga = kaplumbaga;
            this.tyol = tyol;
            this.kyol = kyol;
            
        }

        public void sayiuret()
        {
            

            while (kyol != 70 | tyol != 70)
            {
////////////////////////////////////////////     KAPLUMBAĞA HAREKETLERİ BÖLÜMÜ ////////////////////////////////////
                Random rastgele = new Random();
                kaplumbaga = rastgele.Next(1, 11);
                               
                if (5 >= kaplumbaga & kaplumbaga >= 1)       // hızlı yürüyüş
                {
                    kyol += 3;
                    for (int i = 0; i < 70; i++)
                    {
                        if (i == kyol)
                        {
                            Console.Write("K");
                        }
                        Console.Write("-");
                    }
                    Console.WriteLine();
                    if (kyol == tyol)
                    {
                        Console.WriteLine("OUCH");
                    }
                }
                
                else if (6 <= kaplumbaga & kaplumbaga <= 7)  // kayma 
                {
                    kyol -= 6;
                    if(kyol <= 0)
                    {
                        kyol = 1;
                    }
                    for (int i = 0; i < 70; i++)
                    {
                        if (i == kyol)
                        {
                            Console.Write("K");
                        }
                        Console.Write("-");

                    }
                    Console.WriteLine();
                    if (kyol == tyol)
                    {
                        Console.WriteLine("OUCH");
                    }
                }
                


                else if (10 >= kaplumbaga & kaplumbaga >= 8)  // yavaş yürüyüş
                {
                     kyol += 1;
                    for (int i = 0; i < 70; i++)
                    {
                        if (i == kyol)
                        {
                            Console.Write("K");
                        }
                        Console.Write("-");

                    }
                    Console.WriteLine();
                    if (kyol == tyol)
                    {
                        Console.WriteLine("OUCH");
                    }
                }

               


///////////////////////////////////     TAVŞAN HAREKETLERİ BÖLÜMÜ ////////////////////////////////////////////////

                tavsan = rastgele.Next(1, 10);

                if (2 >= tavsan & tavsan >= 1)           // Hareketsiz
                {
                     tyol += 0;
                    for (int i = 0; i < 70; i++)
                    {
                        if (i == tyol)
                        {
                            Console.Write("T");
                        }
                        Console.Write("-");

                    }
                    Console.WriteLine();
                    if (kyol == tyol)
                    {
                        Console.WriteLine("OUCH");
                    }
                }
                



                else if (4 >= tavsan & tavsan >= 3)   // büyük sıçrama
                {
                     tyol += 9;
                    for (int i = 0; i < 70; i++)
                    {
                        if (i == tyol)
                        {
                            Console.Write("T");
                        }
                        Console.Write("-");

                    }
                    Console.WriteLine();
                    if (kyol == tyol)
                    {
                        Console.WriteLine("OUCH");
                    }

                }
                



                else if (5 == tavsan)                  // büyük kayma
                {
                     tyol -= 12;                       
                    if (tyol <= 0)
                    {
                        tyol = 1;
                    }
                    for (int i = 0; i < 70; i++)
                    {
                        if (i == tyol)
                        {
                            Console.Write("T");
                        }
                        Console.Write("-");

                    }
                    Console.WriteLine();
                    if (kyol == tyol)
                    {
                        Console.WriteLine("OUCH");
                    }
                }
                




                else if (8 >= tavsan & tavsan >= 6)   //küçük sıçrama 
                {
                     tyol += 1;
                    for (int i = 0; i < 70; i++)
                    {
                        if (i == tyol)
                        {
                            Console.Write("T");
                        }
                        Console.Write("-");

                    }
                    Console.WriteLine();
                    if (kyol == tyol)
                    {
                        Console.WriteLine("OUCH");
                    }

                }
                



                else if (10 >= tavsan & tavsan >= 9)    //küçük kayma
                {
                     tyol -= 2;                   
                    if (tyol <= 0 )
                    {
                        tyol = 1;
                    }
                    for (int i = 0; i < 70; i++)
                    {
                        if (i == tyol)
                        {
                            Console.Write("T");
                        }
                        Console.Write("-");

                    }
                    Console.WriteLine();
                    if (kyol == tyol)
                    {
                        Console.WriteLine("OUCH");
                    }
                }



                


               

/////////////////////////////     SONUÇLAR BÖLÜMÜ      ////////////////////////////////////


                if (kyol >= 70 & tyol >= 70)
                {
                    Console.WriteLine();
                    Console.WriteLine("BERABERE");
                    break;
                }

               else if (kyol >= 70)
                {
                    Console.WriteLine();
                    Console.WriteLine("KAPLUMBAĞA KAZANDI !!! OLEYYYYYYYYYYYYYYYYYYY !!!!!");
                    break;
                }
                else if (tyol >= 70)
                {
                    Console.WriteLine();
                    Console.WriteLine("TAVŞAN KAZANDI !!! YUUUUUUUUHHHHHHHHHHHHH !!!!!");
                    break;
                }
                





            }           
        }
    }
}

