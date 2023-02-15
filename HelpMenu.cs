using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichardsTodoList
{
    public class HelpMenu
    {
        internal static void HelpMenus()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*     Welcome to \"Richard's To-Do List\" Finale    *");
            Console.WriteLine("*****************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("  * Instructions!");
            Console.WriteLine("  * All commands must be in CAPITAL CASES!!");
            Console.WriteLine("  * to add, delete, view and complete a task enter command with a list name AND the task");
            Console.WriteLine("");
            Console.WriteLine("  * Commands are as follows:");
            Console.WriteLine("");
            Console.WriteLine("  * \"CREATELIST\", creates a list list(s)");
            Console.WriteLine("  * \"VIEWLISTS\", shows all current list(s)");
            Console.WriteLine("  * \"ADD\", to add task To-Do");
            Console.WriteLine("  * \"COMPLETE\" to mark as completed");
            Console.WriteLine("  * \"DELETE\" to delete task(s)");
            Console.WriteLine("  * \"VIEW\" to see all task(s)");
            Console.WriteLine("  * \"HELP\" to..Wait your already did..");
            Console.WriteLine("  * \"CLOSE\" to leave application");
            Console.WriteLine("  * \"CLEAR\" to clear screen");
            Console.WriteLine("");
        }
    }
}
