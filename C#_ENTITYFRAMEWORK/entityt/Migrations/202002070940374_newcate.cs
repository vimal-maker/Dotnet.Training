namespace entityt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newcate : DbMigration
    {
        public override void Up()
        {
            Sql("update categories  set department = 'mech' where categoryID = 8");
        }
        
        public override void Down()
        {
        }
    }
}
