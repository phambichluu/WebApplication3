namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Class2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class1s",
                c => new
                    {
                        CCCD = c.String(nullable: false, maxLength: 128),
                        Sdt = c.String(),
                    })
                .PrimaryKey(t => t.CCCD);
            
            CreateTable(
                "dbo.Class2s",
                c => new
                    {
                        CCCD = c.String(nullable: false, maxLength: 128),
                        HoVaTen = c.String(),
                        DiaChi = c.String(),
                        TruongHoc = c.String(),
                    })
                .PrimaryKey(t => t.CCCD)
                .ForeignKey("dbo.Class1s", t => t.CCCD)
                .Index(t => t.CCCD);
            
            DropTable("dbo.Class1s");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Class1s",
                c => new
                    {
                        CCCD = c.String(nullable: false, maxLength: 128),
                        Sdt = c.String(),
                    })
                .PrimaryKey(t => t.CCCD);
            
            DropForeignKey("dbo.Class2s", "CCCD", "dbo.Class1s");
            DropIndex("dbo.Class2s", new[] { "CCCD" });
            DropTable("dbo.Class2s");
            DropTable("dbo.Class1s");
        }
    }
}
