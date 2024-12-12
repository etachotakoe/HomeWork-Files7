using System;

public class Employee
{
    public string Name { get; private set; }
    public string Position { get; private set; }

    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public virtual bool CanTakeTask(string taskType)
    {
        return false; // по умолч не может взять задачу
    }
}
