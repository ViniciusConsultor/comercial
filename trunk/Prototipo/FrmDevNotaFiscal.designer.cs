﻿namespace Comercial
{
    partial class FrmDevNotaFiscal
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
            this.components = new System.ComponentModel.Container();
            this.tbPgDevNotaFiscal = new System.Windows.Forms.TabPage();
            this.grpBxItensNotFiscal = new System.Windows.Forms.GroupBox();
            this.dtGrdVwItensNF = new System.Windows.Forms.DataGridView();
            this.grpBxTotais = new System.Windows.Forms.GroupBox();
            this.lblVlrBruto = new System.Windows.Forms.Label();
            this.lblDescontos = new System.Windows.Forms.Label();
            this.lblVlrFrete = new System.Windows.Forms.Label();
            this.lblVlrMercadoria = new System.Windows.Forms.Label();
            this.txtBxDescontos = new System.Windows.Forms.TextBox();
            this.txtBxVlrBruto = new System.Windows.Forms.TextBox();
            this.txtBxVlrFrete = new System.Windows.Forms.TextBox();
            this.txtBxVlrMercadoria = new System.Windows.Forms.TextBox();
            this.grpBxInfNotFiscal = new System.Windows.Forms.GroupBox();
            this.txtTipoNF = new System.Windows.Forms.TextBox();
            this.nOTAFISCALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.lblNumNotFiscal = new System.Windows.Forms.Label();
            this.lblDtEmissao = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.dtTmPckrDtEmissao = new System.Windows.Forms.DateTimePicker();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tbCntrlDevNotFiscal = new System.Windows.Forms.TabControl();
            this.nOTAFISCALTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.NOTAFISCALTableAdapter();
            this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
            this.clmFoiAlterado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVlrUnitário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVlrTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumNF = new Comercial.TextButton();
            this.tbPgDevNotaFiscal.SuspendLayout();
            this.grpBxItensNotFiscal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwItensNF)).BeginInit();
            this.grpBxTotais.SuspendLayout();
            this.grpBxInfNotFiscal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOTAFISCALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            this.tbCntrlDevNotFiscal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPgDevNotaFiscal
            // 
            this.tbPgDevNotaFiscal.Controls.Add(this.grpBxItensNotFiscal);
            this.tbPgDevNotaFiscal.Controls.Add(this.grpBxTotais);
            this.tbPgDevNotaFiscal.Controls.Add(this.grpBxInfNotFiscal);
            this.tbPgDevNotaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPgDevNotaFiscal.ForeColor = System.Drawing.Color.CadetBlue;
            this.tbPgDevNotaFiscal.Location = new System.Drawing.Point(4, 22);
            this.tbPgDevNotaFiscal.Name = "tbPgDevNotaFiscal";
            this.tbPgDevNotaFiscal.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgDevNotaFiscal.Size = new System.Drawing.Size(784, 483);
            this.tbPgDevNotaFiscal.TabIndex = 0;
            this.tbPgDevNotaFiscal.Text = "Devolução Nota Fiscal";
            this.tbPgDevNotaFiscal.UseVisualStyleBackColor = true;
            // 
            // grpBxItensNotFiscal
            // 
            this.grpBxItensNotFiscal.Controls.Add(this.dtGrdVwItensNF);
            this.grpBxItensNotFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxItensNotFiscal.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxItensNotFiscal.Location = new System.Drawing.Point(16, 89);
            this.grpBxItensNotFiscal.Name = "grpBxItensNotFiscal";
            this.grpBxItensNotFiscal.Size = new System.Drawing.Size(741, 246);
            this.grpBxItensNotFiscal.TabIndex = 19;
            this.grpBxItensNotFiscal.TabStop = false;
            this.grpBxItensNotFiscal.Text = "Itens Nota Fiscal";
            // 
            // dtGrdVwItensNF
            // 
            this.dtGrdVwItensNF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwItensNF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFoiAlterado,
            this.clmProduto,
            this.clmDescProd,
            this.clmUnidade,
            this.clmQuantidade,
            this.clmVlrUnitário,
            this.clmVlrTotal});
            this.dtGrdVwItensNF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrdVwItensNF.Location = new System.Drawing.Point(3, 16);
            this.dtGrdVwItensNF.Name = "dtGrdVwItensNF";
            this.dtGrdVwItensNF.Size = new System.Drawing.Size(735, 227);
            this.dtGrdVwItensNF.TabIndex = 0;
            // 
            // grpBxTotais
            // 
            this.grpBxTotais.Controls.Add(this.lblVlrBruto);
            this.grpBxTotais.Controls.Add(this.lblDescontos);
            this.grpBxTotais.Controls.Add(this.lblVlrFrete);
            this.grpBxTotais.Controls.Add(this.lblVlrMercadoria);
            this.grpBxTotais.Controls.Add(this.txtBxDescontos);
            this.grpBxTotais.Controls.Add(this.txtBxVlrBruto);
            this.grpBxTotais.Controls.Add(this.txtBxVlrFrete);
            this.grpBxTotais.Controls.Add(this.txtBxVlrMercadoria);
            this.grpBxTotais.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxTotais.Location = new System.Drawing.Point(19, 341);
            this.grpBxTotais.Name = "grpBxTotais";
            this.grpBxTotais.Size = new System.Drawing.Size(738, 136);
            this.grpBxTotais.TabIndex = 19;
            this.grpBxTotais.TabStop = false;
            this.grpBxTotais.Text = "Totais";
            // 
            // lblVlrBruto
            // 
            this.lblVlrBruto.AutoSize = true;
            this.lblVlrBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrBruto.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblVlrBruto.Location = new System.Drawing.Point(587, 103);
            this.lblVlrBruto.Name = "lblVlrBruto";
            this.lblVlrBruto.Size = new System.Drawing.Size(53, 13);
            this.lblVlrBruto.TabIndex = 25;
            this.lblVlrBruto.Text = "Vlr. Bruto:";
            // 
            // lblDescontos
            // 
            this.lblDescontos.AutoSize = true;
            this.lblDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontos.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDescontos.Location = new System.Drawing.Point(579, 77);
            this.lblDescontos.Name = "lblDescontos";
            this.lblDescontos.Size = new System.Drawing.Size(61, 13);
            this.lblDescontos.TabIndex = 24;
            this.lblDescontos.Text = "Descontos:";
            // 
            // lblVlrFrete
            // 
            this.lblVlrFrete.AutoSize = true;
            this.lblVlrFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrFrete.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblVlrFrete.Location = new System.Drawing.Point(588, 51);
            this.lblVlrFrete.Name = "lblVlrFrete";
            this.lblVlrFrete.Size = new System.Drawing.Size(52, 13);
            this.lblVlrFrete.TabIndex = 23;
            this.lblVlrFrete.Text = "Vlr. Frete:";
            // 
            // lblVlrMercadoria
            // 
            this.lblVlrMercadoria.AutoSize = true;
            this.lblVlrMercadoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrMercadoria.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblVlrMercadoria.Location = new System.Drawing.Point(562, 22);
            this.lblVlrMercadoria.Name = "lblVlrMercadoria";
            this.lblVlrMercadoria.Size = new System.Drawing.Size(81, 13);
            this.lblVlrMercadoria.TabIndex = 22;
            this.lblVlrMercadoria.Text = "Vlr. Mercadoria:";
            // 
            // txtBxDescontos
            // 
            this.txtBxDescontos.Enabled = false;
            this.txtBxDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDescontos.Location = new System.Drawing.Point(649, 74);
            this.txtBxDescontos.Name = "txtBxDescontos";
            this.txtBxDescontos.Size = new System.Drawing.Size(83, 20);
            this.txtBxDescontos.TabIndex = 21;
            // 
            // txtBxVlrBruto
            // 
            this.txtBxVlrBruto.Enabled = false;
            this.txtBxVlrBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxVlrBruto.Location = new System.Drawing.Point(649, 100);
            this.txtBxVlrBruto.Name = "txtBxVlrBruto";
            this.txtBxVlrBruto.Size = new System.Drawing.Size(83, 20);
            this.txtBxVlrBruto.TabIndex = 20;
            // 
            // txtBxVlrFrete
            // 
            this.txtBxVlrFrete.Enabled = false;
            this.txtBxVlrFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxVlrFrete.Location = new System.Drawing.Point(649, 48);
            this.txtBxVlrFrete.Name = "txtBxVlrFrete";
            this.txtBxVlrFrete.Size = new System.Drawing.Size(83, 20);
            this.txtBxVlrFrete.TabIndex = 19;
            // 
            // txtBxVlrMercadoria
            // 
            this.txtBxVlrMercadoria.Enabled = false;
            this.txtBxVlrMercadoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxVlrMercadoria.Location = new System.Drawing.Point(649, 19);
            this.txtBxVlrMercadoria.Name = "txtBxVlrMercadoria";
            this.txtBxVlrMercadoria.Size = new System.Drawing.Size(83, 20);
            this.txtBxVlrMercadoria.TabIndex = 18;
            // 
            // grpBxInfNotFiscal
            // 
            this.grpBxInfNotFiscal.Controls.Add(this.txtNumNF);
            this.grpBxInfNotFiscal.Controls.Add(this.txtTipoNF);
            this.grpBxInfNotFiscal.Controls.Add(this.lblNumNotFiscal);
            this.grpBxInfNotFiscal.Controls.Add(this.lblDtEmissao);
            this.grpBxInfNotFiscal.Controls.Add(this.txtSerie);
            this.grpBxInfNotFiscal.Controls.Add(this.lblSerie);
            this.grpBxInfNotFiscal.Controls.Add(this.dtTmPckrDtEmissao);
            this.grpBxInfNotFiscal.Controls.Add(this.lblTipo);
            this.grpBxInfNotFiscal.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxInfNotFiscal.Location = new System.Drawing.Point(16, 6);
            this.grpBxInfNotFiscal.Name = "grpBxInfNotFiscal";
            this.grpBxInfNotFiscal.Size = new System.Drawing.Size(741, 83);
            this.grpBxInfNotFiscal.TabIndex = 18;
            this.grpBxInfNotFiscal.TabStop = false;
            this.grpBxInfNotFiscal.Text = "Informações Nota Fiscal";
            // 
            // txtTipoNF
            // 
            this.txtTipoNF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nOTAFISCALBindingSource, "Tipo", true));
            this.txtTipoNF.Location = new System.Drawing.Point(555, 33);
            this.txtTipoNF.Name = "txtTipoNF";
            this.txtTipoNF.Size = new System.Drawing.Size(121, 20);
            this.txtTipoNF.TabIndex = 16;
            // 
            // nOTAFISCALBindingSource
            // 
            this.nOTAFISCALBindingSource.DataMember = "NOTAFISCAL";
            this.nOTAFISCALBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // cOMERCIALDataSet
            // 
            this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
            this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNumNotFiscal
            // 
            this.lblNumNotFiscal.AutoSize = true;
            this.lblNumNotFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumNotFiscal.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNumNotFiscal.Location = new System.Drawing.Point(45, 16);
            this.lblNumNotFiscal.Name = "lblNumNotFiscal";
            this.lblNumNotFiscal.Size = new System.Drawing.Size(79, 13);
            this.lblNumNotFiscal.TabIndex = 12;
            this.lblNumNotFiscal.Text = "Número da NF:";
            // 
            // lblDtEmissao
            // 
            this.lblDtEmissao.AutoSize = true;
            this.lblDtEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtEmissao.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDtEmissao.Location = new System.Drawing.Point(402, 16);
            this.lblDtEmissao.Name = "lblDtEmissao";
            this.lblDtEmissao.Size = new System.Drawing.Size(66, 13);
            this.lblDtEmissao.TabIndex = 6;
            this.lblDtEmissao.Text = "Dt. Emissão:";
            // 
            // txtSerie
            // 
            this.txtSerie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nOTAFISCALBindingSource, "Serie", true));
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(309, 33);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(77, 20);
            this.txtSerie.TabIndex = 5;
            this.txtSerie.TextChanged += new System.EventHandler(this.txtSerie_TextChanged);
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblSerie.Location = new System.Drawing.Point(306, 16);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(34, 13);
            this.lblSerie.TabIndex = 4;
            this.lblSerie.Text = "Série:";
            // 
            // dtTmPckrDtEmissao
            // 
            this.dtTmPckrDtEmissao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nOTAFISCALBindingSource, "DataEmissao", true));
            this.dtTmPckrDtEmissao.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nOTAFISCALBindingSource, "DataEmissao", true));
            this.dtTmPckrDtEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTmPckrDtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTmPckrDtEmissao.Location = new System.Drawing.Point(405, 32);
            this.dtTmPckrDtEmissao.Name = "dtTmPckrDtEmissao";
            this.dtTmPckrDtEmissao.Size = new System.Drawing.Size(128, 20);
            this.dtTmPckrDtEmissao.TabIndex = 15;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTipo.Location = new System.Drawing.Point(552, 16);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(48, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo NF:";
            // 
            // tbCntrlDevNotFiscal
            // 
            this.tbCntrlDevNotFiscal.Controls.Add(this.tbPgDevNotaFiscal);
            this.tbCntrlDevNotFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlDevNotFiscal.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlDevNotFiscal.Name = "tbCntrlDevNotFiscal";
            this.tbCntrlDevNotFiscal.SelectedIndex = 0;
            this.tbCntrlDevNotFiscal.Size = new System.Drawing.Size(792, 509);
            this.tbCntrlDevNotFiscal.TabIndex = 18;
            // 
            // nOTAFISCALTableAdapter
            // 
            this.nOTAFISCALTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.CONDICAOPAGAMENTOTableAdapter = null;
            this.tableAdapterManager.GRUPOPRODUTOTableAdapter = null;
            this.tableAdapterManager.ICMSTableAdapter = null;
            this.tableAdapterManager.ItemNotaFiscalTableAdapter = null;
            this.tableAdapterManager.ITEMPEDIDOTableAdapter = null;
            this.tableAdapterManager.MODULOTableAdapter = null;
            this.tableAdapterManager.NOTAFISCALTableAdapter = this.nOTAFISCALTableAdapter;
            this.tableAdapterManager.PEDIDOTableAdapter = null;
            this.tableAdapterManager.PRODUTOTableAdapter = null;
            this.tableAdapterManager.REGIAOTableAdapter = null;
            this.tableAdapterManager.TRANSPORTADORATableAdapter = null;
            this.tableAdapterManager.TRANSPORTADORAVIATableAdapter = null;
            this.tableAdapterManager.UNIDADEMEDIDATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            this.tableAdapterManager.VENDEDORTableAdapter = null;
            this.tableAdapterManager.VIATRANSPORTETableAdapter = null;
            // 
            // clmFoiAlterado
            // 
            this.clmFoiAlterado.HeaderText = "";
            this.clmFoiAlterado.Name = "clmFoiAlterado";
            this.clmFoiAlterado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmFoiAlterado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmFoiAlterado.Width = 50;
            // 
            // clmProduto
            // 
            this.clmProduto.DataPropertyName = "CodProduto";
            this.clmProduto.HeaderText = "Produto";
            this.clmProduto.Name = "clmProduto";
            // 
            // clmDescProd
            // 
            this.clmDescProd.DataPropertyName = "Descricao";
            this.clmDescProd.HeaderText = "Desc. Produto";
            this.clmDescProd.Name = "clmDescProd";
            // 
            // clmUnidade
            // 
            this.clmUnidade.DataPropertyName = "CodUnidadeMedida";
            this.clmUnidade.HeaderText = "Unidade";
            this.clmUnidade.Name = "clmUnidade";
            // 
            // clmQuantidade
            // 
            this.clmQuantidade.DataPropertyName = "Quantidade";
            this.clmQuantidade.HeaderText = "Quantidade";
            this.clmQuantidade.Name = "clmQuantidade";
            // 
            // clmVlrUnitário
            // 
            this.clmVlrUnitário.DataPropertyName = "Valor";
            this.clmVlrUnitário.HeaderText = "Vlr. Unitário";
            this.clmVlrUnitário.Name = "clmVlrUnitário";
            // 
            // clmVlrTotal
            // 
            this.clmVlrTotal.DataPropertyName = "VALORTOTAL";
            this.clmVlrTotal.HeaderText = "Vlr. Total";
            this.clmVlrTotal.Name = "clmVlrTotal";
            // 
            // txtNumNF
            // 
            this.txtNumNF.getText = "";
            this.txtNumNF.Image = global::Comercial.Properties.Resources.search1;
            this.txtNumNF.Location = new System.Drawing.Point(48, 32);
            this.txtNumNF.Name = "txtNumNF";
            this.txtNumNF.ShowButton = false;
            this.txtNumNF.Size = new System.Drawing.Size(255, 25);
            this.txtNumNF.TabIndex = 17;
            this.txtNumNF.ButtonClick += new System.EventHandler(this.txtNumNF_ButtonClick);
            // 
            // FrmDevNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(935, 560);
            this.Controls.Add(this.tbCntrlDevNotFiscal);
            this.Name = "FrmDevNotaFiscal";
            this.ShowIcon = false;
            this.Text = "Devolução Nota Fiscal";
            this.Load += new System.EventHandler(this.FrmDevNotaFiscal_Load);
            this.Leave += new System.EventHandler(this.FrmDevNotaFiscal_Leave);
            this.tbPgDevNotaFiscal.ResumeLayout(false);
            this.grpBxItensNotFiscal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwItensNF)).EndInit();
            this.grpBxTotais.ResumeLayout(false);
            this.grpBxTotais.PerformLayout();
            this.grpBxInfNotFiscal.ResumeLayout(false);
            this.grpBxInfNotFiscal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOTAFISCALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            this.tbCntrlDevNotFiscal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbPgDevNotaFiscal;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblDtEmissao;
        private System.Windows.Forms.Label lblNumNotFiscal;
        private System.Windows.Forms.TabControl tbCntrlDevNotFiscal;
        private System.Windows.Forms.GroupBox grpBxItensNotFiscal;
        private System.Windows.Forms.GroupBox grpBxTotais;
        private System.Windows.Forms.GroupBox grpBxInfNotFiscal;
        private System.Windows.Forms.DataGridView dtGrdVwItensNF;
        private System.Windows.Forms.TextBox txtBxVlrMercadoria;
        private System.Windows.Forms.Label lblVlrBruto;
        private System.Windows.Forms.Label lblDescontos;
        private System.Windows.Forms.Label lblVlrFrete;
        private System.Windows.Forms.Label lblVlrMercadoria;
        private System.Windows.Forms.TextBox txtBxDescontos;
        private System.Windows.Forms.TextBox txtBxVlrBruto;
        private System.Windows.Forms.TextBox txtBxVlrFrete;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource nOTAFISCALBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.NOTAFISCALTableAdapter nOTAFISCALTableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public TextButton txtNumNF;
        public System.Windows.Forms.TextBox txtSerie;
        public System.Windows.Forms.DateTimePicker dtTmPckrDtEmissao;
        public System.Windows.Forms.TextBox txtTipoNF;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmFoiAlterado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVlrUnitário;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVlrTotal;

    }
}