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
                matris = new bool[girilenBoyut, girilenBoyut];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (int satir = 0; satir < matris.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < matris.GetLength(1); sutun++)
                {
                    if (satir == 0 || sutun == 0 | satir == matris.GetLength(0) - 1 ||
                        sutun == matris.GetLength(1) - 1)
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
                    if (matris[satir, sutun])
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
