namespace Entities
{
    using Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_evfoto:IEntity
    {
        [Key]
        public int evFotoID { get; set; }

        public int? evID { get; set; }

        [StringLength(50)]
        public string url { get; set; }

        public virtual tbl_ev tbl_ev { get; set; }
    }
}
