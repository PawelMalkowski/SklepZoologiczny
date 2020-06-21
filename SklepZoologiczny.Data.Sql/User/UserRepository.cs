using System.Threading.Tasks;
using SklepZoologiczny.Api;
using SklepZoologiczny.IData.User;

namespace SklepZoologiczny.Api.User
{
    public class UserRepository: IUserRepository
    {
        private readonly SklepZoologicznyDbContext _context;

        public UserRepository(SklepZoologicznyDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddUser(Domain.User.User uzytkownik)
        {
           var userDAO =  new Api.DAO.Uzytkownik {
               UzytkownikId = uzytkownik.Id,
               Email = uzytkownik.Email,
               Login = uzytkownik.UserName,
               Haslo = uzytkownik.Password
           };
           await _context.AddAsync(userDAO);
           await _context.SaveChangesAsync();
           return userDAO.UzytkownikId;
        }
    }
}