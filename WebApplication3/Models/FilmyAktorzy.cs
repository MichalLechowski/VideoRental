namespace WebAppVideoRental.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FilmyAktorzy")]
    public partial class FilmyAktorzy
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdFilmu { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAktora { get; set; }

        [StringLength(20)]
        public string Rola { get; set; }

        public virtual Aktorzy Aktorzy { get; set; }

        public virtual Filmy Filmy { get; set; }

        public virtual RodzajeRol RodzajeRol { get; set; }
    }
}
