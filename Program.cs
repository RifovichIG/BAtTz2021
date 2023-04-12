using System;
 
class Program
{
    public static double f(double x1, double x2)
    {
        return (2*x1*x1+2*x2*x2+x1*x2-11*x1-8*x2); 
 
    }
 
    public static double grad_x1(double x1, double x2)
    {
        return (4*x1+x2-11);
    }
 
    public static double grad_x2(double x1, double x2)
    {
        return (x1+4*x2-8);
    }
 
    static void Main()
    {
        Console.Write("Введите x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите eps: ");
        double eps = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите шаг h: ");
        double h = Convert.ToDouble(Console.ReadLine());
        int k = 0;
 
        double G, Y, x1_p, x2_p;
 
        do
        {
            x1_p = x1;
            x2_p = x2;
            G = f(x1, x2);
            x1 = x1_p - h * grad_x1(x1_p, x2_p);
            x2 = x2_p - h * grad_x2(x1_p, x2_p);
            Y = f(x1, x2);
 
            k++;
        }
        while ((Math.Abs(Y - G)) > eps);
 
        Console.WriteLine("\nx1= {0} \nx2= {1}\nf(x1,x2)={2}", x1, x2, Y);
        Console.WriteLine("\nКоличество итераций: " + k);
    }
}
//Ход работы 1 запрос ввода данных 
// Вписываю алгоритм с использованием вбытых мною данных
//Создаю файл Гитигнор для правильности показания файла
//Ставлю счетчик 
//Запускаю программу 