namespace ReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Description");
        }
    }
}
