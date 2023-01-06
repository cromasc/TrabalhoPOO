using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final
{
    internal class Produto
    {
        private string nome;
        private int quantidade;
        private string identificador;

        public string Nome { get => nome; set => nome = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Identificador { get => identificador; set => identificador = value; }

        public Produto(string nome, int quantidade, string identificador)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.identificador = identificador;
        }
    }
}
