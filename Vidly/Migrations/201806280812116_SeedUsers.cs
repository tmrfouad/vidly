namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'35238b91-fcfc-4b03-802b-dfbdce2c769d', N'guest@vidly.com', 0, N'APjiWvlDwsYnbS8zBaEILs50r5mg6VPV3/Q9kQPatAtdIEY5xJY32fJkTGEw0cvUdQ==', N'6718331b-f504-498f-a55d-c2b1f856344c', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'98be5b2d-a837-4886-9baa-0046ebafce91', N'admin@vidly.com', 0, N'AJemxPUO3/MrIeHWdRA17QqBI7Fc3l7ZyxMdtjOZyVVVRjhnT6GQEz6SfR7AciS2ag==', N'86e5904c-b5f7-4b89-bb0e-521805731999', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5becff42-60f9-43e4-be59-4ddbc840c501', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'98be5b2d-a837-4886-9baa-0046ebafce91', N'5becff42-60f9-43e4-be59-4ddbc840c501')
            ");
        }
        
        public override void Down()
        {
            Sql(@"
                DELETE FROM [dbo].[AspNetUserRoles] WHERE ([UserId] = N'98be5b2d-a837-4886-9baa-0046ebafce91' AND [RoleId] = N'5becff42-60f9-43e4-be59-4ddbc840c501')

                DELETE FROM [dbo].[AspNetRoles] WHERE ([Id] = N'5becff42-60f9-43e4-be59-4ddbc840c501')

                DELETE FROM [dbo].[AspNetUsers] WHERE ([Id] = N'98be5b2d-a837-4886-9baa-0046ebafce91')
                DELETE FROM [dbo].[AspNetUsers] WHERE ([Id] = N'35238b91-fcfc-4b03-802b-dfbdce2c769d')
            ");
        }
    }
}
