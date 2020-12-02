using System;
using exercicio_0212.Alunos;

namespace exercicio_0212
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();

            Console.WriteLine("Digite o nome do aluno");
            aluno1.nome = Console.ReadLine();

            Console.WriteLine("Digite o curso do aluno");
            aluno1.curso =  Console.ReadLine();

            Console.WriteLine("Digite o RG do Aluno");
            aluno1.RG = Console.ReadLine();

            Console.WriteLine("Digite o idade do Aluno");
            aluno1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a média final do aluno");
            aluno1.idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o valor da mensalidade");
            aluno1.valormensalidade = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite se o aluno é bolsista: s/n");
            string resposta = Console.ReadLine();

            if(resposta =="S"){
                aluno1.bolsista = true;
            }else{
                aluno1.bolsista = false;
            }
            int opcao = 0;

            do{
                Console.WriteLine("Selecione uma opção: ");
                Console.WriteLine("[1] - ver média do aluno");
                Console.WriteLine("[2] - ver mensalidade ");
                Console.WriteLine("[3] - sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                    Console.WriteLine($"A média final do aluno {aluno1.nome} = {aluno1.vermedialuno()}");
                    break;
                    case 2:
                    Console.WriteLine($"O valor da mensalidade fica em: {aluno1.VerMensalidade()}");
                    break;
                    case 3:
                    Console.WriteLine("Obrigado por acessar!");
                    break;
                    default:
                    Console.WriteLine("opção inválida");
                    break;
                }
                
            }while(opcao != 0);
        }
    }
}
