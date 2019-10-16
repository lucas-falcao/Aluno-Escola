using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cadastro
{
    public static class Opcao
    {
        private static List<Aluno> lista = new List<Aluno>();
        public static string Opcoes = "Para cadastrar aluno: 1" + "\n" +
                                        "Para vizualizar os dados: 2" + "\n" +
                                        "Para atualizar aluno: 3" + "\n" +
                                        "Para excluir aluno: 4" + "\n" +
                                        "Para sair: 5 " + "\n";
                                        
        public static void Cadastrar()
        {
            Console.WriteLine("Qual o cpf do aluno?");
            string cpf = Console.ReadLine();
            Aluno aluno = new Aluno(cpf);
            Console.WriteLine("Nome:");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Idade do aluno: ");
            aluno.idade = Convert.ToInt16(Console.ReadLine());
            lista.Add(aluno);
        }
        public static void Mostrar()
        {
            Console.WriteLine("Qual o cpf?");
            string cpf = Console.ReadLine();
            Aluno aluno = lista.Where(c => c.cpf == cpf).FirstOrDefault();
            Console.WriteLine($"O aluno {aluno.nome} está cadastrado e tem {aluno.idade} anos");
        }
        public static void Excluir()
        {
            Console.WriteLine("Qualo cpf");
            string cpf = Console.ReadLine();
            Aluno aluno = lista.Where(c => c.cpf == cpf).FirstOrDefault();
            lista.Remove(aluno);
        }

        public static void Editar()
        {
            Console.WriteLine("Qual o seu cpf?");
            string cpf = Console.ReadLine();
            if (lista.Any(c => c.cpf == cpf)){
                Console.WriteLine("Mudar nome ou idade");
                string res = Console.ReadLine();
                switch (res)
                {
                    case "nome":
                        Console.WriteLine("Qual o novo nome?");
                        string nome = Console.ReadLine();
                        modificaNome(nome);
                        break;
                    case "idade":
                        Console.WriteLine("Qual a nova idade?");
                        int idade = Convert.ToInt16(Console.ReadLine());
                        modificaIdade(idade);
                            break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Não existe aluno cadastrado com esse cpf!");
            }
        }





        private static void modificaNome(string nome){
            var _aluno = lista.FirstOrDefault(c => c.nome == nome).nome = nome;

            
        }
        private static void modificaIdade(int idade)
        {
            var _aluno = lista.FirstOrDefault(c => c.idade == idade).idade = idade;



        }

    }
}
