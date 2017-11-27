namespace FootballApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arenas",
                c => new
                    {
                        ArenaId = c.Int(nullable: false, identity: true),
                        ArenaName = c.String(),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArenaId)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                    })
                .PrimaryKey(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Arenas", "TeamId", "dbo.Teams");
            DropIndex("dbo.Arenas", new[] { "TeamId" });
            DropTable("dbo.Teams");
            DropTable("dbo.Arenas");
        }
    }
}
