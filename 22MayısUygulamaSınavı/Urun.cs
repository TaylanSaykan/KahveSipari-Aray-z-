using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22MayısUygulamaSınavı
{
    public interface IProduct
    {
        string Name { get; set; }
        int PreparationTime { get; set; }
        double SatisfactionRate { get; set; }

        void Prepare();
    }

    public enum ProductType
    {
        Coffee,
        Beverage,
        Food
    }

    public class Product : IProduct
    {
        public string Name { get; set; }
        public int PreparationTime { get; set; }
        public double SatisfactionRate { get; set; }
        public ProductType Type { get; set; }

        public Product(string name, int preparationTime, double satisfactionRate, ProductType type)
        {
            Name = name;
            PreparationTime = preparationTime;
            SatisfactionRate = satisfactionRate;
            Type = type;
        }

        public void Prepare()
        {
            // Ürünün hazırlanma işlemleri
            Console.WriteLine($"{Name} hazırlanıyor...");
            // Hazırlık süresine göre beklemeler, karıştırmalar, vb. işlemler
            Console.WriteLine($"{Name} hazır!");
        }
    }

}

