using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCarDal :EfEntityRepositoryBase<Car,CarRentalContext>,ICarDal
    {
       public List<CarDetailDto>GetCarDetails()
       {
           using (CarRentalContext context = new CarRentalContext())
           {
               var result = from car in context.Cars
                   join brand in context.Brands
                       on car.BrandId equals brand.Id
                   from carcolor in context.Cars
                   join color in context.Colors
                       on carcolor.ColorId equals color.Id
                   select new CarDetailDto
                   {
                       DailyPrice = car.DailyPrice, BrandName = brand.Name, CarName = car.CarName,
                       ColorName = color.Name
                   };

               return result.ToList();
           }
       }
    }
}
