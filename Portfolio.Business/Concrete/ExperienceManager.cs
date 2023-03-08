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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TAdd(Experience entity)
        {
            _experienceDal.Insert(entity);
        }

        public void TDelete(Experience entity)
        {
            _experienceDal.Delete(entity);    
        }

        public Experience TGetByID(int id)
        {
            return _experienceDal.GetByID(id);
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.GetList();     
        }

        public void TUpdate(Experience entity)
        {
            _experienceDal.Update(entity);
        }
    }
}
