namespace Entities
{
    using Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_musteri:IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_musteri()
        {
            tbl_ilan = new HashSet<tbl_ilan>();
        }

        [Key]
        public int MusteriID { get; set; }

        [StringLength(50)]
        public string MusteriAd { get; set; }

        [StringLength(50)]
        public string MusteriSoyad { get; set; }

        [StringLength(50)]
        public string MusteriTel { get; set; }

        [StringLength(50)]
        public string MusteriTC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ilan> tbl_ilan { get; set; }
    }
}
