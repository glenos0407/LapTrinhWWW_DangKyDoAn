namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAvatar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GiangViens", "avatarLink", c => c.String(nullable: false));
            AddColumn("dbo.SinhViens", "avatarLink", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SinhViens", "avatarLink");
            DropColumn("dbo.GiangViens", "avatarLink");
        }
    }
}
