using RichardsTodoList;
using static RichardsTodoList.AppCommands;
using System.Numerics;
using System.Runtime.InteropServices;


List<ListOfLists> allLists = new List<ListOfLists>();

ListOfLists list1 = new ListOfLists { ListName = "List One", TodoLists = new List<TodoList>() };
ListOfLists list2 = new ListOfLists { ListName = "List Two", TodoLists = new List<TodoList>() };

allLists.Add(list1);
allLists.Add(list2);

string userSelectionMenu;

do
{
    userSelectionMenu = Console.ReadLine();

    if (userSelectionMenu.Equals(ViewLists))
    {
        Console.WriteLine("\nThese are the lists: ");
        foreach (var list in allLists)
        {
            Console.WriteLine(list.ListName);
            Console.WriteLine();
        }
    }
    else if (userSelectionMenu.Contains(Add))
    {
        string listName = userSelectionMenu.Replace(Add, string.Empty).Trim();
        ListOfLists selectedList = allLists.FirstOrDefault(i => i.ListName == listName);

        if (selectedList != null)
        {
            TodoList.AddItemOnList(selectedList, userSelectionMenu);
        }
        else
        {
            Console.WriteLine("\nplease enter the list name as well\n");
        }
    }
    else if (userSelectionMenu.Contains(Delete))
    {
        string listName = userSelectionMenu.Replace(Delete, string.Empty).Trim();
        ListOfLists selectedList = allLists.FirstOrDefault(i => i.ListName == listName);

        if (selectedList != null)
        {
            TodoList.DeleteTask(selectedList, userSelectionMenu);
        }
        else
        {
            Console.WriteLine("\nplease enter the list name as well\n");
        }
    }
    else if (userSelectionMenu.Contains(Complete))
    {
        string listName = userSelectionMenu.Replace(Complete, string.Empty).Trim();
        ListOfLists selectedList = allLists.FirstOrDefault(i => i.ListName == listName);

        if (selectedList != null)
        {
            TodoList.ComplteTask(selectedList, userSelectionMenu);
        }
        else
        {
            Console.WriteLine("\nplease enter the list name as well\n");
        }
    }
    else if (userSelectionMenu.Contains(View))
    {
        string listName = userSelectionMenu.Replace(View, string.Empty).Trim();
        ListOfLists selectedList = allLists.FirstOrDefault(i => i.ListName == listName);

        if (selectedList != null)
        {
            TodoList.ViewAllTask(selectedList, userSelectionMenu);
        }
        else
        {
            Console.WriteLine("\nplease enter the list name as well\n");
        }
    }
    else if (userSelectionMenu.Equals(Help))
    {
        if (userSelectionMenu != null)
        {
            HelpMenu.HelpMenus();
        }
        else
        {
            Console.WriteLine("\nNot valid, type \"HELP\" for more info...\n");
        }
    }
    else if (userSelectionMenu.Equals(Clear))
    {
        if (userSelectionMenu != null)
        {
            Console.Clear();
        }
        else
        {
            Console.WriteLine("\nNot valid, type \"HELP\" for more info...\n"); ;
        }
    }
    else if (userSelectionMenu.Equals(Close))
    {
        if (userSelectionMenu != null)
        {
            Console.WriteLine("Thansk for using the applicaton");
        }
        else
        {
            Console.WriteLine("\nNot valid, type \"HELP\" for more info...\n"); ;
        }
    }
    else
    {
        Console.WriteLine("\nNot valid, type \"HELP\" for more info...\n");
    }
} while (userSelectionMenu != Close);