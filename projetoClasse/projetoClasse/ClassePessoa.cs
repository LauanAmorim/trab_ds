using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projetoClasse
{
    internal class ClassePessoa
    {

        private string nome;
        private int idade;
        private double altura;

        public ClassePessoa()
        {
            this.nome = null;
            this.idade = 0;
            this.altura = 0;
        }

        public string Nome {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade {
            get { return idade; }
            set { idade = value; }
        }

        public double Altura { 
            get { return altura; }
            set { altura = value; }
        }

        public override string ToString()
        {
            return (String.Format($"Nome: {nome} \n Idade: {idade} \n Altura: {altura}"));
        }
    }
}
