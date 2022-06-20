void FillArray(string[] array)
{
    System.Console.WriteLine("Введите элементы массива через enter");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
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
    int j = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        for (; j < array1.Length; j++)
        {
            if (array1[j].Length <= 3)
            {
                array2[i] = array1[j];
                j++;
                break;
            }
        }
    }
    return(array2);
}

System.Console.WriteLine("Введите размер массива");
int count = int.Parse(Console.ReadLine());
string[] primordiAlarray = new string[count];
FillArray(primordiAlarray);
System.Console.WriteLine();

string[] resultingArray = ArraySample(primordiAlarray);
PrintArray(resultingArray);