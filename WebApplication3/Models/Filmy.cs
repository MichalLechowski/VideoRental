namespace WebAppVideoRental.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Filmy")]
    public partial class Filmy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Filmy()
        {
            FilmyAktorzy = new HashSet<FilmyAktorzy>();
            Plyty = new HashSet<Plyty>();
            Gatunki = new HashSet<Gatunki>();
        }

        [Key]
        public int IdFilmu { get; set; }

        [StringLength(40)]
        public string TytulFilmu { get; set; }

        [StringLength(4)]
        public string RokProdukcji { get; set; }

        [StringLength(20)]
        public string RodzajFilmu { get; set; }

        public virtual Cennik Cennik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmyAktorzy> FilmyAktorzy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plyty> Plyty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gatunki> Gatunki { get; set; }
    }
}
