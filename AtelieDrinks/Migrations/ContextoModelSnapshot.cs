﻿// <auto-generated />
using System;
using AtelieDrinks.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AtelieDrinks.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AtelieDrinks.Models.Base_alcoolica", b =>
                {
                    b.Property<int>("id_base_alcoolica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_base_alcoolica");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_base_alcoolica"));

                    b.Property<int?>("Ficha_tecnicaid_ficha")
                        .HasColumnType("integer");

                    b.Property<decimal>("custo_garrafa")
                        .HasColumnType("numeric")
                        .HasColumnName("custo_garrafa");

                    b.Property<decimal>("custo_total")
                        .HasColumnType("numeric")
                        .HasColumnName("custo_total");

                    b.Property<int?>("id_bebidaid_marca")
                        .HasColumnType("integer");

                    b.Property<int?>("id_marca1")
                        .HasColumnType("integer");

                    b.Property<string>("nome_bebida")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome_bebida");

                    b.Property<string>("nome_marca")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome_marca");

                    b.Property<int>("quantidade")
                        .HasColumnType("integer")
                        .HasColumnName("quantidade");

                    b.HasKey("id_base_alcoolica");

                    b.HasIndex("Ficha_tecnicaid_ficha");

                    b.HasIndex("id_bebidaid_marca");

                    b.HasIndex("id_marca1");

                    b.ToTable("Base_alcoolica");
                });

            modelBuilder.Entity("AtelieDrinks.Models.CustoOperacional", b =>
                {
                    b.Property<int>("IdCustoOperacional")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("IdCustoOperacional");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdCustoOperacional"));

                    b.Property<decimal>("CustoBalcoes")
                        .HasColumnType("numeric")
                        .HasColumnName("ValorBalcoes");

                    b.Property<decimal>("CustoCoordenador")
                        .HasColumnType("numeric")
                        .HasColumnName("ValorCoordenador");

                    b.Property<decimal>("CustoImpostosFederais")
                        .HasColumnType("numeric")
                        .HasColumnName("ValorImpostosFederais");

                    b.Property<decimal>("CustoProfissionaisGerais")
                        .HasColumnType("numeric")
                        .HasColumnName("ValorProfissionaisGerais");

                    b.Property<decimal>("CustoSeguroReserva")
                        .HasColumnType("numeric")
                        .HasColumnName("ValorSeguroReserva");

                    b.Property<int>("CustoTaxaDeslocamentoId")
                        .HasColumnType("integer")
                        .HasColumnName("Deslocamento.ValorTipoDeslocamento");

                    b.Property<decimal>("CustoTaxaOperacional")
                        .HasColumnType("numeric")
                        .HasColumnName("custo_taxa_operacional");

                    b.Property<decimal>("CustoTransporte")
                        .HasColumnType("numeric")
                        .HasColumnName("ValorTransporte");

                    b.Property<decimal>("Custo_Operacional")
                        .HasColumnType("numeric")
                        .HasColumnName("CustoOperacional");

                    b.Property<int>("DeslocamentoIdTaxaDeslocamento")
                        .HasColumnType("integer");

                    b.Property<int>("QtdBalcoes")
                        .HasColumnType("integer")
                        .HasColumnName("QtdBalcoes");

                    b.Property<int>("QtdCoordenador")
                        .HasColumnType("integer")
                        .HasColumnName("QtdCoordenador");

                    b.Property<int>("QtdImpostosFederais")
                        .HasColumnType("integer")
                        .HasColumnName("QtdImpostosFederais");

                    b.Property<int>("QtdProfissionaisGerais")
                        .HasColumnType("integer")
                        .HasColumnName("QtdProfissionaisGerais");

                    b.Property<int>("QtdSeguroReserva")
                        .HasColumnType("integer")
                        .HasColumnName("QtdSeguroReserva");

                    b.Property<int>("QtdTaxaOperacional")
                        .HasColumnType("integer")
                        .HasColumnName("qtd_taxa_operacional");

                    b.Property<int>("QtdTransporte")
                        .HasColumnType("integer")
                        .HasColumnName("QtdTransporte");

                    b.Property<decimal>("ValorBalcoes")
                        .HasColumnType("numeric")
                        .HasColumnName("valor_balcoes");

                    b.Property<decimal>("ValorCoordenador")
                        .HasColumnType("numeric")
                        .HasColumnName("valor_coordenador");

                    b.Property<decimal>("ValorImpostosFederais")
                        .HasColumnType("numeric")
                        .HasColumnName("valor_impostos_federais");

                    b.Property<decimal>("ValorProfissionaisGerais")
                        .HasColumnType("numeric")
                        .HasColumnName("valor_profissionais_gerais");

                    b.Property<decimal>("ValorSeguroReserva")
                        .HasColumnType("numeric")
                        .HasColumnName("valor_seguro_reserva");

                    b.Property<decimal>("ValorTaxaOperacional")
                        .HasColumnType("numeric")
                        .HasColumnName("valor_taxa_operacional");

                    b.Property<decimal>("ValorTransporte")
                        .HasColumnType("numeric")
                        .HasColumnName("valor_transporte");

                    b.HasKey("IdCustoOperacional");

                    b.HasIndex("DeslocamentoIdTaxaDeslocamento");

                    b.ToTable("CustoOperacional");
                });

            modelBuilder.Entity("AtelieDrinks.Models.Custo_deslocamento", b =>
                {
                    b.Property<int>("IdTaxaDeslocamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_taxa_deslocamento");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdTaxaDeslocamento"));

                    b.Property<decimal>("CustoTipoDeslocamento")
                        .HasColumnType("numeric")
                        .HasColumnName("custo_tipo_deslocamento");

                    b.Property<decimal>("QtdTipoDeslocamento")
                        .HasColumnType("numeric")
                        .HasColumnName("qtd_tipo_deslocamento");

                    b.Property<decimal>("ValorTipoDeslocamento")
                        .HasColumnType("numeric")
                        .HasColumnName("valor_tipo_deslocamento");

                    b.HasKey("IdTaxaDeslocamento");

                    b.ToTable("Custo_deslocamento");
                });

            modelBuilder.Entity("AtelieDrinks.Models.Deposito", b =>
                {
                    b.Property<int>("id_item")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_item");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_item"));

                    b.Property<decimal>("custo_tecnico")
                        .HasColumnType("numeric")
                        .HasColumnName("custo_deposito");

                    b.Property<string>("descricao_observacao")
                        .HasColumnType("text")
                        .HasColumnName("descricao_observacao");

                    b.Property<string>("medida_de_armazenamento")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("medida_de_armazenamento");

                    b.Property<string>("nome_item")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome_item");

                    b.Property<int>("quantidade")
                        .HasColumnType("integer")
                        .HasColumnName("quantidade");

                    b.Property<string>("setor_armazenamento")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("setor_armazenamento");

                    b.HasKey("id_item");

                    b.ToTable("Deposito");
                });

            modelBuilder.Entity("AtelieDrinks.Models.Drinks", b =>
                {
                    b.Property<int>("IdDrink")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_drink");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdDrink"));

                    b.Property<decimal>("CustoDoDrink")
                        .HasColumnType("numeric")
                        .HasColumnName("custo_do_drink");

                    b.Property<string>("IngredientesDoDrink")
                        .HasColumnType("text")
                        .HasColumnName("ingredientes_do_drink");

                    b.Property<string>("NomeDrink")
                        .HasColumnType("text")
                        .HasColumnName("nome_drink");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer")
                        .HasColumnName("quantidade");

                    b.HasKey("IdDrink");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("AtelieDrinks.Models.Ficha_tecnica", b =>
                {
                    b.Property<int>("id_ficha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_ficha");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_ficha"));

                    b.Property<decimal>("custo_base_alcoolica")
                        .HasColumnType("numeric")
                        .HasColumnName("custo_base_alcoolica");

                    b.Property<decimal>("custo_insumo")
                        .HasColumnType("numeric")
                        .HasColumnName("custo_insumo");

                    b.Property<int>("medida")
                        .HasColumnType("integer")
                        .HasColumnName("medida");

                    b.Property<decimal>("ml_unidade")
                        .HasColumnType("numeric")
                        .HasColumnName("ml_unidade");

                    b.Property<string>("nome_base_alcoolica")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome_base_alcoolica");

                    b.Property<string>("nome_drink")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome_drink");

                    b.Property<string>("nome_insumo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome_insumo");

                    b.Property<decimal>("valor_ficha")
                        .HasColumnType("numeric")
                        .HasColumnName("valor_ficha");

                    b.HasKey("id_ficha");

                    b.ToTable("Ficha Tecnica");
                });

            modelBuilder.Entity("AtelieDrinks.Models.Historico", b =>
                {
                    b.Property<int>("IdHistorico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_historico");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdHistorico"));

                    b.Property<string>("BaseOrcamento")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("base_orcamento");

                    b.Property<string>("ComissaoComercial")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("comissao_comercial");

                    b.Property<string>("ComissaoGerencia")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("comissao_gerencia");

                    b.Property<string>("CustoOperacional")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("custo_operacional");

                    b.Property<string>("CustoPorPessoa")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("custo_por_pessoa");

                    b.Property<string>("CustoTotal")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("custo_total");

                    b.Property<string>("CustoTotalInsumos")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("custo_total_insumos");

                    b.Property<string>("DataEvento")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("data_evento");

                    b.Property<string>("MargemNegociacao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("margem_negociacao");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome_cliente");

                    b.Property<int>("NumeroPessoas")
                        .HasColumnType("integer")
                        .HasColumnName("numero_pessoas");

                    b.Property<string>("PrevisaoLucro")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("previsao_lucro");

                    b.Property<string>("TaxaDeLucro")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("taxa_de_lucro");

                    b.Property<string>("ValorArredondadoPraCima")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("valor_arredondado_pra_cima");

                    b.Property<string>("ValorOrcamento")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("valor_orcamento");

                    b.Property<string>("ValorPrimario")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("valor_primario");

                    b.HasKey("IdHistorico");

                    b.ToTable("Historico");
                });

            modelBuilder.Entity("AtelieDrinks.Models.Insumos", b =>
                {
                    b.Property<int>("IdInsumo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_insumo");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdInsumo"));

                    b.Property<int?>("Ficha_tecnicaid_ficha")
                        .HasColumnType("integer");

                    b.Property<string>("NomeInsumo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome_insumo");

                    b.Property<int>("QuantidadeInsumo")
                        .HasColumnType("integer")
                        .HasColumnName("quantidade");

                    b.Property<decimal>("ValorInsumo")
                        .HasColumnType("numeric")
                        .HasColumnName("valor");

                    b.HasKey("IdInsumo");

                    b.HasIndex("Ficha_tecnicaid_ficha");

                    b.ToTable("Insumos");
                });

            modelBuilder.Entity("AtelieDrinks.Models.Marca", b =>
                {
                    b.Property<int>("id_marca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_marca");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_marca"));

                    b.Property<decimal>("custo_garrafa")
                        .HasColumnType("numeric")
                        .HasColumnName("custo_garrafa");

                    b.Property<int>("id_bebida")
                        .HasColumnType("integer")
                        .HasColumnName("id_bebida");

                    b.Property<string>("nome_bebida")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome_bebida");

                    b.Property<string>("nome_marca")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome_marca");

                    b.HasKey("id_marca");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("AtelieDrinks.Models.Numero_convidados", b =>
                {
                    b.Property<int>("id_orcamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_Numero_convidados");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_orcamento"));

                    b.Property<int>("numero_pessoas")
                        .HasColumnType("integer")
                        .HasColumnName("numero_pessoas");

                    b.HasKey("id_orcamento");

                    b.ToTable("Numero_convidados");
                });

            modelBuilder.Entity("AtelieDrinks.Models.Orcamento", b =>
                {
                    b.Property<int>("IdOrcamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_orcamento");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdOrcamento"));

                    b.Property<decimal>("BaseOrcamento")
                        .HasColumnType("numeric")
                        .HasColumnName("base_orcamento");

                    b.Property<decimal>("ComissaoComercial")
                        .HasColumnType("numeric")
                        .HasColumnName("comisao_comercial");

                    b.Property<decimal>("ComissaoGerencia")
                        .HasColumnType("numeric")
                        .HasColumnName("comisao_gerencia");

                    b.Property<int>("CustoOperacional")
                        .HasColumnType("integer")
                        .HasColumnName("custo_operacional");

                    b.Property<decimal>("CustoPorPessoa")
                        .HasColumnType("numeric")
                        .HasColumnName("custo_por_pessoa");

                    b.Property<decimal>("CustoTotal")
                        .HasColumnType("numeric")
                        .HasColumnName("custo_total");

                    b.Property<int>("CustoTotalInsumosIdDrink")
                        .HasColumnType("integer");

                    b.Property<string>("DataEvento")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("data_evento");

                    b.Property<decimal>("MargemNegociacao")
                        .HasColumnType("numeric")
                        .HasColumnName("margem_negociacao");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome_cliente");

                    b.Property<int>("NumeroPessoas")
                        .HasColumnType("integer")
                        .HasColumnName("numero_pessoas");

                    b.Property<decimal>("PrevisaoLucro")
                        .HasColumnType("numeric")
                        .HasColumnName("previsao_lucro");

                    b.Property<int>("QtdeConvidados")
                        .HasColumnType("integer")
                        .HasColumnName("qtde_convidados");

                    b.Property<int>("QtdeDrinks")
                        .HasColumnType("integer")
                        .HasColumnName("qtde_drinks");

                    b.Property<int>("RespostaDrinksIdDrink")
                        .HasColumnType("integer");

                    b.Property<int>("RespostaInsumosIdInsumo")
                        .HasColumnType("integer");

                    b.Property<decimal>("TaxaDeLucro")
                        .HasColumnType("numeric")
                        .HasColumnName("taxa_de_lucro");

                    b.Property<decimal>("ValorArredondadoPraCima")
                        .HasColumnType("numeric")
                        .HasColumnName("valor_arredondado_pra_cima");

                    b.Property<decimal>("ValorOrcamento")
                        .HasColumnType("numeric")
                        .HasColumnName("valor_orcamento");

                    b.Property<decimal>("ValorPrimario")
                        .HasColumnType("numeric")
                        .HasColumnName("valor_primario");

                    b.HasKey("IdOrcamento");

                    b.HasIndex("CustoTotalInsumosIdDrink");

                    b.HasIndex("RespostaDrinksIdDrink");

                    b.HasIndex("RespostaInsumosIdInsumo");

                    b.ToTable("Orcamento");
                });

            modelBuilder.Entity("AtelieDrinks.Models.Base_alcoolica", b =>
                {
                    b.HasOne("AtelieDrinks.Models.Ficha_tecnica", null)
                        .WithMany("id_base_alcoolica")
                        .HasForeignKey("Ficha_tecnicaid_ficha");

                    b.HasOne("AtelieDrinks.Models.Marca", "id_bebida")
                        .WithMany()
                        .HasForeignKey("id_bebidaid_marca");

                    b.HasOne("AtelieDrinks.Models.Marca", "id_marca")
                        .WithMany()
                        .HasForeignKey("id_marca1");

                    b.Navigation("id_bebida");

                    b.Navigation("id_marca");
                });

            modelBuilder.Entity("AtelieDrinks.Models.CustoOperacional", b =>
                {
                    b.HasOne("AtelieDrinks.Models.Custo_deslocamento", "Deslocamento")
                        .WithMany()
                        .HasForeignKey("DeslocamentoIdTaxaDeslocamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deslocamento");
                });

            modelBuilder.Entity("AtelieDrinks.Models.Insumos", b =>
                {
                    b.HasOne("AtelieDrinks.Models.Ficha_tecnica", null)
                        .WithMany("id_insumo")
                        .HasForeignKey("Ficha_tecnicaid_ficha");
                });

            modelBuilder.Entity("AtelieDrinks.Models.Orcamento", b =>
                {
                    b.HasOne("AtelieDrinks.Models.Drinks", "CustoTotalInsumos")
                        .WithMany()
                        .HasForeignKey("CustoTotalInsumosIdDrink")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AtelieDrinks.Models.Drinks", "RespostaDrinks")
                        .WithMany()
                        .HasForeignKey("RespostaDrinksIdDrink")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AtelieDrinks.Models.Insumos", "RespostaInsumos")
                        .WithMany()
                        .HasForeignKey("RespostaInsumosIdInsumo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustoTotalInsumos");

                    b.Navigation("RespostaDrinks");

                    b.Navigation("RespostaInsumos");
                });

            modelBuilder.Entity("AtelieDrinks.Models.Ficha_tecnica", b =>
                {
                    b.Navigation("id_base_alcoolica");

                    b.Navigation("id_insumo");
                });
#pragma warning restore 612, 618
        }
    }
}
