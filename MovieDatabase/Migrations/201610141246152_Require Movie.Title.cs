namespace MovieDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequireMovieTitle : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String());
        }
    }
}
