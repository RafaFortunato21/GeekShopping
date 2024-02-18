﻿// <auto-generated />
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20240218233229_SeedDatabase")]
    partial class SeedDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CategoryName = "Muggy",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/RafaFortunato21/GeekShopping/blob/master/ShoppingImages/1_super_mario.jpg?raw=true",
                            Name = "Super Mario World",
                            Price = 39.9m
                        },
                        new
                        {
                            Id = 2L,
                            CategoryName = "T-shirt",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/RafaFortunato21/GeekShopping/blob/master/ShoppingImages/2_no_internet.jpg?raw=true",
                            Name = "Camiseta No Internet",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryName = "Action Figure",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/RafaFortunato21/GeekShopping/blob/master/ShoppingImages/3_vader.jpg?raw=true",
                            Name = "Capacete Darth Vader Star Wars Black Series",
                            Price = 999.99m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "Action Figure",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/RafaFortunato21/GeekShopping/blob/master/ShoppingImages/4_storm_tropper.jpg?raw=true",
                            Name = "Star Wars The Black Series Hasbro - Stormtrooper Imperial",
                            Price = 189.99m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryName = "T-shirt",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/RafaFortunato21/GeekShopping/blob/master/ShoppingImages/5_100_gamer.jpg?raw=true",
                            Name = "Camiseta Gamer",
                            Price = 69.99m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryName = "T-shirt",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/RafaFortunato21/GeekShopping/blob/master/ShoppingImages/6_spacex.jpg?raw=true",
                            Name = "Camiseta SpaceX",
                            Price = 49.99m
                        },
                        new
                        {
                            Id = 7L,
                            CategoryName = "T-shirt",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/RafaFortunato21/GeekShopping/blob/master/ShoppingImages/7_coffee.jpg?raw=true",
                            Name = "Camiseta Feminina Coffee Benefits",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 8L,
                            CategoryName = "Sweatshirt",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/RafaFortunato21/GeekShopping/blob/master/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true",
                            Name = "Moletom Com Capuz Cobra Kai",
                            Price = 159.9m
                        },
                        new
                        {
                            Id = 9L,
                            CategoryName = "Book",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/RafaFortunato21/GeekShopping/blob/master/ShoppingImages/9_neil.jpg?raw=true",
                            Name = "Livro Star Talk – Neil DeGrasse Tyson",
                            Price = 49.9m
                        },
                        new
                        {
                            Id = 10L,
                            CategoryName = "Action Figure",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/RafaFortunato21/GeekShopping/blob/master/ShoppingImages/10_milennium_falcon.jpg?raw=true",
                            Name = "Star Wars Mission Fleet Han Solo Nave Milennium Falcon",
                            Price = 359.99m
                        },
                        new
                        {
                            Id = 11L,
                            CategoryName = "T-shirt",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/RafaFortunato21/GeekShopping/blob/master/ShoppingImages/11_mars.jpg?raw=true",
                            Name = "Camiseta Elon Musk Spacex Marte Occupy Mars",
                            Price = 59.99m
                        },
                        new
                        {
                            Id = 12L,
                            CategoryName = "T-shirt",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/RafaFortunato21/GeekShopping/blob/master/ShoppingImages/12_gnu_linux.jpg?raw=true",
                            Name = "Camiseta GNU Linux Programador Masculina",
                            Price = 59.99m
                        },
                        new
                        {
                            Id = 13L,
                            CategoryName = "T-shirt",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/RafaFortunato21/GeekShopping/blob/master/ShoppingImages/13_dragon_ball.jpg",
                            Name = "Camiseta Goku Fases",
                            Price = 59.99m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}