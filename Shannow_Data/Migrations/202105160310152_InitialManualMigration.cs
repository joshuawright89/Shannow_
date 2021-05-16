namespace Shannow_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialManualMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Book", "WordCount", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Book", "WordCount");
        }
    }
}
