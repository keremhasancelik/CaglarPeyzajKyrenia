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
    public class FeatureTwoManager : IFeatureTwoService
    {
        IFeatureTwoDal _featureTwoDal;

        public FeatureTwoManager(IFeatureTwoDal featureTwoDal)
        {
            _featureTwoDal = featureTwoDal;
        }

        public FeatureTwo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(FeatureTwo t)
        {
            _featureTwoDal.Insert(t);
        }

        public void TDelete(FeatureTwo t)
        {
            _featureTwoDal.Delete(t);
        }

        public List<FeatureTwo> TGetList()
        {
            return _featureTwoDal.GetList();
        }

        public void TUpdate(FeatureTwo t)
        {
            _featureTwoDal.Update(t);
        }
    }
}
