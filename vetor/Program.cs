int[] numbers = new int[4];
int cont = 0;

void populaVetor()
{
    cont = 0;
    do
    {
        Console.WriteLine($"informe o numero que você deseja adicionar na posição {cont}: ");

        numbers[cont] = int.Parse(Console.ReadLine());
        cont++;
    } while (cont < numbers.Length);
}

void exibeVetor()
{

    cont = 0;
    while (cont < numbers.Length)
    {
        Console.WriteLine($"O numero na posição {cont} é: {numbers[cont]} ");
        cont++;
    } 
}

populaVetor();
exibeVetor();


