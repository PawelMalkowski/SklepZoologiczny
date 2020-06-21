using System;
using System.Threading.Tasks;
using SklepZoologiczny.Api;
using SklepZoologiczny.Api.Enums;
using SklepZoologiczny.Api.DAO;
using SklepZoologiczny.Domain.DomainExceptions;
using SklepZoologiczny.IData.User;
using SklepZoologiczny.IServices.Requests;
using SklepZoologiczny.IServices.User;
using SklepZoologiczny.Services.User;
using SklepZoologiczny.Domain;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace SklepZoologiczny.Services.Tests.User
{
    public class UserServiceTest
    {
        private readonly IUserService _userService;
        private readonly Mock<IUserRepository> _userRepositoryMock;
        
        public UserServiceTest()
        {
            _userRepositoryMock = new Mock<IUserRepository>();
            _userService = new UserService(_userRepositoryMock.Object);
        }
        
        [Fact]
        public void CreateUser_Returns_throws_InvalidBirthDateException()
        {
            var user = new CreateUser
            {
                UserName="Alfons",
                Email= "dja@gmail.com",
                Password= "abcd"
                
            };

            Assert.ThrowsAsync<InvalidBirthDateException>(() => _userService.CreateUser(user));
        }
        
        [Fact]
        public async Task CreateUser_Returns_Correct_Response()
        {
            var user = new CreateUser
            {
                UserName = "Alfons",
                Email = "dja@gmail.com",
                Password = "abcd"
            };
            
            int expectedResult = 0;
            _userRepositoryMock.Setup(x => x.AddUser
                    (new Domain.User.User
                        (user.UserName,
                        user.Password,
                        user.Email
                       )))
                .Returns(Task.FromResult(expectedResult));
            
            var result = await _userService.CreateUser(user);


            Assert.IsType<Domain.User.User>(result);
            Assert.NotNull(result);
            Assert.Equal(expectedResult, result.Id);
        }
    }
}