using RichardsTodoList;
using static RichardsTodoList.AppCommands;
using static RichardsTodoList.HelpMenu;

List<ListOfLists> allLists = new List<ListOfLists>();
string userSelection;

do
{    userSelection = Console.ReadLine();

    if (userSelection.Equals(CreateList))
    {

            Console.WriteLine("\nPlease Enter a List Name spaces will be ignored\n");
            string userListName = Console.ReadLine().Replace(" ", "");
            ListOfLists userList = new ListOfLists { ListName = userListName, TodoLists = new List<TodoList>() };
            allLists.Add(userList);
            Console.WriteLine($"\nList with the following name {userList.ListName} created\n");
    }
    else if (userSelection.Equals(ViewLists))
    {
        if(allLists.Count > 0)
        {
            foreach (var lists in allLists)
            {
                Console.WriteLine($"\n{lists.ListName}\n");
            }
        }
        else
        {
            Console.WriteLine("\nNo lists has been created\n");
        }

    }
    else if (userSelection.Contains(Add))
    {
        try{
            string[] parts = userSelection.Split(' ');
            string actualListName = parts[1];
            ListOfLists selectedList = allLists.FirstOrDefault(i => i.ListName == actualListName);
            if (selectedList != null)
            {
                TodoList.AddTask(selectedList, userSelection);
            }
            else
            {
                Console.WriteLine("\nList not found, create a list or try again using correct list name or Type \"HELP\"\n");
            }
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message +" please provide a list name");
        }

    }
    else if (userSelection.Contains(Delete))
    {
        try
        {
            string[] parts = userSelection.Split(' ');
            string actualListName = parts[1];

            ListOfLists selectedList = allLists.FirstOrDefault(i => i.ListName == actualListName);

            if (selectedList != null)
            {
                TodoList.DeleteTask(selectedList, userSelection);
            }
            else
            {
                Console.WriteLine("\nList not found, create a list or try again using correct list name or Type \"HELP\"\n");
            }
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message + " please provide a list name");
        }
    }
    else if (userSelection.Contains(Complete))
    {
        try
        {
            string[] parts = userSelection.Split(' ');
            string actualListName = parts[1];
            ListOfLists selectedList = allLists.FirstOrDefault(i => i.ListName == actualListName);

            if (selectedList != null)
            {
                actualListName.Replace(actualListName, "");
                TodoList.CompleteTask(selectedList, userSelection);
            }
            else
            {
                Console.WriteLine("\nList not found, create a list or try again using correct list name or Type \"HELP\"\n");
            }

        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message + " please provide a list name");
        }

    }
    else if (userSelection.Contains(View))
    {
        try
        {
            string[] parts = userSelection.Split(' ');
            string actualListName = parts[1];
            ListOfLists selectedList = allLists.FirstOrDefault(i => i.ListName == actualListName);
            if (selectedList != null)
            {

                TodoList.ViewTask(selectedList, userSelection);
            }
            else
            {
                Console.WriteLine("\nList not found, create a list or try again using correct list name or Type \"HELP\"\n");
            }
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message + " please provide a list name");
        }
    }
    else if (userSelection.Equals(Help))
    {
            HelpMenus();
    }
    else if (userSelection.Equals(Clear))
    {
        Console.Clear();
    }
    else if (userSelection.Equals(Close))
    {
        Console.WriteLine("\n Thanks for using the app..\n");
    }
    else
    {
        Console.WriteLine("\nNot Valid type \"HELP\" for more info..\n");
    }


} while (userSelection != Close);


