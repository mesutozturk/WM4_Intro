using System;
using System.Collections.Generic;

namespace MethodKullanimi2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref ve out
            int a = 5;
            RefMetod(ref a);
            Console.WriteLine(a);
            if (DonusturmeyiDene("123", out int cevap))
            {
                Console.WriteLine(cevap);
            }

            Tuple<bool, int> tuple = DonusturmeyiDene("32423");
            if (tuple.Item1)
            {
                Console.WriteLine(tuple.Item2);
            }
        }

        static Tuple<bool, int> DonusturmeyiDene(string ifade)
        {
            try
            {
                int sonuc = int.Parse(ifade);
                return new Tuple<bool, int>(true, sonuc);
            }
            catch
            {
                return new Tuple<bool, int>(false, 0);
            }
        }

        static bool DonusturmeyiDene(string ifade, out int sonuc)
        {
            try
            {
                sonuc = int.Parse(ifade);
                return true;
            }
            catch
            {
                sonuc = 0;
                return false;
            }
        }
        static void RefMetod(ref int a)
        {
            int b = 10;
            a = b;
            b = 20;
        }
    }
}
