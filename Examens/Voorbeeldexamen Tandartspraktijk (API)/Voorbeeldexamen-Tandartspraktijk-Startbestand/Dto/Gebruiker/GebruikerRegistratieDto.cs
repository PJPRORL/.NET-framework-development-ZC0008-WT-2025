namespace TandartsPraktijkAPI.Dto
{
    public class GebruikerRegistratieDto
    {
        [Required(ErrorMessage = "Naam is benodigd!")]
        [StringLength(100)]
        public string GebruikersNaam { get; set; } = "";

        [EmailAddress(ErrorMessage = "Ongeldig emailadres")]
        [Required(ErrorMessage = "Email is verplicht!")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Wachtwoord is verplicht!")]
        public string Wachtwoord { get; set; } = "";

        [Required(ErrorMessage = "Tweede wachtwoord is verplicht in te vullen.")]
        [Compare("Password", ErrorMessage = "De wachtwoorden komen niet overeen.")]
        public string BevestigWachtwoord { get; set; } = "";
        public string Telefoonnummer { get; set; } = "";
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Adres { get; set; }
        public string Specialisatie { get; set; }
        public string Licentie { get; set; }
    }
}
