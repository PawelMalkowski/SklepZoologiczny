using System;
using System.Collections.Generic;
using SklepZoologiczny.Api.DAO;
using SklepZoologiczny.Api.Enums;

namespace SklepZoologiczny.Api.ViewModels
{
    public class UserViewModel
    {

        public int UzytkownikId { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public string Email { get; set; }

    }
}

