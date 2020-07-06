using System.Collections.Generic;
using System.IO;

namespace WhatsConsole
{
    public class Mensagem 
    {
        public string Texto { get; set; }
        public Contato Destinario { get; set; }

        public string Enviar(Contato c)
        {
            return $"Para: {c.Nome} - Mensagem {Texto}";
        }

       
    }
}