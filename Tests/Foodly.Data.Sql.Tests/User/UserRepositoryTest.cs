using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SklepZoologiczny.Api;
using SklepZoologiczny.Api.Enums;
using SklepZoologiczny.Api.User;
using SklepZoologiczny.Domain.DomainExceptions;
using SklepZoologiczny.IData.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Xunit;

namespace SklepZoologiczny.Api.Tests.User
{
    public class UserRepositoryTest
    {
        public IConfiguration Configuration { get; }
        private  SklepZoologicznyDbContext _context;
        private  IUserRepository _userRepository;

        public UserRepositoryTest()
        {
            var optionsBuilder = new DbContextOptionsBuilder<SklepZoologicznyDbContext>();
            optionsBuilder.UseMySQL(
                "server=localhost;userid=root;pwd=;port=3307;database=sklepzoologiczny;");
            _context = new SklepZoologicznyDbContext(optionsBuilder.Options);
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
            _userRepository = new UserRepository(_context);
        }
        
        [Fact]
        public async Task AddUser_Returns_Correct_Response()
        {
            var user = new Domain.User.User("Name", "Email", "Password");
            
            var userId = await _userRepository.AddUser(user);
            
            var createdUser = await _context.Uzytkownik.FirstOrDefaultAsync(x => x.UzytkownikId == userId);
            Assert.NotNull(createdUser);

            _context.Uzytkownik.Remove(createdUser);
            await _context.SaveChangesAsync();
        }
    }
}