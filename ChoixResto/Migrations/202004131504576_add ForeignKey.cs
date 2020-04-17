namespace ChoixResto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vote", "Resto_RestoId", "dbo.Resto");
            DropIndex("dbo.Vote", new[] { "Resto_RestoId" });
            RenameColumn(table: "dbo.Vote", name: "Resto_RestoId", newName: "RestoId");
            RenameColumn(table: "dbo.Vote", name: "Utilisateur_Id", newName: "UserId");
            RenameIndex(table: "dbo.Vote", name: "IX_Utilisateur_Id", newName: "IX_UserId");
            AlterColumn("dbo.Vote", "RestoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Vote", "RestoId");
            AddForeignKey("dbo.Vote", "RestoId", "dbo.Resto", "RestoId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vote", "RestoId", "dbo.Resto");
            DropIndex("dbo.Vote", new[] { "RestoId" });
            AlterColumn("dbo.Vote", "RestoId", c => c.Int());
            RenameIndex(table: "dbo.Vote", name: "IX_UserId", newName: "IX_Utilisateur_Id");
            RenameColumn(table: "dbo.Vote", name: "UserId", newName: "Utilisateur_Id");
            RenameColumn(table: "dbo.Vote", name: "RestoId", newName: "Resto_RestoId");
            CreateIndex("dbo.Vote", "Resto_RestoId");
            AddForeignKey("dbo.Vote", "Resto_RestoId", "dbo.Resto", "RestoId");
        }
    }
}
