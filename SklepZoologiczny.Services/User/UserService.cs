using System.Threading.Tasks;
using SklepZoologiczny.IData.User;
using SklepZoologiczny.IServices.Requests;
using SklepZoologiczny.IServices.User;

namespace SklepZoologiczny.Services.User
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Domain.User.User> CreateUser(CreateUser createUser)
        {
            var user = new Domain.User.User(createUser.UserName, createUser.Email, createUser.Password);
            user.Id = await _userRepository.AddUser(user);
            return user;
        }
    }
}