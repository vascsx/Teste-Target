using System;

class QuestaoSecond
{
    private int[] sequencia;

    public QuestaoSecond(int limite)
    {
        sequencia = new int[limite];
        sequencia[0] = 0;
        sequencia[1] = 1;
        for (int i = 2; i < limite; i++)
        {
            try
            {
                sequencia[i] = checked(sequencia[i - 1] + sequencia[i - 2]);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Erro: O limite do tipo 'int' foi ultrapassado ao calcular a sequência de Fibonacci.");
                Environment.Exit(1);
            }
        }
    }

    public bool Pertence(int numero)
    {
        foreach (int fib in sequencia)
        {
            if (fib == numero)
            {
                return true;
            }
        }
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        const int Limite = 100;

        QuestaoSecond fib = new QuestaoSecond(Limite);

        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        int numero;
        try
        {
            numero = int.Parse(Console.ReadLine());
        }
        catch (OverflowException)
        {
            Console.WriteLine("Erro: O número digitado ultrapassa o limite do tipo 'int'.");
            return;
        }

        bool pertence = fib.Pertence(numero);

        if (pertence)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }
}
