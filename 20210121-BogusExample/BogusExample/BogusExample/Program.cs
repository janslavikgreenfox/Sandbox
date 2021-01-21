using System;
using System.Text.Json;
using Bogus;

namespace BogusExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // To be deterministic, the Faker will generate everytime the same record 
            var fixedSeed = 42;
            Randomizer.Seed = new Random(fixedSeed);

            var orderFaker = new Faker<Order>()
                .RuleFor(x=>x.Id,x=>x.UniqueIndex)
                .RuleFor(x=>x.Title,x=>x.Commerce.ProductName())
                .RuleFor(x=>x.Identification, x=>x.Random.String())
                .RuleFor(x=>x.IssuingDate,x=>x.Date.Past())
                .RuleFor(x=>x.Address,x => x.Address.StreetAddress())
                .RuleFor(x=>x.TelephoneNumber,x=>x.Person.Phone)
                .RuleFor(x => x.Email, x => x.Person.Email);

            var generatedOrderFaker = orderFaker.Generate();

            var serializedFakeOrder = JsonSerializer.Serialize(generatedOrderFaker);

            Console.WriteLine(serializedFakeOrder);

            ;
        }

  
    }

    class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Identification { get; set; }
        public DateTime IssuingDate { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public string  Email { get; set; }

    }
}
