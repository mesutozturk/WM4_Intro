using System;

namespace AdresDefteri
{
    class Kisi
    {
        //Access Modifiers - erişim belirleyici
        /*
         * public
         * private
         * internal
         * *protected
         * *internal protected 
         */

        //Fields

        private string _ad;
        private string _soyad;

        //encapsulation

        public string Ad
        {
            set // value 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new FormatException("Kişinin adı boş geçilemez");
                }

                foreach (char harf in value)
                {
                    if (char.IsDigit(harf))
                        throw new Exception("Kişinin adı rakam bulunumaz");
                    if (char.IsSymbol(harf) || char.IsControl(harf) || char.IsPunctuation(harf))
                        throw new Exception("Kişinin adı geçersiz karakter bulunmaktadır.");
                }

                if (value.Length > 50)
                    throw new Exception("Girilen ifade 50 karakterden fazla olamaz");
                _ad = value;
            }
            get //return
            {
                return _ad.Substring(0, 1).ToUpper() + _ad.Substring(1).ToLower();
            }
        }

        public string Soyad
        {
            get
            {
                return _soyad.Substring(0, 1).ToUpper() + _soyad.Substring(1).ToLower(); ;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new FormatException("Kişinin soyadı boş geçilemez");
                }

                foreach (char harf in value)
                {
                    if (char.IsDigit(harf))
                        throw new Exception("Kişinin soyadında rakam bulunumaz");
                    if (char.IsSymbol(harf) || char.IsControl(harf) || char.IsPunctuation(harf))
                        throw new Exception("Kişinin soyadında geçersiz karakter bulunmaktadır.");
                }

                if (value.Length > 50)
                    throw new Exception("Girilen ifade 50 karakterden fazla olamaz");

                _soyad = value;
            }
        }

    }
    interface IKisi { }

    enum KisiTipleri
    {

    }
}
