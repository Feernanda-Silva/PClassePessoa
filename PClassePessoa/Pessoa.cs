using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClassePessoa
{
    internal class Pessoa
    {
        String nome;
        String nascimento;
        String cpf;
        String telefone;

        public override string ToString() //override: aproveita um metodo que ja existe
        {
            return "Nome: " + nome + "\nNascimento: " + nascimento + "\nCpf: " + cpf + "\nTelefone:" + telefone;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setNascimento(String nascimento)
        {
            this.nascimento = nascimento;
        }

        public void setCpf(String cpf)
        {
            this.cpf = cpf;
        }

        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }

        public String getNome()
        {
            return nome;
        }

        public String getNascimento()
        {
            return nascimento;
        }

        public String getCpf()
        {
            return cpf;
        }

        public String getTelefone()
        {
            return telefone;
        }
    }
}
