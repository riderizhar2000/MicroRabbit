using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroRabbit.Transfer.Data.Migrations
{
    public partial class ChangedColumnAmounttoTransferAmountinTableTransferLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "TransferLog");

            migrationBuilder.AddColumn<decimal>(
                name: "TransferAmount",
                table: "TransferLog",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransferAmount",
                table: "TransferLog");

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "TransferLog",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
