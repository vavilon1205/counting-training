




bool programm = true;
int menu = 0;
int min = 0;
int max = 10;
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
            }
            else
            {
                Console.WriteLine("Решите следующий пример\n");
            }
            znak = RandomNumber(0, 1);
            if (znak == 0)
            {
                while (true)
                {
                    number1 = RandomNumber(min, max);
                    number2 = RandomNumber(min, max);
                    if (number1 >= number2 & calculationLimit >= (number1 | number2))
                    {
                        Console.WriteLine($"{number1} - {number2}");
                        result = number1 - number2;
                        menu = 2;
                        break;
                    }
                }             
            }
            if(znak == 1)
            {
                while (true)
                {
                    number1 = RandomNumber(min, max);
                    number2 = RandomNumber(min, max);
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
            while (answer != result)
            {
                mistakes++;
                Console.Clear();
                Console.WriteLine("Не правильно!\n\nДопущено ошибок - {0}\nРешено примеров - {1}\n", mistakes, examples);
                if (znak == 0)
                {
                    Console.WriteLine("{0} - {1}\n", number1, number2);
                    Console.WriteLine("Ваш ответ?\n");
                }
                if (znak == 1)
                {
                    Console.WriteLine("{0} + {1}\n", number1, number2);
                    Console.WriteLine("Ваш ответ?\n");
                }


                //answer = Convert.ToInt32(Console.ReadLine());

            }
            Console.Clear();
            examples++;
            string total = $"{a} + {b} = {result}";
            list.Add(examples, total);
            Console.WriteLine("Правильно!!!\n\nДопущено ошибок - {0}\nРешено примеров - {1}", mistakes, examples);
            Console.WriteLine("\nДля продолжения нажмите - Enter\nДля выхода нажмите - Home\n");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            if (key.Key == ConsoleKey.Enter)
            {
                continue;

            }
            if (key.Key == ConsoleKey.Home)
            {
                programm = false;

            }
            break;

        


    }








   


    //Console.WriteLine("Ваш ответ?\n");
    //string a = Console.ReadLine();





    //Console.WriteLine("{0} + {1}", a, b);
    //Console.WriteLine("Ваш ответ?\n");
    //string enter = Console.ReadLine();
    //if (int.TryParse(enter, out answer))

    //{

    //    answer = Convert.ToInt32(enter);
    //    break;

    //}
    //else
    //{
    //    Console.Clear();
    //    continue;
    //}


    //    answer = Answer();
    //    while (answer != result)
    //    {
    //        mistakes++;
    //        Console.Clear();
    //        Console.WriteLine("Не правильно!\n\nДопущено ошибок - {0}\nРешено примеров - {1}\n", mistakes, examples);
    //        Console.WriteLine("{0} + {1}", a, b);
    //        Console.WriteLine("Ваш ответ?\n");

    //        //answer = Convert.ToInt32(Console.ReadLine());

    //    }
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






    //}
    //double mistakesDec = Convert.ToDouble(mistakes);
    //double examplesDec = Convert.ToDouble(examples);
    //double efficiency = (100 - examplesDec / mistakesDec * 100);
    //Console.WriteLine("Статистика решенных примеров:\nПримеров - {0}\nДопущено ошибок - {1}\nЭффективность - {2}%\n", examples, mistakes, efficiency);
    //foreach (var item in list)
    //{
    //    Console.WriteLine($"{item.Key}. {item.Value}");
    //}
    //Environment.Exit(0);









}



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

