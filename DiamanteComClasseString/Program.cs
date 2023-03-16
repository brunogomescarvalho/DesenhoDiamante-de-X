Console.Clear();
Console.WriteLine("--- Pirâmide Diamante ---");

var x = 0;
do
{
    System.Console.WriteLine("Informe o valor de X"); 
    x = int.Parse(Console.ReadLine()!); 

    if (x % 2 == 0)
    {
        Console.Clear();
        System.Console.WriteLine("O valor de X precisa ser ímpar\nTecle para continuar");
        Console.ReadKey();
        Console.Clear();
    }

} while (x % 2 == 0);

var cursor = x + 2;
var metade = (x - 1) / 2;
var inf = (x - 2);
var sup = 1;

Console.CursorLeft = (cursor);

for (int i = 0; i <= metade; i++)
{
    string superior = new String('X', sup);
    System.Console.WriteLine(superior);
    Console.CursorLeft = cursor -= 1;
    sup += 2;
}

Console.CursorLeft = cursor += 2;

for (int i = 0; i < metade; i++)
{
    string inferior = new String('X', inf);
    System.Console.WriteLine(inferior);
    Console.CursorLeft = cursor += 1;
    inf -= 2;
}

