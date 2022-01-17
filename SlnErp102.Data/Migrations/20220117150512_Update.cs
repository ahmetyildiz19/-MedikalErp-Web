using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SlnErp102.Data.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BranchNoId = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SutCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SutPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SutDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_tblCompanies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tblCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BranchNoId", "CompanyId", "CreatedOn", "Description", "EntryDate", "ModifiedOn", "ModifiedUser", "Picture", "ProductCode", "SutCode", "SutDescription", "SutPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1928), "Suture Passer, Transosseous", new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1922), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1929), "system", "product1.jpg", "AR-1000", "AE-1000", "DÜZ TİTANYUM", 125.75m },
                    { 2, 2, 1, new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1932), "Suture Passer, Transosseous1", new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1930), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1932), "system", "product2.jpg", "AR-1001", "AE-1001", "DÜZ TİTANYUM", 155.75m },
                    { 3, 1, 1, new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1934), "Suture Passer, Transosseous2", new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1933), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1934), "system", "product3.jpg", "AR-1002", "AE-1002", "DÜZ TİTANYUM", 115.75m },
                    { 4, 1, 1, new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1936), "Suture Passer, Transosseous3", new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1935), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1937), "system", "product4.jpg", "AR-1003", "AE-1003", "DÜZ TİTANYUM", 215.25m }
                });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1547), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1550), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1551), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1313), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1315), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1317), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1319), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1320), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1322), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1620), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1621), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1624), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1624), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1626), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1626), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1760), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1761), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1761), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1759), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1764), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1765), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1765), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1763), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1767), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1768), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1768), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1767), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1206), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1209), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1211), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1212), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1214), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1216), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1217), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1219), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1034), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1037), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1038), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1040), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1041), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1042), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1044), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1046), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1047), new DateTime(2022, 1, 17, 18, 5, 11, 527, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyId",
                table: "Products",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(723), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(725), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(727), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(528), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(531), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(532), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(534), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(536), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(537), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(789), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(790), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(792), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(793), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(794), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(795), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(916), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(917), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(917), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(915), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(920), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(921), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(922), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(919), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(924), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(924), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(925), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(923), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(451), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(454), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(456), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(458), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(460), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(461), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(463), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(464), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(220), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(223), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(224), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(226), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(227), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(228), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(230), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(231), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(233), new DateTime(2022, 1, 17, 17, 5, 52, 950, DateTimeKind.Local).AddTicks(232) });
        }
    }
}
