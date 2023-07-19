﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NSE.Carrinho.API.Data;

#nullable disable

namespace NSE.Carrinho.API.Migrations
{
    [DbContext(typeof(CarrinhoContext))]
    [Migration("20230719042148_CarrinhoCascade")]
    partial class CarrinhoCascade
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NSE.Carrinho.API.Model.CarrinhoCliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("char(36)");

                    b.Property<decimal>("Desconto")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("VoucherUtilizado")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .HasDatabaseName("IDX_Cliente");

                    b.ToTable("CarrinhoCliente");
                });

            modelBuilder.Entity("NSE.Carrinho.API.Model.CarrinhoItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CarrinhoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("ProdutoId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("CarrinhoId");

                    b.ToTable("CarrinhoItens");
                });

            modelBuilder.Entity("NSE.Carrinho.API.Model.CarrinhoCliente", b =>
                {
                    b.OwnsOne("NSE.Carrinho.API.Model.Voucher", "Voucher", b1 =>
                        {
                            b1.Property<Guid>("CarrinhoClienteId")
                                .HasColumnType("char(36)");

                            b1.Property<string>("Codigo")
                                .IsRequired()
                                .HasColumnType("varchar(50)")
                                .HasColumnName("VoucherCodigo");

                            b1.Property<decimal?>("Percentual")
                                .HasColumnType("decimal(65,30)")
                                .HasColumnName("Percentual");

                            b1.Property<int>("TipoDesconto")
                                .HasColumnType("int")
                                .HasColumnName("TipoDesconto");

                            b1.Property<decimal?>("ValorDesconto")
                                .HasColumnType("decimal(65,30)")
                                .HasColumnName("ValorDesconto");

                            b1.HasKey("CarrinhoClienteId");

                            b1.ToTable("CarrinhoCliente");

                            b1.WithOwner()
                                .HasForeignKey("CarrinhoClienteId");
                        });

                    b.Navigation("Voucher")
                        .IsRequired();
                });

            modelBuilder.Entity("NSE.Carrinho.API.Model.CarrinhoItem", b =>
                {
                    b.HasOne("NSE.Carrinho.API.Model.CarrinhoCliente", "CarrinhoCliente")
                        .WithMany("Itens")
                        .HasForeignKey("CarrinhoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarrinhoCliente");
                });

            modelBuilder.Entity("NSE.Carrinho.API.Model.CarrinhoCliente", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}
