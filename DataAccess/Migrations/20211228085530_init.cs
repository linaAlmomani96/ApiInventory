using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "currencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Attribute_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttributeValues_Attributes_Attribute_Id",
                        column: x => x.Attribute_Id,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ChargeAmount = table.Column<double>(nullable: false),
                    VatCharge = table.Column<double>(nullable: false),
                    Addrees = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    country_Id = table.Column<int>(nullable: false),
                    currency_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_companies_countries_country_Id",
                        column: x => x.country_Id,
                        principalTable: "countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_companies_currencies_currency_Id",
                        column: x => x.currency_Id,
                        principalTable: "currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SKU = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ImgPhoto = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    SizeId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false),
                    Brand_Id = table.Column<int>(nullable: false),
                    Category_Id = table.Column<int>(nullable: false),
                    Store_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_Brands_Brand_Id",
                        column: x => x.Brand_Id,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_Categories_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_AttributeValues_ColorId",
                        column: x => x.ColorId,
                        principalTable: "AttributeValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_AttributeValues_SizeId",
                        column: x => x.SizeId,
                        principalTable: "AttributeValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_Stores_Store_Id",
                        column: x => x.Store_Id,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerAddress = table.Column<string>(nullable: true),
                    CustomerPhone = table.Column<string>(nullable: true),
                    Product_Id = table.Column<int>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    Rate = table.Column<double>(nullable: false),
                    GrossAmount = table.Column<double>(nullable: false),
                    Vat = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    NetAmount = table.Column<double>(nullable: false),
                    ChargeAmount = table.Column<double>(nullable: false),
                    Paid_Statue = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_products_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValues_Attribute_Id",
                table: "AttributeValues",
                column: "Attribute_Id");

            migrationBuilder.CreateIndex(
                name: "IX_companies_country_Id",
                table: "companies",
                column: "country_Id");

            migrationBuilder.CreateIndex(
                name: "IX_companies_currency_Id",
                table: "companies",
                column: "currency_Id");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Product_Id",
                table: "orders",
                column: "Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_products_Brand_Id",
                table: "products",
                column: "Brand_Id");

            migrationBuilder.CreateIndex(
                name: "IX_products_Category_Id",
                table: "products",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_products_ColorId",
                table: "products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_products_SizeId",
                table: "products",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_products_Store_Id",
                table: "products",
                column: "Store_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "companies");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.DropTable(
                name: "currencies");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AttributeValues");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Attributes");
        }
    }
}
