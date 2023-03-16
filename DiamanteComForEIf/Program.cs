Console.WriteLine("--- Pirâmide Diamante ---");
int tamanho = 0;
do
{
    System.Console.WriteLine("Informe o valor de X");
    tamanho = int.Parse(Console.ReadLine()!);

    if (tamanho % 2 == 0)
    {
        Console.Clear();
        System.Console.WriteLine("O valor de X precisa ser ímpar\nTecle para continuar");
        Console.ReadKey();
        Console.Clear();
    }

} while (tamanho % 2 == 0);

int meio = (tamanho - 1) / 2;
int qtdX = 1;
int qtdBranco = meio;

//superior

for (int i = 0; i <= meio - 1; i++)
{
    for (int h = 0; h <= qtdBranco; h++)
    {
        System.Console.Write(" ");
    }
    for (int h = 0; h < qtdX; h++)
    {
        System.Console.Write("X");
    }

    Console.WriteLine();
    qtdBranco--;
    qtdX += 2;
}

meio = 1;

// linha central

for (int j = 0; j < meio; j++)
{
    System.Console.Write(" ");
}
for (int i = 0; i < tamanho; i++)
{
    System.Console.Write("X");
}

Console.WriteLine();


// inferior

qtdX = tamanho - 2;
meio = (tamanho - 1) / 2;
qtdBranco = 2;

for (int i = 0; i < meio; i++)
{
    for (int h = 0; h < qtdBranco; h++)
    {
        System.Console.Write(" ");
    }
    for (int h = 0; h < qtdX; h++)
    {
        System.Console.Write("X");
    }

    Console.WriteLine();
    qtdBranco++;
    qtdX -= 2;
}

