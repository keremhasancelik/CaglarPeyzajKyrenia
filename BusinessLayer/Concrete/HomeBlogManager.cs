using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HomeBlogManager : IHomeBlogService
    {
        IHomeBlogDal _homeBlogDal;

        public HomeBlogManager(IHomeBlogDal homeBlogDal)
        {
            _homeBlogDal = homeBlogDal;
        }

        public HomeBlog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(HomeBlog t)
        {
            _homeBlogDal.Insert(t);
        }

        public void TDelete(HomeBlog t)
        {
            _homeBlogDal.Delete(t);
        }

        public List<HomeBlog> TGetList()
        {
            return _homeBlogDal.GetList();
        }

        public void TUpdate(HomeBlog t)
        {
            _homeBlogDal.Update(t);
        }
    }
}
