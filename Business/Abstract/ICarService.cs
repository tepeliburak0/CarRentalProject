using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
   public interface ICarService
   {
       IResult Add(Car car);
       IResult Delete(Car car);
       IResult Update(Car car);
       IDataResult<List<Car>> GetAll();
       IDataResult<List<Car>> GetCarsByBrandId(int brandId);
       IDataResult<List<Car>> GetCarsByColorId(int colorId);

       IDataResult<List<CarDetailDto>> GetCarDetail();
   }
}
