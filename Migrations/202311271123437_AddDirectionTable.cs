namespace AISLab67.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDirectionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Directions",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 8),
                        Name = c.String(nullable: false),
                        SchoolId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schools", t => t.SchoolId)
                .Index(t => t.SchoolId);
            
            AlterColumn("dbo.Schools", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Schools", "Campus", c => c.String(nullable: false));
            AlterColumn("dbo.Schools", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Schools", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Directions", "SchoolId", "dbo.Schools");
            DropIndex("dbo.Directions", new[] { "SchoolId" });
            AlterColumn("dbo.Schools", "Phone", c => c.String());
            AlterColumn("dbo.Schools", "Address", c => c.String());
            AlterColumn("dbo.Schools", "Campus", c => c.String());
            AlterColumn("dbo.Schools", "Name", c => c.String());
            DropTable("dbo.Directions");
        }
    }
}
