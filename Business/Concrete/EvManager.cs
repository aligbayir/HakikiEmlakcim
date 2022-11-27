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
    public class EvManager : IEvService
    {
        EfEvDal _evDal = new EfEvDal();

        public void Add(tbl_ev ev)
        {
            if (ev.il != null && ev.ilce != null && ev.ilanTarih !=null && ev.brütm2 != null &&
                ev.netm2 !=null && ev.odasayisi !=null && ev.binayas !=null && 
                ev.bulundugukat !=null && ev.binadakitoplamkat!=null && ev.isitma !=null && 
                ev.banyosayisi !=null && ev.Aidat !=null && ev.balkondurum !=null && 
                ev.esyadurum != null && ev.esyadurum !=null && ev.siteicidurum !=null && 
                ev.krediyeuygunlukdurum!=null && ev.tapucesidi !=null && ev.takasdurum!=null && 
                ev.satilikdurum!=null)
            {
                _evDal.Add(ev);
            }else
            {
                MessageBox.Show("Ev Eklerken Bütün Alanları Doldurmanız Gerekmektedir.");
            }
        }
        public void Delete(tbl_ev ev)
        {
            _evDal.Delete(ev);
        }

        public tbl_ev Get(Expression<Func<tbl_ev, bool>> filter)
        {
            return _evDal.Get(filter);
        }

        public List<tbl_ev> GetAll(Expression<Func<tbl_ev, bool>> filter=null)
        {
            return _evDal.GetAll();
        }

        public void Update(tbl_ev ev)
        {
            var bulunan = _evDal.Get(x => x.evID == ev.evID);
            bulunan.il = ev.il;
            bulunan.ilce = ev.ilce;
            bulunan.ilanTarih = ev.ilanTarih;
            bulunan.brütm2 = ev.brütm2;
            bulunan.netm2 = ev.netm2;
            bulunan.odasayisi = ev.odasayisi;
            bulunan.binayas = ev.binayas;
            bulunan.bulundugukat = ev.bulundugukat;
            bulunan.binadakitoplamkat = ev.binadakitoplamkat;
            bulunan.isitma = ev.isitma;
            bulunan.banyosayisi = ev.banyosayisi;
            bulunan.Aidat = ev.Aidat;
            bulunan.balkondurum = ev.balkondurum;
            bulunan.esyadurum = ev.esyadurum;
            bulunan.siteicidurum = ev.siteicidurum;
            bulunan.krediyeuygunlukdurum = ev.krediyeuygunlukdurum;
            bulunan.tapucesidi = ev.tapucesidi;
            bulunan.tapucesidi = ev.tapucesidi;
            bulunan.satilikdurum = ev.satilikdurum;
            _evDal.Update(bulunan);

        }
    }
}
