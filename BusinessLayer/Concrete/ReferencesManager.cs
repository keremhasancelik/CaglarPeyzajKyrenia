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
    public class ReferencesManager : IReferencesService
    {
        IReferencesDal _referencesDal;

        public ReferencesManager(IReferencesDal referencesDal)
        {
            _referencesDal = referencesDal;
        }

        public References GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(References t)
        {
            _referencesDal.Insert(t);
        }

        public void TDelete(References t)
        {
            _referencesDal.Delete(t);
        }

        public List<References> TGetList()
        {
            return _referencesDal.GetList();
        }

        public void TUpdate(References t)
        {
            _referencesDal.Update(t);
        }
    }
}
