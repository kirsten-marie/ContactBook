using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactBook.Migrations
{
    public partial class ModelRevisions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Addresses_AddressId1",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_FrequencyChoices_ContactFrequencyId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_AddressId1",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_ContactFrequencyId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "AddressId1",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "ContactFrequencyId",
                table: "Contacts");

            migrationBuilder.AlterColumn<long>(
                name: "AddressId",
                table: "Contacts",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "ContactFrequencyFrequencyId",
                table: "Contacts",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AddressId",
                table: "Contacts",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ContactFrequencyFrequencyId",
                table: "Contacts",
                column: "ContactFrequencyFrequencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Addresses_AddressId",
                table: "Contacts",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_FrequencyChoices_ContactFrequencyFrequencyId",
                table: "Contacts",
                column: "ContactFrequencyFrequencyId",
                principalTable: "FrequencyChoices",
                principalColumn: "FrequencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Addresses_AddressId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_FrequencyChoices_ContactFrequencyFrequencyId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_AddressId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_ContactFrequencyFrequencyId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "ContactFrequencyFrequencyId",
                table: "Contacts");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Contacts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "AddressId1",
                table: "Contacts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "ContactFrequencyId",
                table: "Contacts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AddressId1",
                table: "Contacts",
                column: "AddressId1");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ContactFrequencyId",
                table: "Contacts",
                column: "ContactFrequencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Addresses_AddressId1",
                table: "Contacts",
                column: "AddressId1",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_FrequencyChoices_ContactFrequencyId",
                table: "Contacts",
                column: "ContactFrequencyId",
                principalTable: "FrequencyChoices",
                principalColumn: "FrequencyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
