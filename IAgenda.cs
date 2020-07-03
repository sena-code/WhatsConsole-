using System.Collections.Generic;

namespace WhatsConsole
{
    public interface IAgenda
    {
        string Separate(string data);
         void Cadastrar(Contato cont);
         void Excluir(string _cont);
         List<Contato> Listar();
         string PrepararLinha(Contato contato);

         


    }
}