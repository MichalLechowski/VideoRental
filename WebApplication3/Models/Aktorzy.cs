namespace WebAppVideoRental.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aktorzy")]
    public partial class Aktorzy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aktorzy()
        {
            FilmyAktorzy = new HashSet<FilmyAktorzy>();
        }

        [Key]
        public int IdAktora { get; set; }

        [Required]
        [StringLength(20)]
        public string NazwiskoAktora { get; set; }

        [Required]
        [StringLength(20)]
        public string ImieAktora { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmyAktorzy> FilmyAktorzy { get; set; }
    }
}
