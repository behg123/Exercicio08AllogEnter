using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    class Exercicio
    {
        // Função que fará a verificação do 
        public float ValidarValor(String text, String input)
        {
            float outputValue;
            // Enquanto a conversão da string não der um valor float, ou a conversão de um valor menor que zero, ele continuará fazendo a função
            while (!float.TryParse(input, out outputValue) || float.Parse(input) < 0)
            {
                Console.Clear();

                //Se o valor for negativo, será mostrado uma mensagem personalizado ao usuário
                if (float.Parse(input) < 0)
                    Console.WriteLine("Valor inválido, Seu salário não pode ser negativo");
                //Se o valor não for numérico, será mostrado uma mensagem personalizado ao usuário
                else
                    Console.WriteLine("Valor inválido, Digite apenas números");


                Console.WriteLine(text + ": ");
                input = Console.ReadLine();
            }
            return outputValue;
        }
        public void Exercicio08()
        {

            /* Crie um programa que calcule o reajuste salarial. 
             * Se o salário for abaixo de 1.850 o ajuste é de R$320.00,
             * se maior de R$ 180.00. Para finalizar, exiba o novo salário na tela.
             */
            string resposta = "1",
                   perguntaSalario = "Qual seu salário?";
            float salario;

            // Enquanto a resposta do usuário não for zero
            while (resposta != "0"){
                Console.Clear();

                // Perguntar ao usuário o valor de seu salário
                Console.WriteLine(perguntaSalario);
                var input = Console.ReadLine().Replace(".", ",");

                // Será feita a verificação se o valor digitado é realmente um float
                salario = ValidarValor(perguntaSalario, input);

                // Função em que, se for maior que 1850, será adicionado 180, se não será adicionado 320
                salario = salario >= 1850 ? salario + 180 : salario + 320;

                // Mostrar na tela
                Console.WriteLine($"O novo salário será R${salario},00");

                // Perguntar se deseja continuar
                Console.WriteLine("Deseja continuar? Sim (1) Não (0)");
                resposta = Console.ReadLine();

            }

        }
    }
}
