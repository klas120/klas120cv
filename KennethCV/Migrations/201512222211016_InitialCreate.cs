namespace KennethCV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TrainingCenter = c.String(nullable: false),
                        CertificateName = c.String(nullable: false),
                        GradeLevel = c.String(),
                        yearReceived = c.String(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Employment = c.String(nullable: false),
                        SinceUntil = c.String(nullable: false),
                        Workplace = c.String(nullable: false),
                        WorkDetail = c.String(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.References",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameRefefence = c.String(nullable: false),
                        SurnameReference = c.String(nullable: false),
                        PhoneReference = c.String(nullable: false),
                        employmentReference = c.String(nullable: false),
                        WorkPlaceReference = c.String(nullable: false),
                        EmailReference = c.String(),
                        ComentReference = c.String(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameUser = c.String(nullable: false),
                        SurnameUser = c.String(nullable: false),
                        AgeUser = c.Int(nullable: false),
                        DocumentUser = c.String(nullable: false),
                        PhoneUser = c.String(nullable: false),
                        AddressUser = c.String(nullable: false),
                        EmailUser = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.References", "UserId", "dbo.Users");
            DropForeignKey("dbo.Experiences", "UserId", "dbo.Users");
            DropForeignKey("dbo.Educations", "UserId", "dbo.Users");
            DropIndex("dbo.References", new[] { "UserId" });
            DropIndex("dbo.Experiences", new[] { "UserId" });
            DropIndex("dbo.Educations", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.References");
            DropTable("dbo.Experiences");
            DropTable("dbo.Educations");
        }
    }
}
