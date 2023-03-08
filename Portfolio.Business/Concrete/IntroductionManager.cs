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
    public class IntroductionManager : IIntroductionService
    {
        IIntroductionDal _introductionDal;

        public IntroductionManager(IIntroductionDal introductionDal)
        {
            _introductionDal = introductionDal;
        }

        public void TAdd(Introduction entity)
        {
            _introductionDal.Insert(entity);
        }

        public void TDelete(Introduction entity)
        {
            _introductionDal.Delete(entity);
        }

        public Introduction TGetByID(int id)
        {
            return _introductionDal.GetByID(id);
        }

        public List<Introduction> TGetList()
        {
            return _introductionDal.GetList();
        }

        public void TUpdate(Introduction entity)
        {
            _introductionDal.Update(entity);
        }
    }
}
