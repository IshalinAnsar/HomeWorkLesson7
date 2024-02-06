// // Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int start = m;
int end = n;

void ShowNumbers(int start, int end)
{
    if (start == end)
    {
        Console.Write(start);
        return;
    }
    Console.Write(start + " ");
    ShowNumbers(start + 1, end);
}
ShowNumbers(start, end);
Natural(m,n);

void Natural(int n, int m)
{
    if (m > n)
    {
        Natural(m, n + 1);
        Console.Write($" {n}");
    }
    else
    {
        return;
    }
}




// // Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);


// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int [] CreateArray (int size, int max, int min)
{
    int [] array  = new int[size];
    Random rand = new();
        for (int i = 0; i < size; i++)
        {
            array [i] = rand.Next(min,max+1);
        }
    return array;
}
    string PrintArray(int [] array)
    {
    return string.Join(", ",array);
    }
    int [] ArraySwap(int [] array,int index)
    {

        if (index <= 0)
            {
                return array;
            }
        int temp = array[index];
        array[index] = array[array.Length - index-1];
        array[array.Length - index-1] = temp;
        return ArraySwap(array,index -= 2);
    }
int [] array = CreateArray(10,10,0);
    System.Console.WriteLine($"Произвольный массив => [{PrintArray(array)}]");
    System.Console.WriteLine($"Перевернутый массив => [{PrintArray(ArraySwap(array,array.Length-1))}]");