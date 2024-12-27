
using Tyuiu.MerzhinskiyOO.Sprint2.Task3.V18.Lib;
namespace Tyuiu.MerzhinskiyOO.Sprint2.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Введите значение переменной X= ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Значение функции = " + res);
            Console.ReadLine();
        }
    }
}
