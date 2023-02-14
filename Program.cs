using RichardsTodoList;

List<TodoList> todos = new List<TodoList>();


string userSelection;



string userSelectionMenu;

do
{
    Console.WriteLine("");
    Console.WriteLine("todo: v1");
    Console.WriteLine("What would you like to do");
    Console.WriteLine("");
    Console.WriteLine("1: to add task To-Do");
    Console.WriteLine("2: to mark as completed");
    Console.WriteLine("3: to delete task(s)");
    Console.WriteLine("4: to see all task(s)");
    Console.WriteLine("5: to leave application");
    Console.WriteLine("");

    userSelectionMenu = Console.ReadLine();

    switch (userSelectionMenu)
    {
        case "1":
            TodoList.AddItemOnList(todos);
            break;

        case "2":
            TodoList.CompletedTask(todos);
            break;

        case "3":
            TodoList.DeleteTask(todos);
            break;

        case "4":
            TodoList.ViewAllTask(todos);
            break;

        case "5": break;

        default:
            Console.WriteLine("invalid, please try again");
            break;
    }
} while (userSelectionMenu != "5");

Console.WriteLine("App Closed");

