



Random rnd = new Random();
bool programm = true;
int menu = 0;
int calculationLimit = 0;
int znak = 0;
int number1 = 0;
int number2 = 0;
int mistakes = 0;
int examples = 0;
string enter;
bool number;
int answer = 0;
int result = 0;
int attempt = 0;
float efficiency = 0;
string total;
var list = new Dictionary<int, string>();

Console.SetWindowSize(90, 30);



while (programm == true)
{
    switch (menu)
    {
        case 0:
            Console.WriteLine("Добро пожаловать в программу\n");
            Console.WriteLine("Введите предел расчета\n");
            enter = Console.ReadLine();
            number = NumberCheck(enter);
            if (number == true)
            {
                calculationLimit = int.Parse(enter);
                Console.Clear();
                menu = 1;
            }
            else
            {
                Console.Clear();
                menu = 0;
            }
            break;

        case 1:
            if (examples == 0)
            {
                Console.WriteLine("Решите пример\n");
                examples++;
            }
            else
            {
                Console.WriteLine("Решите следующий пример\n");
                examples++;
            }
            znak = rnd.Next(0, 1);
            if (znak == 0)
            {
                while (true)
                {
                    number1 = rnd.Next(0, calculationLimit);
                    number2 = rnd.Next(0, calculationLimit);
                    if ((number1 >= number2) & calculationLimit >= (number1 | number2))
                    {
                        Console.WriteLine($"{number1} - {number2}");
                        result = number1 - number2;
                        menu = 2;
                        break;
                    }
                }
            }
            if (znak == 1)
            {
                while (true)
                {
                    number1 = rnd.Next(0, calculationLimit);
                    number2 = rnd.Next(0, calculationLimit);
                    if (calculationLimit <= number1 + number2)
                    {
                        Console.WriteLine($"{number1} + {number2}");
                        result = number1 + number2;
                        menu = 2;
                        break;
                    }


                }
            }
            break;

        case 2:
            Console.WriteLine("Ваш ответ?\n");
            enter = Console.ReadLine();
            number = NumberCheck(enter);
            if (number == true)
            {
                answer = int.Parse(enter);
                Console.Clear();
                menu = 3;
            }
            else
            {
                Console.Clear();
                menu = 2;
            }
            break;

        case 3:

            if (answer != result)
            {
                mistakes++;
                Console.Clear();
                Console.WriteLine("\nНеправильно!\nПодумайте еще. Это несложно! ;)\n");


                if (znak == 0)
                {
                    Console.WriteLine("{0} - {1} = ?\n", number1, number2);
                    total = $" {number1} - {number2} = {answer} - Ошибка!";
                    attempt++;
                    list.Add(attempt, total);

                }
                if (znak == 1)
                {
                    Console.WriteLine("{0} + {1} = ?\n", number1, number2);
                    total = $" {number1} + {number2} = {answer} - Ошибка!";
                    attempt++;
                    list.Add(attempt, total);

                }
                menu = 2;
            }
            if (answer == result)
            {
                if (znak == 0)
                {
                    Console.WriteLine("\n{0} - {1} = {2}\n", number1, number2, result);
                    total = $" {number1} - {number2} = {result} - Правильно!";
                    attempt++;
                    list.Add(attempt, total);

                }
                if (znak == 1)
                {
                    Console.WriteLine("\n{0} + {1} = {2}\n", number1, number2, result);
                    total = $" {number1} + {number2} = {result} - Правильно!";
                    attempt++;
                    list.Add(attempt, total);

                }


                Console.WriteLine("Правильно!!!\n\nДопущено ошибок - {0}\nРешено примеров - {1}", mistakes, examples);
                menu = 4;
            }
            break;


        case 4:
            Console.WriteLine("\nДля продолжения нажмите - Enter\nДля просмотра статистики и выхода нажмите - Home\n");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            if (key.Key == ConsoleKey.Enter)
            {
                menu = 1;

            }
            if (key.Key == ConsoleKey.Home)
            {
                menu = 5;

            }

            break;

        case 5:

            if (attempt == 0 | mistakes == 0)
            {
                efficiency = 100;
            }
            else
            {
                efficiency = (float)examples / (float)attempt / (float)mistakes * 100;
            }

            Console.WriteLine("Статистика решенных примеров:\nПримеров - {0}\nПопыток - {1}\nДопущено ошибок - {2}\nЭффективность - {3}%\n", examples, attempt, mistakes, efficiency);
            Console.WriteLine("\nДля выхода из программы нажмите - Enter\n");
            Console.WriteLine("Список решенных примеров:\n");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key}. {item.Value}");
            }

            key = Console.ReadKey();
            Console.Clear();
            if (key.Key == ConsoleKey.Enter)
            {
                Environment.Exit(0);
            }
            break;

    }
}





//answer = Convert.ToInt32(Console.ReadLine());
//Console.Clear();
//examples++;
//string total = $"{a} + {b} = {result}";
//list.Add(examples, total);
//Console.WriteLine("Правильно!!!\n\nДопущено ошибок - {0}\nРешено примеров - {1}", mistakes, examples);
//Console.WriteLine("\nДля продолжения нажмите - Enter\nДля выхода нажмите - Home\n");
//ConsoleKeyInfo key = Console.ReadKey();
//Console.Clear();
//if (key.Key == ConsoleKey.Enter)
//{
//    continue;

//}
//if (key.Key == ConsoleKey.Home)
//{
//    programm = false;

//}









//    Console.Clear();
//    examples++;
//    string total = $"{a} + {b} = {result}";
//    list.Add(examples, total);
//    Console.WriteLine("Правильно!!!\n\nДопущено ошибок - {0}\nРешено примеров - {1}", mistakes, examples);
//    Console.WriteLine("\nДля продолжения нажмите - Enter\nДля выхода нажмите - Home\n");
//    ConsoleKeyInfo key = Console.ReadKey();
//    Console.Clear();
//    if (key.Key == ConsoleKey.Enter)
//    {
//        continue;

//    }
//    if (key.Key == ConsoleKey.Home)
//    {
//        programm = false;

//    }







//double mistakesDec = Convert.ToDouble(mistakes);
//double examplesDec = Convert.ToDouble(examples);
//double efficiency = (100 - examplesDec / mistakesDec * 100);
//Console.WriteLine("Статистика решенных примеров:\nПримеров - {0}\nДопущено ошибок - {1}\nЭффективность - {2}%\n", examples, mistakes, efficiency);
//foreach (var item in list)
//{
//    Console.WriteLine($"{item.Key}. {item.Value}");
//}
//Environment.Exit(0);













static bool NumberCheck(string a)
{
    int b;
    while (true)
    {
        if (int.TryParse(a, out b))

        {
            b = Convert.ToInt32(a);
            return true;
        }
        else
        {
            return false;
        }
    }
}


static int RandomNumber(int min, int max)
{
    Random rnd = new Random();
    int a = rnd.Next(min, max);
    return a;
}

