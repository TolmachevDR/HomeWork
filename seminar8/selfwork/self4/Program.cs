/* Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. */

int[] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
    return array;
}

int[,] UnicNumbers(int array)
{
    for (int i = 0; count = 0; i < arrayLength; i++)
        UnicNumber = i;
        count
        if 

        return UnicNumber;
} 

int[,] CalcCountOfElements(int[,] array)
{
    int[,] unicValue = new int[2, array.GetLength(0) * array.GetLength(1)];
    int indexLast = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            bool isFinded = false;
            for (int k = 0; k < unicValue.GetLength(1); k++)
            {
                if (array[i, j] == unicValue[0, k])
                {
                    unicValue[1, k]++;
                    isFinded = true;
                    break;
                }
            }
            if (!isFinded)
            {
                unicValue[0, indexLast] = array[i, j];
                unicValue[1, indexLast]++;
                indexLast++;
            }
        }
    }
    return unicValue;
}

int[] array = new int[12];
array = NewArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");