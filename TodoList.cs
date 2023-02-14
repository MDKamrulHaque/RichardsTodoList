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

        internal static void AddItemOnList(ListOfLists selectedLists, string userSelectionMenu)
        {
            Console.WriteLine($"\nEnter Task to add to {selectedLists.ListName}\n");
            string userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("\nInvalid, nothing to add\n");
            }
            else
            {
                TodoList task = new TodoList(userInput.Trim().ToLower());
                selectedLists.TodoLists.Add(task);
                Console.WriteLine($"\nTask has been add to {selectedLists.ListName}\n");
            }
        }

        internal static void DeleteTask(ListOfLists selectedLists, string userSelectionMenu)
        {
            Console.WriteLine($"\nEnter a task to delete from {selectedLists.ListName}\n");
            string userInput = Console.ReadLine();
            TodoList taskToDelete = selectedLists.TodoLists.Find(x => x.NameOfTheTask.Equals(userInput.Trim().ToLower()));
            if (taskToDelete != null)
            {
                selectedLists.TodoLists.Remove(taskToDelete);
                Console.WriteLine($"\nTask has been deleted from {selectedLists.ListName}\n");
            }
            else
            {
                Console.WriteLine("\n Task not found\n");
            }
        }

        internal static void ComplteTask(ListOfLists selectedLists, string userSelectionMenu)
        {
            Console.WriteLine($"\nEnter a task to complete from {selectedLists.ListName}\n");
            string userInput = Console.ReadLine();

            TodoList taskToUpdate = selectedLists.TodoLists.Find(x => x.NameOfTheTask.Equals(userInput.Trim().ToLower()));
            if (taskToUpdate != null)
            {
                taskToUpdate.IsDone = true;
                Console.WriteLine($"\nTask has been updated in {selectedLists.ListName}\n");
            }
            else
            {
                Console.WriteLine("\n Task not found\n");
            }
        }

        internal static void ViewAllTask(ListOfLists selectedLists, string userSelectionMenu)
        {
            Console.WriteLine($"\nList Type: {selectedLists.ListName}\n");
            Console.WriteLine($"Uncompleted Tasks");

            if (selectedLists.TodoLists.Where(i => !i.IsDone).Count() == 0)
            {
                Console.WriteLine($"Empty \n");
            }
            else
            {
                foreach (var task in selectedLists.TodoLists.Where(i => !i.IsDone))
                {
                    task.DisplayTaskDetails();
                    Console.WriteLine();
                }
            }

            Console.WriteLine($"\nCompleted Tasks");

            if (selectedLists.TodoLists.Where(i => i.IsDone).Count() == 0)
            {
                Console.WriteLine($"Empty \n");
            }
            else
            {
                foreach (var task in selectedLists.TodoLists.Where(i => i.IsDone))
                {
                    task.DisplayTaskDetails();
                    Console.WriteLine();
                }
            }
        }
    }
}
