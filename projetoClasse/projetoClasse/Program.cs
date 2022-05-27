using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            Console.Write("Digite o nome da pessoa: "); string n = Console.ReadLine();
            Console.Write($"Digite a Idade de {n}: "); int i = int.Parse(Console.ReadLine());
            Console.Write($"Digite a altura de {n}: "); double a = double.Parse(Console.ReadLine());
            ClassePessoa pessoa = new ClassePessoa();
         

            Console.WriteLine("\n \n***Dados da pessoa***");
            Console.WriteLine($"Nome: {n} \n Idade: {i} \n Altura: {a}");

            Console.WriteLine(pessoa.Altura.ToString());

            Console.ReadKey();


        }
    }
}
