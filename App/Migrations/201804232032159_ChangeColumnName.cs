namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeColumnName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TaskModels", "TaskStatus", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TaskModels", "TaskStatus", c => c.Int(nullable: false));
        }
    }
}
