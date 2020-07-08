namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateSinhVien_Diem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SinhViens", "diem", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SinhViens", "diem");
        }
    }
}
