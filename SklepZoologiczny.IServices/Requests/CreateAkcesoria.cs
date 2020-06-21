using System;


namespace SklepZoologiczny.IServices.Requests
{
    public class CreateAkcesoria
    {
        public int AkcesoriaId { get; set; }
        public string Nazwa { get; set; }
        public int ProducentId { get; set; }

    }
}