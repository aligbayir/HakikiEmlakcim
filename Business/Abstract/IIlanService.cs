using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIlanService
    {
        List<tbl_ilan> GetAll(Expression<Func<tbl_ilan, bool>> filter=null);
        tbl_ilan Get(Expression<Func<tbl_ilan,bool>> filter);
        void Add(tbl_ilan ilan);
        void Delete(tbl_ilan ilan);
        void Update(tbl_ilan ilan);

    }
}
