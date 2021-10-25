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

            int x = matris.GetLength(0);
            int y = matris.GetLength(1);
            for (int satir = x - 1; satir >= 0; satir--)
            {
                for (int sutun = 0; sutun < y; sutun++)
                {
                    matris[satir, sutun] = true;
                    int boslukSayisi = (x - 1 - satir) * 2;

                    int bosluk2 = boslukSayisi / 2;
                    if (bosluk2 == 0) continue;
                    for (int i = 0; i < bosluk2; i++)
                    {
                        matris[satir, i] = false;
                    }

                    for (int i = y - 1; i > y - 1 - bosluk2; i--)
                    {
                        matris[satir, i] = false;
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
        }
    }
}
