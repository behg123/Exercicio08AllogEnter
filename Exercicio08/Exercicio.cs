using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    class Exercicio
    {
        public float ValidarFloat(String text, String input)
        {
            float outputValue;
            while (!float.TryParse(input, out outputValue))
            {
                Console.Clear();
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
            string perguntaSalario = "Qual seu salário?";
            float salario;

            Console.WriteLine(perguntaSalario);
            var input = Console.ReadLine().Replace(".", ",");
            salario = ValidarFloat(perguntaSalario, input);

            salario = salario >= 1850 ? salario + 180 : salario + 320;

            Console.WriteLine($"O novo salário será R${salario},00");
            Console.ReadLine();
        }
    }
}
