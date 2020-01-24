namespace TaskManager
{
    public interface IObserver
    {
        void Notify(Task task);
    }
}