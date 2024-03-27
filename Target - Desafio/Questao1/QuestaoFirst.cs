using System;

class QuestaoFirst
{
    int INDICE;
    int soma;
    int K;

    public QuestaoFirst()
    {
        this.INDICE = 13;
        this.K = 0;
        this.soma = 0;
    }

    static void Main(string[] args)
    {
        QuestaoFirst q = new QuestaoFirst();

        while (q.K < q.INDICE)
        {
            q.K = q.K + 1;
            q.soma = q.soma + q.K;
        }

        Console.WriteLine(q.soma);
    }
}
