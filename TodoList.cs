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

        internal static void AddTask(ListOfLists selectedList, string userSelection)
        {
            char[] wordSeperator = { ' ' };
            string[] subStrings = userSelection.Split(wordSeperator);

            var theActualTakToAdd = string.Join(" ", subStrings, 2, subStrings.Length - 2);
                        
            if (String.IsNullOrWhiteSpace(theActualTakToAdd))
            {
                Console.WriteLine("\ntask cannot be empty, try again\n");
            }
            else
            {
                TodoList usersTasks = new TodoList(theActualTakToAdd.Trim().ToLower());
                selectedList.TodoLists.Add(usersTasks);
                Console.WriteLine($"\nTask has been add to {selectedList.ListName}\n");
            }
        }

        internal static void DeleteTask(ListOfLists selectedList, string userSelection)
        {
            char[] wordSeperator = { ' ' };
            string[] subStrings = userSelection.Split(wordSeperator);

            var theActualTakToDelete = string.Join(" ", subStrings, 2, subStrings.Length - 2);

            TodoList usersTaskToDelete = selectedList.TodoLists.Find(x => x.NameOfTheTask == theActualTakToDelete.Trim().ToLower());
           
            if (usersTaskToDelete != null)
            {
                selectedList.TodoLists.Remove(usersTaskToDelete);
                Console.WriteLine($"\nTask has been deleted from {selectedList.ListName}\n");
            }
            else
            {
                Console.WriteLine("\nno task found, try again\n");
            }
        }
        internal static void CompleteTask(ListOfLists selectedList, string userSelection)
        {
            char[] wordSeperator = { ' ' };
            string[] subStrings = userSelection.Split(wordSeperator);

            var theActualTakToComplete = string.Join(" ", subStrings, 2, subStrings.Length - 2);
            TodoList usersTaskToComplete = selectedList.TodoLists.Find(x => x.NameOfTheTask == theActualTakToComplete.Trim().ToLower());
            if (usersTaskToComplete != null)
            {
                selectedList.TodoLists.Find(x => x.IsDone = true);
                Console.WriteLine($"\nTask has been update from {selectedList.ListName}\n");
            }
            else
            {
                Console.WriteLine("\nno task found, try again\n");
            }    
        }

        internal static void ViewTask(ListOfLists selectedList, string userSelection)
        {
            Console.WriteLine("");
            Console.WriteLine($"List Type: {selectedList.ListName}");
            Console.WriteLine("");
            Console.WriteLine("\nList Of Uncompleted Task(s)");
            Console.WriteLine("");

            if (selectedList.TodoLists.Where(i => !i.IsDone).Count() == 0)
            {
                Console.WriteLine("\nEmpty!");
                Console.WriteLine("");
            }
            else
            {
                foreach (var task in selectedList.TodoLists.Where(i => !i.IsDone))
                {
                    task.DisplayTaskDetails();
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("\nList Of Completed Task(s)");
            if (selectedList.TodoLists.Where(i => i.IsDone).Count() == 0)
            {
                Console.WriteLine("\nEmpty!");
                Console.WriteLine("");
            }
            else
            {
                foreach (var task in selectedList.TodoLists.Where(i => i.IsDone))
                {
                    task.DisplayTaskDetails();
                    Console.WriteLine("");
                }
            }
        }
    }
}
