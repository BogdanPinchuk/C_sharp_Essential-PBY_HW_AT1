using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    /// <summary>
    /// Коло, круг
    /// </summary>
    class Circle
    {
        /// <summary>
        /// Радіус
        /// </summary>
        private double radius;
        /// <summary>
        /// доступ до розрахунків
        /// </summary>
        private bool access = true;

        /// <summary>
        /// Радіус
        /// </summary>
        internal double Radius
        {
            get { return radius; }
            set
            {
                radius = ExamData(value);
            }
        }

        /// <summary>
        /// Розрахунок площі круга
        /// </summary>
        /// <returns></returns>
        internal double GetArea()
        {
            double res = default;

            if (access)
            {
                res = Math.PI * radius * radius;
            }
            else
            {
                // на випадок якщо хтось захоче все таки розрахувати щось
                Console.WriteLine("\nРадіус кола не може мати довжину мену або рівну нулю.");
            }

            return res;
        }

        /// <summary>
        /// Розрахунок довжини кола
        /// </summary>
        /// <returns></returns>
        internal double GetCircumference()
        {
            double res = default;

            if (access)
            {
                res = 2 * Math.PI * radius;
            }
            else
            {
                // на випадок якщо хтось захоче все таки розрахувати щось
                Console.WriteLine("\nРадіус кола не може мати довжину мену або рівну нулю.");
            }

            return res;
        }

        /// <summary>
        /// Перевірка правильності введених даних
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        private double ExamData(double radius)
        {
            if (radius <= 0) // перевірка на коректність даних
            {
                Console.WriteLine("\nРадіус кола не може мати довжину мену або рівну нулю.");
                access = false;
                return default;
            }
            else
            {
                access = true;
                return radius;
            }
        }
    }
}
