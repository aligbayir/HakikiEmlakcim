using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEvService
    {
        List<tbl_ev> GetAll(Expression<Func<tbl_ev, bool>> filter = null);
        tbl_ev Get(Expression<Func<tbl_ev, bool>> filter);
        void Add(tbl_ev ev);
        void Delete(tbl_ev ev);
        void Update(tbl_ev ev);
    }
}
