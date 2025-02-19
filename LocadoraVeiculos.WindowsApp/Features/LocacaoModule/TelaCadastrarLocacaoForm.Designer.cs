﻿
namespace LocadoraVeiculos.WindowsApp.Features.LocacaoModule
{
    partial class TelaCadastrarLocacaoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarLocacaoForm));
            this.lblId = new System.Windows.Forms.Label();
            this.txtValorEntrada = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbVeiculo = new System.Windows.Forms.ComboBox();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.cmbPlano = new System.Windows.Forms.ComboBox();
            this.lblPlano = new System.Windows.Forms.Label();
            this.lblValorEntrada = new System.Windows.Forms.Label();
            this.dateDataSaida = new System.Windows.Forms.DateTimePicker();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.dateDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.btnGravar = new System.Windows.Forms.Button();
            this.cmbCondutor = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblCondutor = new System.Windows.Forms.Label();
            this.btnSelecionarTaxas = new System.Windows.Forms.Button();
            this.listaTaxasServicos = new System.Windows.Forms.ListBox();
            this.btnCalcularTotal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(295, 89);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 18);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorEntrada.Location = new System.Drawing.Point(329, 271);
            this.txtValorEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Size = new System.Drawing.Size(116, 26);
            this.txtValorEntrada.TabIndex = 5;
            this.txtValorEntrada.TextChanged += new System.EventHandler(this.txtCaucao_TextChanged);
            this.txtValorEntrada.Enter += new System.EventHandler(this.txtValorEntrada_Enter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(493, 591);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 36);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(329, 85);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(112, 26);
            this.txtId.TabIndex = 4;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(329, 124);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(194, 26);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.Location = new System.Drawing.Point(252, 127);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 18);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente:";
            // 
            // cmbVeiculo
            // 
            this.cmbVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeiculo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbVeiculo.FormattingEnabled = true;
            this.cmbVeiculo.Location = new System.Drawing.Point(329, 197);
            this.cmbVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVeiculo.Name = "cmbVeiculo";
            this.cmbVeiculo.Size = new System.Drawing.Size(194, 26);
            this.cmbVeiculo.TabIndex = 3;
            this.cmbVeiculo.SelectedIndexChanged += new System.EventHandler(this.cmbVeiculo_SelectedIndexChanged);
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVeiculo.Location = new System.Drawing.Point(251, 201);
            this.lblVeiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(62, 18);
            this.lblVeiculo.TabIndex = 7;
            this.lblVeiculo.Text = "Veículo:";
            // 
            // cmbPlano
            // 
            this.cmbPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlano.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPlano.FormattingEnabled = true;
            this.cmbPlano.ItemHeight = 18;
            this.cmbPlano.Items.AddRange(new object[] {
            "Plano Diário",
            "Km Controlado",
            "Km Livre"});
            this.cmbPlano.Location = new System.Drawing.Point(329, 234);
            this.cmbPlano.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlano.Name = "cmbPlano";
            this.cmbPlano.Size = new System.Drawing.Size(194, 26);
            this.cmbPlano.TabIndex = 4;
            this.cmbPlano.SelectedIndexChanged += new System.EventHandler(this.cmbPlano_SelectedIndexChanged);
            // 
            // lblPlano
            // 
            this.lblPlano.AutoSize = true;
            this.lblPlano.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlano.Location = new System.Drawing.Point(262, 238);
            this.lblPlano.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(52, 18);
            this.lblPlano.TabIndex = 9;
            this.lblPlano.Text = "Plano:";
            // 
            // lblValorEntrada
            // 
            this.lblValorEntrada.AutoSize = true;
            this.lblValorEntrada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorEntrada.Location = new System.Drawing.Point(172, 275);
            this.lblValorEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorEntrada.Name = "lblValorEntrada";
            this.lblValorEntrada.Size = new System.Drawing.Size(129, 18);
            this.lblValorEntrada.TabIndex = 11;
            this.lblValorEntrada.Text = "Valor de Entrada:";
            // 
            // dateDataSaida
            // 
            this.dateDataSaida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataSaida.Location = new System.Drawing.Point(329, 308);
            this.dateDataSaida.Margin = new System.Windows.Forms.Padding(4);
            this.dateDataSaida.MinDate = new System.DateTime(2021, 8, 24, 0, 0, 0, 0);
            this.dateDataSaida.Name = "dateDataSaida";
            this.dateDataSaida.Size = new System.Drawing.Size(140, 26);
            this.dateDataSaida.TabIndex = 6;
            this.dateDataSaida.ValueChanged += new System.EventHandler(this.dateDataSaida_ValueChanged);
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataSaida.Location = new System.Drawing.Point(192, 314);
            this.lblDataSaida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(113, 18);
            this.lblDataSaida.TabIndex = 13;
            this.lblDataSaida.Text = "Data de Saída:";
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataDevolucao.Location = new System.Drawing.Point(153, 350);
            this.lblDataDevolucao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(146, 18);
            this.lblDataDevolucao.TabIndex = 15;
            this.lblDataDevolucao.Text = "Data de Devolução:";
            // 
            // dateDataDevolucao
            // 
            this.dateDataDevolucao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateDataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataDevolucao.Location = new System.Drawing.Point(329, 345);
            this.dateDataDevolucao.Margin = new System.Windows.Forms.Padding(4);
            this.dateDataDevolucao.Name = "dateDataDevolucao";
            this.dateDataDevolucao.Size = new System.Drawing.Size(140, 26);
            this.dateDataDevolucao.TabIndex = 7;
            this.dateDataDevolucao.ValueChanged += new System.EventHandler(this.dateDataDevolucao_ValueChanged);
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Enabled = false;
            this.btnGravar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGravar.Location = new System.Drawing.Point(388, 591);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(97, 36);
            this.btnGravar.TabIndex = 11;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // cmbCondutor
            // 
            this.cmbCondutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondutor.Enabled = false;
            this.cmbCondutor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCondutor.FormattingEnabled = true;
            this.cmbCondutor.Location = new System.Drawing.Point(329, 160);
            this.cmbCondutor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCondutor.Name = "cmbCondutor";
            this.cmbCondutor.Size = new System.Drawing.Size(194, 26);
            this.cmbCondutor.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(161, 566);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(237, 19);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Previsão do Total + entrada: R$";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotal.Location = new System.Drawing.Point(447, 566);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(18, 19);
            this.lblValorTotal.TabIndex = 20;
            this.lblValorTotal.Text = "0";
            // 
            // lblCondutor
            // 
            this.lblCondutor.AutoSize = true;
            this.lblCondutor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCondutor.Location = new System.Drawing.Point(234, 164);
            this.lblCondutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCondutor.Name = "lblCondutor";
            this.lblCondutor.Size = new System.Drawing.Size(76, 18);
            this.lblCondutor.TabIndex = 21;
            this.lblCondutor.Text = "Condutor:";
            // 
            // btnSelecionarTaxas
            // 
            this.btnSelecionarTaxas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelecionarTaxas.Location = new System.Drawing.Point(192, 504);
            this.btnSelecionarTaxas.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarTaxas.Name = "btnSelecionarTaxas";
            this.btnSelecionarTaxas.Size = new System.Drawing.Size(162, 36);
            this.btnSelecionarTaxas.TabIndex = 9;
            this.btnSelecionarTaxas.Text = "Selecionar Taxas";
            this.btnSelecionarTaxas.UseVisualStyleBackColor = true;
            this.btnSelecionarTaxas.Click += new System.EventHandler(this.btnSelecionarTaxas_Click);
            // 
            // listaTaxasServicos
            // 
            this.listaTaxasServicos.Enabled = false;
            this.listaTaxasServicos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listaTaxasServicos.FormattingEnabled = true;
            this.listaTaxasServicos.ItemHeight = 16;
            this.listaTaxasServicos.Location = new System.Drawing.Point(195, 396);
            this.listaTaxasServicos.Margin = new System.Windows.Forms.Padding(4);
            this.listaTaxasServicos.Name = "listaTaxasServicos";
            this.listaTaxasServicos.Size = new System.Drawing.Size(329, 100);
            this.listaTaxasServicos.TabIndex = 8;
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularTotal.Location = new System.Drawing.Point(157, 591);
            this.btnCalcularTotal.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(162, 36);
            this.btnCalcularTotal.TabIndex = 10;
            this.btnCalcularTotal.Text = "Calcular Total";
            this.btnCalcularTotal.UseVisualStyleBackColor = true;
            this.btnCalcularTotal.Click += new System.EventHandler(this.btnCalcularTotal_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 69);
            this.panel2.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LocadoraVeiculos.WindowsApp.Properties.Resources.sedan;
            this.pictureBox1.Location = new System.Drawing.Point(15, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(91)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(102, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOCADORA RECH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(416, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "O carro certo para você!";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 566);
            this.panel3.TabIndex = 25;
            // 
            // TelaCadastrarLocacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(603, 635);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCalcularTotal);
            this.Controls.Add(this.listaTaxasServicos);
            this.Controls.Add(this.btnSelecionarTaxas);
            this.Controls.Add(this.lblCondutor);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cmbCondutor);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblDataDevolucao);
            this.Controls.Add(this.dateDataDevolucao);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.dateDataSaida);
            this.Controls.Add(this.lblValorEntrada);
            this.Controls.Add(this.cmbPlano);
            this.Controls.Add(this.lblPlano);
            this.Controls.Add(this.cmbVeiculo);
            this.Controls.Add(this.lblVeiculo);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtValorEntrada);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastrarLocacaoForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Locações";
            this.Load += new System.EventHandler(this.TelaCadastrarLocacaoForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbVeiculo;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.ComboBox cmbPlano;
        private System.Windows.Forms.Label lblPlano;
        private System.Windows.Forms.Label lblValorEntrada;
        private System.Windows.Forms.DateTimePicker dateDataSaida;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblDataDevolucao;
        private System.Windows.Forms.DateTimePicker dateDataDevolucao;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.ComboBox cmbCondutor;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValorEntrada;
        private System.Windows.Forms.Label lblCondutor;
        private System.Windows.Forms.Button btnSelecionarTaxas;
        private System.Windows.Forms.ListBox listaTaxasServicos;
        private System.Windows.Forms.Button btnCalcularTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
    }
}