namespace Entities
{
    using Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_ilan:IEntity
    {
        [Key]
        public int ilanID { get; set; }

        public int? musteriID { get; set; }

        public int? evID { get; set; }
        public string Baslik { get; set; }

        public virtual tbl_ev tbl_ev { get; set; }

        public virtual tbl_musteri tbl_musteri { get; set; }
    }
}
