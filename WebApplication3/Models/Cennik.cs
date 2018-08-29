namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cennik")]
    public partial class Cennik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cennik()
        {
            Filmy = new HashSet<Filmy>();
        }

        [Key]
        [StringLength(20)]
        public string RodzajFilmu { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal OplataZa1Dzien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Filmy> Filmy { get; set; }
    }
}
