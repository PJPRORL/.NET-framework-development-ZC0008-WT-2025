namespace TandartsPraktijkAPI.Models
{
    public class Gebruiker: IdentityUser
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Adres { get; set; }
        public string Telefoonnummer { get; set; }
        public string Specialisatie { get; set; }
        public string Licentie { get; set; }

    }
}
