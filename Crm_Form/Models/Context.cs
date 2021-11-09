using System.Collections.Generic;

namespace Crm_Form.Models
{
    public class Context
    {
        public Context()
        {
            for (int i = 0; i < 500; i++)
            {
                Kisiler.Add(new Kisi()
                {
                    Ad = Faker.NameFaker.FirstName(),
                    Soyad = Faker.NameFaker.LastName(),
                    DogumTarihi = Faker.DateTimeFaker.BirthDay(),
                    Falan = Faker.NumberFaker.Number(1000, 9999)
                });
            }
        }
        public List<Kisi> Kisiler { get; set; } = new List<Kisi>();
    }
}
