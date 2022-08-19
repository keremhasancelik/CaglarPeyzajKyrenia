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
    public class FeatureFourManager : IFeatureFourService
    {
        IFeatureFourDal _featureFourDal;

        public FeatureFourManager(IFeatureFourDal featureFourDal)
        {
            _featureFourDal = featureFourDal;
        }

        public FeatureFour GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(FeatureFour t)
        {
            _featureFourDal.Insert(t);
        }

        public void TDelete(FeatureFour t)
        {
            _featureFourDal.Delete(t);
        }

        public List<FeatureFour> TGetList()
        {
            return _featureFourDal.GetList();
        }

        public void TUpdate(FeatureFour t)
        {
            _featureFourDal.Update(t);
        }
    }
}
