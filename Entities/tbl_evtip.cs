namespace Entities
{
    using Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_evtip:IEntity
    {
        [Key]
        public int evTipID { get; set; }

        public int? evID { get; set; }

        [StringLength(50)]
        public string TipAdi { get; set; }

        public virtual tbl_ev tbl_ev { get; set; }
    }
}
