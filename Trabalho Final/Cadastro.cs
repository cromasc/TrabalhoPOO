using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final
{
    internal class Cadastro
    {
        public string nome;
        public string usuario;
        public string senha;
        public string CPF;
        public string endereco;
        public int nPets;
        public string[] nomePets;

        public Cadastro(string nome, string usuario, string senha, string CPF, string endereco, string[] nomePets)
        {
            this.nome = nome;
            this.usuario = usuario;
            this.senha = senha;
            this.CPF = CPF;
            this.endereco = endereco;
            this.nPets = nomePets.Length;
            this.nomePets = nomePets;
        }
    }
}
