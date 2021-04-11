namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Class1 : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Class1s");
        }
    }
}
