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
    public class AdvantagesManager : IAdvantagesService
    {
        IAdvantagesDal _advantagesDal;

        public AdvantagesManager(IAdvantagesDal advantagesDal)
        {
            _advantagesDal = advantagesDal;
        }

        public Advantages GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Advantages t)
        {
            _advantagesDal.Insert(t);
        }

        public void TDelete(Advantages t)
        {
            _advantagesDal.Delete(t);
        }

        public List<Advantages> TGetList()
        {
            return _advantagesDal.GetList();
        }

        public void TUpdate(Advantages t)
        {
            _advantagesDal.Update(t);
        }
    }
}
