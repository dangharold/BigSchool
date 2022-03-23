namespace _1911065192_HuynhHaiDang_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT  CATEGORIES (ID, NAME) VALUES (1, 'DEVELOPMENT')");
            Sql("INSERT  CATEGORIES (ID, NAME) VALUES (2, 'BUSINESS')");
            Sql("INSERT  CATEGORIES (ID, NAME) VALUES (3, 'MARKETING')");
            Sql("INSERT  CATEGORIES (ID, NAME) VALUES (4, 'TEACHER')");
            Sql("INSERT  CATEGORIES (ID, NAME) VALUES (5, 'MEMBER')");

        }

        public override void Down()
        {
        }
    }
}
