namespace ChoixResto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renamingtable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Restoes", newName: "Resto");
            RenameTable(name: "dbo.Sondages", newName: "Sondage");
            RenameTable(name: "dbo.Votes", newName: "Vote");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Vote", newName: "Votes");
            RenameTable(name: "dbo.Sondage", newName: "Sondages");
            RenameTable(name: "dbo.Resto", newName: "Restoes");
        }
    }
}
