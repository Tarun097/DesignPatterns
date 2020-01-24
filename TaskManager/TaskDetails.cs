using System;

namespace TaskManager
{
    public class TaskDetails : IObserver
    {
        private Task task;

        public void Notify(Task task)
        {
            this.task = task;
            Console.WriteLine("Updating task details :::::: .....");
            Display();
        }

        public void ChangeTaskStatus()
        {
            //For this we again need to update Task grid
            //here TaskDetails is subject and TaskGrid is observer
        }

        public void UpdateTask() 
        { }

        public void DeleteTask() 
        { }

        private void Display()
        {
            Console.WriteLine("***********Task Details************");
            Console.WriteLine($"{task.ID},  {task.Name}, {task.Description}, {task.State}");
            Console.WriteLine("***********************************");
        }
    }
}
