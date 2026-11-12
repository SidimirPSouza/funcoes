string[] vetor = new string[10];
string[] NovoVetor = new string[20];

void montarVetor()
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine($"Digite o caracter da posição {i}: ");
        vetor[i] = Console.ReadLine();
    }
}

void montarNovoVetor()
{
    int cont = 0;
    for (int i = 0; i < NovoVetor.Length; i++)
    {
        if (i == 0 || i % 2 == 0)
        {
            NovoVetor[i] = vetor[cont];
        }
        else
        {
            char caracter = char.Parse(vetor[cont]);
            int ASC = caracter;
            NovoVetor[i] = $"{ASC}";
            cont++;
        }
    }
}
void escreveVetor(string[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        if (i == 0 || i % 2 == 0)
        {
            Console.WriteLine($"O caracter de posição {i} no vetor é: {vetor[i]}");
        }
        else
        {
            Console.WriteLine($"O codigo ASCII de posição {i} no vetor é: {vetor[i]} e corresponde ao caracter de posição {i - 1}");
            Console.WriteLine("\n");
        }
    }
}

montarVetor();
montarNovoVetor();
Console.WriteLine("\n");
escreveVetor(NovoVetor);


