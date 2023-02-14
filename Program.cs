using RichardsTodoList;

List<TodoList> todos = new List<TodoList>();

string userSelectionMenu;

do
{
    userSelectionMenu = Console.ReadLine();

    if (userSelectionMenu.Contains("ADD"))
    {
        string newUserSelection = userSelectionMenu.Replace("ADD", "");

        TodoList.AddItemOnList(todos, newUserSelection);
    }
    else if (userSelectionMenu.Contains("VIEW"))
    {
        TodoList.ViewAllTask(todos);
    }
    else if (userSelectionMenu.Contains("COMPLETE"))
    {
        string newUserSelection = userSelectionMenu.Replace("COMPLETE", "");
        TodoList.ComplteTask(todos, newUserSelection);
    }
    else if (userSelectionMenu.Contains("DELETE"))
    {
        string newUserSelection = userSelectionMenu.Replace("DELETE", "");
        TodoList.DeleteTask(todos, newUserSelection);
    }
    else if (userSelectionMenu.Contains("HELP"))
    {
        TodoList.HelpMenu();
    }
    else
    {
        if (userSelectionMenu.Contains("CLOSE"))
        {
            Console.WriteLine("Thanks for using the application");
        }
        else
        {
            Console.WriteLine("Type \"HELP\" for more information");
        }
    }
}

while (userSelectionMenu != "CLOSE");