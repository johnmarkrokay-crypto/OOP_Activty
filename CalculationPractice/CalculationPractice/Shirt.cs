using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationPractice
{
    internal class Shirt
    {
        public double Price { get; set; }

        public double Discount { get; set; }

        public double Id { get; set; }

        public virtual double PriceDiscount
        {
            get { return Price - Discount; }
        }

        public virtual double IdDiscount
        {
            get { return PriceDiscount - Id; }
        }
    }

    class Jersey : Shirt
    {
        public override double PriceDiscount
        {
            get { return Price - Discount; }
        }


        public Jersey(double aPrice, double aDiscount, double aId)
        {
            Price = aPrice;
            Discount = aDiscount;
            Id = aId;
        }
    }

    class Sleeveless : Shirt
    {
        public override double PriceDiscount
        {
            get { return Price - Discount; }
        }
        public Sleeveless(double aPrice, double aDiscount, double aId)
        {
            Price = aPrice;
            Discount = aDiscount;
            Id = aId;
        }
    }
}
