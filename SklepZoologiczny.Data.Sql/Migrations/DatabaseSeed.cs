using System;
using System.Collections.Generic;
using System.Linq;
using SklepZoologiczny.Api.Enums;
using SklepZoologiczny.Common.Extensions;
using SklepZoologiczny.Api.DAO;

namespace SklepZoologiczny.Api.Sql.Migrations
{
    public class DatabaseSeed
    {
        private readonly SklepZoologicznyDbContext _context;

        public DatabaseSeed(SklepZoologicznyDbContext context)
        {
            _context = context;
        }
        
        public void Seed()
        {
            #region CreateUzytkownik
            var UzytkownikList = BuildUzytkownikList();
            _context.Uzytkownik.AddRange(UzytkownikList);
            _context.SaveChanges();
            #endregion

            #region CreateFirma
            var FirmaList = BuildFirmaList();
            _context.Firma.AddRange(FirmaList);
            _context.SaveChanges();
            #endregion

            #region CreateFirma
            var UzytkownikFirmaList = BuildUzytkownikFirmaList();
            _context.UzytkownikFirma.AddRange(UzytkownikFirmaList);
            _context.SaveChanges();
            #endregion

            #region CreatZamowienie
            var ZamowienieList = BuildZamowienieList();
            _context.Zamowienie.AddRange(ZamowienieList);
            _context.SaveChanges();
            #endregion

            #region CreateGatunek
            var GatunekList = BuildGatunekList();
            _context.Gatunek.AddRange(GatunekList);
            _context.SaveChanges();
            #endregion

            #region CreateProdukt
            var ProduktList = BuildProduktList();
            _context.Produkt.AddRange(ProduktList);
            _context.SaveChanges();
            #endregion

            #region CreateProduktZamowienie
            var ProduktZamowienieList = BuildProduktZamowienieList();
            _context.ProduktZamowienie.AddRange(ProduktZamowienieList);
            _context.SaveChanges();
            #endregion

            #region CreateAkcesorieGatunek
            var AkcesorieGatunekList = BuildAkcesorieGatunekList();
            _context.AkcesorieGatuneks.AddRange(AkcesorieGatunekList);
            _context.SaveChanges();
            #endregion

            #region CreateUzytkownik
            var PokarmGatunekList = BuildPokarmGatunekList();
            _context.PokarmGatunek.AddRange(PokarmGatunekList);
            _context.SaveChanges();
            #endregion
        }
        private IEnumerable<Uzytkownik> BuildUzytkownikList()
        {
            System.Random x = new Random(System.DateTime.Now.Millisecond);
            var UzytkownikList = new List<Uzytkownik>();

            var uzytkownik = new Uzytkownik()
            {
                Login = "Botek",
                Haslo="Q1w2e3r4t5y6",
                Email="xmalkowskipawelx@gmail.com"
                
            };
            UzytkownikList.Add(uzytkownik);
            for (int i = 2; i < 40; i++)
            {
                int czy = x.Next(1, 3);
                if (czy == 2)
                {
                    var Uzytkownik2 = new Uzytkownik()
                    {
                        Login = "User" + i,
                        Haslo = "Password" + i,
                        Email = "user" + i + "@student.po.edu.pl",
                        Klients = new Klient()
                        {
                            Imie = "Imie" + i.ToString(),
                            Nazwisko = "Naziwsko" + i,
                            Telefon = x.Next(10000, 99999).ToString() + x.Next(1000, 9999),
                            Email = "person" + i + "@student.po.edu.pl",
                            Kraj = "Polska",
                            Miejscowosc = "Opole",
                            Ulica = "Miejsska",
                            Nr_domu = x.Next(1, 100).ToString(),
                            Kodpocztowy = x.Next(1, 99).ToString() + "-" + x.Next(100, 999).ToString(),
                            Nr_mieszkania = x.Next(1, 20).ToString()
                        }

                    };
                    UzytkownikList.Add(Uzytkownik2);
                }
                if (czy == 1)
                {
                    var Uzytkownik2 = new Uzytkownik()
                    {
                        Login = "User" + i,
                        Haslo = "Password" + i,
                        Email = "user" + i + "@student.po.edu.pl",
                        Klients = new Klient()
                        {
                            Imie = "Imie" + i.ToString(),
                            Nazwisko = "Naziwsko" + i,
                            Telefon = x.Next(10000, 99999).ToString() + x.Next(1000, 9999),
                            Email = "person" + i + "@student.po.edu.pl",
                            Kraj = "Polska",
                            Miejscowosc = "Opole",
                            Ulica = "Miejsska",
                            Nr_domu = x.Next(1, 100).ToString(),
                            Kodpocztowy = x.Next(1, 99).ToString() + "-" + x.Next(100, 999).ToString(),
                        }

                    };
                    UzytkownikList.Add(Uzytkownik2);
                }
            }

          
            return UzytkownikList;
        }

        private IEnumerable<Firma> BuildFirmaList()
        {
            System.Random x = new Random(System.DateTime.Now.Millisecond);
            var FirmaList = new List<Firma>();
            for (int i = 1; i < 30; i++)
            {
                int czy = x.Next(1, 3);
                if (czy == 2)
                {
                    var firma = new Firma()
                    {
                        Nazwa = "Firma" + i,
                        Telefon = x.Next(10000, 99999).ToString() + x.Next(1000, 9999),
                        Nip = x.Next(10000, 99999).ToString() + x.Next(10000, 99999).ToString(),
                        Email = "person" + i + "@student.po.edu.pl",
                        Kraj = "Polska",
                        Miejscowosc = "Opole",
                        Ulica = "Wiejska",
                        Nr_domu = x.Next(1, 100).ToString(),
                        Kodpocztowy = x.Next(1, 99).ToString() + "-" + x.Next(100, 999).ToString(),
                        Nr_mieszkania = x.Next(1, 20).ToString()
                    };
                    FirmaList.Add(firma);
                }
                else
                {
                    var firma = new Firma()
                    {
                        Nazwa = "Firma" + i,
                        Telefon = x.Next(10000, 99999).ToString() + x.Next(1000, 9999),
                        Nip = x.Next(10000, 99999).ToString() + x.Next(10000, 99999).ToString(),
                        Email = "person" + i + "@student.po.edu.pl",
                        Kraj = "Polska",
                        Miejscowosc = "Opole",
                        Ulica = "Wiejska",
                        Nr_domu = x.Next(1, 100).ToString(),
                        Kodpocztowy = x.Next(1, 99).ToString() + "-" + x.Next(100, 999).ToString()
                    };
                    FirmaList.Add(firma);
                }
                
            }
            return FirmaList;
        }

        private IEnumerable<UzytkownikFirma> BuildUzytkownikFirmaList()
        {

            List<List<int>> losowanie= new List<List<int>>();
            System.Random x = new Random(System.DateTime.Now.Millisecond);
            var UztkownikFirmaList = new List<UzytkownikFirma>();
            var liczby = new List<int>();
            for (int j = 0; j < _context.Firma.Count(); j++)
            {
                liczby.Add(j);
            }
            for (int j = 0; j < _context.Uzytkownik.Count(); j++)
            {
                losowanie.Add(new List<int>());
                losowanie[j].AddRange(liczby);
            }
                
            for (int i=0; i < 70; i++)
            {
               
                int a=0;
                bool test = true;
                while (test)
                {
                    test = true;
                     a = x.Next(0, losowanie.Count - 1);
                    if (losowanie[a].Count > 0) test = false;
                }
               
                 int   b = x.Next(0, losowanie[a].Count - 1);
                
                var uzytkownik_Firma = new UzytkownikFirma()
                {
                    FirmaId = a+1,
                    UzytkownikId = b+1
                };
                losowanie[a].RemoveAt(b);
                UztkownikFirmaList.Add(uzytkownik_Firma);
            }
            return UztkownikFirmaList;
        }
        private IEnumerable<Zamowienie> BuildZamowienieList()
        {
            var ZamowienieList = new List<Zamowienie>();
            System.Random x = new Random(System.DateTime.Now.Millisecond);
            string[] Statusy = {"zlozone","gotowe do wysylki","wyslane","zrealizowane" };
            string[] Przesylka = { "kurier", "paczkomat", "poczta", "odbiór osobisty" };

            for (int i = 1; i < 100;i++) {
               int CzyFirma= x.Next(0, 2);
                if (CzyFirma == 1)
                {
                    var zamowienie = new Zamowienie()
                    {
                        Data_zlozenia = LosowaData(),
                        Status = Statusy[x.Next(0, Statusy.Length)],
                        Przesylka = Przesylka[x.Next(0, Przesylka.Length)],
                        FirmaId = x.Next(1, _context.Firma.Count() + 1)

                    };
                    ZamowienieList.Add(zamowienie);
                }
                else
                {
                    var zamowienie = new Zamowienie()
                    {
                        Data_zlozenia = LosowaData(),
                        Status = Statusy[x.Next(0, Statusy.Length)],
                        Przesylka = Przesylka[x.Next(0, Przesylka.Length)],
                        KlientId = x.Next(1, _context.Klient.Count() + 1),

                    };
                    ZamowienieList.Add(zamowienie);
                }
                
                }
            return ZamowienieList;
        }
        private IEnumerable<Gatunek> BuildGatunekList()
        {
            var GatunekList = new List<Gatunek>();
            for(int i = 1; i < 21; i++)
            {
                var gatunek = new Gatunek()
                {
                    Nazwa = "Gatunek" + i.ToString()
                };
                GatunekList.Add(gatunek);
            }
            return GatunekList;
        }
        private IEnumerable<Produkt> BuildProduktList()
        {
            System.Random x = new Random(System.DateTime.Now.Millisecond);
            var ProduktList = new List<Produkt>();
            for(int i=0; i < 200; i++)
            {
               int jakiprodukt= x.Next(0, 3);
                if (jakiprodukt == 0)
                {
                    var produkt = new Produkt
                    {
                        Ilosc= x.Next(0,1001),
                        Waga= x.Next(0,40),
                        Cena= x.Next(1,100000)/100,
                        Zwierzes= new Zwierze
                        {
                            GatunekId = x.Next(1, _context.Klient.Count()+1),
                            Wiek= x.Next(0,20),
                            Licencja= Convert.ToBoolean(x.Next(0,2)),
                            Transport= Convert.ToBoolean(x.Next(0, 2)),
                            HodowlaId= x.Next(1, _context.Firma.Count() + 1),
                            DostawcaId= x.Next(1, _context.Firma.Count() + 1)
                        }
                    };
                    ProduktList.Add(produkt);
                }
                else if (jakiprodukt == 1)
                {
                    var produkt = new Produkt
                    {
                        Ilosc = x.Next(0, 1001),
                        Waga = x.Next(0, 40),
                        Cena = x.Next(1, 100000) / 100,
                        Pokarms = new Pokarm
                        {
                            ProducentId = x.Next(1, _context.Firma.Count() + 1),
                            Kalorie = x.Next(100, 1000),
                            Nazwa = "Nazwa" + i.ToString()
                        }
                    };
                    ProduktList.Add(produkt);
                }
                else
                {
                    var produkt = new Produkt
                    {
                        Ilosc = x.Next(0, 1001),
                        Waga = x.Next(0, 40),
                        Cena = x.Next(1, 100000) / 100,
                        Akcesorias = new Akcesoria
                        {
                           ProducentId = x.Next(1, _context.Firma.Count() + 1),
                           Nazwa = "Nazwa" + i.ToString(),

                        }
                    };
                    ProduktList.Add(produkt);
                }

            }
            return ProduktList;
        }
        private IEnumerable<ProduktZamowienie> BuildProduktZamowienieList()
        {
            List<List<int>> losowanie = new List<List<int>>();
            List<int> liczby = new List<int>();
            var ProduktZamowienieList = new List<ProduktZamowienie>();
            System.Random x = new Random(System.DateTime.Now.Millisecond);
            for (int j = 0; j < _context.Zamowienie.Count(); j++)
            {
                liczby.Add(j);
            }
                for (int i = 0; i < _context.Produkt.Count(); i++)
            {
                losowanie.Add(new List<int>());
                losowanie[i].AddRange(liczby);
              }
            for (int i = 0; i < 300; i++)
            {

                int a = 0;
                bool test = true;
                while (test)
                {
                    a = x.Next(0, losowanie.Count - 1);
                    if (losowanie[a].Count > 0) test = false;
                }

                int b = x.Next(0, losowanie[a].Count - 1);

                var produktZamowienie = new ProduktZamowienie()
                {
                    ProduktId = a + 1,
                    ZamowienieId = b + 1
                };
                losowanie[a].RemoveAt(b);
                ProduktZamowienieList.Add(produktZamowienie);
            }
            return ProduktZamowienieList;
        }
        private IEnumerable<AkcesorieGatunek> BuildAkcesorieGatunekList()
        {
            List<List<int>> losowanie = new List<List<int>>();
            List<int> liczby = new List<int>();
            var AkcesorieGatunekList = new List<AkcesorieGatunek>();
            System.Random x = new Random(System.DateTime.Now.Millisecond);
            for (int j = 0; j < _context.Akcesorie.Count(); j++)
            {
                liczby.Add(j);
            }
            for (int i = 0; i < _context.Gatunek.Count(); i++)
            {
                losowanie.Add(new List<int>());
                losowanie[i].AddRange(liczby);
            }
            for (int i = 0; i < 30; i++)
            {

                int a = 0;
                bool test = true;
                while (test)
                {
                    a = x.Next(0, losowanie.Count - 1);
                    if (losowanie[a].Count > 0) test = false;
                }

                int b = x.Next(0, losowanie[a].Count - 1);

                var akcesorieGatunek = new AkcesorieGatunek()
                {
                    AkceorieId = a + 1,
                    GatunekId = b + 1
                };
                losowanie[a].RemoveAt(b);
                AkcesorieGatunekList.Add(akcesorieGatunek);
            }
            return AkcesorieGatunekList;
        }
        private IEnumerable<PokarmGatunek> BuildPokarmGatunekList()
        {
            List<List<int>> losowanie = new List<List<int>>();
            List<int> liczby = new List<int>();
            var PokarmGatunekList = new List<PokarmGatunek>();
            System.Random x = new Random(System.DateTime.Now.Millisecond);
            for (int j = 0; j < _context.Pokarm.Count(); j++)
            {
                liczby.Add(j);
            }
            for (int i = 0; i < _context.Gatunek.Count(); i++)
            {
                losowanie.Add(new List<int>());
                losowanie[i].AddRange(liczby);
            }
            for (int i = 0; i < 30; i++)
            {

                int a = 0;
                bool test = true;
                while (test)
                {
                    a = x.Next(0, losowanie.Count - 1);
                    if (losowanie[a].Count > 0) test = false;
                }

                int b = x.Next(0, losowanie[a].Count - 1);

                var pokarmGatunek = new PokarmGatunek()
                {
                    PokarmId = a + 1,
                    GatunekId = b + 1
                };
                losowanie[a].RemoveAt(b);
                PokarmGatunekList.Add(pokarmGatunek);
            }
            return PokarmGatunekList;
        }

        private DateTime LosowaData()
        {
            int rok, miesiac, dzien;
            System.Random x = new Random(System.DateTime.Now.Millisecond);
             rok = x.Next(2000, System.DateTime.Now.Year + 1);
            if (rok != System.DateTime.Now.Year) {
                 miesiac = x.Next(1, 13);
            }
            else
            {
                miesiac = x.Next(1, DateTime.Now.Month + 1);
            }

            dzien = x.Next(1, DateTime.DaysInMonth(rok, miesiac));

            var data = new DateTime(rok, miesiac, dzien,x.Next(0,24),x.Next(0,60),x.Next(0,60));
            return data;
        }
    }
}

