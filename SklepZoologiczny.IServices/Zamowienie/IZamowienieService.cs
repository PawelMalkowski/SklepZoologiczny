using System.Threading.Tasks;
using SklepZoologiczny.IServices.Requests;

namespace SklepZoologiczny.IServices.Zamowienie
{
    public interface IZamowienieService
    {
        Task<SklepZoologiczny.Domain.Zamowienie.Zamowienie> CreateZamowienie(CreateZamowienie createZamowienie);
    }
}