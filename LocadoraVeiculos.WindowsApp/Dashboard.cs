﻿using System;
using System.Windows.Forms;
using LocadoraVeiculos.WindowsApp.Features.ClienteModule;
using LocadoraVeiculos.WindowsApp.Features.FuncionarioModule;
using LocadoraVeiculos.WindowsApp.Features.GrupoAutomoveisModule;
using LocadoraVeiculos.WindowsApp.Shared;
using LocadoraVeiculos.WindowsApp.Feature.VeiculoModule;
using LocadoraVeiculos.WindowsApp.Features.VeiculoModule;
using LocadoraVeiculos.WindowsApp.Features.CombustivelModule;
using LocadoraVeiculos.WindowsApp.Features.TaxasServicosModule;
using LocadoraVeiculos.WindowsApp.Features.LocacaoModule;
using LocadoraVeiculos.Infra.JSON.CombustivelModule;
using Serilog;
using Autofac;
using LocadoraVeiculos.WindowsApp.Features.ParceiroModule;

namespace LocadoraVeiculos.WindowsApp
{
    public partial class Dashboard : Form
    {
        #region Mensagens de Log

        private string msgLoginCompleto { get => $"Usuário [{ Usuario }]: Login completo... Executando o Dashboard."; }

        #endregion

        private ICadastravel operacoes;
        public static Dashboard Instancia { get; set; }
        public string Usuario { get; set; }

        public Dashboard(string usuario)
        {
            InitializeComponent();
           

            Instancia = this;
            Usuario = usuario;
            Log.Debug(msgLoginCompleto);
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        public void DesabilitarBotoesIndisponiveisParaDevolucao()
        {
            toolStripBtnDevolucao.Enabled = false;
            toolStripBtnEditar.Enabled = false;
            toolStripBtnExcluir.Enabled = true;
        }

        public void HabilitarBotoesIndisponiveisParaDevolucao()
        {
            toolStripBtnDevolucao.Enabled = true;
            toolStripBtnEditar.Enabled = true;
            toolStripBtnExcluir.Enabled = false;
        }

        #region Eventos de Click dos Botões do Menu Principal

        private  void btnLocacoes_Click(object sender, EventArgs e)
        {
            ConfiguracoesLocacaoToolBox config = new ConfiguracoesLocacaoToolBox();

            ConfigurarToolBox(config);

            AtualizarRodape(config.TipoCadastro);

            operacoes = ServiceLocator.Container.Resolve<OperacoesLocacao>();

            ConfigurarPainelRegistros();

            OperacoesLocacao operacoesLocacao = operacoes as OperacoesLocacao;

            //await operacoesLocacao.EnviarEmailsAgendados();
        }

        private void btnCadastroClientes_Click(object sender, System.EventArgs e)
        {
            ConfiguracaoClienteToolBox config = new ConfiguracaoClienteToolBox();

            ConfigurarToolBox(config);

            AtualizarRodape(config.TipoCadastro);

            operacoes = ServiceLocator.Container.Resolve<OperacoesCliente>();

            ConfigurarPainelRegistros();
        }

        private void btnCadastroFuncionario_Click(object sender, System.EventArgs e)
        {
            ConfiguracaoFuncionarioToolBox configuracao = new ConfiguracaoFuncionarioToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = ServiceLocator.Container.Resolve<OperacoesFuncionario>();

            ConfigurarPainelRegistros();
        }

        private void btnCadastroVeiculoModules_Click(object sender, System.EventArgs e)
        {
            ConfiguracaoVeiculoToolBox configuracao = new ConfiguracaoVeiculoToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = ServiceLocator.Container.Resolve<OperacoesVeiculos>();

            ConfigurarPainelRegistros();
        }

        private void btnCadastroGrupoAutomoveis_Click(object sender, EventArgs e)
        {
            ConfiguracaoGrupoAutomoveisToolBox configuracao = new ConfiguracaoGrupoAutomoveisToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = ServiceLocator.Container.Resolve<OperacoesGrupoAutomoveis>();

            ConfigurarPainelRegistros();
        }

        private void btnTaxasServicos_Click(object sender, EventArgs e)
        {
            ConfiguracaoTaxasServicosToolBox config = new ConfiguracaoTaxasServicosToolBox();

            ConfigurarToolBox(config);

            AtualizarRodape(config.TipoCadastro);

            operacoes = ServiceLocator.Container.Resolve<OperacoesTaxasServicos>();

            ConfigurarPainelRegistros();
        }

        private void btnConfiguracoes_Click(object sender, System.EventArgs e)
        {
            ConfiguracaoCombustivelToolBox configuracao = new ConfiguracaoCombustivelToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            ConfigurarPainelConfiguracoes();
        }

        private void btnParceiros_Click(object sender, EventArgs e)
        {
            ConfiguracaoParceiroToolBox configuracao = new ConfiguracaoParceiroToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = ServiceLocator.Container.Resolve<OperacoesParceiro>();

            ConfigurarPainelRegistros();
        }

        #endregion

        #region Eventos de Click dos Botões de CRUD

        private void toolStripBtnAdicionar_Click(object sender, System.EventArgs e)
        {
            operacoes.InserirNovoRegistro();
        }

        private void toolStripBtnEditar_Click(object sender, System.EventArgs e)
        {
            operacoes.EditarRegistro();
        }

        private void toolStripBtnExcluir_Click(object sender, EventArgs e)
        {
            operacoes.ExcluirRegistro();
        }

        private void toolStripBtnFiltrar_Click(object sender, System.EventArgs e)
        {
            txtPesquisa.Text = "Digite para Pesquisar";
            operacoes.FiltrarRegistros();
        }
        private void toolStripBtnAgrupar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = "Digite para Pesquisar";
            operacoes.AgruparRegistros();
        }

        private void toolStripBtnDesagrupar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = "Digite para Pesquisar";
            operacoes.DesagruparRegistros();
        }

        private void toolStripBtnDevolucao_Click(object sender, EventArgs e)
        {
            if (operacoes is OperacoesLocacao)
                ((OperacoesLocacao)operacoes).RegistrarDevolucao();
        }
        #endregion

        #region Métodos Privados da Classe

        private void ConfigurarPainelRegistros()
        {
            UserControl tabela = operacoes.ObterTabela();

            tabela.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(tabela);

            operacoes.DesagruparRegistros();
        }

        private void ConfigurarPainelConfiguracoes()
        {
            UserControl tela = new CombustivelControl(new CombustivelConfiguration());

            tela.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(tela);
        }

        private void ConfigurarToolBox(IConfiguracaoToolBox configuracao)
        {
            toolBoxAcoes.Enabled = true;

            toolStripBtnAdicionar.ToolTipText = configuracao.ToolTipAdicionar;
            toolStripBtnEditar.ToolTipText = configuracao.ToolTipEditar;
            toolStripBtnExcluir.ToolTipText = configuracao.ToolTipExcluir;
            toolStripBtnDevolucao.ToolTipText = configuracao.ToolTipDevolucao;

            toolStripBtnAgrupar.ToolTipText = configuracao.ToolTipAgrupar;
            toolStripBtnDesagrupar.ToolTipText = configuracao.ToolTipDesagrupar;
            toolStripBtnFiltrar.ToolTipText = configuracao.ToolTipFiltrar;

            txtPesquisa.Enabled = configuracao.BarraPesquisa;
            toolStripBtnAdicionar.Enabled = configuracao.BotaoAdicionar;
            toolStripBtnEditar.Enabled = configuracao.BotaoEditar;
            toolStripBtnExcluir.Enabled = configuracao.BotaoExcluir;

            toolStripBtnAgrupar.Enabled = configuracao.BotaoAgrupar;
            toolStripBtnDesagrupar.Enabled = configuracao.BotaoDesagrupar;
            toolStripBtnFiltrar.Enabled = configuracao.BotaoFiltrar;

            toolStripBtnDevolucao.Visible = configuracao.BotaoDevolucao;
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log.Debug($"Usuário [{ Usuario }]: Encerrando a execução...");
            Application.Exit();
        }
        #endregion

        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "Digite para Pesquisar")
                txtPesquisa.Text = "";
        }

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
                txtPesquisa.Text = "Digite para Pesquisar";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "Digite para Pesquisar")
                operacoes.Pesquisar(txtPesquisa.Text);
        }

        
    }
}
