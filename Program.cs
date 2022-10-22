Console.Clear();

int GetNumber (string message) //Функция проверки, чтобы длинна массива была больше 1 элемента
{
    int result = 0;
    string errorMessage = "Вы ввели не число или число меньше 1, введите любое положительное число: ";

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            if(result > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}

int lengthArray = GetNumber("Введите кол-во строк, которое хотите задать: ");
string[] arrayString = new string[lengthArray];
int cnt = 0;  //счетчик кол-ва элементов для вывода обработанного массива 

//Цикл для формирования ввода элементов массива
    for (int i = 0; i < lengthArray; i++)
    {
        Console.Write("Введите строку: ");
        arrayString[i] = Console.ReadLine();
    }

Console.WriteLine();

//Цикл для вывода отфильтрованных по условию элементов массива
    for (int i = 0; i < lengthArray; i++)
    {
        if (arrayString[i].Length <= 3) {
            Console.Write(arrayString[i] + ", ");
            cnt++;
        }
    }

    if (cnt == 0) 
    Console.WriteLine("Нет ни одной строки, содержащей менее 4 символов!");
    else
    Console.WriteLine();