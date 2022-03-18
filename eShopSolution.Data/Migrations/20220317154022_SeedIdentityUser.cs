using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 17, 22, 40, 20, 595, DateTimeKind.Local).AddTicks(9587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 17, 22, 17, 45, 382, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("247445ac-36fa-4caf-bc47-536bc5fd48e1"), "9eb10129-8cb7-4f04-8a41-1b52fb513a4a", "Adminitrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("247445ac-36fa-4caf-bc47-536bc5fd48e1"), new Guid("0cb1a7b9-290d-4e1c-8525-55ca1825eca4") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("0cb1a7b9-290d-4e1c-8525-55ca1825eca4"), 0, "d7fff67c-f691-43d4-8fe3-b913ea5a3d37", new DateTime(2002, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "giappham345@gmail.com", true, "Quang", "Giáp", false, null, "giappham345@gmail.com", "admin", "AQAAAAEAACcQAAAAEMbN9J7hKRNHHE2QLUspDCOXk4cyxXz33wZhYSByXPDTZ6enrxtDv2EOqInUjTLwdw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 17, 22, 40, 20, 626, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 17, 22, 40, 20, 626, DateTimeKind.Local).AddTicks(3779));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("247445ac-36fa-4caf-bc47-536bc5fd48e1"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("247445ac-36fa-4caf-bc47-536bc5fd48e1"), new Guid("0cb1a7b9-290d-4e1c-8525-55ca1825eca4") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("0cb1a7b9-290d-4e1c-8525-55ca1825eca4"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 17, 22, 17, 45, 382, DateTimeKind.Local).AddTicks(1642),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 3, 17, 22, 40, 20, 595, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 17, 22, 17, 45, 413, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 17, 22, 17, 45, 413, DateTimeKind.Local).AddTicks(3344));
        }
    }
}
