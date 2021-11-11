using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UnitPrice { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{{ ID : {Id}, Name : {Name}, Price : {UnitPrice} }}");
            return stringBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            Product item = (Product)obj;
            if (item is null)
                return false;

            return this.Id.Equals(item.Id);
        }

        private static int _lastId = 1; 

        public static List<Product> CreateFakeDatas(int count)
        {
            Random random = new Random();
            List<Product> list = new List<Product>();
            for (int i = 1; i <= count; i++)
                list.Add(GetFakeProduct());
            return list;
        }

        public static Product GetFakeProduct()
        {
            var faker = new Faker<Product>("en");
            faker.RuleFor(x => x.Name, y => y.Commerce.ProductName());
            faker.RuleFor(x => x.UnitPrice, y => y.Commerce.Price());
            faker.RuleFor(x => x.Id, _lastId);
            _lastId++;
            return faker;
        }
    }
}
