namespace WhatsConsole
{
    public class Mensagem : Contato
    {
        public string Texto { get; set; }
        public string Destinário { get; set; }

        public string Enviar(Contato cont){
            return Texto;
        }
    }
}