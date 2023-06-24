using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1: Среднее арифметическое трех чисел
            Task1();

            // Задача 2: Возведение числа в степень
            Task2();

            // Задача 3: Конвертация гривен в доллары и евро
            Task3();

            // Задача 4: Конвертация километров в сухопутные и морские мили
            Task4();

            // Задача 5: Расчет процента от числа
            Task5();

            // Задача 6: Конвертация градусов Цельсия в градусы Фаренгейта и обратно
            Task6();

            Console.ReadLine();
        }

        #region Задача 1: Среднее арифметическое трех чисел

        static void Task1()
        {
            Console.WriteLine("--- Задача 1: Среднее арифметическое ---");

            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            double c = double.Parse(Console.ReadLine());

            double average = CalculateAverage(a, b, c);

            Console.WriteLine("Среднее арифметическое: " + average);
        }

        static double CalculateAverage(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }

        #endregion

        #region Задача 2: Возведение числа в степень

        static void Task2()
        {
            Console.WriteLine("--- Задача 2: Возведение числа в степень ---");

            Console.Write("Введите число: ");
            double number = double.Parse(Console.ReadLine());

            Console.Write("Введите степень: ");
            int exponent = int.Parse(Console.ReadLine());

            double result = CalculatePower(number, exponent);

            Console.WriteLine("Результат: " + result);
        }

        static double CalculatePower(double number, int exponent)
        {
            return Math.Pow(number, exponent);
        }

        #endregion

        #region Задача 3: Конвертация гривен в доллары и евро

        static void Task3()
        {
            Console.WriteLine("--- Задача 3: Конвертация гривен в доллары и евро ---");

            Console.Write("Введите количество гривен: ");
            double amount = double.Parse(Console.ReadLine());

            (double dollars, double euros) = ConvertCurrency(amount);

            Console.WriteLine("Количество долларов: " + dollars);
            Console.WriteLine("Количество евро: " + euros);
        }

        static (double, double) ConvertCurrency(double amount)
        {
            double exchangeRateUsd = 0.036;  // Курс гривны к доллару
            double exchangeRateEur = 0.032;  // Курс гривны к евро

            double dollars = amount * exchangeRateUsd;
            double euros = amount * exchangeRateEur;

            return (dollars, euros);
        }

        #endregion

        #region Задача 4: Конвертация километров в сухопутные и морские мили

        static void Task4()
        {
            Console.WriteLine("--- Задача 4: Конвертация километров в сухопутные и морские мили ---");

            Console.Write("Введите количество километров: ");
            double kilometers = double.Parse(Console.ReadLine());

            (double landMiles, double nauticalMiles) = ConvertKmToMiles(kilometers);

            Console.WriteLine("Сухопутные мили: " + landMiles);
            Console.WriteLine("Морские мили: " + nauticalMiles);
        }

        static (double, double) ConvertKmToMiles(double kilometers)
        {
            double landMiles = kilometers / 1.609;  // Количество сухопутных миль в километрах
            double nauticalMiles = kilometers / 1.852;  // Количество морских миль в километрах

            return (landMiles, nauticalMiles);
        }

        #endregion

        #region Задача 5: Расчет процента от числа

        static void Task5()
        {
            Console.WriteLine("--- Задача 5: Расчет процента от числа ---");

            Console.Write("Введите число: ");
            double number = double.Parse(Console.ReadLine());

            Console.Write("Введите процент: ");
            double percent = double.Parse(Console.ReadLine());

            double result = CalculatePercentage(number, percent);

            Console.WriteLine("Результат: " + result);
        }

        static double CalculatePercentage(double number, double percent)
        {
            return number * percent / 100;
        }

        #endregion

        #region Задача 6: Конвертация градусов Цельсия в градусы Фаренгейта и обратно

        static void Task6()
        {
            Console.WriteLine("--- Задача 6: Конвертация градусов Цельсия в градусы Фаренгейта и обратно ---");

            Console.Write("Введите количество градусов по Цельсию: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine("Градусы по Фаренгейту: " + fahrenheit);

            double convertedCelsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine("Градусы по Цельсию: " + convertedCelsius);
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        #endregion
    }
}
