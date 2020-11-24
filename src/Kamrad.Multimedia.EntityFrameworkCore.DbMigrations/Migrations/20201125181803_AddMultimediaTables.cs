using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kamrad.Multimedia.Migrations
{
    public partial class AddMultimediaTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "File");

            migrationBuilder.EnsureSchema(
                name: "Media");

            migrationBuilder.CreateTable(
                name: "AppFileCategories",
                schema: "File",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    ContentType = table.Column<string>(nullable: true),
                    MaxLength = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppFileCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppGenres",
                schema: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppGenres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppMediaEvents",
                schema: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMediaEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppOrganizationalMatters",
                schema: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bandwidth = table.Column<int>(nullable: false),
                    ConnectionType = table.Column<string>(nullable: true),
                    OrganizationalMatterIdFk = table.Column<int>(nullable: true),
                    OrganizationalName = table.Column<string>(nullable: true),
                    OrganizationalMatterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOrganizationalMatters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppOrganizationalMatters_AppOrganizationalMatters_OrganizationalMatterId",
                        column: x => x.OrganizationalMatterId,
                        principalSchema: "Media",
                        principalTable: "AppOrganizationalMatters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppOrganizationalPositions",
                schema: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationalpositionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOrganizationalPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppThematicCategories",
                schema: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThematicCategorieName = table.Column<string>(nullable: true),
                    ThematicCategorieIdFk = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppThematicCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppThematicCategories_AppThematicCategories_ThematicCategorieIdFk",
                        column: x => x.ThematicCategorieIdFk,
                        principalSchema: "Media",
                        principalTable: "AppThematicCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppFileTypes",
                schema: "File",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileCategoryFk = table.Column<int>(nullable: false),
                    FileExtension = table.Column<string>(nullable: true),
                    FileMimeType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppFileTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppFileTypes_AppFileCategories_FileCategoryFk",
                        column: x => x.FileCategoryFk,
                        principalSchema: "File",
                        principalTable: "AppFileCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppParticipants",
                schema: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationalPositionIdFk = table.Column<int>(nullable: true),
                    ParticipantLastName = table.Column<string>(nullable: true),
                    ParticipantName = table.Column<string>(nullable: true),
                    OrganizationalPositionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppParticipants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppParticipants_AppOrganizationalPositions_OrganizationalPositionId",
                        column: x => x.OrganizationalPositionId,
                        principalSchema: "Media",
                        principalTable: "AppOrganizationalPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppMediaInfos",
                schema: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Actors = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    CameraMan = table.Column<string>(nullable: true),
                    CameraModel = table.Column<string>(nullable: true),
                    Compositor = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Editor = table.Column<string>(nullable: true),
                    MediaEventIdFk = table.Column<int>(nullable: true),
                    ManufactureDate = table.Column<DateTime>(nullable: true),
                    MediaName = table.Column<string>(nullable: true),
                    NumberOfRowsAndArchive = table.Column<int>(nullable: false),
                    Orator = table.Column<string>(nullable: true),
                    ParticipantIdFk = table.Column<int>(nullable: true),
                    Photographer = table.Column<string>(nullable: true),
                    Place = table.Column<string>(nullable: true),
                    Producer = table.Column<string>(nullable: true),
                    Rate = table.Column<int>(nullable: false),
                    Studio = table.Column<string>(nullable: true),
                    ThematicCategoryIdFk = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    UserIdFk = table.Column<int>(nullable: false),
                    GenreIdFk = table.Column<int>(nullable: true),
                    ParticipantsId = table.Column<int>(nullable: true),
                    Tags = table.Column<string>(nullable: true),
                    MediaInfoIdFk = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMediaInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppMediaInfos_AppGenres_GenreIdFk",
                        column: x => x.GenreIdFk,
                        principalSchema: "Media",
                        principalTable: "AppGenres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppMediaInfos_AppMediaEvents_MediaEventIdFk",
                        column: x => x.MediaEventIdFk,
                        principalSchema: "Media",
                        principalTable: "AppMediaEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppMediaInfos_AppParticipants_ParticipantIdFk",
                        column: x => x.ParticipantIdFk,
                        principalSchema: "Media",
                        principalTable: "AppParticipants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppMediaInfos_AppThematicCategories_ThematicCategoryIdFk",
                        column: x => x.ThematicCategoryIdFk,
                        principalSchema: "Media",
                        principalTable: "AppThematicCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppFiles",
                schema: "File",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duration = table.Column<double>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    FileSize = table.Column<long>(nullable: false),
                    FileTypeFk = table.Column<int>(nullable: false),
                    Img = table.Column<byte[]>(nullable: true),
                    MediaAddress = table.Column<string>(nullable: true),
                    MediaInfoFk = table.Column<int>(nullable: false),
                    Tag = table.Column<string>(nullable: true),
                    Like = table.Column<long>(nullable: false),
                    Visit = table.Column<long>(nullable: false),
                    FileTypeId = table.Column<int>(nullable: true),
                    ParticipantsId = table.Column<int>(nullable: true),
                    Latitude = table.Column<double>(nullable: true),
                    Longitude = table.Column<double>(nullable: true),
                    Place = table.Column<string>(nullable: true),
                    ShortKey = table.Column<string>(nullable: true),
                    MediaInfoFkNavigationId = table.Column<int>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppFiles_AppFileTypes_FileTypeId",
                        column: x => x.FileTypeId,
                        principalSchema: "File",
                        principalTable: "AppFileTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppFiles_AppMediaInfos_MediaInfoFkNavigationId",
                        column: x => x.MediaInfoFkNavigationId,
                        principalSchema: "Media",
                        principalTable: "AppMediaInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppFileComments",
                schema: "File",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(nullable: true),
                    FileIdFk = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppFileComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppFileComments_AppFiles_FileIdFk",
                        column: x => x.FileIdFk,
                        principalSchema: "File",
                        principalTable: "AppFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppFileUserLikes",
                schema: "File",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ipaddress = table.Column<string>(nullable: true),
                    FileIdFk = table.Column<long>(nullable: false),
                    UserIdFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppFileUserLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppFileUserLikes_AppFiles_FileIdFk",
                        column: x => x.FileIdFk,
                        principalSchema: "File",
                        principalTable: "AppFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppMediaInfoFileParticipants",
                schema: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaInfoIdFk = table.Column<int>(nullable: true),
                    FileIdFk = table.Column<int>(nullable: true),
                    ParticipantIdFk = table.Column<int>(nullable: false),
                    FileId = table.Column<long>(nullable: true),
                    MediaInfoId = table.Column<int>(nullable: true),
                    ParticipantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMediaInfoFileParticipants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppMediaInfoFileParticipants_AppFiles_FileId",
                        column: x => x.FileId,
                        principalSchema: "File",
                        principalTable: "AppFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppMediaInfoFileParticipants_AppMediaInfos_MediaInfoId",
                        column: x => x.MediaInfoId,
                        principalSchema: "Media",
                        principalTable: "AppMediaInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppMediaInfoFileParticipants_AppParticipants_ParticipantId",
                        column: x => x.ParticipantId,
                        principalSchema: "Media",
                        principalTable: "AppParticipants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppFileComments_FileIdFk",
                schema: "File",
                table: "AppFileComments",
                column: "FileIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_AppFiles_FileTypeId",
                schema: "File",
                table: "AppFiles",
                column: "FileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppFiles_MediaInfoFkNavigationId",
                schema: "File",
                table: "AppFiles",
                column: "MediaInfoFkNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_AppFileTypes_FileCategoryFk",
                schema: "File",
                table: "AppFileTypes",
                column: "FileCategoryFk");

            migrationBuilder.CreateIndex(
                name: "IX_AppFileUserLikes_FileIdFk",
                schema: "File",
                table: "AppFileUserLikes",
                column: "FileIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_AppMediaInfoFileParticipants_FileId",
                schema: "Media",
                table: "AppMediaInfoFileParticipants",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_AppMediaInfoFileParticipants_MediaInfoId",
                schema: "Media",
                table: "AppMediaInfoFileParticipants",
                column: "MediaInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_AppMediaInfoFileParticipants_ParticipantId",
                schema: "Media",
                table: "AppMediaInfoFileParticipants",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_AppMediaInfos_GenreIdFk",
                schema: "Media",
                table: "AppMediaInfos",
                column: "GenreIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_AppMediaInfos_MediaEventIdFk",
                schema: "Media",
                table: "AppMediaInfos",
                column: "MediaEventIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_AppMediaInfos_ParticipantIdFk",
                schema: "Media",
                table: "AppMediaInfos",
                column: "ParticipantIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_AppMediaInfos_ThematicCategoryIdFk",
                schema: "Media",
                table: "AppMediaInfos",
                column: "ThematicCategoryIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_AppOrganizationalMatters_OrganizationalMatterId",
                schema: "Media",
                table: "AppOrganizationalMatters",
                column: "OrganizationalMatterId");

            migrationBuilder.CreateIndex(
                name: "IX_AppParticipants_OrganizationalPositionId",
                schema: "Media",
                table: "AppParticipants",
                column: "OrganizationalPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppThematicCategories_ThematicCategorieIdFk",
                schema: "Media",
                table: "AppThematicCategories",
                column: "ThematicCategorieIdFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppFileComments",
                schema: "File");

            migrationBuilder.DropTable(
                name: "AppFileUserLikes",
                schema: "File");

            migrationBuilder.DropTable(
                name: "AppMediaInfoFileParticipants",
                schema: "Media");

            migrationBuilder.DropTable(
                name: "AppOrganizationalMatters",
                schema: "Media");

            migrationBuilder.DropTable(
                name: "AppFiles",
                schema: "File");

            migrationBuilder.DropTable(
                name: "AppFileTypes",
                schema: "File");

            migrationBuilder.DropTable(
                name: "AppMediaInfos",
                schema: "Media");

            migrationBuilder.DropTable(
                name: "AppFileCategories",
                schema: "File");

            migrationBuilder.DropTable(
                name: "AppGenres",
                schema: "Media");

            migrationBuilder.DropTable(
                name: "AppMediaEvents",
                schema: "Media");

            migrationBuilder.DropTable(
                name: "AppParticipants",
                schema: "Media");

            migrationBuilder.DropTable(
                name: "AppThematicCategories",
                schema: "Media");

            migrationBuilder.DropTable(
                name: "AppOrganizationalPositions",
                schema: "Media");
        }
    }
}
