namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Type = c.Int(nullable: false),
                        Story_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stories", t => t.Story_Id)
                .Index(t => t.Story_Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                        Approved = c.Boolean(nullable: false),
                        ImageLink = c.String(),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Author_Id)
                .Index(t => t.Author_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StoryText = c.String(),
                        Approved = c.Boolean(nullable: false),
                        CompletionStatus = c.Int(nullable: false),
                        Post_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.Post_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Post_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PostTagPosts",
                c => new
                    {
                        PostTag_Id = c.Int(nullable: false),
                        Post_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PostTag_Id, t.Post_Id })
                .ForeignKey("dbo.PostTags", t => t.PostTag_Id, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.Post_Id, cascadeDelete: true)
                .Index(t => t.PostTag_Id)
                .Index(t => t.Post_Id);
            
            CreateTable(
                "dbo.TagPostTags",
                c => new
                    {
                        Tag_Id = c.Int(nullable: false),
                        PostTag_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_Id, t.PostTag_Id })
                .ForeignKey("dbo.Tags", t => t.Tag_Id, cascadeDelete: true)
                .ForeignKey("dbo.PostTags", t => t.PostTag_Id, cascadeDelete: true)
                .Index(t => t.Tag_Id)
                .Index(t => t.PostTag_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TagPostTags", "PostTag_Id", "dbo.PostTags");
            DropForeignKey("dbo.TagPostTags", "Tag_Id", "dbo.Tags");
            DropForeignKey("dbo.PostTagPosts", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.PostTagPosts", "PostTag_Id", "dbo.PostTags");
            DropForeignKey("dbo.Posts", "Author_Id", "dbo.Users");
            DropForeignKey("dbo.Stories", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Stories", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.Contents", "Story_Id", "dbo.Stories");
            DropIndex("dbo.TagPostTags", new[] { "PostTag_Id" });
            DropIndex("dbo.TagPostTags", new[] { "Tag_Id" });
            DropIndex("dbo.PostTagPosts", new[] { "Post_Id" });
            DropIndex("dbo.PostTagPosts", new[] { "PostTag_Id" });
            DropIndex("dbo.Stories", new[] { "User_Id" });
            DropIndex("dbo.Stories", new[] { "Post_Id" });
            DropIndex("dbo.Posts", new[] { "Author_Id" });
            DropIndex("dbo.Contents", new[] { "Story_Id" });
            DropTable("dbo.TagPostTags");
            DropTable("dbo.PostTagPosts");
            DropTable("dbo.Tags");
            DropTable("dbo.PostTags");
            DropTable("dbo.Stories");
            DropTable("dbo.Users");
            DropTable("dbo.Posts");
            DropTable("dbo.Contents");
        }
    }
}
