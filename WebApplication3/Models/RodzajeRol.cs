namespace WebAppVideoRental.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RodzajeRol")]
    public partial class RodzajeRol
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RodzajeRol()
        {
            FilmyAktorzy = new HashSet<FilmyAktorzy>();
        }

        [Key]
        [StringLength(20)]
        public string Rola { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmyAktorzy> FilmyAktorzy { get; set; }
    }
}
