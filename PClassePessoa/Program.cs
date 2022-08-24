using System;

namespace PClassePessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] Pessoa = new Pessoa[3];

            for (int i = 0; i < Pessoa.Length; i++)
            {
                Pessoa[i] = new Pessoa();
                Console.WriteLine("Digite o nome da " + (i + 1) + " pessoa ");
                Pessoa[i].setNome(Console.ReadLine());
                Console.WriteLine("Digite a data de nascimento da " + (i + 1) + " pessoa: ");
                Pessoa[i].setNascimento(Console.ReadLine());
                Console.WriteLine("Digite o cpf da" + (i + 1) + " pessoa: ");
                Pessoa[i].setCpf(Console.ReadLine());
                Console.WriteLine("Digite o telefone da " + (i + 1) + " pessoa: ");
                Pessoa[i].setTelefone(Console.ReadLine());
                Console.WriteLine();
            }

            for (int i = 0; i < Pessoa.Length; i++)
            {
                Console.WriteLine("\nPessoa " + (i + 1) + "\n" + Pessoa[i].ToString());
            }
        }
    }
}