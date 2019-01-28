namespace MVCRockers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PromoterName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Concerts", "PromoteName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Concerts", "PromoteName");
        }
    }
}
