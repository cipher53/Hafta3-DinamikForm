using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamikForm
{
    // FilmKategori adında bir enum tanımlanıyor.
    public enum FilmKategori {
        Korku, Aksiyon, BilimKurgu, Komedi
    }
    // Film sınıfı tanımlanıyor.
    public class Film
    {
         // Film özellikleri tanımlanıyor.
        public int FilmID { get; set; }
        public string FilmAdı { get; set; }
        public int FilmSüresi { get; set; }
        public FilmKategori kategori { get; set; }

         // Film sınıfının parametresiz yapıcısı (constructor).
        public Film() { }

         // Filmleri içeren bir List döndüren statik bir metot tanımlanıyor.
        public static List<Film> FilmleriListele() 
        {
            // Örnek bir film listesi oluşturuluyor ve döndürülüyor.
            return new List<Film>()
            {
                // Birkaç örnek film ekleniyor.
                new Film(){
                    FilmAdı = "Avatar",
                    FilmSüresi = 180,
                    kategori = FilmKategori.BilimKurgu,               
                },
                new Film(){
                    FilmAdı = "Hayvan Mezarlığı",
                    FilmSüresi = 150,
                    kategori = FilmKategori.Korku,
                },
                new Film(){
                    FilmAdı = "Intersteller",
                    FilmSüresi = 180,
                    kategori = FilmKategori.BilimKurgu,
                },
                new Film(){
                    FilmAdı = "Recep İvedik",
                    FilmSüresi = 200,
                    kategori = FilmKategori.Komedi,
                },
                new Film(){
                    FilmAdı = "Hızlı Öfkeli",
                    FilmSüresi = 200,
                    kategori = FilmKategori.Aksiyon,
                },
                new Film(){
                    FilmAdı = "Kolpaçino",
                    FilmSüresi = 120,
                    kategori = FilmKategori.Komedi,
                },
            };
        }


    }
}
