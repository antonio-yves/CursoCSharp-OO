using System;

class Program
{
    static void Main(string[] agrs)
    {
        Console.WriteLine("Bem vindx ao byteBank!");

        string NomeTitular = "João Gomes";
        string Conta = "1234-x";
        int Agencia = 23;
        string NomeAgencia = "Agência Central";
        double Saldo = 93.50;

        Console.WriteLine("\nNome do Titular: " + NomeTitular);
        Console.WriteLine("Agência: " + Agencia);
        Console.WriteLine("Conta: " + Conta);
        Console.WriteLine("Nome da Agência: " + NomeAgencia);
        Console.WriteLine("Saldo: R$ " + Saldo);
    }
}