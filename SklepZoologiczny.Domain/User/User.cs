using System;
using System.Data;
using SklepZoologiczny.Api.Enums;
using SklepZoologiczny.Domain.DomainExceptions;

namespace SklepZoologiczny.Domain.User
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }

        public string Password { get; private set; }
       

        public User(string userName, string email, string password)
        {
   
            UserName = userName;
            Email = email;
            Password = password;

        }
        
    }
}