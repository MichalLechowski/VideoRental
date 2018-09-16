namespace WebAppVideoRental.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wypozyczenia")]
    public partial class Wypozyczenia
    {
        [Key]
        public int IdWypozyczenia { get; set; }

        public int? IdPlyty { get; set; }

        public int? IdKlienta { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataWypozyczenia { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? OplataZa1Dzien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataZwrotu { get; set; }

        [Column(TypeName = "smallmoney")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? Doplata { get; set; }

        public virtual Klienci Klienci { get; set; }

        public virtual Plyty Plyty { get; set; }
    }
}
