using System;
using System.Threading.Tasks;
using SklepZoologiczny.Api.BindingModels;
using SklepZoologiczny.Api.DAO;
using SklepZoologiczny.Api.Mappers;
using SklepZoologiczny.Api.Validation;
using SklepZoologiczny.Api.ViewModels;
using SklepZoologiczny.IServices.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SklepZoologiczny.Api.Controllers
{
    [ApiVersion( "2.0" )]
    [Route( "api/v{version:apiVersion}/user" )]
    public class UserV2Controller : Controller
    {
        private readonly SklepZoologicznyDbContext _context;
        private readonly IUserService _userService;

        /// <inheritdoc />
        public UserV2Controller(SklepZoologicznyDbContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }
        
        [Route("{userId:min(1)}", Name = "GetUserById")]
        [HttpGet]
        public async Task<IActionResult> GetUserById(int userId)
        {
            var user = await _context.Uzytkownik.FirstOrDefaultAsync(x=>x.UzytkownikId == userId);
            if (user != null)
            {
                return Ok(new UserViewModel
                {
                    UzytkownikId = user.UzytkownikId,
                    Email = user.Email,
                    Login = user.Login,
                    Haslo = user.Haslo
                });
            }
            return NotFound();
        }
        
        [Route("name/{userName}", Name = "GetUserByUserName")]
        [HttpGet]
        public async Task<IActionResult> GetUserByUserName(string userName)
        {
            var user = await _context.Uzytkownik.FirstOrDefaultAsync(x=>x.Login == userName);

            if (user != null)
            {
                return Ok(new UserViewModel
                {

                    Email = user.Email,
                    Login = user.Login,
                    Haslo= user.Haslo,
                    UzytkownikId= user.UzytkownikId
                });
            }
            return NotFound();
        }
        
        [ValidateModel]
        public async Task<IActionResult> Post([FromBody] IServices.Requests.CreateUser createUser)
        {
            var user = await _userService.CreateUser(createUser);
            
            return Created(user.Id.ToString(),UserToUserViewModelMapper.UserToUserViewModel(user)) ;
        }

        [Route("create", Name = "CreateUser")]
        [ValidateModel]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUser createUser)
        {
            System.Console.WriteLine("Started for " + createUser);
            var user = new Uzytkownik
            {
                Login = createUser.Login,
                Email = createUser.Email,
                Haslo = createUser.Haslo,
            };

            await _context.AddAsync(user);
            await _context.SaveChangesAsync();

            return Created(user.UzytkownikId.ToString(), new UserViewModel
            {
                Login = user.Login,
                Email = user.Email,
                Haslo = user.Haslo,
            });
        }

        [Route("edit/{userId:min(1)}", Name = "EditUser")]
        [ValidateModel]
        [HttpPatch]
        public async Task<IActionResult> EditUser([FromBody] EditUser editUser, int userId)
        {
            var user = await _context.Uzytkownik.FirstOrDefaultAsync(x=>x.UzytkownikId == userId);
            user.Login = editUser.Login;
            user.Haslo = editUser.Haslo;
            await _context.SaveChangesAsync();

            return Ok(new UserViewModel
            {
                Email = user.Email,
                Login = user.Login,
                Haslo= user.Haslo,
                UzytkownikId= user.UzytkownikId

            });
        }

        [Route("delete/{userId:min(1)}", Name = "DeleteUser")]
        [ValidateModel]
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            var user = await _context.Uzytkownik.FirstOrDefaultAsync(x => x.UzytkownikId == userId);
            _context.Attach(user);
            _context.Remove(user);
            await _context.SaveChangesAsync();

            return Ok(new UserViewModel
            {
                Email = user.Email,
                Login = user.Login,
                Haslo = user.Haslo,
                UzytkownikId = user.UzytkownikId

            });
        }
    }
}