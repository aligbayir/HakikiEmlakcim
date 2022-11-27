using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEvTipService
    {
        List<tbl_evtip> GetAll();
        tbl_evtip Get(Expression<Func<tbl_evtip, bool>> filter);
        void Add(tbl_evtip evtip);
        void Delete(tbl_evtip evtip);
        void Update(tbl_evtip evtip);
    }
}
