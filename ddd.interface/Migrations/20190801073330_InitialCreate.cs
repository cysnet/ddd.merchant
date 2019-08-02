using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ddd.api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BalanceInfo",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: true),
                    Id = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTimeOffset>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    IsValid = table.Column<bool>(nullable: false),
                    Source = table.Column<int>(nullable: false),
                    MerchantId = table.Column<Guid>(nullable: false),
                    BlongAccount = table.Column<string>(nullable: true),
                    MoneyInfo_Money = table.Column<decimal>(nullable: false),
                    MoneyInfo_ServiceRate = table.Column<decimal>(nullable: false),
                    MoneyInfo_ServiceCharge = table.Column<decimal>(nullable: false),
                    MoneyInfo_TotleMoney = table.Column<decimal>(nullable: false),
                    PersonInfo_Name = table.Column<string>(nullable: true),
                    PersonInfo_IdCard = table.Column<string>(nullable: true),
                    PersonInfo_BankCard = table.Column<string>(nullable: true),
                    PersonInfo_PhoneNum = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceInfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BalanceInfo");
        }
    }
}
