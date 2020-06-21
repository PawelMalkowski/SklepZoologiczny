using System.Threading.Tasks;
using SklepZoologiczny.IServices.Requests;

namespace SklepZoologiczny.IServices.Akcesoria
{
    public interface IAkcesoriaService
    {
        Task<SklepZoologiczny.Domain.Akcesoria.Akcesoria> CreateAkcesoria(CreateAkcesoria createAkcesoria);
    }
}