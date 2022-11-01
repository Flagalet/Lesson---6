// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int [] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
            res[i] = int.Parse(nums[i]);
    }
    return res;
}
 int NumArray(int [] array)
 {
    int number = 0;
    for(int i = 0; i < array.Length; i++)
    if(array[i] > 0)
    {
        number++;
    }
    return number;
 }
Console.Clear();
string number = Console.ReadLine();
int [] numArray = GetArrayFromString(number);
int nums = NumArray(numArray);
Console.WriteLine( $"Чисел больше 0: {nums}");

 