using System.Threading.Tasks;
using SklepZoologiczny.IServices.Requests;

namespace SklepZoologiczny.IServices.User
{
    public interface IUserService
    {
        Task<SklepZoologiczny.Domain.User.User> CreateUser(CreateUser createUser);
    }
}