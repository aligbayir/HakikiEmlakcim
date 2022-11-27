using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EvTipManager : IEvTipService
    {
        EfEvTipDal _evtipdal = new EfEvTipDal();
        public void Add(tbl_evtip evtip)
        {
            _evtipdal.Add(evtip);
        }

        public void Delete(tbl_evtip evtip)
        {
           _evtipdal.Delete(evtip);
        }

        public tbl_evtip Get(Expression<Func<tbl_evtip, bool>> filter)
        {
           return _evtipdal.Get(filter);
        }

        public List<tbl_evtip> GetAll()
        {
            return _evtipdal.GetAll();
        }

        public void Update(tbl_evtip evtip)
        {
            var bulunan = _evtipdal.Get(x=>x.evTipID==evtip.evTipID);
            bulunan.TipAdi = evtip.TipAdi;
            _evtipdal.Update(bulunan);
        }
    }
}
