using Business.Concrete;
using System;
using System.Collections.Generic;
using DataAccess.Concrete.EntitiyFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarAdd();
            //ColorAdd();
            // BrandAdd();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetail().Data)
            {
                Console.WriteLine(car.DailyPrice + car.BrandName + car.ColorName + car.CarName);
            }
        }

        private static void ColorAdd()
        {
            Color color = new Color
            {
                Name = "Pembe"
            };
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(color);
        }

        private static void BrandAdd()
        {
            Brand brand = new Brand
            {
                Name = "Vosvogen"
            };
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(brand);
        }

        private static void CarAdd()
        {
            Car car = new Car
            {
                BrandId = 1,
                DailyPrice = 100,
                CarName = "Vosvos",
                ColorId = 1,
                ModelYear = "1199",
                Description = "asdasd",
                Id = 4
            };

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.GetCarsByColorId(1);
        }
    }
}
