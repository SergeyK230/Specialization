void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}

int count = int.Parse(Console.ReadLine());
string [] array = new string[count];