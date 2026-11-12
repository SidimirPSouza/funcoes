Console.WriteLine("Escolha o tamanho de 1 a 6 para o seu vetor: ");
int tam = int.Parse(Console.ReadLine());
char[] vetor = new char[tam];

void montaVetor()
{
    for (int i = 0; i < tam; i++)
    {
        Console.WriteLine($"Informe o caracter de posição {i} no vetor: ");
        vetor[i] = char.Parse(Console.ReadLine());
    }
}

void escreveVetor()
{
    for (int i = 0; i < tam; i++)
    {
        Console.WriteLine($"O caracter de posição {i} no vetor é: {vetor[i]}");
    }
}

void InverteEscreveVetor()
{
    for (int i = tam-1; i >= 0; i--)
    {
        Console.WriteLine($"O caracter de posição {i} no vetor é: {vetor[i]}");
    }
}

if (tam <= 6 && tam > 0)
{
    Console.WriteLine("\n");
    montaVetor();
    Console.WriteLine("\n");
    escreveVetor();
    Console.WriteLine("\n");
    InverteEscreveVetor();
}
else
{
    Console.WriteLine("tamanho do vetor inválido");
}


