using Tyuiu.MerzhinskiyOO.Sprint2.Task5.V6.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint2.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.WriteLine("Введите номер масти: ");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер достоинства карты: ");
            int value2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var result = ds.FindCardNameAndValue(value1, value2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
