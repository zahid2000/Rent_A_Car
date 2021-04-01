using Core.DataAccess;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICarImageDal:IEntityRepository<CarImage>
    {
        bool IsExists(int id);
       

    }
}
