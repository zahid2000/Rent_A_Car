using Core.DataAccess;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICarImageDal:IEntityRepository<CarImage>
    {
        bool IsExists(int id);
        List<CarImageDto> GetCarImagesDetail(Expression<Func<CarImageDto, bool>> filter = null);

    }
}
