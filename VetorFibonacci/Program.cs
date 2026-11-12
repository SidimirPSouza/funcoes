Console.WriteLine("Digite a posição desejada: ");
int num = int.Parse(Console.ReadLine());
int cont = 0;
int fibonacci = 1;
int termo = 0;
int[] Vetor = new int[num];

void montarVetor()
{
    while (cont < num)
    {
        Vetor[cont] = fibonacci;
        int antigoTermo = termo;
        termo = fibonacci;
        fibonacci += antigoTermo;
        cont++;
    }
}

void escreveVetor(int[] vetor)
{
    int cont = 0;
    while (cont < num)
    {
        Console.WriteLine($"A posição {cont + 1} da sequencia de fibonacci é: {Vetor[cont]}");
        cont++;
    }
}

montarVetor();
escreveVetor(Vetor);
