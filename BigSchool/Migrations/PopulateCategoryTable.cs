namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Categorys(Id, Name) values (1, 'Development')");
            Sql("insert into Categorys(Id, Name) values (1, 'Development')");
            Sql("insert into Categorys(Id, Name) values (1, 'Development')");
        }
        
        public override void Down()
        {
        }
    }
}
