using System;
using System.Collections.Generic;

namespace WhatsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contato> contatos = new List<Contato>();
            Contato c1 = new Contato();
            c1.Nome = "Carol";
            c1.Telefone = 994521579;

            c1.Cadastrar(c1);

             Contato c2 = new Contato();
            c2.Nome = "Mãe";
            c2.Telefone = 961541277;

            c2.Cadastrar(c2);

             Contato c3 = new Contato();
            c3.Nome = "Pai";
            c3.Telefone = 948521374;

            c3.Cadastrar(c3);

            Contato co = new Contato();
            List<Contato> cont =co.Listar();

            foreach (Contato ct in cont)
            {
                Console.WriteLine($"{ct.Nome} - {ct.Telefone}");
            }

        }
    }
}
