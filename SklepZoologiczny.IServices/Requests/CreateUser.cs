using System;
using SklepZoologiczny.Api.Enums;

namespace SklepZoologiczny.IServices.Requests
{
    public class CreateUser
    {
        public string UserName { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }
        
    }
}