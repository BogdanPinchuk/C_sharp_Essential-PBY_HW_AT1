using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    class Program
    {
        static void Main()
        {
            // підключення Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // створення екземпляра
            Circle circle = new Circle();

            // коло - це крива, круг - це заповнене в середині коло 
            Console.Write("\tВведіть радіус кола/круга: ");
            bool error = double.TryParse(Console.ReadLine().Replace(".", ","), out double radius);
            // аналіз чи можна далі продовжувати, додаткова перевірка на <= 0
            if (!error || radius <= 0)
            {
                AnaliseOfInputNumber(false);
            }

            // вносимо дані в екземпляр
            circle.Radius = radius;

            // виведення даних
            Console.WriteLine("\nПараметри кола/круга\n");
            // так як не вказано, що методи зразу виводять інформацію з методів,
            // то реазлізуємо це тут
            Console.WriteLine($"\tПериметр кола: {circle.GetCircumference():N2}");
            Console.WriteLine($"\tПлоща круга: {circle.GetArea():N2}");

            // повторення
            DoExitOrRepeat();
        }

        /// <summary>
        /// Умова коли невірно введені дані
        /// </summary>
        /// <param name="res"></param>
        static void AnaliseOfInputNumber(bool res)
        {
            if (!res)
            {
                Console.WriteLine("\nНевірно введені дані!");
                DoExitOrRepeat();
            }
        }

        /// <summary>
        /// Метод виходу або повторення методу Main()
        /// </summary>
        static void DoExitOrRepeat()
        {
            Console.WriteLine("\n\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey(true);

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
                // без використання рекурсії
                //Process.Start(Assembly.GetExecutingAssembly().Location);
                //Environment.Exit(0);
            }
            else
            {
                // закриває консоль
                Environment.Exit(0);
            }
        }
    }
}
