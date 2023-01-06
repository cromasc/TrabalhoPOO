using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final
{
    internal class Cliente
    {
        private string nome;
        private string cpf;
        private int nPets;
        private string endereco;
        private string usuario;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public int NPets { get => nPets; set => nPets = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Usuario { get => usuario; set => usuario = value; }

        public Cliente(string nome, string cpf, int nPets, string endereco, string usuario)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.nPets = nPets;
            this.endereco = endereco;
            this.usuario = usuario;
        }
    }
}
