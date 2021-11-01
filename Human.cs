using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home12
{
    public class Human
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string SecondName { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        /// Зарплата
        /// </summary>
        public uint Salary { get; set; }

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="Name">Имя</param>
        /// <param name="Level">Уровень</param>
        /// <param name="HitPoint">Запас здоровья</param>
        public Human(string FirstName, string SecondName, string Place, uint Salary)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.Place = Place;
            this.Salary = Salary;
        }

        /// <summary>
        /// Информация о сотруднике
        /// </summary>
        /// <returns></returns>
        public string HumanInformation()
        {
            return String.Format("Имя:{0,10} |  Фамилия:{1,10} |  Должность:{2,10} |  Зарплата:{3,7}",
                this.FirstName,
                this.SecondName,
                this.Place,
                this.Salary
                );
        }
    }
}
