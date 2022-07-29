string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();
        words[i] = words[i].ToLower();
        Console.WriteLine();
    }
return words;
}

void ShowArray (string[] array)
{
    for (int i = 0; i< array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.WriteLine("Input number of words");
int size = Convert.ToInt32(Console.ReadLine());

string [] array = CreateStringArray(size);
ShowArray(array);

void ShowThreeSimbolsArray (string[] array)
{
    for (int i = 0; i< array.Length; i++)
        if (array[i].Length <= 3)
            Console.Write(array[i] + " ");
}

ShowThreeSimbolsArray(array);
