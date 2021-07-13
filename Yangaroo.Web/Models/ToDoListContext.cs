using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Yangaroo.Web.Models
{
    public class ToDoListContext: DbContext
    {
        public ToDoListContext(): base("ToDoListEntity")
        {

        }

        public DbSet<ToDoItem> ToDoListItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}