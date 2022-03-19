using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaPlace.Server.Migrations
{
    public partial class ChangePizzaPlaceTableToPizzas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PizzaPlaces",
                table: "PizzaPlaces");

            migrationBuilder.RenameTable(
                name: "PizzaPlaces",
                newName: "Pizzas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas");

            migrationBuilder.RenameTable(
                name: "Pizzas",
                newName: "PizzaPlaces");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PizzaPlaces",
                table: "PizzaPlaces",
                column: "Id");
        }
    }
}
