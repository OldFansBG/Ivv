using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivv
{
    public class Program
    {
        public static void Main()
        {
            List<Laptop> laptops = new List<Laptop>()
        {
            new Laptop("Laptop1", "LENOVO", "Model1", 2020),
            new Laptop("Laptop2", "DELL", "Model2", 2021),
            new Laptop("Laptop3", "ACER", "Model3", 2022),
            new Laptop("Laptop4", "HP", "Model4", 2023),
            new Laptop("Laptop5", "ASUS", "Model5", 2024)
        };

            // Изведете всички компютри в нисходящ ред годината на производство
            var orderedLaptops = laptops.OrderByDescending(l => l.YearProduce);
            foreach (var laptop in orderedLaptops)
            {
                Console.WriteLine(laptop);
            }

            // Изведете всички превозни средства, които са марка “LENOVO”, “DELL” или „ACER”
            var selectedBrands = new List<string> { "LENOVO", "DELL", "ACER" };
            var laptopsWithSelectedBrands = laptops.Where(l => selectedBrands.Contains(l.Brand));
            foreach (var laptop in laptopsWithSelectedBrands)
            {
                Console.WriteLine(laptop);
            }

            // Изведете тези лаптопи, които са произведени в периода между 2020-2024-тата година
            var laptopsProducedBetween2020And2024 = laptops.Where(l => l.YearProduce >= 2020 && l.YearProduce <= 2024);
            foreach (var laptop in laptopsProducedBetween2020And2024)
            {
                Console.WriteLine(laptop);
            }
        }
    }
}

