// See https://aka.ms/new-console-template for more information
 bool exitNah=true; // переменная, обращение которой в true дает команду на выход из программы
    string selNum = "";

    Console.WriteLine("Welcome to HELL !!!");

    while (exitNah == true)
    {
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------");
    
    Console.WriteLine("Введите необходимую опцию меню(цифра):");
    Console.WriteLine("--------------------------------------------------------------------");
    Console.WriteLine("'1' для операции 1");
    Console.WriteLine("'2' для операции 2");
    Console.WriteLine("'3' для операции 3");
    Console.WriteLine("'Q' или 'q' для выхода");
    Console.WriteLine();
    Console.Write($"Выбрано : {selNum}");
    Console.WriteLine();

    //string selNum = "";
    selNum = Console.ReadLine();
        switch(selNum)
        {
            case "1":
            {
                Console.WriteLine($"Выбрано : {selNum}");
                Console.Clear(); 
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            
                break;
            }

            case "2":
            {    Console.WriteLine($"Выбрано : {selNum}");
                Console.Clear(); 
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            
                break;
            }
            case "3":
            {
                Console.WriteLine($"Выбрано : {selNum}");
                Console.Clear(); 
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
//=====================================================================================================================
// Функция принимает число из консоли и обходит ошибку ввода
int IntInput(string intName) // функция принимает число из консоли, преобразуя его в целое
                             // зело ругаеццо при косячном вводе
{
    int num;

    Console.Write($"Введите число {intName}: ");
    while(!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Ерунда какая-то... Ощущение, что введено не целое число.");
        Console.Write($"Ну-ка, еще разок! {intName} = ");
    }
    return  num;
}


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

void NumbersMore0(int m);
{
    int num = 0;
    //int forNum = m;
    for(int i=1; i <= m; i++)
    {
        Console.WriteLine($"Ура! - в {i}-й раз" );
    }

    //return num;
}
    
Console.WriteLine(NumbersMore0(10));
