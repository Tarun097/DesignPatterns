namespace TaskManager
{
    public class Task
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }
        public TaskState State { get; set; } = TaskState.Created;
    }
}