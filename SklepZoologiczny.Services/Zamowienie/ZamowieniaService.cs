using System.Threading.Tasks;
using SklepZoologiczny.IData.Zamowienie;
using SklepZoologiczny.IServices.Requests;
using SklepZoologiczny.IServices.Zamowienie;

namespace SklepZoologiczny.Services.Zamowienie
{
    public class ZamowienieService : IZamowienieService
    {
        private readonly IZamowienieRepository _zamowienieRepository;

        public ZamowienieService(IZamowienieRepository zamowieniaRepository)
        {
            _zamowienieRepository = zamowieniaRepository;
        }

        public async Task<Domain.Zamowienie.Zamowienie> CreateZamowienie(CreateZamowienie createZamowienie)
        {
            var zamowienie = new Domain.Zamowienie.Zamowienie(createZamowienie.Data_zlozenia, createZamowienie.Status,createZamowienie.Przesylka,createZamowienie.FirmaId,createZamowienie.KlientId);
            zamowienie.Id = await _zamowienieRepository.AddZamowienie(zamowienie);
            return zamowienie;
        }
    }
}