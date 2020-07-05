namespace WhatsConsole
{
    public class Contato : Agenda
    {
        public string Nome { get; set; }
        public int Telefone { get; set; }
         public string Texto {get; set;}
        public string Destinário {get; set;}

        public Contato (string _nome, int _telefone, string _texto, string _dest)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.Texto = _texto;
            this.Destinário = _dest;
        }

        public Contato()
        {
        }
    }
}