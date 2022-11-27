using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class HakikiEmlakcimContext:DbContext
    {
        public HakikiEmlakcimContext()
            : base("name=HakikiEmlakcimModel2")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_ev> tbl_ev { get; set; }
        public virtual DbSet<tbl_evfoto> tbl_evfoto { get; set; }
        public virtual DbSet<tbl_evtip> tbl_evtip { get; set; }
        public virtual DbSet<tbl_ilan> tbl_ilan { get; set; }
        public virtual DbSet<tbl_musteri> tbl_musteri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
