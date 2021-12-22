using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class Advertisiment
    {
        public Advertisiment(Car car, string name, double price, Status saleStatus, Bitmap image)
        {
            Car = car;
            Price = price;
            SaleStatus = saleStatus;
            CarImage = image;
        }
        public Car Car { get; set; }
        public double Price { get; set; }
        public Status SaleStatus { get; set; }
        public Bitmap CarImage { get; set; }
    }
    enum Status
    {
        OnSale,
        Sold
    }
}

