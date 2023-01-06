using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final
{
    internal class Pets
    {
        private string nome;
        private string dono;
        private int idade;

        public string Nome { get => nome; set => nome = value; }
        public string Dono { get => dono; set => dono = value; }
        public int Idade { get => idade; set => idade = value; }

        public Pets(string nome, string dono, int idade)
        {
            this.nome = nome;
            this.dono = dono;
            this.idade = idade;
        }
    }
}
