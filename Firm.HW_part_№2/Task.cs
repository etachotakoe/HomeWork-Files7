public class Task
{
    public string Title { get; private set; }
    public string TaskType { get; private set; }

    public Task(string title, string taskType)
    {
        Title = title;
        TaskType = taskType;
    }
}
