using System.Threading.Tasks;

namespace SklepZoologiczny.IData.User
{
    public interface IUserRepository
    {
        Task<int> AddUser(SklepZoologiczny.Domain.User.User user);
    }
}