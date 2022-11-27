using Business.Abstract;
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
    public class EvFotoManager : IEvFotoService
    {
        EfEvFotoDal _evFotoDal = new EfEvFotoDal();
        public void Add(tbl_evfoto evfoto)
        {
            if (evfoto.url != null)
            {
                _evFotoDal.Add(evfoto);
            }else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız.");
            }
        }
        public void Delete(tbl_evfoto evfoto)
        {
            _evFotoDal.Delete(evfoto);
        }

        public tbl_evfoto Get(Expression<Func<tbl_evfoto, bool>> filter)
        {
            return _evFotoDal.Get(filter);
        }

        public List<tbl_evfoto> GetAll()
        {
            return _evFotoDal.GetAll();
        }

        public void Update(tbl_evfoto evfoto)
        {
                if (evfoto.url != null)
                {
                    var bulunan = _evFotoDal.Get(x => x.evFotoID == evfoto.evFotoID);
                    bulunan.url = evfoto.url;
                    _evFotoDal.Update(bulunan);
                }
                else
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız.");
                }
            
            //var bulunan = _evFotoDal.Get(x => x.evFotoID == evfoto.evFotoID);
            //bulunan.url = evfoto.url;
            //_evFotoDal.Update(bulunan);
        }
    }
}
