using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarRentalContext>, IColorDal
    {
      
    }
}
