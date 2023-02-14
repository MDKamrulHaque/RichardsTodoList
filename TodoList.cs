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
            Console.WriteLine(NameOfTheTask);
        }

        internal static void AddItemOnList(List<TodoList> todoLists, string userSelectionMenu)
        {
            if (String.IsNullOrWhiteSpace(userSelectionMenu))
            {
                Console.WriteLine("Invalid, Enter somthing to add");
            }
            else
            {
                TodoList usersTasks = new TodoList(userSelectionMenu.Trim().ToLower());

                todoLists.Add(usersTasks);

                Console.WriteLine("Task Has Been Added On The To-Do List\n");
            }
        }

        internal static void DeleteTask(List<TodoList> todoLists, string userSelectionMenu)
        {
            var taskToRemove = todoLists.FirstOrDefault(x => x.NameOfTheTask == userSelectionMenu.Trim().ToLower());

            if (taskToRemove != null)
            {
                todoLists.Remove(taskToRemove);
                Console.WriteLine("Task Has Been Removed From List\n");
            }
            else
            {
                Console.WriteLine("Item not found!, Enter the correct name of the task!\n");
            }
        }

        internal static void ComplteTask(List<TodoList> todoLists, string userSelectionMenu)
        {
            var taskToRemove = todoLists.FirstOrDefault(x => x.NameOfTheTask == userSelectionMenu.Trim().ToLower());

            if (taskToRemove != null)
            {
                taskToRemove.IsDone = true;
                Console.WriteLine("Your Task List Has Been Updated\n");
            }
            else
            {
                Console.WriteLine("Item not found! Enter the correct name of the task!\n");
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

        internal static void HelpMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********************************");
            Console.WriteLine("*     Welcome to TodoList \"V2\"     *");
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Instructions!");
            Console.WriteLine("All commands must be in CAPITAL CASES!!");
            Console.WriteLine("");
            Console.WriteLine("Commands are as follows:");
            Console.WriteLine("");
            Console.WriteLine("\"ADD\", to add task To-Do");
            Console.WriteLine("\"COMPLETE\" to mark as completed");
            Console.WriteLine("\"DELETE\" to delete task(s)");
            Console.WriteLine("\"VIEW\" to see all task(s)");
            Console.WriteLine("\"HELP\" to..Wait your already did..");
            Console.WriteLine("\"CLOSE\" to leave application");
            Console.WriteLine("");
        }
    }
}
