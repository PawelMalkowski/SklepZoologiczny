using SklepZoologiczny.Api.ViewModels;

namespace SklepZoologiczny.Api.Mappers
{
    public class ZamowienieToZamowienieViewModelMapper
    {
        public static ZamowienieViewModel ZamowienieToZamowienieViewModel(Domain.Zamowienie.Zamowienie zamowienie)
        {
            var zamowienieViewModel = new ZamowienieViewModel
            {
               ZamowienieId=zamowienie.Id,
               Data_zlozenia= zamowienie.Data_zlozenia,
               Status= zamowienie.Status,
               Przesylka= zamowienie.Przesylka,
               FirmaId= zamowienie.FirmaId,
               KlientId= zamowienie.KlientId

            };
            return zamowienieViewModel;
        }
    }
}
