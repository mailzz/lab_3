namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Universities",
                c => new
                    {
                        UniversityId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UniversityId);
            
            CreateTable(
                "dbo.Directions",
                c => new
                    {
                        DirectionsId = c.Int(nullable: false, identity: true),
                        group = c.String(),
                        nubmer = c.Int(nullable: false),
                        UniversityId = c.Int(),
                    })
                .PrimaryKey(t => t.DirectionsId)
                .ForeignKey("dbo.Universities", t => t.UniversityId)
                .Index(t => t.UniversityId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentsId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FirstName = c.Int(nullable: false),
                        UniversityId = c.Int(),
                        Directions_DirectionsId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentsId)
                .ForeignKey("dbo.Directions", t => t.Directions_DirectionsId)
                .Index(t => t.Directions_DirectionsId);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        SectionsId = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Name = c.String(),
                        UniversityId = c.Int(),
                        Students_StudentsId = c.Int(),
                    })
                .PrimaryKey(t => t.SectionsId)
                .ForeignKey("dbo.Students", t => t.Students_StudentsId)
                .ForeignKey("dbo.Universities", t => t.UniversityId)
                .Index(t => t.UniversityId)
                .Index(t => t.Students_StudentsId);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        ProfessorsId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        subject = c.String(),
                        UniversityId = c.Int(),
                    })
                .PrimaryKey(t => t.ProfessorsId)
                .ForeignKey("dbo.Universities", t => t.UniversityId)
                .Index(t => t.UniversityId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        GroupsId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GroupsId);
            
            CreateTable(
                "dbo.GroupsProfessors",
                c => new
                    {
                        Groups_GroupsId = c.Int(nullable: false),
                        Professors_ProfessorsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Groups_GroupsId, t.Professors_ProfessorsId })
                .ForeignKey("dbo.Groups", t => t.Groups_GroupsId, cascadeDelete: true)
                .ForeignKey("dbo.Professors", t => t.Professors_ProfessorsId, cascadeDelete: true)
                .Index(t => t.Groups_GroupsId)
                .Index(t => t.Professors_ProfessorsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sections", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.Professors", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.GroupsProfessors", "Professors_ProfessorsId", "dbo.Professors");
            DropForeignKey("dbo.GroupsProfessors", "Groups_GroupsId", "dbo.Groups");
            DropForeignKey("dbo.Directions", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.Students", "Directions_DirectionsId", "dbo.Directions");
            DropForeignKey("dbo.Sections", "Students_StudentsId", "dbo.Students");
            DropIndex("dbo.GroupsProfessors", new[] { "Professors_ProfessorsId" });
            DropIndex("dbo.GroupsProfessors", new[] { "Groups_GroupsId" });
            DropIndex("dbo.Professors", new[] { "UniversityId" });
            DropIndex("dbo.Sections", new[] { "Students_StudentsId" });
            DropIndex("dbo.Sections", new[] { "UniversityId" });
            DropIndex("dbo.Students", new[] { "Directions_DirectionsId" });
            DropIndex("dbo.Directions", new[] { "UniversityId" });
            DropTable("dbo.GroupsProfessors");
            DropTable("dbo.Groups");
            DropTable("dbo.Professors");
            DropTable("dbo.Sections");
            DropTable("dbo.Students");
            DropTable("dbo.Directions");
            DropTable("dbo.Universities");
        }
    }
}
