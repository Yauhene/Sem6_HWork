//=====================================================================================================================
// Функция консольного меню

void myTaskMenu()
{
 bool exitNah=true; // переменная, обращение которой в true дает команду на выход из программы
    string selNum = "";

    Console.WriteLine("Welcome to HELL !!!");

    while (exitNah == true)
    {
    Console.Clear(); 
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------");
    Console.WriteLine("Представлены решения задач 41 и 43");
    Console.WriteLine("Введите номер задачи(либо q/Q для выхода):");
    Console.WriteLine("--------------------------------------------------------------------");
    for(int i=1; i <=5; i++) Console.WriteLine();
    Console.WriteLine();
    Console.Write($"Ваш выбор? : {selNum}");
    
    selNum = Console.ReadLine();
        switch(selNum)
        {
            case "41":
            {
                Console.Write($"Выбрано : Задача {selNum}");
                Console.Clear(); 
                Console.WriteLine();
                
                Task_41();
                
                selNum = "";
                Console.Clear(); 
                for(int i = 1; i <= 3, i++) Console.WriteLine();
                            
                break;
            }

            case "43":
            {    Console.WriteLine($"Выбрано : Задача {selNum}");
                Task_43();

                selNum = "";

                Console.Clear(); 
                for(int i = 1; i <= 3, i++) Console.WriteLine();
            
                break;
            }
            
            case "q":
            {
                exitNah = false;
                Console.Clear(); 
                for(int i = 1; i <= 3, i++) Console.WriteLine();
            
                break;
            }

            case "Q":
            {
                exitNah = false;
                Console.Clear(); 
                for(int i = 1; i <= 3, i++) Console.WriteLine();
            
                break;
            }
            default:
            {
                Console.WriteLine("Попробуйте еще раз. Есть шанс исправиться.");
                Console.WriteLine();
                Console.WriteLine();
                selNum = "";

                break;
            }
                
            
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


//=====================================================================================================================
// Функция принимает указанное число значений из консоли и считает числа больше нуля
int NumbersMore0(int m)
{
    int num = 0;  
    for(int i=1; i <= m; i++)
    {
        if(IntInput($"число #{i}") > 0)
        {
            num++;
        }
    }

    return num;
}
//=====================================================================================================================
void Task_41()
{
    Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    Console.WriteLine("0, 7, 8, -2, -2 -> 2");
    Console.WriteLine("1, -7, 567, 89, 223-> 3");
    Console.WriteLine();

    int callArg = IntInput("M");

    int more0;

    more0 = NumbersMore0(callArg);
    Console.WriteLine();
    Console.WriteLine( $"В серии из введенных {callArg} чисел  значений больше нуля: {more0}");
    Console.WriteLine();
    Console.WriteLine( "Для продолжения нажмите 'Ввод'...");
    Console.ReadLine();
}
//=====================================================================================================================
void Task_43()
{   
    Console.WriteLine();
    Console.WriteLine("Программа ищет точку пересечения двух прямых, ");
    Console.WriteLine("заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;");
    Console.WriteLine("значения b1, k1, b2 и k2 задаются пользователем.");
    Console.WriteLine("Пример: k1 = 5, b1 = 2, k2 = 9, b2 = 4 -> (-0,5; -0,5)");
    Console.WriteLine();

    double k1 = IntInput("k1");
    double b1 = IntInput("b1");
    double k2 = IntInput("k2");
    double b2 = IntInput("b2");

    double deltaK = k1-k2;
    double deltaB = b1-b2;
    double x = (-1)*deltaB/deltaK;
    double y = k2*x + b2;
    Console.WriteLine();
    Console.WriteLine( $"Координаты пересечения данных прямых: x = {x}, y = {y}");
    Console.WriteLine();
    Console.WriteLine("Для продолжения нажмите 'Ввод'...");
    Console.WriteLine();
    Console.ReadLine();

}

//=====================================================================================================================
void GeneralMethod()
{
    myTaskMenu();
}
//=====================================================================================================================

GeneralMethod();