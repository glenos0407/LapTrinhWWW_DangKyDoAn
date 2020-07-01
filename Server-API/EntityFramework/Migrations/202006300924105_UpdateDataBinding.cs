namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDataBinding : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GiangViens", "email", c => c.String());
            AlterColumn("dbo.GiangViens", "diaChi", c => c.String());
            AlterColumn("dbo.GiangViens", "soDienThoai", c => c.String());
            AlterColumn("dbo.SinhViens", "diaChi", c => c.String());
            AlterColumn("dbo.SinhViens", "soDienThoai", c => c.String());
            AlterColumn("dbo.SinhViens", "email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SinhViens", "email", c => c.String(nullable: false));
            AlterColumn("dbo.SinhViens", "soDienThoai", c => c.String(nullable: false));
            AlterColumn("dbo.SinhViens", "diaChi", c => c.String(nullable: false));
            AlterColumn("dbo.GiangViens", "soDienThoai", c => c.String(nullable: false));
            AlterColumn("dbo.GiangViens", "diaChi", c => c.String(nullable: false));
            AlterColumn("dbo.GiangViens", "email", c => c.String(nullable: false));
        }
    }
}
