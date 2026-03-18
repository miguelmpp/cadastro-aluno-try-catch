using System;

namespace CadastroAluno
{
    public class Aluno
    {
        private string nome;
        private int idade;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new CadastroInvalidoException("O nome do aluno não pode estar vazio.");

                nome = value;
            }
        }

        public int Idade
        {
            get { return idade; }
            set
            {
                if (value < 0)
                    throw new CadastroInvalidoException("A idade não pode ser negativa.");

                idade = value;
            }
        }

        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void ExibirDados()
        {
            Console.WriteLine("\nAluno cadastrado com sucesso!");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
        }
    }
}