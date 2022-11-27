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
    public class MusteriManager : IMusteriService
    {
        IMusteriDal _musteriDal = new EfMusteriDal();

        public void Add(tbl_musteri musteri)
        {
            if (musteri.MusteriAd != null && musteri.MusteriSoyad !=null && musteri.MusteriTel != null && musteri.MusteriTC != null)
            {
                _musteriDal.Add(musteri);
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız.");
            }
        }

        public void Delete(tbl_musteri musteri)
        {
          _musteriDal.Delete(musteri);
        }

        public tbl_musteri Get(Expression<Func<tbl_musteri, bool>> filter)
        {
            return _musteriDal.Get(filter);
        }

        public List<tbl_musteri> GetAll()
        {
            return _musteriDal.GetAll();
        }

        public void Update(tbl_musteri musteri)
        {
            var bulunan =_musteriDal.Get(x=>x.MusteriID==musteri.MusteriID);
            bulunan.MusteriAd = musteri.MusteriAd;
            bulunan.MusteriSoyad = musteri.MusteriSoyad;
            bulunan.MusteriTel = musteri.MusteriTel;
            bulunan.MusteriTC = musteri.MusteriTC;
            _musteriDal.Update(bulunan);
        }
    }
}
