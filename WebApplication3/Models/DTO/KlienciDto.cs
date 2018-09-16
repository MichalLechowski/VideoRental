using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppVideoRental.Models.DTO
{
    public class KlienciDto
    {
        [Key]
        public int IdKlienta { get; set; }

        public string NrDowodu { get; set; }
        public string NazwiskoKlienta { get; set; }
        public string ImieKlienta { get; set; }
        public string Plec { get; set; }
        public DateTime? DataUrodzenia { get; set; }
        public string Ulica { get; set; }
        public string KodPocztowy { get; set; }
        public string Miejscowosc { get; set; }
        public DateTime? DataWprowadzenia { get; set; }
        public string Haslo { get; set; }
        //public bool czyPracownik { get; set; }
        public virtual ICollection<Wypozyczenia> Wypozyczenia { get; set; }
    }
}