namespace SklepZoologiczny.Api.DAO
{
    public class UzytkownikFirma
    {
        public int UzytkownikFirmaId { get; set; }
        public int UzytkownikId { get; set; }
        public int FirmaId { get; set; }

        public virtual Uzytkownik Uzytkownik { get; set; }
        public virtual Firma Firma { get; set; }
    }
}
