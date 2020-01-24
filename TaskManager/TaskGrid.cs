using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskManager
{
    public class TaskGrid : IObserver
    {
        private List<Task> tasks =  new List<Task>();
        private List<IObserver> observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Display()
        {
            Console.WriteLine("************Grid Display***********");
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.ID},  {task.Name}, {task.Description}, {task.State}");
            }
            Console.WriteLine("***********************************");
        }

        public void SelectTaskByID(int id)
        {
            Console.WriteLine("Selection result :: ");
            foreach (var task in tasks.Where((t)=> t.ID== id))
            {
                Console.WriteLine($"{task.ID},  {task.Name}, {task.Description}, {task.State}");
                foreach (var observer in observers)
                {
                    observer.Notify(task);
                }
            }
        }

        public void Notify(Task task)
        {
            tasks.Add(task);
            Console.WriteLine("Updating grid :::::: .....");
            Display();
        }
    }
}