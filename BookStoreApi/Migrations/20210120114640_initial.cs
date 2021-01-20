using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Author",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Genre = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookShelf",
                schema: "dbo",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookName = table.Column<string>(maxLength: 200, nullable: false),
                    Category = table.Column<string>(maxLength: 100, nullable: false),
                    SubCategory = table.Column<string>(maxLength: 100, nullable: false),
                    Publisher = table.Column<string>(maxLength: 20, nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Medium = table.Column<string>(maxLength: 20, nullable: false),
                    Rating = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(maxLength: 300, nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookShelf", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerOrder",
                schema: "dbo",
                columns: table => new
                {
                    CustomerOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeliveryAddress = table.Column<string>(maxLength: 200, nullable: false),
                    PaymentMode = table.Column<string>(nullable: false),
                    PaymentDetails = table.Column<string>(nullable: false),
                    CourierId = table.Column<int>(nullable: false),
                    TotalCost = table.Column<decimal>(nullable: false),
                    OrderDateRaised = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOrder", x => x.CustomerOrderId);
                });

            migrationBuilder.CreateTable(
                name: "MembershipDetail",
                schema: "dbo",
                columns: table => new
                {
                    MembershipId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Discount = table.Column<decimal>(nullable: false),
                    DeliveryCharges = table.Column<decimal>(nullable: false),
                    DeliveryPriority = table.Column<string>(nullable: false),
                    MembershipType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipDetail", x => x.MembershipId);
                });

            migrationBuilder.CreateTable(
                name: "PublisherDetails",
                schema: "dbo",
                columns: table => new
                {
                    PublisherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PublisherName = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublisherDetails", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerOrderId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    OrderDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_BookShelf_BookId",
                        column: x => x.BookId,
                        principalSchema: "dbo",
                        principalTable: "BookShelf",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_CustomerOrder_CustomerOrderId",
                        column: x => x.CustomerOrderId,
                        principalSchema: "dbo",
                        principalTable: "CustomerOrder",
                        principalColumn: "CustomerOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderInventory",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PublisherOrderId = table.Column<int>(nullable: false),
                    CustomerOrderId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    OrderType = table.Column<string>(nullable: true),
                    DateRaised = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderInventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderInventory_CustomerOrder_CustomerOrderId",
                        column: x => x.CustomerOrderId,
                        principalSchema: "dbo",
                        principalTable: "CustomerOrder",
                        principalColumn: "CustomerOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                schema: "dbo",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DisplayName = table.Column<string>(maxLength: 50, nullable: false),
                    MembershipId = table.Column<int>(nullable: false),
                    MainDeliveryAddress = table.Column<string>(maxLength: 200, nullable: false),
                    ActiveDirectoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customer_MembershipDetail_MembershipId",
                        column: x => x.MembershipId,
                        principalSchema: "dbo",
                        principalTable: "MembershipDetail",
                        principalColumn: "MembershipId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PublisherOrder",
                schema: "dbo",
                columns: table => new
                {
                    PublisherOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderDetailId = table.Column<int>(nullable: false),
                    OrderRaisedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublisherOrder", x => x.PublisherOrderId);
                    table.ForeignKey(
                        name: "FK_PublisherOrder_OrderDetails_OrderDetailId",
                        column: x => x.OrderDetailId,
                        principalSchema: "dbo",
                        principalTable: "OrderDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookRating",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    RatingComments = table.Column<string>(nullable: true),
                    Recommendation = table.Column<string>(nullable: true),
                    BookId = table.Column<int>(nullable: false),
                    Rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookRating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookRating_BookShelf_BookId",
                        column: x => x.BookId,
                        principalSchema: "dbo",
                        principalTable: "BookShelf",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookRating_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerPaymentDetails",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    PreferredPaymentOption = table.Column<string>(maxLength: 10, nullable: false),
                    CardNumber = table.Column<int>(nullable: false),
                    CardType = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPaymentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerPaymentDetails_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "dbo",
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PublisherOrderDetails",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PublisherOrderId = table.Column<int>(nullable: false),
                    BookName = table.Column<string>(maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublisherOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PublisherOrderDetails_PublisherOrder_PublisherOrderId",
                        column: x => x.PublisherOrderId,
                        principalSchema: "dbo",
                        principalTable: "PublisherOrder",
                        principalColumn: "PublisherOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BookShelf",
                columns: new[] { "BookId", "BookName", "Category", "Cost", "Count", "Medium", "Publisher", "Rating", "SubCategory", "Summary" },
                values: new object[] { 1, "Azure Basics", "Infomation Technology", 500m, 20, "E Book", "O Reilly", null, "Cloud Computing", "This a basic book for understanding Azure Fundamentals" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BookShelf",
                columns: new[] { "BookId", "BookName", "Category", "Cost", "Count", "Medium", "Publisher", "Rating", "SubCategory", "Summary" },
                values: new object[] { 2, "AWS Basics", "Infomation Technology", 600m, 25, "E Book", "O Reilly", null, "Cloud Computing", "This a basic book for understanding AWS Fundamentals" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "BookShelf",
                columns: new[] { "BookId", "BookName", "Category", "Cost", "Count", "Medium", "Publisher", "Rating", "SubCategory", "Summary" },
                values: new object[] { 3, "NetWorking Basics", "Infomation Technology", 400m, 50, "E Book", "O Reilly", null, "Networks", "This a basic book for understanding NetWorking Fundamentals" });

            migrationBuilder.CreateIndex(
                name: "IX_BookRating_BookId",
                schema: "dbo",
                table: "BookRating",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookRating_CustomerId",
                schema: "dbo",
                table: "BookRating",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_MembershipId",
                schema: "dbo",
                table: "Customer",
                column: "MembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPaymentDetails_CustomerId",
                schema: "dbo",
                table: "CustomerPaymentDetails",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_BookId",
                schema: "dbo",
                table: "OrderDetails",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CustomerOrderId",
                schema: "dbo",
                table: "OrderDetails",
                column: "CustomerOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderInventory_CustomerOrderId",
                schema: "dbo",
                table: "OrderInventory",
                column: "CustomerOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_PublisherOrder_OrderDetailId",
                schema: "dbo",
                table: "PublisherOrder",
                column: "OrderDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PublisherOrderDetails_PublisherOrderId",
                schema: "dbo",
                table: "PublisherOrderDetails",
                column: "PublisherOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Author",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BookRating",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CustomerPaymentDetails",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OrderInventory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PublisherDetails",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PublisherOrderDetails",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Customer",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PublisherOrder",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MembershipDetail",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OrderDetails",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BookShelf",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CustomerOrder",
                schema: "dbo");
        }
    }
}
