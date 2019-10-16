using System;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {

            int res=10;
            Console.WriteLine("Bem vindo a Escola de Csharp!" + "\n" +
                    "O que deseja fazer?");
            Console.WriteLine(Opcao.Opcoes);
            while (res!=5)
            {
                Console.WriteLine("Digite uma da opções: ");
                res = Convert.ToInt16(Console.ReadLine());
                switch (res)
                {
                    case 1:
                        Opcao.Cadastrar();
                        break;
                    case 2:
                        Opcao.Mostrar();
                        break;
                    case 3:
                        Opcao.Editar();
                        break;
                    case 4:
                        Opcao.Excluir();
                        break;
                }
            }
            Console.WriteLine("FIM");
        }
    }
}
