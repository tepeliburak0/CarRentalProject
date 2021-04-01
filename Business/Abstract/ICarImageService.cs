﻿using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
   public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> Get(int id);
        IResult Add(CarImage carImage, IFormFile file);
        IResult Update(CarImage carImage, IFormFile file);
        IResult Delete(CarImage carImage);
        IDataResult<List<CarImage>> GetImagesByCarId(int id);
        IResult TransactionalOperation(CarImage carImage, IFormFile file);
    }
}
