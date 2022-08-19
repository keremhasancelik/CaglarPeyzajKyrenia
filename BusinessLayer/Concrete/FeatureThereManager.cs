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
    public class FeatureThereManager : IFeatureThereService
    {
        IFeatureThereDal _featureThereDal;

        public FeatureThereManager(IFeatureThereDal featureThereDal)
        {
            _featureThereDal = featureThereDal;
        }

        public FeatureThere GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(FeatureThere t)
        {
            _featureThereDal.Insert(t);
        }

        public void TDelete(FeatureThere t)
        {
            _featureThereDal.Delete(t);
        }

        public List<FeatureThere> TGetList()
        {
            return _featureThereDal.GetList();
        }

        public void TUpdate(FeatureThere t)
        {
            _featureThereDal.Update(t);
        }
    }
}
