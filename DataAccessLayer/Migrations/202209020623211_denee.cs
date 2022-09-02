namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class denee : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contents", "ContentValue", c => c.String(maxLength: 995));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contents", "ContentValue", c => c.String(maxLength: 990));
        }
    }
}
