public class SystemAdministrator : Employee
{
    public SystemAdministrator(string name) : base(name, "Системщик") { }

    public override bool CanTakeTask(string taskType)
    {
        return taskType == "Система"; // могут брать только задачи на системы
    }
}
