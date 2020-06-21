using System.Threading.Tasks;

namespace SklepZoologiczny.IData.Zamowienie
{
    public interface IZamowienieRepository
    {
        Task<int> AddZamowienie(SklepZoologiczny.Domain.Zamowienie.Zamowienie zamowienie);
    }
}