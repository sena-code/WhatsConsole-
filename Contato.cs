namespace WhatsConsole
{
    public class Contato : Agenda
    {
        public string Nome { get; set; }
        public int Telefone { get; set; }

        public Contato (string _nome, int _telefone)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
           
        }

        public Contato()
        {
        }
    }
}