using Portfolio.Business.Abstract;
using Portfolio.DataAccess.Abstract;
using Portfolio.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Business.Concrete
{
    public class PortfolyoManager : IPortfolyoService
    {
        IPortfolyoDal _portfolyoDal;
        public void TAdd(Portfolyo entity)
        {
            _portfolyoDal.Insert(entity);
        }

        public void TDelete(Portfolyo entity)
        {
            _portfolyoDal.Delete(entity);
        }

        public Portfolyo TGetByID(int id)
        {
            return _portfolyoDal.GetByID(id);
        }

        public List<Portfolyo> TGetList()
        {
            return _portfolyoDal.GetList();
        }

        public void TUpdate(Portfolyo entity)
        {
            _portfolyoDal.Update(entity);
        }
    }
}
