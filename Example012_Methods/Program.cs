// Вид 1
// Метод ничего не принимает и ничего не возвращает
void Methods1()
{
    System.Console.WriteLine("Автор Александр Лемешко");
}

//Methods1();

// Вид 2
// Метод принимает аргументы, но ничего не возвращает

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

//Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine((msg));
        i++;

    }
}

// Method21(msg: "Text", count: 4); // порядок указания именованных аргументов неважен

//Вид 3
// Метод ничего не принимает, но возвращает

int Method3()
{
    return DateTime.Now.Year;
}

// int year = Method3();
// System.Console.WriteLine(year);


//Вид 3
//Методы которые принимают аргументы и возвращают значение

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }

//     return result;
// }

string Method4(int count, string text)
{

    string result = String.Empty;

    for (int i = 0; i < count; i++)

    {
        result = result + text;
    }

    return result;
}

string res = Method4(10, "asdf");
// System.Console.WriteLine(res);

//Вывод таблицы умножения на экран

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         System.Console.WriteLine($"{i} x {j} = {i * j}");
//     }

//     System.Console.WriteLine();
// }

// Дан текст. В тексте нужно все пробелы заменить чёрточками,
//  маленькие буквы"к" заменить большими "К", а большие "С" заменить маленькими "с".

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else  result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();

// newText = Replace(newText, 'с', 'С');
// System.Console.WriteLine(newText);


// Сортировка (упорядочевание) массива

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i +1; j < array.Length; j++)
        {
            if(array[j] >  array[minPosition]) minPosition = j;

        }


        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);