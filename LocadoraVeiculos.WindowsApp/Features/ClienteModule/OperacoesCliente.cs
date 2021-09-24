﻿using LocadoraVeiculos.Aplicacao.ClienteModule;
using LocadoraVeiculos.netCore.Dominio.ClienteModule;
using LocadoraVeiculos.WindowsApp.Shared;
using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace LocadoraVeiculos.WindowsApp.Features.ClienteModule
{
    public class OperacoesCliente : ICadastravel
    {
        private readonly ClienteAppService clienteService;
        private readonly TabelaClienteControl tabelaClientes;
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public OperacoesCliente(ClienteAppService clienteService)
        {
            this.clienteService = clienteService;
            tabelaClientes = new TabelaClienteControl();
        }

        public void InserirNovoRegistro()
        {
            TelaClienteForm tela = new TelaClienteForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    clienteService.InserirNovo(tela.Cliente);

                    List<Cliente> clientes = clienteService.SelecionarTodos();

                    tabelaClientes.AtualizarRegistros(clientes);

                    Dashboard.Instancia.AtualizarRodape($"Cliente: [{tela.Cliente.Nome}] inserido com sucesso!");
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message, ex);

                    Dashboard.Instancia.AtualizarRodape(ex.Message);

                    return;
                }
            }
        }

        public void EditarRegistro()
        {
            int id = tabelaClientes.ObtemIdSelecionado();

            if (id == 0)
            {
                Dashboard.Instancia.AtualizarRodape("Selecione um cliente para poder editar!");
                return;
            }

            Cliente clienteSelecionado = clienteService.SelecionarPorId(id);

            TelaClienteForm tela = new TelaClienteForm();

            tela.Cliente = clienteSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    clienteService.Editar(id, tela.Cliente);

                    List<Cliente> clientes = clienteService.SelecionarTodos();

                    tabelaClientes.AtualizarRegistros(clientes);

                    Dashboard.Instancia.AtualizarRodape($"Cliente: [{tela.Cliente.Nome}] inserido com sucesso");
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message, ex);

                    Dashboard.Instancia.AtualizarRodape(ex.Message);

                    return;
                }
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaClientes.ObtemIdSelecionado();

            if (id == 0)
            {
                Dashboard.Instancia.AtualizarRodape($"Selecione um registro para poder excluir!");
                return;
            }

            Cliente clienteSelecionado = clienteService.SelecionarPorId(id);

            if (clienteSelecionado.TemLocacaoAtiva)
            {
                Dashboard.Instancia.AtualizarRodape($"Cliente: [{clienteSelecionado}] não pôde ser excluído pois está em uma locação ativa!");
                return;
            }

            if (MessageBox.Show($"Tem certeza que deseja excluir o cliente: [{clienteSelecionado.Nome}] ?",
                "Exclusão de Clientes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                clienteService.Excluir(id);

                List<Cliente> clientes = clienteService.SelecionarTodos();

                tabelaClientes.AtualizarRegistros(clientes);
            }
        }

        public void FiltrarRegistros()
        {
            FiltroClienteForm telaFiltro = new FiltroClienteForm();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                List<Cliente> clientes = new List<Cliente>();

                switch (telaFiltro.TipoFiltro)
                {
                    case FiltroClienteEnum.PessoasFisicas:
                        clientes = clienteService.SelecionarTodasPessoasFisicas();
                        break;

                    case FiltroClienteEnum.PessoasJuridicas:
                        clientes = clienteService.SelecionarTodasPessoasJuridicas();
                        break;

                    default:
                        break;
                }

                tabelaClientes.AtualizarRegistros(clientes);
            }
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void DesagruparRegistros()
        {
            var clientes = clienteService.SelecionarTodos();

            tabelaClientes.AtualizarRegistros(clientes);
        }

        public UserControl ObterTabela()
        {
            List<Cliente> clientes = clienteService.SelecionarTodos();

            tabelaClientes.AtualizarRegistros(clientes);

            return tabelaClientes;
        }

        public void Pesquisar(string text)
        {
            List<Cliente> clientesSelecionados = clienteService.Pesquisar(text);

            tabelaClientes.AtualizarRegistros(clientesSelecionados);
        }
    }
}
