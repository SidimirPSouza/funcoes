void Hello(string nome)
{
    Console.WriteLine($"Olá {nome}! Seja bem-vindo");
}

Console.WriteLine($"Digite o nome: ");
string nome = Console.ReadLine();
Hello(nome);