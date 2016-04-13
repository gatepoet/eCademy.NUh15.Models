namespace Models1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieTitleLengthValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false, maxLength: 64));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false));
        }
    }
}
