﻿using LocadoraVeiculos.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos.WindowsApp.Features.LocacaoModule
{
    public class ConfiguracoesLocacaoToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar => "Adicionar uma nova locação";

        public string TipoCadastro => "Cadastro de Locações";

        public string ToolTipEditar => "Editar uma locação";

        public string ToolTipExcluir => "Excluir uma locação";

        public string ToolTipFiltrar => "Fitrar locações";

        public string ToolTipAgrupar => "Indisponível";

        public string ToolTipDesagrupar => "Desagrupar locações";

        public bool BarraPesquisa => false;

        public bool BotaoAdicionar => true;

        public bool BotaoDevolucao => true;

        public bool BotaoEditar => true;

        public bool BotaoExcluir => true;

        public bool BotaoFiltrar => true;

        public bool BotaoAgrupar => false;

        public bool BotaoDesagrupar => true;

        public string ToolTipDevolucao => "Registrar Devolução";
    }
}
