using SklepZoologiczny.Api.DAO;
using SklepZoologiczny.Api.DAOConfigurations;
using Microsoft.EntityFrameworkCore;

namespace SklepZoologiczny.Api
{
    //Klasa odpowiadająca za konfigurację Entity Framework Core
    //Przy pomocy instancji klasy SklepZoologicznDbContext możliwe jest wykonywanie
    //wszystkich operacji na bazie danych od tworzenia bazy danych po zapytanie do bazy danych itd.
    public class SklepZoologicznyDbContext : DbContext
    {
        public SklepZoologicznyDbContext(DbContextOptions<SklepZoologicznyDbContext> options) : base(options) { }

        //Ustawienie klas z folderu DAO jako tabele bazy danych
        public virtual DbSet<Akcesoria> Akcesorie { get; set; }
        public virtual DbSet<Firma> Firma { get; set; }
        public virtual DbSet<Gatunek> Gatunek { get; set; }
        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<Pokarm> Pokarm { get; set; }
        public virtual DbSet<AkcesorieGatunek> AkcesorieGatuneks { get; set; }
        public virtual DbSet<PokarmGatunek> PokarmGatunek { get; set; }
        public virtual DbSet<ProduktZamowienie> ProduktZamowienie { get; set; }
        public virtual DbSet<UzytkownikFirma> UzytkownikFirma { get; set; }
        public virtual DbSet<Produkt> Produkt { get; set; }
        public virtual DbSet<Uzytkownik> Uzytkownik { get; set; }
        public virtual DbSet<Zamowienie> Zamowienie { get; set; }
        public virtual DbSet<Zwierze> Zwierze { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AkcesoriaConfiguration());
            builder.ApplyConfiguration(new FirmaConfiguration());
            builder.ApplyConfiguration(new GatunekConfiguration());
            builder.ApplyConfiguration(new KlientConfiguration());
            builder.ApplyConfiguration(new PokarmConfiguration());
            builder.ApplyConfiguration(new AkcesorieGatunekConfiguration());
            builder.ApplyConfiguration(new PokarmGatunekConfiguration());
            builder.ApplyConfiguration(new ProduktZamowienieConfiguration());
            builder.ApplyConfiguration(new UzytkownikFirmaConfiguration());
            builder.ApplyConfiguration(new ProduktConfiguration());
            builder.ApplyConfiguration(new UzytkownikConfiguration());
            builder.ApplyConfiguration(new ZamowienieConfiguration());
            builder.ApplyConfiguration(new ZwierzeConfiguration());



        }

    }
}