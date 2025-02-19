﻿using LocadoraVeiculos.netCore.Dominio.LocacaoModule;
using LocadoraVeiculos.netCore.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LocadoraVeiculos.netCore.Dominio.ClienteModule
{
    public class Cliente : EntidadeBase, IEquatable<Cliente>
    {
        public string Nome { get; }
        public string Email { get; }
        public string Endereco { get; }
        public string Telefone { get; }
        public string TipoCadastro { get; }
        public string NumeroCadastro { get; }
        public string CNH { get; }
        public DateTime? VencimentoCnh { get; }
        public string RG { get; }
        public int? EmpresaId { get; set; }
        public Cliente Empresa { get; set; }
        public virtual List<Cliente> Clientes { get; set; }
        public bool TemLocacaoAtiva { get; set; }
        public List<Locacao> Locacoes { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string email, string endereco, string telefone, string tipoPessoa,
            string cnh, DateTime? vencimentoCnh, string cadastro, string rg, Cliente empresa) 
        {
            Nome = nome;
            Email = email;
            Endereco = endereco;
            Telefone = telefone;
            TipoCadastro = tipoPessoa;
            CNH = cnh;
            VencimentoCnh = vencimentoCnh;
            NumeroCadastro = cadastro;
            RG = rg;
            Empresa = empresa;
        }

        public override string ToString()
        {
            return Nome;
        }

        public override string Validar()
        {
            Regex templateEmail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Nome))
                resultadoValidacao = "O campo Nome é obrigatório";

            if(templateEmail.IsMatch(Email) == false)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Email está inválido";

            if (string.IsNullOrEmpty(Endereco))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Endereço é obrigatório";

            if (string.IsNullOrEmpty(Telefone) || Telefone == "(  )      -")
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Telefone é obrigatório";

            if (string.IsNullOrEmpty(NumeroCadastro))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Documento é obrigatório";

            if (TipoCadastro == "CPF" && string.IsNullOrEmpty(RG))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo RG é obrigatório para pessoas físicas";

            if (TipoCadastro == "CPF" && string.IsNullOrEmpty(RG))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo RG é obrigatório para pessoas físicas";

            
            if (TipoCadastro == "CPF" && VencimentoCnh == null && VencimentoCnh < DateTime.Now)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "A CNH inserida está vencida!";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Cliente);
        }

        public bool Equals(Cliente other)
        {
            return other is Cliente cliente &&
                   Id == cliente.Id &&
                   Nome == cliente.Nome &&
                   Email == cliente.Email &&
                   Endereco == cliente.Endereco &&
                   Telefone == cliente.Telefone &&
                   TipoCadastro == cliente.TipoCadastro &&
                   NumeroCadastro == cliente.NumeroCadastro &&
                   CNH == cliente.CNH &&
                   VencimentoCnh == cliente.VencimentoCnh &&
                   RG == cliente.RG &&
                   EqualityComparer<Cliente>.Default.Equals(Empresa, cliente.Empresa);
        }

        public override int GetHashCode()
        {
            int hashCode = 2119485743;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Endereco);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Telefone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TipoCadastro);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NumeroCadastro);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CNH);
            hashCode = hashCode * -1521134295 + VencimentoCnh.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RG);
            hashCode = hashCode * -1521134295 + EqualityComparer<Cliente>.Default.GetHashCode(Empresa);
            return hashCode;
        }
    }
}
