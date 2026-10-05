using System.ComponentModel.DataAnnotations.Schema;

namespace TandartsPraktijkAPI.Models
{
    public class Behandeling
    {
        public int Id { get; set; }

        public string Naam { get; set; }

        public decimal Prijs { get; set; }

        public string Beschrijving { get; set; }

    }
}
