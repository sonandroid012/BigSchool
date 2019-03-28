namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Categories(Id, Name) values (1, 'Development')");
            Sql("insert into Categories(Id, Name) values (2, 'Marketing')");
            Sql("insert into Categories(Id, Name) values (3, 'Business')");
        }
        
        public override void Down()
        {
        }
    }
}
