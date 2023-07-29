namespace demo.Model
{
    public class Dipendenti
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        public string? Ruolo { get; set; }

        public Dipendenti(string id, string nome, string cognome, string? ruolo = null)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cognome = cognome;
            this.Ruolo = ruolo;
        }



    }
}
