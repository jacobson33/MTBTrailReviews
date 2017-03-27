namespace MTBTrailReviews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "UserName", c => c.String());
            AddColumn("dbo.Reviews", "DateCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Trails", "Longitude", c => c.Double(nullable: false));
            AlterColumn("dbo.Trails", "Latitude", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trails", "Latitude", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Trails", "Longitude", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Reviews", "DateCreated");
            DropColumn("dbo.Reviews", "UserName");
        }
    }
}
