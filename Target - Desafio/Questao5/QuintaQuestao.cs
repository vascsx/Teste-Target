using System;

class StringInverter
{
    private string originalString;

    public StringInverter(string str)
    {
        originalString = str;
    }

    public string Invert()
    {
        char[] charArray = originalString.ToCharArray();
        int length = charArray.Length;
        char[] invertedArray = new char[length];

        for (int i = 0; i < length; i++)
        {
            invertedArray[i] = charArray[length - 1 - i];
        }

        return new string(invertedArray);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma string para inverter: ");
        string inputString = Console.ReadLine();

        StringInverter inverter = new StringInverter(inputString);

        string invertedString = inverter.Invert();

        Console.WriteLine("String original: " + inputString);
        Console.WriteLine("String invertida: " + invertedString);
    }
}
