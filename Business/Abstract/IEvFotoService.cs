using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEvFotoService
    {
        List<tbl_evfoto> GetAll();

        void Add(tbl_evfoto evfoto);
        void Update(tbl_evfoto evfoto);
        void Delete(tbl_evfoto evfoto);
        tbl_evfoto Get(Expression<Func<tbl_evfoto, bool>> filter);
    }
}
