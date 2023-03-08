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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMedia;

        public SocialMediaManager(ISocialMediaDal socialMedia)
        {
            _socialMedia = socialMedia;
        }

        public void TAdd(SocialMedia entity)
        {
            _socialMedia.Insert(entity);
        }

        public void TDelete(SocialMedia entity)
        {
            _socialMedia.Delete(entity);
        }

        public SocialMedia TGetByID(int id)
        {
            return _socialMedia.GetByID(id);
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMedia.GetList();
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMedia.Update(entity);
        }
    }
}
