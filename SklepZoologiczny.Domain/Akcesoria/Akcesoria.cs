using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny.Domain.Akcesoria
{
    public class Akcesoria
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int ProducentId { get; set; }

        public Akcesoria(int id, string nazwa, int producentId)
        {
            Id = id;
            Nazwa = nazwa;
            ProducentId = producentId;

        }
    }
}
