﻿using LocadoraVeiculos.WindowsApp.Shared;

namespace LocadoraVeiculos.WindowsApp.Features.ClienteModule
{
    public class ConfiguracaoClienteToolBox : IConfiguracaoToolBox
    {
        public string TipoCadastro => "Cadastro de Clientes";

        public string ToolTipAdicionar => "Adicionar um novo cliente";

        public string ToolTipEditar => "Editar um cliente";

        public string ToolTipExcluir => "Excluir um cliente";

        public string ToolTipFiltrar => "Filtrar clientes";

        public string ToolTipAgrupar => "Indisponivel";

        public string ToolTipDesagrupar => "Desagrupar clientes";

        public bool BarraPesquisa => true;

        public bool BotaoAdicionar => true;

        public bool BotaoDevolucao => false;

        public bool BotaoEditar => true;

        public bool BotaoExcluir => true;

        public bool BotaoFiltrar => true;

        public bool BotaoAgrupar => false;

        public bool BotaoDesagrupar => true;

        public string ToolTipDevolucao => "";
    }
}
