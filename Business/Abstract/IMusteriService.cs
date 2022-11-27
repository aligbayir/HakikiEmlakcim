using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMusteriService
    {
        List<tbl_musteri> GetAll();
        tbl_musteri Get(Expression<Func<tbl_musteri, bool>> filter);

        void Add(tbl_musteri musteri);
        void Delete(tbl_musteri musteri);
        void Update(tbl_musteri musteri);
        
    }
}
