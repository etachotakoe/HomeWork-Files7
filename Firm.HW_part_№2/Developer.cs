public class Developer : Employee
{
    public Developer(string name) : base(name, "Разработчик") { }

    public override bool CanTakeTask(string taskType)
    {
        return taskType == "Разработка"; // иогут брать только задачи на разработку
    }
}
