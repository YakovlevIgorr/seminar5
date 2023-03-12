// Задача 38: Задайте массив натуральных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] array = new int[5];
int [] GetRandomArray()
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0,100);
    }
    return array;
}
int MaxAndMinArray(int [] fullArray, bool maxOrMin)
{
    int maxCount = fullArray[0];
    for(int i  = 1; i < fullArray.Length; i++)
    {
        if(maxCount < fullArray[i] && maxOrMin == true) 
        {
            maxCount = fullArray[i];
        } else if(maxCount > fullArray[i] && maxOrMin == false) maxCount = fullArray[i];

    }
    return maxCount;
}

GetRandomArray();
int maxCount = MaxAndMinArray(array, true);
int minCount = MaxAndMinArray(array, false);
System.Console.WriteLine($"[{string.Join(",",array)}] -> {maxCount - minCount} ");