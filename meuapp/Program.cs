using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura (em metros): ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso (em kg): ");
            double peso = double.Parse(Console.ReadLine());

            double imc = CalcularIMC(peso, altura);
            string categoriaIMC = DeterminarCategoriaIMC(imc);
            string faixaEtaria = DeterminarFaixaEtaria(idade);

            Console.WriteLine("\nRelatório:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"IMC: {imc:F2} ({categoriaIMC})");
            Console.WriteLine($"Faixa Etária: {faixaEtaria}");

            Console.Write("\nDeseja gerar um novo relatório para outra pessoa? (S/N): ");
            string resposta = Console.ReadLine();
            if (resposta.ToUpper() != "S")
            {
                break;
            }
        }
    }

    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    static string DeterminarCategoriaIMC(double imc)
    {
        if (imc < 18.5)
        {
            return "Abaixo do peso";
        }
        else if (imc < 24.9)
        {
            return "Normal";
        }
        else if (imc < 29.9)
        {
            return "Sobrepeso";
        }
        else
        {
            return "Obeso";
        }
    }

    static string DeterminarFaixaEtaria(int idade)
    {
        if (idade < 12)
        {
            return "Criança";
        }
        else if (idade < 18)
        {
            return "Adolescente";
        }
        else if (idade < 60)
        {
            return "Adulto";
        }
        else
        {
            return "Idoso";
        }
    }
}


