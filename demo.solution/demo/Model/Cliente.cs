namespace demo.Model
{
    public class Cliente 
    {
      
        public int Id { get; set; }

        public string Nome { get; set; }
        public string stocazzo { get; set; }

        public string Cognome { get; set; }
        public string Tipologia { get; set; } // da aquisire o cliente fisso
       // public int  Contrattounic { get; set; }

        public Cliente( int Id, string nome,string stocazzo, string cognome, string tipologia /*, int contrattoid*/)
        {
            this.stocazzo = stocazzo;
            this.Id = Id;
            Nome = nome;
            Cognome = cognome;
            Tipologia = tipologia;
         //   Contrattounic = contrattoid;
        }
    }
}
