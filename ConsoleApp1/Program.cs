using System;

//

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            string[] clubs = { "6 Крести", "7 Крести", "8 Крести", "9 Крести", "10 Крести", "Валет Крести", "Дама Крести", "Король Крести", "Туз Крести" };

           string[] spades = { "6 Пики", "7 Пики", "8 Пики", "9 Пики", "10 Пики", "Валет Пики", "Дама Пики", "Король Пики", "Туз Пики" };

           string[] hearts = { "6 Червы", "7 Червы", "8 Червы", "9 Червы", "10 Червы", "Валет Червы", "Дама Червы", "Король Червы", "Туз Червы" };

           string[] diamonds = { "6 Буби", "7 Буби", "8 Буби", "9 Буби", "10 Буби", "Валет Буби", "Дама Буби", "Король Буби", "Туз Буби" };

            while (true)

            {

                Console.Clear();

                Console.WriteLine("Привет! Добро пожаловать в Охоту на Ведьм!");

                Console.WriteLine("Угадай карту из стандартной колоды 36 карт, за масть одно очко, за номинал - два, угадали карту - три!");

                Console.WriteLine("(И одно очечко за то, что ты сегодня - супер!)");

                Console.WriteLine("Если все понятно - нажми ВВОД для продолжения");

                Console.ReadLine();

                //System.Threading.Thread.Sleep(10000);

                int score = 0;

                int quan = 36;

                for (; quan >= 0;)

                {

                    Console.Clear();

                    if (quan > 0)

                    {

                        Console.WriteLine("Осталось карт: " + quan);

                    }

                    else

                    {

                        Console.WriteLine("Последняя карта!");

                    }

                    string nom = "Не выбрана";

                    int massnom;

                    Console.WriteLine("Введи номинал (от 6 до 10 - цифры, Валет, Дама, Король, Туз): ");

                    nom = Console.ReadLine();

                    switch (nom)

                    {
                        case "6":

                            massnom = 0;

                            break;

                        case "7":

                            massnom = 1;

                            break;

                        case "8":

                            massnom = 2;

                            break;

                        case "9":

                            massnom = 3;

                            break;

                        case "10":

                            massnom = 4;

                            break;

                        case "Валет":

                            massnom = 5;

                            break;

                        case "валет":

                            massnom = 5;

                            break;

                        case "Дама":

                            massnom = 6;

                            break;

                        case "дама":

                            massnom = 6;

                            break;

                        case "Король":

                            massnom = 7;

                            break;

                        case "король":

                            massnom = 7;

                            break;

                        case "Туз":

                            massnom = 8;

                            break;

                        case "туз":

                            massnom = 8;

                            break;

                        default:

                            Console.Write("Номинал не верен, попробуй еще раз!");

                            System.Threading.Thread.Sleep(4000);

                            continue;

                    }

                    string kind = "Не выбрана";

                    int masskind;

                    Console.WriteLine("Введи масть (♣ - крести, ♠ - пики, ♥ - червы, ♦ - буби): ");

                    kind = Console.ReadLine();

                    switch (kind)

                    {

                        case "крести":

                            masskind = 0;

                            break;

                        case "пики":

                            masskind = 1;

                            break;

                        case "червы":

                            masskind = 2;

                            break;

                        case "буби":

                            masskind = 3;

                            break;

                        case "Крести":

                            masskind = 0;

                            break;

                        case "Пики":

                            masskind = 1;

                            break;

                        case "Червы":

                            masskind = 2;

                            break;

                        case "Буби":

                            masskind = 3;

                            break;

                        default:

                            Console.Write("Масть не верна, попробуй еще раз!");

                            System.Threading.Thread.Sleep(4000);

                            continue;

                    }

                    Console.WriteLine("Твой выбор: " + nom + " " + kind);

                    Random rnd = new Random();

                    int rndnom = rnd.Next(8);

                    int rndkind = rnd.Next(3);

                    if (massnom == rndnom)

                    {
                        score = score + 2;
                    }

                    if (masskind == rndkind)

                    {
                        score = score + 1;

                    }

                        score++;

                    Console.Write("Карта: ");

                    switch (rndnom)

                    {

                        case 0:

                            Console.Write("6 ");

                            break;

                        case 1:

                            Console.Write("7 ");

                            break;

                        case 2:

                            Console.Write("8 ");

                            break;

                        case 3:

                            Console.Write("9 ");

                            break;

                        case 4:

                            Console.Write("10 ");

                            break;

                        case 5:

                            Console.Write("Валет ");

                            break;

                        case 6:

                            Console.Write("Дама ");

                            break;

                        case 7:

                            Console.Write("Король ");

                            break;

                        case 8:

                            Console.Write("Туз ");

                            break;

                    }

                    switch (rndkind)

                    {

                        case 0:

                            Console.WriteLine("крести");

                            break;

                        case 1:

                            Console.WriteLine("пики");

                            break;

                        case 2:

                            Console.WriteLine("червы");

                            break;

                        case 3:

                            Console.WriteLine("буби");

                            break;

                    }

                    Console.WriteLine("Твой счёт: " + score + "!");

                    Console.WriteLine("Нажми ВВОД для продолжения");

                    Console.ReadLine();

                    quan--;

                }

                Console.WriteLine("Спасибо за игру! Твой счёт - " + score + "! Хочешь сыграть ещё раз? Введи =Да= для продолжения: ");

                string reply = Console.ReadLine();

                switch (reply)

                {

                    case "Да":

                        continue;

                    case "да":

                        continue;

                    default:

                        Console.WriteLine("Окей, до следующего раза! ;^)");

                        return;

                }

            }

        }

    }

}




        
    

