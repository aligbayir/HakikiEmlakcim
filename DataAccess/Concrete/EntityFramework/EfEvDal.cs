using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEvDal : EfEntityRepositoryBase<tbl_ev, HakikiEmlakcimContext>, IEvDal
    {
    }
}
