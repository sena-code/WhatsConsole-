using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WhatsConsole
{
    public class Agenda : IAgenda
    {
        List<Contato> contato = new List<Contato>();
        private const string PATH = "Database/agenda.csv";
        private const string PATHDIRECTORY = "Database";
       


        public Agenda(){

            if(!Directory.Exists(PATHDIRECTORY))
            {
                Directory.CreateDirectory(PATHDIRECTORY);
            }
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
           
        public string Separate(string data)
        {
            return data.Split("=")[1];
        }
        public void Cadastrar(Contato c)
        {
            List<Contato> cont = new List<Contato>();
            var line = new string[] { PrepararLinha(c) };

           File.AppendAllLines(PATH, line);
        }

        public void Excluir(string _cont)
        {
              List<string> lines = new List<string>();

                //we use "using" for open and close our file with database
                using(StreamReader file = new StreamReader(PATH))
                {
                    //Read the file
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                    //Remove all lines that have the term solicited
                    lines.RemoveAll(z => z.Contains(_cont));
                }
        }

        public List<Contato> Listar()
        {
            List<Contato> cont = new List<Contato>();

            string[] lines = File.ReadAllLines(PATH);

            foreach(string line in lines )
            {
                string[] data = line.Split(";");

                Contato c = new Contato();
                c.Nome = Separate(data[0]);
                c.Telefone = Int32.Parse(Separate(data[1]));
                c.Texto = Separate(data[2]);

                cont.Add(c);

                cont = cont.OrderBy(x => x.Nome).ToList();

            } return cont;
        }

        public string PrepararLinha(Contato contato)
        {
          return $"name={contato.Nome}; Telefone={contato.Telefone}; Mensagem={contato.Texto};";
        }

       
        
    }
}