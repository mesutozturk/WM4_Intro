using System;

namespace DiziSekiller
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] matris = null;
            try
            {
                Console.Write("Lütfen Boyutu Girin: ");
                int girilenBoyut = int.Parse(Console.ReadLine());
                matris = new bool[girilenBoyut, 2 * girilenBoyut - 1];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            for (int satir = 0; satir < matris.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < matris.GetLength(1); sutun++)
                {
                    if ((satir + sutun >= matris.GetLength(0) - 1  && sutun - satir <= matris.GetLength(0) -1 ))
                    {
                        matris[satir, sutun] = true;
                    }
                }
            
            }

            //ekrana yazdır

            for (int satir = 0; satir < matris.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < matris.GetLength(1); sutun++)
                {
                    Console.Write(matris[satir, sutun] ? "X" : " ");
                }
                Console.WriteLine();
            }

            //Console.Write("Uzunluk : ");
            //int kenarUzunlugu = Convert.ToInt32(Console.ReadLine());
            //int ortaNokta = kenarUzunlugu - 1;
            //int taban = kenarUzunlugu * 2 - 1;
            //for (int i = 0; i < kenarUzunlugu; i++)
            //{
            //    for (int k = 0; k < taban; k++)
            //    {
            //        if ((i + k >= ortaNokta && k - i <= ortaNokta))
            //        {
            //            Console.Write("*");
            //        }
            //        else if (i == ortaNokta)
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");

            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
        }
    }
}
