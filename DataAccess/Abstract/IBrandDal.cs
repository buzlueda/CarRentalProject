using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.DataAccess;


namespace DataAccess.Abstract
{
    public interface IBrandDal : IEntityRepository<Brand>
    {
        
    }
}