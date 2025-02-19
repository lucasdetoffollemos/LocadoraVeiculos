﻿using LocadoraVeiculos.Infra.SQL.Shared;
using LocadoraVeiculos.netCore.Dominio.LocacaoModule;
using LocadoraVeiculos.netCore.Dominio.TaxasServicosModule;
using LocadoraVeiculos.netCore.Infra.SQL.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraVeiculos.Infra.SQL.TaxasServicosModule
{
    public class TaxasServicosDAO : BaseDAO<TaxasServicos>, ITaxasServicosRepository
    {
        #region Queries
        private const string sqlInserirTaxasServicos =
            @"INSERT INTO TBTAXASSERVICOS
	                (
		                [SERVICO], 
		                [TAXA], 
		                [OPCAOSERVICO],
                        [LOCALSERVICO]
	                ) 
	                VALUES
	                (
                        @SERVICO, 
                        @TAXA,
                        @OPCAOSERVICO, 
                        @LOCALSERVICO
	                )";

        private const string sqlInserirTaxasServicosUsados =
            @"INSERT INTO TBTAXASSERVICOS_USADOS
	                (
		                [ID_TAXASSERVICOS], 
		                [ID_LOCACAO]
	                ) 
	                VALUES
	                (
                        @ID_TAXASSERVICOS, 
                        @ID_LOCACAO
	                )";

        private const string sqlEditarTaxasServicos =
            @"UPDATE TBTAXASSERVICOS
                    SET
                        [SERVICO] = @SERVICO,
		                [TAXA] = @TAXA, 
		                [OPCAOSERVICO] = @OPCAOSERVICO,
                        [LOCALSERVICO] = @LOCALSERVICO

                    WHERE 
                        ID = @ID";

        private const string sqlEditarTaxasServicosUsados =
            @"UPDATE TBTAXASSERVICOS_USADOS
                    SET
                        [ID_TAXASSERVICOS] = @ID_TAXASSERVICOS,
		                [ID_LOCACAO] = @ID_LOCACAO
                    WHERE 
                        [ID_TAXASSERVICOS]= @ID_TAXASSERVICOS";


        private const string sqlExcluirTaxasServicos =
            @"DELETE 
	                FROM
                        TBTAXASSERVICOS
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirTaxasServicosUsados =
            @"DELETE 
	                FROM
                        TBTAXASSERVICOS_USADOS
                    WHERE 
                        ID_LOCACAO = @ID";

        private const string sqlSelecionarTaxasServicosPorId =
            @"SELECT
                        [ID],
		                [SERVICO], 
		                [TAXA], 
		                [OPCAOSERVICO], 
                        [LOCALSERVICO]
	                FROM
                        TBTAXASSERVICOS
                    WHERE 
                        ID = @ID";


        private const string sqlSelecionarTodasTaxasServicos =
            @"SELECT
                        [ID],
		                [SERVICO], 
		                [TAXA], 
		                [OPCAOSERVICO],
                        [LOCALSERVICO]
	                FROM
                        TBTAXASSERVICOS";

        private const string sqlSelecionarTaxasServicosUsados =
            @"SELECT
                [ID],
                [ID_TAXASSERVICOS],
                [ID_LOCACAO]
            FROM
                [TBTAXASSERVICOS_USADOS]
            WHERE
                [ID_LOCACAO] = @ID";


        private const string sqlExisteTaxasServicos =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBTAXASSERVICOS]
            WHERE 
                [ID] = @ID";
        #endregion

        public void InserirNovo(TaxasServicos registro)
        {
            try
            {
                registro.Id = Db.Insert(sqlInserirTaxasServicos, ObtemParametrosRegistro(registro));
            }
            catch(Exception ex)
            {
                ex.Data.Add("sqlInserirTaxasServicos", sqlInserirTaxasServicos);
                throw ex;
            }
            
        }

        public void InserirNovaTaxaUsada(Locacao registro)
        {
            try
            {
                foreach (TaxasServicos taxa in registro.Taxas)
                    Db.Insert(sqlInserirTaxasServicosUsados, ObtemParametrosTaxasServicosUsados(registro, taxa));
            }
            catch(Exception ex)
            {
                ex.Data.Add("sqlInserirTaxasServicosUsados", sqlInserirTaxasServicosUsados);
                
                throw ex;
            }
        }

        public void Editar(int id, TaxasServicos registro)
        {
            registro.Id = id;
            try
            {
                Db.Update(sqlEditarTaxasServicos, ObtemParametrosRegistro(registro));
            }
            catch(Exception ex)
            {
                ex.Data.Add("sqlEditarTaxasServicos", sqlEditarTaxasServicos);
                ex.Data.Add("idTaxa", id);
                throw ex;
            }
            
        }

        public void EditarTaxasUsadas(Locacao locacao)
        {
            try
            {
                foreach (TaxasServicos taxa in locacao.Taxas)
                    Db.Update(sqlEditarTaxasServicosUsados, ObtemParametrosTaxasServicosUsados(locacao, taxa));
            }
            catch(Exception ex)
            {
                ex.Data.Add("sqlEditarTaxasServicosUsados", sqlEditarTaxasServicosUsados);
                
                throw ex;
            }
        }

        public bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirTaxasServicos, AdicionarParametro("ID", id));
            }
            catch (Exception ex)
            {
                ex.Data.Add("sqlExcluirTaxasServicos", sqlExcluirTaxasServicos);
                ex.Data.Add("idTaxa", id);
                throw ex;
            }

            return true;
        }

        public bool ExcluirTaxaUsada(Locacao locacao)
        {
            try
            {
                Db.Delete(sqlExcluirTaxasServicosUsados, AdicionarParametro("ID", locacao.Id));
            }
            catch (Exception ex)
            {
                ex.Data.Add("sqlExcluirTaxasServicosUsados", sqlExcluirTaxasServicosUsados);
                
                throw ex;
            }

            return true;
        }

        public bool Existe(int id)
        {
            try
            {
                return Db.Exists(sqlExisteTaxasServicos, AdicionarParametro("ID", id));
            }
            catch(Exception ex)
            {
                ex.Data.Add("sqlExisteTaxasServicos", sqlExisteTaxasServicos);
                ex.Data.Add("idTaxa", id);
                throw ex;
            }
        }

        public TaxasServicos SelecionarPorId(int id)
        {
            try
            {
                return Db.Get(sqlSelecionarTaxasServicosPorId, ConverterEmRegistro, AdicionarParametro("ID", id));
            }
            catch(Exception ex)
            {
                ex.Data.Add("sqlSelecionarTaxasServicosPorId", sqlSelecionarTaxasServicosPorId);
                ex.Data.Add("idTaxa", id);
                throw ex;
            }
            
        }

        public List<TaxasServicos> SelecionarTodos()
        {
            try
            {
                return Db.GetAll(sqlSelecionarTodasTaxasServicos, ConverterEmRegistro);
            }
            catch(Exception ex)
            {
                ex.Data.Add("sqlSelecionarTodasTaxasServicos", sqlSelecionarTodasTaxasServicos);
                throw ex;
            }
        }

        public List<TaxasServicos> Pesquisar(string texto)
        {
            throw new NotImplementedException();
        }

        public List<TaxasServicos> SelecionarTaxasServicosUsados(int id)
        {
            try
            {
                return Db.GetAll(sqlSelecionarTaxasServicosUsados, ConverterEmTaxasServicosUsados, AdicionarParametro("ID", id));
            }
            catch(Exception ex)
            {
                ex.Data.Add("sqlSelecionarTaxasServicosUsados", sqlSelecionarTaxasServicosUsados);
                ex.Data.Add("idTaxa", id);
                throw ex;
            }
            
        }

        public override Dictionary<string, object> ObtemParametrosRegistro(TaxasServicos taxasServicos)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", taxasServicos.Id);
            parametros.Add("SERVICO", taxasServicos.Servico);
            parametros.Add("TAXA", taxasServicos.Taxa);
            parametros.Add("OPCAOSERVICO", taxasServicos.OpcaoServico);
            parametros.Add("LOCALSERVICO", taxasServicos.LocalServico);

            return parametros;
        }

        public Dictionary<string, object> ObtemParametrosTaxasServicosUsados(Locacao locacao, TaxasServicos taxa)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID_TAXASSERVICOS", taxa.Id);
            parametros.Add("ID_LOCACAO", locacao.Id);

            return parametros;
        }

        public override TaxasServicos ConverterEmRegistro(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string servico = Convert.ToString(reader["SERVICO"]);
            double taxa = Convert.ToDouble(reader["TAXA"]);
            string opcaoServico = Convert.ToString(reader["OPCAOSERVICO"]);
            string localServico = Convert.ToString(reader["LOCALSERVICO"]);

            TaxasServicos taxasServicos = new TaxasServicos(servico, taxa, opcaoServico, localServico);

            taxasServicos.Id = id;

            return taxasServicos;
        }

        public TaxasServicos ConverterEmTaxasServicosUsados(IDataReader reader)
        {
            if (reader["ID_TAXASSERVICOS"] == DBNull.Value)
                return null;

            return SelecionarPorId(Convert.ToInt32(reader["ID_TAXASSERVICOS"]));
        }
    }
}
