namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TaskDescription = c.String(),
                        TaskStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaskModels");
        }
    }
}
