using System;
using System.Collections.Generic;

namespace Company
{
    // Класс Работник
    class Employee
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public double Salary { get; set; }
        public int HoursPerDay { get; set; }
    }

    // Класс Директор
    class Director
    {
        public int EmployeeCount { get; set; }
        public double AverageSalary { get; set; }
        public int DisabledEmployees { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            // Добавляем работников в список
            employees.Add(new Employee { Name = "Иван", Experience = 3, Salary = 2000, HoursPerDay = 8 });
            employees.Add(new Employee { Name = "Мария", Experience = 5, Salary = 2500, HoursPerDay = 7 });
            employees.Add(new Employee { Name = "Алексей", Experience = 1, Salary = 1500, HoursPerDay = 6 });

            // Создаем директора
            Director director = new Director();
            director.EmployeeCount = employees.Count;

            // Рассчитываем среднюю заработную плату
            double totalSalary = 0;
            foreach (Employee emp in employees)
            {
                totalSalary += emp.Salary;
            }
            director.AverageSalary = totalSalary / employees.Count;

            // Указываем количество работников-инвалидов
            director.DisabledEmployees = 1;

            // Выводим результаты
            Console.WriteLine("Список работников:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"Имя: {emp.Name}, Стаж: {emp.Experience} года, Зарплата: {emp.Salary}, Часы работы: {emp.HoursPerDay}");
            }

            Console.WriteLine();
            Console.WriteLine("Информация о директоре:");
            Console.WriteLine($"Количество работников: {director.EmployeeCount}");
            Console.WriteLine($"Средняя заработная плата: {director.AverageSalary}");
            Console.WriteLine($"Количество работников-инвалидов: {director.DisabledEmployees}");

            Console.ReadLine();
        }
    }
}
