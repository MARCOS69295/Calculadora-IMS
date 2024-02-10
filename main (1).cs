using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Índice de Massa Corporal (IMC)");

            // Solicita o peso do usuário
            Console.Write("Digite seu peso em quilogramas (kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            // Solicita a altura do usuário
            Console.Write("Digite sua altura em metros (m): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            // Calcula o IMC
            double imc = CalcularIMC(peso, altura);

            // Exibe o IMC e a categoria
            Console.WriteLine($"Seu IMC é: {imc:F2}");
            Console.WriteLine($"Categoria: {InterpretarIMC(imc)}");

            Console.ReadKey();
        }

        static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        static string InterpretarIMC(double imc)
        {
            if (imc < 18.5)
                return "Abaixo do peso";
            else if (imc >= 18.5 && imc <= 24.9)
                return "Peso normal";
            else if (imc >= 25 && imc <= 29.9)
                return "Sobrepeso";
            else if (imc >= 30 && imc <= 34.9)
                return "Obesidade grau I";
            else if (imc >= 35 && imc <= 39.9)
                return "Obesidade grau II";
            else
                return "Obesidade grau III ou mórbida";
        }
    }
}
