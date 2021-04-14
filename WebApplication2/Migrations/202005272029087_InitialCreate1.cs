namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.GroupsProfessors", newName: "ProfessorsGroups");
            DropPrimaryKey("dbo.ProfessorsGroups");
            AddPrimaryKey("dbo.ProfessorsGroups", new[] { "Professors_ProfessorsId", "Groups_GroupsId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ProfessorsGroups");
            AddPrimaryKey("dbo.ProfessorsGroups", new[] { "Groups_GroupsId", "Professors_ProfessorsId" });
            RenameTable(name: "dbo.ProfessorsGroups", newName: "GroupsProfessors");
        }
    }
}
