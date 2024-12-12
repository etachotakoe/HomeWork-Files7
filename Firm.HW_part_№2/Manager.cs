public class Manager : Employee
{
    public Manager(string name, string position) : base(name, position) { }

    public override bool CanTakeTask(string taskType)
    {
        // руководители могут брать любые задачи
        return true;
    }
}
