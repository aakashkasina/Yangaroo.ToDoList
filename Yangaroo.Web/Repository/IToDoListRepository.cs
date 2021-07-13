using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yangaroo.Web.Models;

namespace Yangaroo.Web.Repository
{
    interface IToDoListRepository
    {
        bool AddItem(ToDoItem toDoItem);
        List<ToDoItem> GetItems();
    }
}
