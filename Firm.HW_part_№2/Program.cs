using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //список работников
        var timur = new Manager("Тимур", "Генеральный директор");
        var rashid = new Manager("Рашид", "Финансовый директор");
        var ilham = new Manager("О Ильхам", "Директор по автоматизации");

        var orkadiy = new Manager("Оркадий", "Начальник ИТ");
        var volodya = new Manager("Володя", "Зам.начальника ИТ");

        var ilshat = new SystemAdministrator("Ильшат");
        var ivanych = new SystemAdministrator("Иваныч");
        var ilya = new SystemAdministrator("Илья");
        var vitya = new SystemAdministrator("Витя");
        var zhenya = new SystemAdministrator("Женя");

        var sergey = new Developer("Сергей");
        var laysan = new Developer("Ляйсан");
        var marat = new Developer("Марат");
        var dina = new Developer("Дина");
        var ildar = new Developer("Ильдар");
        var anton = new Developer("Антон");

        // список задач
        List<Task> tasks = new List<Task>
        {
            new Task("Автоматизация отчетности", "Разработка"),
            new Task("Настройка сети", "Система"),
            new Task("Создание нового ПО", "Разработка"),
            new Task("Обслуживание серверов", "Система")
        };

        // распределение задач
        AssignTasks(new List<Employee> { ilya, vitya, zhenya, sergey, marat, dina }, tasks);

        Console.ReadLine(); 
    }

    static void AssignTasks(List<Employee> employees, List<Task> tasks)
    {
        foreach (var task in tasks)
        {
            foreach (var employee in employees)
            {
                if (employee.CanTakeTask(task.TaskType))
                {
                    Console.WriteLine($"Задача '{task.Title}' назначена {employee.Name}. Берет задачу: Да");
                    break;
                }
                else
                {
                    Console.WriteLine($"Задача '{task.Title}' назначена {employee.Name}. Берет задачу: Нет");
                }
            }
        }
    }
}
