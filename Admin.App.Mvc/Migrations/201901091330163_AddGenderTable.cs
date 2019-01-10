namespace Admin.App.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenderTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "Gender_Id", c => c.Byte());
            CreateIndex("dbo.Employees", "Gender_Id");
            AddForeignKey("dbo.Employees", "Gender_Id", "dbo.Genders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Gender_Id", "dbo.Genders");
            DropIndex("dbo.Employees", new[] { "Gender_Id" });
            DropColumn("dbo.Employees", "Gender_Id");
            DropTable("dbo.Genders");
        }
    }
}
