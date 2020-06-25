namespace Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        idAdmin = c.Int(nullable: false, identity: true),
                        hoTen = c.String(nullable: false),
                        password = c.String(nullable: false),
                        email = c.String(nullable: false),
                        soDienThoai = c.String(nullable: false),
                        khoa = c.String(nullable: false),
                        chucVu = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.idAdmin);
            
            CreateTable(
                "dbo.DoAns",
                c => new
                    {
                        idDoAn = c.Int(nullable: false, identity: true),
                        tenDoAn = c.String(nullable: false),
                        noiDung = c.String(nullable: false),
                        khoaHoc = c.String(nullable: false),
                        khoa = c.String(nullable: false),
                        idGiangVien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idDoAn)
                .ForeignKey("dbo.GiangViens", t => t.idGiangVien, cascadeDelete: true)
                .Index(t => t.idGiangVien);
            
            CreateTable(
                "dbo.GiangViens",
                c => new
                    {
                        idGiangVien = c.Int(nullable: false, identity: true),
                        hoTen = c.String(nullable: false),
                        password = c.String(nullable: false),
                        email = c.String(nullable: false),
                        diaChi = c.String(nullable: false),
                        soDienThoai = c.String(nullable: false),
                        chucVu = c.String(nullable: false),
                        khoa = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.idGiangVien);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        idSinhVien = c.Int(nullable: false, identity: true),
                        hoTenSinhVien = c.String(nullable: false),
                        password = c.String(nullable: false),
                        nienKhoa = c.String(nullable: false),
                        diaChi = c.String(nullable: false),
                        soDienThoai = c.String(nullable: false),
                        email = c.String(nullable: false),
                        khoa = c.String(nullable: false),
                        idDoAn = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idSinhVien)
                .ForeignKey("dbo.DoAns", t => t.idDoAn, cascadeDelete: true)
                .Index(t => t.idDoAn);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "idDoAn", "dbo.DoAns");
            DropForeignKey("dbo.DoAns", "idGiangVien", "dbo.GiangViens");
            DropIndex("dbo.SinhViens", new[] { "idDoAn" });
            DropIndex("dbo.DoAns", new[] { "idGiangVien" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.GiangViens");
            DropTable("dbo.DoAns");
            DropTable("dbo.Admins");
        }
    }
}
