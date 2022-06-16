void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}

int FindCountSample(string[] array)
{
    int countSample = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) countSample ++;
    }
    return countSample;
}

string[] ArraySample(string[] array)
{
    FindCountSample(array);
}

int count = int.Parse(Console.ReadLine());
string[] array1 = new string[count];
FillArray(array1);

string[] array2 = new string[];