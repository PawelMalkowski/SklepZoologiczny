using System.Threading.Tasks;

namespace SklepZoologiczny.IData.Akcesoria
{
    public interface IAkcesoriaRepository
    {
        Task<int> AddAkcesoria(SklepZoologiczny.Domain.Akcesoria.Akcesoria akcesoria);
    }
}