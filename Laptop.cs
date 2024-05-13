using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ivv
{
    public class Laptop
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int YearProduce { get; set; }

        public Laptop(string name, string brand, string model, int yearProduce)
        {
            Name = name;
            Brand = brand;
            Model = model;
            YearProduce = yearProduce;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Brand: {Brand}, Model: {Model}, Year Produced: {YearProduce}";
        }
    }



