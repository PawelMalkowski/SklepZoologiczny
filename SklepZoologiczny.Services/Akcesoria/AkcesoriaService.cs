using System.Threading.Tasks;
using SklepZoologiczny.IData.Akcesoria;
using SklepZoologiczny.IServices.Requests;
using SklepZoologiczny.IServices.Akcesoria;

namespace SklepZoologiczny.Services.Akcesoria
{
    public class AkcesoriaService : IAkcesoriaService
    {
        private readonly IAkcesoriaRepository _akcesoriaRepository;

        public AkcesoriaService(IAkcesoriaRepository akcesoriaRepository)
        {
            _akcesoriaRepository = akcesoriaRepository;
        }

        public async Task<Domain.Akcesoria.Akcesoria> CreateAkcesoria(CreateAkcesoria createAkcesoria)
        {
            var akcesoria = new Domain.Akcesoria.Akcesoria(createAkcesoria.AkcesoriaId,createAkcesoria.Nazwa, createAkcesoria.ProducentId);
            akcesoria.Id = await _akcesoriaRepository.AddAkcesoria(akcesoria);
            return akcesoria;
        }
    }
}