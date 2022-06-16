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

string[] ArraySample(string[] array1)
{
    
    string[] array2 = new string[FindCountSample(array1)];
    for (int i = 0; i < array2.Length; i++)
    {
        int j = 0;
        for (; j < array1.Length; j++)
        {
            if (array1[j].Length <= 3)
            {
                array2[i] = array1[j];
                break;
            }
        }
    }
    return(array2);
}

int count = int.Parse(Console.ReadLine());
string[] array1 = new string[count];
FillArray(array1);

string[] array2 = ArraySample(array1);