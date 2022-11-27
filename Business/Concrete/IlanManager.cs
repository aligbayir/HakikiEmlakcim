using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.Concrete
{
    public class IlanManager : IIlanService
    {
        EfIlanDal _ilanDal = new EfIlanDal();
        public void Add(tbl_ilan ilan)
        {
            if (ilan.Baslik !=null)
            {
                _ilanDal.Add(ilan);
            }else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız.");
            }
            
        }

        public void Delete(tbl_ilan ilan)
        {
            _ilanDal.Delete(ilan);
        }

        public tbl_ilan Get(Expression<Func<tbl_ilan, bool>> filter)
        {
           return _ilanDal.Get(filter);
        }

        
        public List<tbl_ilan> GetAll(Expression<Func<tbl_ilan, bool>> filter = null)
        {
            return filter ==null ? _ilanDal.GetAll() : _ilanDal.GetAll(filter);
        }

        public void Update(tbl_ilan ilan)
        {
            var bulunan= _ilanDal.Get(x=>x.ilanID==ilan.ilanID);
            bulunan.Baslik=ilan.Baslik;
            _ilanDal.Update(bulunan);

        }
    }
}
