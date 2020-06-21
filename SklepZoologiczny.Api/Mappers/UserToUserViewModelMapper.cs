using SklepZoologiczny.Api.ViewModels;

namespace SklepZoologiczny.Api.Mappers
{
    public class UserToUserViewModelMapper
    {
        public static UserViewModel UserToUserViewModel(Domain.User.User user)
        {
            var userViewModel = new UserViewModel
            {
                UzytkownikId = user.Id,
                Email = user.Email,
                Login = user.UserName,
                Haslo = user.Password,


            };
            return userViewModel;
        }
    }
}