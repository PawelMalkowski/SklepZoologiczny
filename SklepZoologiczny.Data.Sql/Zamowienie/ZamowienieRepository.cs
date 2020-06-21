using System.Threading.Tasks;
using SklepZoologiczny.Api;
using SklepZoologiczny.IData.Zamowienie;

namespace SklepZoologiczny.Api.zamowienie
{
    public class ZamowienieRepository : IZamowienieRepository
    {
        private readonly SklepZoologicznyDbContext _context;

        public ZamowienieRepository(SklepZoologicznyDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddZamowienie (Domain.Zamowienie.Zamowienie zamowienie)
        {
            var zamowienieDAO = new Api.DAO.Zamowienie
            {
                ZamowienieId = zamowienie.Id,
                Data_zlozenia= zamowienie.Data_zlozenia,
                Status= zamowienie.Status,
                Przesylka=zamowienie.Przesylka,
                FirmaId= zamowienie.FirmaId,
                KlientId= zamowienie.KlientId
            };
            await _context.AddAsync(zamowienieDAO);
            await _context.SaveChangesAsync();
            return zamowienieDAO.ZamowienieId;
        }
    }
}