using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yangaroo.Web.Models;

namespace Yangaroo.Web.Repository
{
    public class ToDoListRepository: IToDoListRepository
    {
        public ToDoListRepository()
        {

        }

        public bool AddItem(ToDoItem toDoItem)
        {
            try
            {
                using (var context = new ToDoListContext())
                {
                    context.ToDoListItems.Add(toDoItem);
                    context.SaveChanges();
                    return true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public List<ToDoItem> GetItems()
        {
            try
            {
                using(var context = new ToDoListContext())
                {
                    return context.ToDoListItems.ToList();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}