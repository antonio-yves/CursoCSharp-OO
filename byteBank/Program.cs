using System.Windows;
using byteBank;

class Program
{
    static void Main(string[] agrs)
    {
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.Clear();

        Console.WriteLine("Bem vindx ao byteBank!");

        ContaCorrente contaCorrente = new ContaCorrente();

        contaCorrente.Titular = "João Gomes";
        contaCorrente.Conta = "1234-x";
        contaCorrente.Agencia = 23;
        contaCorrente.NomeAgencia = "Agência Central";
        contaCorrente.Saldo = 93.50;

        Console.WriteLine("\nNome do Titular: " + contaCorrente.Titular);
        Console.WriteLine("Agência: " + contaCorrente.Agencia);
        Console.WriteLine("Conta: " + contaCorrente.Conta);
        Console.WriteLine("Nome da Agência: " + contaCorrente.NomeAgencia);
        Console.WriteLine("Saldo: R$ " + contaCorrente.Saldo);
    }
}