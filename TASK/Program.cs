// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int el = int.Parse(Prompt("Введите количество элементов в массиве: "));
string[] array = GetArrayString(el);
PrintArray(array);
string[] arrayNew = GetNewArray(array);
Console.WriteLine();
PrintArray(arrayNew);

string Prompt(string mes) // метод работы с пользователем
   {
    string str = String.Empty;
    Console.Write(mes);
    return str = Console.ReadLine();
   }

string[] GetArrayString(int element) // метод создания массива
   {
    string[] arr = new string[element];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Prompt("Введите элемент: ");
    }
    return arr;
   }

void PrintArray(string[] array) //метод вывода массива на консоль
   {
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
   }
   
string[] GetNewArray(string[] array) // метод создания массива по условию задачи
   {
    string[] arr = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        string element = array[i];
        if (element.Length <= 3)
           {
            arr[i] = element;
           }
    }
    return arr;
   }
