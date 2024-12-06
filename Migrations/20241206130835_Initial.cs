using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocumentationWebSiteApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeadCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    Key = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Firstname = table.Column<string>(type: "text", nullable: false),
                    Lastname = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutUs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutUs_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HeadCategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_HeadCategories_HeadCategoryId",
                        column: x => x.HeadCategoryId,
                        principalTable: "HeadCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    AboutUsId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_AboutUs_AboutUsId",
                        column: x => x.AboutUsId,
                        principalTable: "AboutUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SubCategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topics_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TopicId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UploadedFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: false),
                    Alt = table.Column<string>(type: "text", nullable: false),
                    FileExtention = table.Column<string>(type: "text", nullable: false),
                    FilePath = table.Column<string>(type: "text", nullable: false),
                    FileSize = table.Column<string>(type: "text", nullable: false),
                    FileUrl = table.Column<string>(type: "text", nullable: false),
                    ContentId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadedFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UploadedFiles_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MultiLanguageTexts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    MetaDataType = table.Column<int>(type: "integer", nullable: false),
                    AboutUsId = table.Column<Guid>(type: "uuid", nullable: true),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    ContactId = table.Column<Guid>(type: "uuid", nullable: true),
                    ContentId = table.Column<Guid>(type: "uuid", nullable: true),
                    HeadCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    SubCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    TopicId = table.Column<Guid>(type: "uuid", nullable: true),
                    LanguageId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    MultiLanguageTextId = table.Column<Guid>(type: "uuid", nullable: true),
                    UploadedFileId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiLanguageTexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultiLanguageTexts_AboutUs_AboutUsId",
                        column: x => x.AboutUsId,
                        principalTable: "AboutUs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MultiLanguageTexts_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MultiLanguageTexts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MultiLanguageTexts_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MultiLanguageTexts_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MultiLanguageTexts_HeadCategories_HeadCategoryId",
                        column: x => x.HeadCategoryId,
                        principalTable: "HeadCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MultiLanguageTexts_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MultiLanguageTexts_Languages_LanguageId1",
                        column: x => x.LanguageId1,
                        principalTable: "Languages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MultiLanguageTexts_MultiLanguageTexts_MultiLanguageTextId",
                        column: x => x.MultiLanguageTextId,
                        principalTable: "MultiLanguageTexts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MultiLanguageTexts_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MultiLanguageTexts_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MultiLanguageTexts_UploadedFiles_UploadedFileId",
                        column: x => x.UploadedFileId,
                        principalTable: "UploadedFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MultiLanguageTexts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutUs_AddressId",
                table: "AboutUs",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_HeadCategoryId",
                table: "Categories",
                column: "HeadCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AboutUsId",
                table: "Contacts",
                column: "AboutUsId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_TopicId",
                table: "Contents",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Key",
                table: "Languages",
                column: "Key",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_AboutUsId",
                table: "MultiLanguageTexts",
                column: "AboutUsId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_AddressId",
                table: "MultiLanguageTexts",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_CategoryId",
                table: "MultiLanguageTexts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_ContactId",
                table: "MultiLanguageTexts",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_ContentId",
                table: "MultiLanguageTexts",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_HeadCategoryId",
                table: "MultiLanguageTexts",
                column: "HeadCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_LanguageId_MetaDataType_AboutUsId",
                table: "MultiLanguageTexts",
                columns: new[] { "LanguageId", "MetaDataType", "AboutUsId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_LanguageId_MetaDataType_AddressId",
                table: "MultiLanguageTexts",
                columns: new[] { "LanguageId", "MetaDataType", "AddressId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_LanguageId_MetaDataType_CategoryId",
                table: "MultiLanguageTexts",
                columns: new[] { "LanguageId", "MetaDataType", "CategoryId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_LanguageId_MetaDataType_ContactId",
                table: "MultiLanguageTexts",
                columns: new[] { "LanguageId", "MetaDataType", "ContactId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_LanguageId_MetaDataType_ContentId",
                table: "MultiLanguageTexts",
                columns: new[] { "LanguageId", "MetaDataType", "ContentId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_LanguageId_MetaDataType_HeadCategoryId",
                table: "MultiLanguageTexts",
                columns: new[] { "LanguageId", "MetaDataType", "HeadCategoryId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_LanguageId_MetaDataType_SubCategoryId",
                table: "MultiLanguageTexts",
                columns: new[] { "LanguageId", "MetaDataType", "SubCategoryId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_LanguageId_MetaDataType_TopicId",
                table: "MultiLanguageTexts",
                columns: new[] { "LanguageId", "MetaDataType", "TopicId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_LanguageId1",
                table: "MultiLanguageTexts",
                column: "LanguageId1");

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_MultiLanguageTextId",
                table: "MultiLanguageTexts",
                column: "MultiLanguageTextId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_SubCategoryId",
                table: "MultiLanguageTexts",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_TopicId",
                table: "MultiLanguageTexts",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_UploadedFileId",
                table: "MultiLanguageTexts",
                column: "UploadedFileId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiLanguageTexts_UserId",
                table: "MultiLanguageTexts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_SubCategoryId",
                table: "Topics",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadedFiles_ContentId",
                table: "UploadedFiles",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadedFiles_FileName",
                table: "UploadedFiles",
                column: "FileName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MultiLanguageTexts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "UploadedFiles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AboutUs");

            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "HeadCategories");
        }
    }
}
