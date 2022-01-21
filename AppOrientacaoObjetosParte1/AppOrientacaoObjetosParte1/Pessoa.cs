using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOrientacaoObjetosParte1
{
    internal class Pessoa
    {
        // Atributos e Métodos
        // Atributos = características
        // Metodos = ações

        //Declaração de Atributos
        public string nome;
        public int idade;
        public double peso;
        public string sexo;

        //Metodo contrutor
        public Pessoa(string _nome)
        {
            this.nome = _nome;
        }

        public void Andar()
        {
            Console.WriteLine("{0} Está Andando", this.nome);
        }

        public void Comer(string _comida)
        {
            Console.WriteLine("{0} Está comendo {1}", this.nome, _comida );
        }
    }
}
