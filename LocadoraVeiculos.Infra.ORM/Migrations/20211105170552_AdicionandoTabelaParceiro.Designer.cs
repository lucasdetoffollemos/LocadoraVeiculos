﻿// <auto-generated />
using System;
using LocadoraVeiculos.Infra.ORM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocadoraVeiculos.Infra.ORM.Migrations
{
    [DbContext(typeof(LocadoraDbContext))]
    [Migration("20211105170552_AdicionandoTabelaParceiro")]
    partial class AdicionandoTabelaParceiro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LocacaoTaxasServicos", b =>
                {
                    b.Property<int>("LocacoesId")
                        .HasColumnType("int");

                    b.Property<int>("TaxasId")
                        .HasColumnType("int");

                    b.HasKey("LocacoesId", "TaxasId");

                    b.HasIndex("TaxasId");

                    b.ToTable("LocacaoTaxasServicos");
                });

            modelBuilder.Entity("LocadoraVeiculos.netCore.Dominio.ClienteModule.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNH")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("NumeroCadastro")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("RG")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TemLocacaoAtiva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("TipoCadastro")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime?>("VencimentoCnh")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("TBCLIENTE");
                });

            modelBuilder.Entity("LocadoraVeiculos.netCore.Dominio.FuncionarioModule.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("DATE");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Salario")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("TBFUNCIONARIO");
                });

            modelBuilder.Entity("LocadoraVeiculos.netCore.Dominio.GrupoAutomoveisModule.GrupoAutomoveis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KmControladoDois")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("KmControladoIncluida")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("KmControladoUm")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("KmLivreUm")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("NomeGrupo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("PlanoDiarioDois")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("PlanoDiarioUm")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("TBGRUPOAUTOMOVEIS");
                });

            modelBuilder.Entity("LocadoraVeiculos.netCore.Dominio.LocacaoModule.Locacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Caucao")
                        .HasColumnType("float");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Condutor")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("datetime2");

                    b.Property<string>("Devolucao")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasDefaultValue("Pendente");

                    b.Property<string>("Plano")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("TBLOCACAO");
                });

            modelBuilder.Entity("LocadoraVeiculos.netCore.Dominio.LocacaoModule.SolicitacaoEmail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CaminhoRecibo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EnvioPendente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("LocacaoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocacaoId");

                    b.ToTable("TBSOLICITACAO_EMAIL");
                });

            modelBuilder.Entity("LocadoraVeiculos.netCore.Dominio.ParceiroModule.Parceiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("TBPARCEIRO");
                });

            modelBuilder.Entity("LocadoraVeiculos.netCore.Dominio.TaxasServicosModule.TaxasServicos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LocalServico")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("OpcaoServico")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Servico")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<double>("Taxa")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("TBTAXASSERVICOS");
                });

            modelBuilder.Entity("LocadoraVeiculos.netCore.Dominio.VeiculoModule.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CapacidadeTanque")
                        .HasColumnType("INT");

                    b.Property<bool>("EstaAlugado")
                        .HasColumnType("BIT");

                    b.Property<byte[]>("Foto")
                        .IsRequired()
                        .HasColumnType("VARBINARY(MAX)");

                    b.Property<int?>("IdGrupoAutomoveis")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<int>("Quilometragem")
                        .HasColumnType("INT");

                    b.Property<string>("TipoCombustivel")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdGrupoAutomoveis");

                    b.ToTable("TBVEICULO");
                });

            modelBuilder.Entity("LocacaoTaxasServicos", b =>
                {
                    b.HasOne("LocadoraVeiculos.netCore.Dominio.LocacaoModule.Locacao", null)
                        .WithMany()
                        .HasForeignKey("LocacoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LocadoraVeiculos.netCore.Dominio.TaxasServicosModule.TaxasServicos", null)
                        .WithMany()
                        .HasForeignKey("TaxasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LocadoraVeiculos.netCore.Dominio.ClienteModule.Cliente", b =>
                {
                    b.HasOne("LocadoraVeiculos.netCore.Dominio.ClienteModule.Cliente", "Empresa")
                        .WithMany("Clientes")
                        .HasForeignKey("EmpresaId");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("LocadoraVeiculos.netCore.Dominio.LocacaoModule.Locacao", b =>
                {
                    b.HasOne("LocadoraVeiculos.netCore.Dominio.ClienteModule.Cliente", "Cliente")
                        .WithMany("Locacoes")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LocadoraVeiculos.netCore.Dominio.VeiculoModule.Veiculo", "Veiculo")
                        .WithMany("Locacoes")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("LocadoraVeiculos.netCore.Dominio.LocacaoModule.SolicitacaoEmail", b =>
                {
                    b.HasOne("LocadoraVeiculos.netCore.Dominio.LocacaoModule.Locacao", "Locacao")
                        .WithMany("SolicitacoesEmail")
                        .HasForeignKey("LocacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Locacao");
                });

            modelBuilder.Entity("LocadoraVeiculos.netCore.Dominio.VeiculoModule.Veiculo", b =>
                {
                    b.HasOne("LocadoraVeiculos.netCore.Dominio.GrupoAutomoveisModule.GrupoAutomoveis", "GrupoAutomoveis")
                        .WithMany("Veiculos")
                        .HasForeignKey("IdGrupoAutomoveis")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("GrupoAutomoveis");
                });

            modelBuilder.Entity("LocadoraVeiculos.netCore.Dominio.ClienteModule.Cliente", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("Locacoes");
                });

            modelBuilder.Entity("LocadoraVeiculos.netCore.Dominio.GrupoAutomoveisModule.GrupoAutomoveis", b =>
                {
                    b.Navigation("Veiculos");
                });

            modelBuilder.Entity("LocadoraVeiculos.netCore.Dominio.LocacaoModule.Locacao", b =>
                {
                    b.Navigation("SolicitacoesEmail");
                });

            modelBuilder.Entity("LocadoraVeiculos.netCore.Dominio.VeiculoModule.Veiculo", b =>
                {
                    b.Navigation("Locacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
