﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
  public  interface IRentalService
  {
      IDataResult<List<Rental>> GetAll();
      IDataResult<Rental> GetById(int id);
      IDataResult<List<RentalDetailDto>> GetRentalDetailsDto(int carId);
        IResult Add(Rental rental);
      IResult Delete(Rental rental);
      IResult Update(Rental rental);
      IResult CheckReturnDate(int carId);
      IResult UpdateReturnDate(int carId);
  }
}
