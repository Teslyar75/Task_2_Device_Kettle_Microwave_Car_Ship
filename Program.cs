/*Завдання 2
Створити базовий клас «Пристрій» і похідні класи:
«Чайник», «Мікрохвильовка», «Автомобіль», «Пароплав».
За допомогою конструктора, встановити назву до кожного
пристрою і його характеристики.
Реалізуйте для кожного з класів методи:
■ Sound — видає звук пристрою (пишемо текстом у
консоль);
■ Show — відображає назву пристрою;
■ Desc — відображає опис пристрою.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Device_Kettle_Microwave_Car_Ship
{
    using System;

    class Device
    {
        private string name;
        private string description;

        public Device(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Звук устройства (общий для всех устройств)");
        }

        public void Show()
        {
            Console.WriteLine($"Название устройства: {name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Описание устройства: {description}");
        }
    }

    class Kettle : Device
    {
        public Kettle(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Звук чайника: Вода кипит.");
        }
    }

    class Microwave : Device
    {
        public Microwave(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Звук микроволновки: Шум работы микроволновки.");
        }
    }

    class Car : Device
    {
        public Car(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Звук автомобиля: рев двигателя");
        }
    }

    class Ship : Device
    {
        public Ship(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Звук парохода: Работает большой двигатель большого корабля.");
        }
    }

    class Program
    {
        static void Main()
        {
            Device kettle = new Kettle("Чайник", "Электрический чайник");
            Device microwave = new Microwave("Микроволновка", "Для разогрева пищи.");
            Device car = new Car("Автомобиль", "Легковой автомобиль");
            Device ship = new Ship("Пароход", "Водный транспорт");

            kettle.Show();
            kettle.Sound();
            kettle.Desc();
            Console.WriteLine();
            microwave.Show();
            microwave.Sound();
            microwave.Desc();
            Console.WriteLine();
            car.Show();
            car.Sound();
            car.Desc();
            Console.WriteLine();
            ship.Show();
            ship.Sound();
            ship.Desc();
            Console.ReadKey();
        }
    }

}
