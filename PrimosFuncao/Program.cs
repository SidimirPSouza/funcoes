bool EPrimo(int numero)
{
    if (numero == 1)
        return false;

    int cont = 0;

    for (int i = 2; i <= numero; i++)
    {
        if (numero % i == 0)
        {
            return false;
        }
    }
    return true;
}

void primos(int numero)
{
    for (int i = numero; i >= 2; i--)
    {

        if (EPrimo(numero) && numero == i)
        {
            Console.WriteLine("O numero informado é primo");
        }
        else if(!EPrimo(numero))
        {
            Console.WriteLine("O numero informado não é primo");
            break;
        }
        else
        {            
        if (EPrimo(i))
            Console.WriteLine(i);
        }

    }
}

Console.WriteLine("Informe o numero desejado: ");
primos(int.Parse(Console.ReadLine()));

