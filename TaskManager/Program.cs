using System;

namespace TaskManager
{
    //Observer pattern - is one to many
    //Not good for cloud events (too many events)
    //So many one to one links because of many events

    //Hence we go event aggregator - publisher subscriber/Mediator
    //It is many to many
    //Per process we need only one mediator  
    //Mediator maintains one dict<Event, List<Subscribers>>
    class Program
    {
        static void Main(string[] args)
        {
            var taskManger = new TaskManager();

            var grid = new TaskGrid();
            taskManger.Subscribe(grid);
            
            var taskDetails = new TaskDetails();
            grid.Subscribe(taskDetails);

            taskManger.CreateTask(new Task(){ID = 1, Name = "notepad", Description = "Editor", State = TaskState.Created});
            taskManger.CreateTask(new Task() { ID = 2, Name = "cmd", Description = "Command Prompt", State = TaskState.Created });

            Console.WriteLine("\n\nSelecting task with ID 1");
            grid.SelectTaskByID(1);

            Console.ReadLine();
        }

    }
}
