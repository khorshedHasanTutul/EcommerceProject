using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceBlazor.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "The Hitchhiker's Guide to the Galaxy has become an international multi-media phenomenon; the novels are the most widely distributed, having been translated into more than 30 languages by 2005.[4][5] The first novel, The Hitchhiker's Guide to the Galaxy (1979), has been ranked fourth on the BBC’s The Big Read poll.[6] The sixth novel, And Another Thing, was written by Eoin Colfer with additional unpublished material by Douglas Adams. In 2017, BBC Radio 4 announced a 40th-anniversary celebration with Dirk Maggs, one of the original producers, in charge.[7] The first of six new episodes was broadcast on 8 March 2018.[8] ", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 7.59m, "The Hitchhiker's Guide to the Galaxy" },
                    { 2, "One Thursday morning, Arthur Dent discovers that his house is to be immediately demolished to make way for a bypass. He tries delaying the bulldozers by lying down in front of them. Ford Prefect, a friend of Arthur's, convinces him to go to a pub with him.", "https://upload.wikimedia.org/wikipedia/en/7/7a/Hitchhikers_guide_to_the_galaxy.jpg", 5m, "The Hitchhiker's Guide to the Galaxy" },
                    { 3, "The Hitchhiker's Guide to the Galaxy has become an international multi-media phenomenon; the novels are the most widely distributed, having been translated into more than 30 languages by 2005.[4][5] The first novel, The Hitchhiker's Guide to the Galaxy (1979), has been ranked fourth on the BBC’s The Big Read poll.[6] The sixth novel, And Another Thing, was written by Eoin Colfer with additional unpublished material by Douglas Adams. In 2017, BBC Radio 4 announced a 40th-anniversary celebration with Dirk Maggs, one of the original producers, in charge.[7] The first of six new episodes was broadcast on 8 March 2018.[8] ", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 50.42m, "The Hitchhiker's Guide to the Galaxy" },
                    { 4, "One Thursday morning, Arthur Dent discovers that his house is to be immediately demolished to make way for a bypass. He tries delaying the bulldozers by lying down in front of them. Ford Prefect, a friend of Arthur's, convinces him to go to a pub with him.", "https://upload.wikimedia.org/wikipedia/en/7/7a/Hitchhikers_guide_to_the_galaxy.jpg", 45.90m, "The Hitchhiker's Guide to the Galaxy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
