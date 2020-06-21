using System;
using System.Collections.Generic;
using SklepZoologiczny.Api.DAO;
using SklepZoologiczny.Api.Enums;

namespace SklepZoologiczny.Api.ViewModels
{
    public class ZamowienieViewModel
    {
        public int ZamowienieId { get; set; }
        public DateTime Data_zlozenia { get; set; }
        public string Status { get; set; }
        public string Przesylka { get; set; }
        public int FirmaId { get; set; }

        public int KlientId { get; set; }
    }
}
