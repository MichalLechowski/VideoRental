using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppVideoRental.Context;
using WebAppVideoRental.Models.DTO;
using System.Data.Entity;

namespace WebAppVideoRental.Models.Repo
{
    public class KlientRepository : ICrudRepository<KlienciDto>
    {
        public List<KlienciDto> GetAll()
        {
            using (VideoRentalContext db = new VideoRentalContext())
            {
                List<KlienciDto> klienci = new List<KlienciDto>();
                db.Klienci.ToList().ForEach(k => klienci.Add(new KlienciDto()
                {
                    DataUrodzenia = k.DataUrodzenia,
                    DataWprowadzenia = k.DataWprowadzenia,
                    ImieKlienta = k.ImieKlienta,
                    NazwiskoKlienta = k.NazwiskoKlienta,
                    KodPocztowy = k.KodPocztowy,
                    Haslo = k.Haslo,
                    Miejscowosc = k.Miejscowosc,
                    NrDowodu = k.NrDowodu,
                    Ulica = k.Ulica,
                    Plec = k.Plec,
                    Wypozyczenia = k.Wypozyczenia,
                    //czyPracownik = k.czyPracownik,
                    IdKlienta = k.IdKlienta
                }));
                return klienci;
            }
        }

        public KlienciDto GetSingle(int id)
        {
            using (VideoRentalContext db = new VideoRentalContext())
            {
                var klient = db.Klienci.Single(k => k.IdKlienta == id);
                return new KlienciDto()
                {
                    IdKlienta = klient.IdKlienta,
                    DataUrodzenia = klient.DataUrodzenia,
                    DataWprowadzenia = klient.DataWprowadzenia,
                    ImieKlienta = klient.ImieKlienta,
                    NazwiskoKlienta = klient.NazwiskoKlienta,
                    KodPocztowy = klient.KodPocztowy,
                    Haslo = klient.Haslo,
                    Miejscowosc = klient.Miejscowosc,
                    NrDowodu = klient.NrDowodu,
                    Ulica = klient.Ulica,
                    Plec = klient.Plec,
                    Wypozyczenia = klient.Wypozyczenia,
                    //czyPracownik = klient.czyPracownik
                };
            }
        }

        public void Add(KlienciDto obj)
        {
            using (VideoRentalContext db = new VideoRentalContext())
            {
                Klienci klient = new Klienci
                {
                    DataUrodzenia = obj.DataUrodzenia,
                    DataWprowadzenia = obj.DataWprowadzenia,
                    ImieKlienta = obj.ImieKlienta,
                    NazwiskoKlienta = obj.NazwiskoKlienta,
                    KodPocztowy = obj.KodPocztowy,
                    Haslo = obj.Haslo,
                    Miejscowosc = obj.Miejscowosc,
                    NrDowodu = obj.NrDowodu,
                    Ulica = obj.Ulica,
                    Plec = obj.Plec,
                    Wypozyczenia = obj.Wypozyczenia
                };
                //klient.czyPracownik = obj.czyPracownik;
                db.Klienci.Add(klient);
                db.SaveChanges();
            }
        }

        public bool Update(KlienciDto obj)
        {
            try
            {
                using (VideoRentalContext db = new VideoRentalContext())
                {
                    var pierwotnyKlient = db.Klienci.Find(obj.IdKlienta);
                    pierwotnyKlient.IdKlienta = obj.IdKlienta;
                    pierwotnyKlient.DataUrodzenia = obj.DataUrodzenia;
                    pierwotnyKlient.DataWprowadzenia = obj.DataWprowadzenia;
                    pierwotnyKlient.ImieKlienta = obj.ImieKlienta;
                    pierwotnyKlient.NazwiskoKlienta = obj.NazwiskoKlienta;
                    pierwotnyKlient.KodPocztowy = obj.KodPocztowy;
                    pierwotnyKlient.Haslo = obj.Haslo;
                    pierwotnyKlient.Miejscowosc = obj.Miejscowosc;
                    pierwotnyKlient.NrDowodu = obj.NrDowodu;
                    pierwotnyKlient.Ulica = obj.Ulica;
                    pierwotnyKlient.Plec = obj.Plec;
                    pierwotnyKlient.Wypozyczenia = obj.Wypozyczenia;
                    //pierwotnyKlient.czyPracownik = obj.czyPracownik;
                    db.Entry(pierwotnyKlient).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public void Delete(int id)
        {
            using (VideoRentalContext db = new VideoRentalContext())
            {
                Klienci klient = db.Klienci.Find(id);
                db.Klienci.Remove(klient);
                db.SaveChanges();
            }
        }
    }
}