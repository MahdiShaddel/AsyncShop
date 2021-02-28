using Microsoft.EntityFrameworkCore.Migrations;

namespace VenderFluentApi.Migrations
{
    public partial class fixVendor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Vendor_VendorFK",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Tag_VendorFK",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "VendorFK",
                table: "Tag");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_VendorId",
                table: "Tag",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Vendor_VendorId",
                table: "Tag",
                column: "VendorId",
                principalTable: "Vendor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Vendor_VendorId",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Tag_VendorId",
                table: "Tag");

            migrationBuilder.AddColumn<int>(
                name: "VendorFK",
                table: "Tag",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tag_VendorFK",
                table: "Tag",
                column: "VendorFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Vendor_VendorFK",
                table: "Tag",
                column: "VendorFK",
                principalTable: "Vendor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
