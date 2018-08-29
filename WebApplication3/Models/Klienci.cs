namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Klienci")]
    public partial class Klienci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klienci()
        {
            Wypozyczenia = new HashSet<Wypozyczenia>();
        }

        [Key]
        public int IdKlienta { get; set; }

        [Required]
        [StringLength(9)]
        public string NrDowodu { get; set; }

        [StringLength(30)]
        public string NazwiskoKlienta { get; set; }

        [StringLength(20)]
        public string ImieKlienta { get; set; }

        [StringLength(1)]
        public string Plec { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataUrodzenia { get; set; }

        [StringLength(40)]
        public string Ulica { get; set; }

        [StringLength(6)]
        public string KodPocztowy { get; set; }

        [StringLength(40)]
        public string Miejscowosc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataWprowadzenia { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Haslo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wypozyczenia> Wypozyczenia { get; set; }
    }
}
