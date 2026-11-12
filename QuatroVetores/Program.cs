int[] vetor = new int[5];
int[] vetorInverso = new int[5];


montaVetor();
Console.WriteLine("\nVetor:");
escreveVetor(vetor);

Console.WriteLine("\nVetor inverso:");
InverteVetor();
escreveVetor(vetorInverso);

Console.WriteLine("\nVetor Par:");
int numPar = validarPar(vetor);
int[] vetorPar = montaVetorPar();
escreveVetor(vetorPar);


Console.WriteLine("\nVetor Impar:");
int numImpar = validarImpar(vetor);
int[] vetorImpar = montaVetorImpar();
escreveVetor(vetorImpar);


void montaVetor()
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine($"Informe o caracter de posição {i} no vetor: ");
        vetor[i] = int.Parse(Console.ReadLine());
    }
}
int[] montaVetorImpar()
{
    int[] vetorImpar = new int[numImpar];
    int cont = 0;
    for (int i = 0; i < vetor.Length; i++)
    {
        if (vetor[i] % 2 != 0)
        {
            vetorImpar[cont] = vetor[i];
            cont++;
        }
    }
    return vetorImpar;
}
int[] montaVetorPar()
{
    int[] vetorPar = new int[numPar];
    int cont = 0;
    for (int i = 0; i < vetor.Length; i++)
    {
        if (vetor[i] % 2 == 0)
        {
            vetorPar[cont] = vetor[i];
            cont++;
        }
    }
    return vetorPar;
}
void escreveVetor(int[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine($"O caracter de posição {i} no vetor é: {vetor[i]}");
    }
}
void InverteVetor()
{
    int j = 0;
    for (int i = vetor.Length; i > 0; i--)
    {
        vetorInverso[j] = vetor[i - 1];
        j++;
    }
}
int validarPar(int[] vetor)
{
    int cont = 0;
    int quant = 0;
    while (cont < vetor.Length)
    {
        if (vetor[cont] % 2 == 0)
        {
            quant++;
        }
        cont++;
    }
    return quant;
}
int validarImpar(int[] vetor)
{
    int cont = 0;
    int quant = 0;
    while (cont < vetor.Length)
    {
        if (vetor[cont] % 2 != 0)
        {
            quant++;
        }
        cont++;
    }
    return quant;
}


