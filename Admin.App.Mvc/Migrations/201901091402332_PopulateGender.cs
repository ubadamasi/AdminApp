namespace Admin.App.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGender : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genders(Id, Description) Values (1, 'Male')");
            Sql("insert into Genders(Id, Description) Values (2, 'Female')");
        }
        
        public override void Down()
        {
        }
    }
}
