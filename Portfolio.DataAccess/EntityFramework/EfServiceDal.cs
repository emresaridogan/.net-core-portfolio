using Portfolio.DataAccess.Abstract;
using Portfolio.DataAccess.Repository;
using Portfolio.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.DataAccess.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
    }
}
