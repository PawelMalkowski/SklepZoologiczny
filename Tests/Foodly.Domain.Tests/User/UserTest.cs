using System;
using SklepZoologiczny.Api.Enums;
using SklepZoologiczny.Domain.DomainExceptions;
using Xunit;

namespace SklepZoologiczny.Domain.Tests.User
{
    public class UserTest
    {
        public UserTest()
        {

        }

     
        
        [Fact]
        public void CreateUser_Returns_Correct_Response()
        {
            var user = new Domain.User.User("Name", "Email", "Password");

            Assert.Equal("Password", user.Password);
            Assert.Equal("Email", user.Email);
            Assert.Equal("Name", user.UserName);
        }
    }
}