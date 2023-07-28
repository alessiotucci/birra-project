namespace demo.Model
{
    public class dipendenti
    {
        public string Cf { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        public string Ruolo { get; set; }

        public dipendenti(string _cf, string _nome, string _cognome, string _ruolo)
        {
            Cf = _cf;
            Nome = _nome;
            Cognome = _cognome;
            Ruolo = _ruolo;

        }


    }
}
