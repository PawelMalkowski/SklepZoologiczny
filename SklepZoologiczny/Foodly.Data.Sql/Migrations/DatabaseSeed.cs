using System;
using System.Collections.Generic;
using System.Linq;
using SklepZoologiczny.Common.Enums;
using SklepZoologiczny.Common.Extensions;
using SklepZoologiczny.Data.Sql.DAO;

namespace SklepZoologiczny.Data.Sql.Migrations
{
    //klasa odpowiadająca za wypełnienie testowymi danymi bazę danych
    public class DatabaseSeed
    {
        private readonly SklepZoologicznyDbContext _context;
        
        //wstrzyknięcie instancji klasy SklepZoologicznDbContext poprzez konstruktor
        public DatabaseSeed(SklepZoologicznyDbContext context)
        {
            _context = context;
        }
        
        //metoda odpowiadająca za uzupełnienie utworzonej bazy danych testowymi danymi
        //kolejność wywołania ma niestety znaczenie, ponieważ nie da się utworzyć rekordu
        //w bazie dnaych bez znajmości wartości klucza obcego
        //dlatego należy zacząć od uzupełniania tabel, które nie posiadają kluczy obcych
        //--OFFTOP
        //w przeciwną stronę działa ręczne usuwanie tabel z wypełnionymi danymi w bazie danych
        //należy zacząć od tabel, które posiadają klucze obce, a skończyć na tabelach, które 
        //nie posiadają
        public void Seed()
        {
            
            //regiony pozwalają na zwinięcie kodu w IDE
            //nie sa dobrą praktyką, kod w danej klasie/metodzie nie powinien wymagać jego zwijania
            //zastosowałem je z lenistwa nie powinno to mieć miejsca 
            #region CreateUzytkownik
            var UzytkownikList = BuildUzytkownikList();
            //dodanie użytkowników do tabeli User
            _context.Uzytkownik.AddRange(UzytkownikList);
            //zapisanie zmian w bazie danych
            _context.SaveChanges();
            #endregion
            
            
        }
        private IEnumerable<Uzytkownik> BuildUzytkownikList()
        {
            var UzytkownikList = new List<Uzytkownik>();
           
            var uzytkownik = new Uzytkownik()
            {
                Login = "Botek",
                Haslo="Q1w2e3r4t5y6",
                Email="xmalkowskipawelx@gmail.com"
                
            };
            UzytkownikList.Add(uzytkownik);
            for(int i= 2; i < 40; i++)
            {
                var Uzytkownik2 = new Uzytkownik()
                {
                    Login = "User" + i,
                    Haslo = "Password" + i,
                    Email = "user" + i + "@student.po.edu.pl",
                  
                };
                UzytkownikList.Add(Uzytkownik2);
            }

            return UzytkownikList;
        }
    }
}