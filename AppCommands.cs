using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichardsTodoList
{
    internal class ListOfLists{
        public string ListName { get; set; }
        public List<TodoList> TodoLists { get; set; }

    }
    internal class AppCommands
    {
        public const string ViewLists = "VIEWLISTS";
        public const string Add = "ADD";
        public const string Complete = "COMPLETE";
        public const string Delete = "DELETE";
        public const string View = "VIEW";
        public const string Help = "HELP";
        public const string Close = "CLOSE";
        public const string Clear = "CLEAR";

    }
}
