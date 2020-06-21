using SklepZoologiczny.Api.ViewModels;

namespace SklepZoologiczny.Api.Mappers
{
    public class AkcesoriaToAkcesoriaViewModelMapper
    {
        public static AkcesoriaViewModel AkcesoriaToAkcesoriaViewModel(Domain.Akcesoria.Akcesoria akcesoria)
        {
            var userViewModel = new AkcesoriaViewModel
            {
                AkcesoriaId = akcesoria.Id,
                Nazwa = akcesoria.Nazwa,
                ProducentId = akcesoria.ProducentId

            };
            return userViewModel;
        }
    }
}
