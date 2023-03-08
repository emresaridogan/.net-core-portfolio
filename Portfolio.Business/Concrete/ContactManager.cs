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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact entity)
        {
            _contactDal.Insert(entity);
        }

        public void TDelete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public Contact TGetByID(int id)
        {
            return _contactDal.GetByID(id);    
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
