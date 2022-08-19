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
    public class CustomersSayManager : ICustomersSayService
    {
        ICustomersSayDal _customersSayDal;

        public CustomersSayManager(ICustomersSayDal customersSayDal)
        {
            _customersSayDal = customersSayDal;
        }

        public CustomersSay GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(CustomersSay t)
        {
            _customersSayDal.Insert(t);
        }

        public void TDelete(CustomersSay t)
        {
            _customersSayDal.Delete(t);
        }

        public List<CustomersSay> TGetList()
        {
            return _customersSayDal.GetList();
        }

        public void TUpdate(CustomersSay t)
        {
            _customersSayDal.Update(t);
        }
    }
}
