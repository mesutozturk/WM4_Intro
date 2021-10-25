using System;

namespace BomOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bom oyunu
            int bomSayisi = 5, sinir = 100;
            do//1 oyunluk döngü
            {
                do
                {
                    try
                    {
                        Console.Write("BOM oyunu için 1-50 bir sayı giriniz ");
                        bomSayisi = int.Parse(Console.ReadLine());
                        if (bomSayisi < 1 || bomSayisi > 50)
                            throw new Exception("1 - 50 arası bir sayı girmediniz");
                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Lütfen bir sayı giriniz");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    } // dışarıdan uygun sayıyı almak
                } while (true);
                for (int i = 1; i <= sinir; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write("Bilgisayar: ");
                        if (i % bomSayisi == 0)
                            Console.WriteLine("BOM");
                        else
                            Console.WriteLine(i);
                    } //bilgisayarın sırasını ayarlamak
                    else
                    {
                        Console.Write("Kullanıcı: ");
                        string giris = Console.ReadLine();
                        if (i % bomSayisi == 0)
                        {
                            if (giris.ToLower() != "bom")
                            {
                                Console.WriteLine("Kaybettiniz");
                                break;
                            }
                        } //bom girilmesi gerektiğini zaman
                        else
                        {
                            try
                            {
                                int girisSayi = int.Parse(giris);
                                if (girisSayi != i)
                                {
                                    Console.WriteLine("KAYBETTİNİZ");
                                    break;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Yanlış bir giriş yaptınız");
                                Console.WriteLine("KAYBETTİNİZ");
                                break;
                            }
                        } //sayı girilmesi gerektiği zaman
                    }//kullanıcının sırasını ayarlamak

                    if (i == sinir)
                        Console.WriteLine("Tebrikler berabere kaldınız.");
                }

                Console.WriteLine("Tekrar oynamak içi E tuşuna basınız");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key != ConsoleKey.E) 
                    break; 
            } while (true);
        }
    }
}
