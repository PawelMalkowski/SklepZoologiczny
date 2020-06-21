using SklepZoologiczny.Data.Sql.DAO;
using SklepZoologiczny.Data.Sql.DAOConfigurations;
using Microsoft.EntityFrameworkCore;

namespace SklepZoologiczny.Data.Sql
{
    //Klasa odpowiadająca za konfigurację Entity Framework Core
    //Przy pomocy instancji klasy SklepZoologicznDbContext możliwe jest wykonywanie
    //wszystkich operacji na bazie danych od tworzenia bazy danych po zapytanie do bazy danych itd.
    public class SklepZoologicznyDbContext : DbContext
    {
        public SklepZoologicznyDbContext(DbContextOptions<SklepZoologicznyDbContext> options) : base(options) { }

        //Ustawienie klas z folderu DAO jako tabele bazy danych
        public virtual DbSet<Akcesoria> Akcesoria { get; set; }
        public virtual DbSet<Firma> Firma { get; set; }
        public virtual DbSet<Gatunek> Gatunek { get; set; }
        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<Pokarm> Pokarm { get; set; }
        public virtual DbSet<Akcesorie_Gatunek> Akcesorie_Gatuneks { get; set; }
        public virtual DbSet<Pokarm_Gatunek> Pokarm_Gatunek { get; set; }
        public virtual DbSet<Produkt_Zamowienie> Produkt_Zamowienie { get; set; }
        public virtual DbSet<Uzytkownik_Firma> Uzytkownik_Firma { get; set; }
        public virtual DbSet<Produkt> Produkt { get; set; }
        public virtual DbSet<Uzytkownik> Uzytkownik { get; set; }
        public virtual DbSet<Zamowienie> Zamowienia { get; set; }
        public virtual DbSet<Zwierze> Zwierze { get; set; }



        //Przykład konfiguracji modeli/encji poprzez klasy konfiguracyjne z folderu DAOConfigurations
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AkcesoriaConfiguration());
            builder.ApplyConfiguration(new FirmaConfiguration());
            builder.ApplyConfiguration(new GatunekConfiguration());
            builder.ApplyConfiguration(new KlientConfiguration());
            builder.ApplyConfiguration(new PokarmConfiguration());
            builder.ApplyConfiguration(new Akcesorie_GatunekConfiguration());
            builder.ApplyConfiguration(new Pokarm_GatunekConfiguration());
            builder.ApplyConfiguration(new Produkt_ZamowienieConfiguration());
            builder.ApplyConfiguration(new Uzytkownik_FirmaConfiguration());
            builder.ApplyConfiguration(new ProduktConfiguration());
            builder.ApplyConfiguration(new UzytkownikConfiguration());
            builder.ApplyConfiguration(new ZamowieniaConfiguration());
            builder.ApplyConfiguration(new ZwierzeConfiguration());



        }

    }
}