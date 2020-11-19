using System;

namespace Exercicios_18_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // int nota;

            // do{
            // Console.WriteLine("Digite uma nota");
            // nota = int.Parse(Console.ReadLine());
            // }while(nota <= 10);{
            //     Console.WriteLine("Nota inválida digite novamente");
            //     Console.ReadLine();
            // }Console.WriteLine("Obrigado!");




            // string nome, senha ;

            // Console.WriteLine("Digite seu nome:");
            // nome = Console.ReadLine();
            // Console.WriteLine("Digite sua senha:");
            // senha = Console.ReadLine();
            
            // while(senha == nome){
            //     Console.WriteLine("Senha inválida");
            //     Console.WriteLine("Digite a senha novamente");
            //     Console.ReadLine();
            // }Console.WriteLine("Bem Vindo!");
            



            // string nome, estciv;
            // int idade;
            // float salario;

            // Console.WriteLine("Digite seu nome");
            // nome = Console.ReadLine();

            // while(nome == ""){
            //     Console.WriteLine("O nome não pode ser vazio");
            //     Console.WriteLine("Digite seu nome");
            //     nome = Console.ReadLine();
            // }

            // Console.WriteLine("Digite sua idade");
            // idade = int.Parse(Console.ReadLine());

            // while(idade <0 || idade >150){
            //     Console.WriteLine("A idade deve ser entre 0 e 150");
            //     Console.WriteLine("Digite sua idade novamente");
            //     idade = int.Parse(Console.ReadLine());
            // }

            // Console.WriteLine("Digite seu salário:");
            // salario = float.Parse(Console.ReadLine());

            // while(salario <=0){
            //     Console.WriteLine("Seu salario deve ser maior que zero");
            //     Console.WriteLine("Digite novamente");
            //     Console.ReadLine();
            // }

            // Console.WriteLine("Estado Civil - Selecione uma opção abaixo");
            // Console.WriteLine("s - Solteiro");
            // Console.WriteLine("c - Casado");
            // Console.WriteLine("v - Viuvo");
            // Console.WriteLine("d - Divorciado");
            // estciv = Console.ReadLine();
            
            // while (estciv != "s" && estciv != "c" && estciv != "v" && estciv != "d"){
            //     Console.WriteLine("Opção inválida, Digite novamente");
            //     Console.ReadLine();
            // }
            // Console.WriteLine("Você selecionou "+estciv);
            



            //Desafio
            
            int n1 = 0;
            int n2 = 1;
            int soma = n1+n2;
            int contador = 1;

            Console.WriteLine(0 + "\n" + 1);

            while(contador <= 14){
                soma = n1 + n2;
                n1 = n2;
                n2 = soma;

                Console.WriteLine(soma);
                
                contador++;
            }
        }//FIM DO MAIN
    }
}
