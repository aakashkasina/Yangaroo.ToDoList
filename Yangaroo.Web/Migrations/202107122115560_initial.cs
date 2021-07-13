namespace Yangaroo.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ListItem = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ToDoItem");
        }
    }
}
