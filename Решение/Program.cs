string[] CreateMassive(int n)
{
    string[] arrayText = new string[n];
    for (int i = 0; i < arrayText.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} строку");
        arrayText[i] = Console.ReadLine();
    }
    Console.WriteLine("Введенный массив: ");
    for (int i = 0; i < arrayText.Length; i++)
    {
        Console.Write(arrayText[i] + " ");
    }
    return arrayText;
}

void NewMassive(string[] arrayText)
{
string[] arrayTextNew = new string[arrayText.Length];
int count = 0;
    for (int i = 0; i < arrayText.Length; i++)
    {
    if(arrayText[i].Length <= 3)
        {
        arrayTextNew[count] = arrayText[i];
        Console.Write(arrayTextNew[count] + " ");
        count++;
        }
    }
}

Console.WriteLine("Введите количество строк массива");
int n = Convert.ToInt32(Console.ReadLine());
string[] arrayText = CreateMassive(n);
Console.WriteLine();
NewMassive(arrayText);