namespace demo.Model
{
    public class Cliente 
    {
        public string AgenteCf { get; set; }
        public int Piva { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }
        public string Tipologia { get; set; } // da aquisire o cliente fisso
        public int  ContrattoId { get; set; }

        public Cliente(string agentecf, int piva, string nome, string cognome, string tipologia, int contrattoid)
        {
            AgenteCf = agentecf;
            Piva = piva;
            Nome = nome;
            Cognome = cognome;
            Tipologia = tipologia;
            ContrattoId = contrattoid;
        }
    }
}
