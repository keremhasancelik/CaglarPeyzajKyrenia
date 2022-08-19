using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SettingManager : ISettingService
    {
        ISettingDal _settingDal;

        public SettingManager(ISettingDal settingDal)
        {
            _settingDal = settingDal;
        }

        public Setting GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Setting t)
        {
            _settingDal.Insert(t);
        }

        public void TDelete(Setting t)
        {
            _settingDal.Delete(t);
        }

        public List<Setting> TGetList()
        {
            return _settingDal.GetList();
        }

        public void TUpdate(Setting t)
        {
            _settingDal.Update(t);
        }
    }
}
