using System;

namespace CadastroAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE CADASTRO DE ALUNO ===");
                Console.WriteLine("1 - Cadastrar aluno");
                Console.WriteLine("2 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarAluno();
                        break;

                    case "2":
                        continuar = false;
                        Console.WriteLine("Encerrando o sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        Pausar();
                        break;
                }
            }
        }

        static void CadastrarAluno()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("=== CADASTRO DE ALUNO ===");

                Console.Write("Digite o nome do aluno: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a idade do aluno: ");
                int idade = int.Parse(Console.ReadLine());

                Aluno aluno = new Aluno(nome, idade);
                aluno.ExibirDados();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nErro: a idade deve ser um número inteiro válido.");
            }
            catch (CadastroInvalidoException ex)
            {
                Console.WriteLine($"\nErro de cadastro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro inesperado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nProcesso finalizado.");
                Pausar();
            }
        }

        static void Pausar()
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}