using System;
using System.Collections.Generic;

namespace TaskManager
{
    public class TaskManager
    {
        private List<IObserver> observers = new List<IObserver>();
        public void CreateTask(Task task)
        {
            Console.WriteLine($"Creating task : {task.ID}");
            foreach (var observer in observers)
            {
                observer.Notify(task);
            }
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

    }
}