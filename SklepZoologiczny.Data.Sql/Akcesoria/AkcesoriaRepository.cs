using System.Threading.Tasks;
using SklepZoologiczny.Api;
using SklepZoologiczny.IData.Akcesoria;

namespace SklepZoologiczny.Api.akcesoria
{
    public class AkcesoriaRepository : IAkcesoriaRepository
    {
        private readonly SklepZoologicznyDbContext _context;

        public AkcesoriaRepository(SklepZoologicznyDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddAkcesoria(Domain.Akcesoria.Akcesoria akcesoria)
        {
            var akcesoriaDAO = new Api.DAO.Akcesoria
            {
                AkcesoriaId = akcesoria.Id,
                Nazwa= akcesoria.Nazwa,
                ProducentId= akcesoria.ProducentId
            };
            await _context.AddAsync(akcesoriaDAO);
            await _context.SaveChangesAsync();
            return akcesoriaDAO.AkcesoriaId;
        }
    }
}