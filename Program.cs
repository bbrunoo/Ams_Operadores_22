using static System.Console;

int valorA = 0;
int valorB = 0;
int result = 0;

WriteLine("Escreva o valor A");
valorA = Convert.ToInt32(ReadLine());

WriteLine("Escreva o valor B");
valorB = Convert.ToInt32(ReadLine());

if (valorA < 0)
{
    WriteLine("Valor Negativo!");

    result = valorA - valorB;
    WriteLine($"Resultado é: {result}");

}

else
{
    WriteLine("Valor Positvo");

    result = valorA - valorB;
    WriteLine($"Resultado é: {result}");
}

