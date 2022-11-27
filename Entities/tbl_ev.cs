namespace Entities
{
    using Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_ev:IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_ev()
        {
            tbl_evfoto = new HashSet<tbl_evfoto>();
            tbl_evtip = new HashSet<tbl_evtip>();
            tbl_ilan = new HashSet<tbl_ilan>();
        }

        [Key]
        public int evID { get; set; }

        [StringLength(50)]
        public string il { get; set; }

        [StringLength(50)]
        public string ilce { get; set; }

        public DateTime? ilanTarih { get; set; }

        [StringLength(50)]
        public string brütm2 { get; set; }

        [StringLength(50)]
        public string netm2 { get; set; }

        [StringLength(50)]
        public string odasayisi { get; set; }

        [StringLength(50)]
        public string binayas { get; set; }

        [StringLength(50)]
        public string bulundugukat { get; set; }

        [StringLength(50)]
        public string binadakitoplamkat { get; set; }

        [StringLength(50)]
        public string isitma { get; set; }

        public int? banyosayisi { get; set; }

        public int? Aidat { get; set; }

        public bool? balkondurum { get; set; }

        public bool? esyadurum { get; set; }

        public bool? siteicidurum { get; set; }

        public bool? krediyeuygunlukdurum { get; set; }

        public bool? tapucesidi { get; set; }

        public bool? takasdurum { get; set; }

        public bool? satilikdurum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_evfoto> tbl_evfoto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_evtip> tbl_evtip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ilan> tbl_ilan { get; set; }
    }
}
