namespace entityt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newcategories : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.categories", "department", c => c.String());
            Sql("update categories  set department = 'mech' where categoryID = 8");
        }
        
        public override void Down()
        {
            DropColumn("dbo.categories", "department");
        }
    }
}
