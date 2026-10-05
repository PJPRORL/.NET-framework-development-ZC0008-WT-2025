using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace TandartsPraktijkAPI.Models
{
    public class Afspraak
    {
        public int Id { get; set; }

        public DateTime DatumTijd { get; set; }

        public string? Opmerkingen { get; set; }

        public string GebruikerId { get; set; }

        public int KlantId { get; set; }

        public int BehandelingId { get; set; }

    }
}
