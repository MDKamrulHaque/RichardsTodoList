using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichardsTodoList
{
    internal class TodoList
    {
        public string NameOfTheTask { get; set; }
        public bool IsDone { get; set; } = false;
        public TodoList(string nameOfTheTask)
        {
            NameOfTheTask = nameOfTheTask;
        }

        public void DisplayTaskDetails()
        {
            Console.WriteLine($"-{NameOfTheTask}");
        }

        internal static void AddItemOnList(List<TodoList> todoLists)
        {
            Console.WriteLine("You selected to add an item");
            Console.WriteLine("Enter what to add: ");
            string nameOfTheTask = Console.ReadLine();

            TodoList todo = new TodoList(nameOfTheTask);
            todoLists.Add(todo);
            Console.WriteLine("Task added to list");
        }

        internal static void DeleteTask(List<TodoList> todoLists)
        {
            Console.WriteLine("Which task you want to delete");
            string nameOfTheTask = Console.ReadLine();
            var taskTodelete = todoLists.FirstOrDefault(x => x.NameOfTheTask == nameOfTheTask);

            if (taskTodelete != null)
            {
                todoLists.Remove(taskTodelete);
                Console.WriteLine("Task deleted");
            }
            else
            {
                Console.WriteLine("not found");
            }
        }

        internal static void CompletedTask(List<TodoList> todoLists)
        {
            Console.WriteLine("which task to complete");
            string taskToComplte = Console.ReadLine();

            var completedTask = todoLists.FirstOrDefault(x => x.NameOfTheTask == taskToComplte);

            if (completedTask != null)
            {
                completedTask.IsDone = true;
                Console.WriteLine("Task completed");
            }
            else
            {
                Console.WriteLine("not found");
            }
        }

        internal static void ViewAllTask(List<TodoList> todoLists)
        {
            Console.WriteLine("");
            Console.WriteLine("List Of Uncompleted Task(s)");

            if (todoLists.Where(i => !i.IsDone).Count() == 0)
            {
                Console.WriteLine("Task List is Empty!");
            }
            else
            {
                foreach (var task in todoLists.Where(i => !i.IsDone))
                {
                    task.DisplayTaskDetails();
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("List Of Completed Task(s)");
            if (todoLists.Where(i => i.IsDone).Count() == 0)
            {
                Console.WriteLine("Task List is Empty!");
            }
            else
            {
                foreach (var task in todoLists.Where(i => i.IsDone))
                {
                    task.DisplayTaskDetails();
                    Console.WriteLine("");
                }
            }
        }
    }
}
