namespace Comercial
{
    partial class FrmConPDV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConPDV));
            this.tbCntrlConPDV = new System.Windows.Forms.TabControl();
            this.tbPgConCli = new System.Windows.Forms.TabPage();
            this.grpBxFiltro = new System.Windows.Forms.GroupBox();
            this.grpSituacao = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblteztoPendente = new System.Windows.Forms.Label();
            this.lblPendente = new System.Windows.Forms.Label();
            this.lblCancelado = new System.Windows.Forms.Label();
            this.lblEfetivado = new System.Windows.Forms.Label();
            this.grpBxTpRel = new System.Windows.Forms.GroupBox();
            this.rdbProd = new System.Windows.Forms.RadioButton();
            this.rdbped = new System.Windows.Forms.RadioButton();
            this.grpBxCli = new System.Windows.Forms.GroupBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.grpBxPedido = new System.Windows.Forms.GroupBox();
            this.txtCodPed = new System.Windows.Forms.TextBox();
            this.cmBxTipoPed = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rdbtnPendente = new System.Windows.Forms.RadioButton();
            this.rdbtnEfetivado = new System.Windows.Forms.RadioButton();
            this.dttmDataPedidoate = new System.Windows.Forms.DateTimePicker();
            this.dttmDataPedido = new System.Windows.Forms.DateTimePicker();
            this.lblDataate = new System.Windows.Forms.Label();
            this.lblDataPed = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblTipoPed = new System.Windows.Forms.Label();
            this.dtGrdConPDV = new System.Windows.Forms.DataGridView();
            this.ColStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.ClmnCodPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDtPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtEmissão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnValPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMPEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMERCIALDataSet = new Comercial.COMERCIALDataSet();
            this.iTEMPEDIDOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter();
            this.tableAdapterManager = new Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager();
            this.pEDIDOTableAdapter = new Comercial.COMERCIALDataSetTableAdapters.PEDIDOTableAdapter();
            this.pEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCodProd = new Comercial.TextButton();
            this.tbCntrlConPDV.SuspendLayout();
            this.tbPgConCli.SuspendLayout();
            this.grpBxFiltro.SuspendLayout();
            this.grpSituacao.SuspendLayout();
            this.grpBxTpRel.SuspendLayout();
            this.grpBxCli.SuspendLayout();
            this.grpBxPedido.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdConPDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMPEDIDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCntrlConPDV
            // 
            this.tbCntrlConPDV.Controls.Add(this.tbPgConCli);
            this.tbCntrlConPDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrlConPDV.Location = new System.Drawing.Point(12, 12);
            this.tbCntrlConPDV.Name = "tbCntrlConPDV";
            this.tbCntrlConPDV.SelectedIndex = 0;
            this.tbCntrlConPDV.Size = new System.Drawing.Size(1145, 464);
            this.tbCntrlConPDV.TabIndex = 1;
            // 
            // tbPgConCli
            // 
            this.tbPgConCli.AutoScroll = true;
            this.tbPgConCli.Controls.Add(this.grpBxFiltro);
            this.tbPgConCli.Controls.Add(this.dtGrdConPDV);
            this.tbPgConCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPgConCli.ForeColor = System.Drawing.Color.CadetBlue;
            this.tbPgConCli.Location = new System.Drawing.Point(4, 22);
            this.tbPgConCli.Name = "tbPgConCli";
            this.tbPgConCli.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgConCli.Size = new System.Drawing.Size(1137, 438);
            this.tbPgConCli.TabIndex = 0;
            this.tbPgConCli.Text = "Consulta Pedido de Venda - Pedido / Cliente";
            this.tbPgConCli.UseVisualStyleBackColor = true;
            this.tbPgConCli.Click += new System.EventHandler(this.tbPgConCli_Click);
            // 
            // grpBxFiltro
            // 
            this.grpBxFiltro.Controls.Add(this.grpSituacao);
            this.grpBxFiltro.Controls.Add(this.grpBxTpRel);
            this.grpBxFiltro.Controls.Add(this.grpBxCli);
            this.grpBxFiltro.Controls.Add(this.grpBxPedido);
            this.grpBxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxFiltro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxFiltro.Location = new System.Drawing.Point(6, 6);
            this.grpBxFiltro.Name = "grpBxFiltro";
            this.grpBxFiltro.Size = new System.Drawing.Size(648, 198);
            this.grpBxFiltro.TabIndex = 1;
            this.grpBxFiltro.TabStop = false;
            this.grpBxFiltro.Text = "Filtros:";
            // 
            // grpSituacao
            // 
            this.grpSituacao.Controls.Add(this.label2);
            this.grpSituacao.Controls.Add(this.label1);
            this.grpSituacao.Controls.Add(this.lblteztoPendente);
            this.grpSituacao.Controls.Add(this.lblPendente);
            this.grpSituacao.Controls.Add(this.lblCancelado);
            this.grpSituacao.Controls.Add(this.lblEfetivado);
            this.grpSituacao.Enabled = false;
            this.grpSituacao.ForeColor = System.Drawing.Color.CadetBlue;
            this.grpSituacao.Location = new System.Drawing.Point(519, 102);
            this.grpSituacao.Name = "grpSituacao";
            this.grpSituacao.Size = new System.Drawing.Size(123, 91);
            this.grpSituacao.TabIndex = 5;
            this.grpSituacao.TabStop = false;
            this.grpSituacao.Text = "Legenda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cancelado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Efetivado";
            // 
            // lblteztoPendente
            // 
            this.lblteztoPendente.AutoSize = true;
            this.lblteztoPendente.Location = new System.Drawing.Point(33, 20);
            this.lblteztoPendente.Name = "lblteztoPendente";
            this.lblteztoPendente.Size = new System.Drawing.Size(61, 13);
            this.lblteztoPendente.TabIndex = 5;
            this.lblteztoPendente.Text = "Pendente";
            // 
            // lblPendente
            // 
            this.lblPendente.AutoSize = true;
            this.lblPendente.Image = global::Comercial.Properties.Resources.BolaAmarela;
            this.lblPendente.Location = new System.Drawing.Point(6, 20);
            this.lblPendente.MaximumSize = new System.Drawing.Size(30, 30);
            this.lblPendente.MinimumSize = new System.Drawing.Size(30, 0);
            this.lblPendente.Name = "lblPendente";
            this.lblPendente.Size = new System.Drawing.Size(30, 13);
            this.lblPendente.TabIndex = 2;
            // 
            // lblCancelado
            // 
            this.lblCancelado.AutoSize = true;
            this.lblCancelado.Image = global::Comercial.Properties.Resources.BolaVermelho;
            this.lblCancelado.Location = new System.Drawing.Point(6, 65);
            this.lblCancelado.MaximumSize = new System.Drawing.Size(30, 30);
            this.lblCancelado.MinimumSize = new System.Drawing.Size(30, 0);
            this.lblCancelado.Name = "lblCancelado";
            this.lblCancelado.Size = new System.Drawing.Size(30, 13);
            this.lblCancelado.TabIndex = 4;
            // 
            // lblEfetivado
            // 
            this.lblEfetivado.AutoSize = true;
            this.lblEfetivado.Image = global::Comercial.Properties.Resources.BolaVerde;
            this.lblEfetivado.Location = new System.Drawing.Point(6, 43);
            this.lblEfetivado.MaximumSize = new System.Drawing.Size(30, 30);
            this.lblEfetivado.MinimumSize = new System.Drawing.Size(30, 0);
            this.lblEfetivado.Name = "lblEfetivado";
            this.lblEfetivado.Size = new System.Drawing.Size(30, 13);
            this.lblEfetivado.TabIndex = 3;
            // 
            // grpBxTpRel
            // 
            this.grpBxTpRel.Controls.Add(this.rdbProd);
            this.grpBxTpRel.Controls.Add(this.rdbped);
            this.grpBxTpRel.ForeColor = System.Drawing.Color.CadetBlue;
            this.grpBxTpRel.Location = new System.Drawing.Point(318, 101);
            this.grpBxTpRel.Name = "grpBxTpRel";
            this.grpBxTpRel.Size = new System.Drawing.Size(195, 53);
            this.grpBxTpRel.TabIndex = 10;
            this.grpBxTpRel.TabStop = false;
            this.grpBxTpRel.Text = "Tipo Relatório";
            // 
            // rdbProd
            // 
            this.rdbProd.AutoSize = true;
            this.rdbProd.ForeColor = System.Drawing.Color.CadetBlue;
            this.rdbProd.Location = new System.Drawing.Point(93, 28);
            this.rdbProd.Name = "rdbProd";
            this.rdbProd.Size = new System.Drawing.Size(65, 17);
            this.rdbProd.TabIndex = 1;
            this.rdbProd.Text = "Poduto";
            this.rdbProd.UseVisualStyleBackColor = true;
            // 
            // rdbped
            // 
            this.rdbped.AutoSize = true;
            this.rdbped.Checked = true;
            this.rdbped.ForeColor = System.Drawing.Color.CadetBlue;
            this.rdbped.Location = new System.Drawing.Point(10, 28);
            this.rdbped.Name = "rdbped";
            this.rdbped.Size = new System.Drawing.Size(64, 17);
            this.rdbped.TabIndex = 0;
            this.rdbped.TabStop = true;
            this.rdbped.Text = "Pedido";
            this.rdbped.UseVisualStyleBackColor = true;
            // 
            // grpBxCli
            // 
            this.grpBxCli.Controls.Add(this.txtCodProd);
            this.grpBxCli.Controls.Add(this.txtDesc);
            this.grpBxCli.Controls.Add(this.lblNome);
            this.grpBxCli.Controls.Add(this.lblCodCli);
            this.grpBxCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxCli.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxCli.Location = new System.Drawing.Point(318, 19);
            this.grpBxCli.Name = "grpBxCli";
            this.grpBxCli.Size = new System.Drawing.Size(324, 76);
            this.grpBxCli.TabIndex = 9;
            this.grpBxCli.TabStop = false;
            this.grpBxCli.Text = "Dados Produto:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(123, 36);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(187, 20);
            this.txtDesc.TabIndex = 23;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNome.Location = new System.Drawing.Point(120, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 13);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "Descrição:";
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCli.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblCodCli.Location = new System.Drawing.Point(12, 19);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(43, 13);
            this.lblCodCli.TabIndex = 20;
            this.lblCodCli.Text = "Código:";
            // 
            // grpBxPedido
            // 
            this.grpBxPedido.Controls.Add(this.txtCodPed);
            this.grpBxPedido.Controls.Add(this.cmBxTipoPed);
            this.grpBxPedido.Controls.Add(this.groupBox2);
            this.grpBxPedido.Controls.Add(this.dttmDataPedidoate);
            this.grpBxPedido.Controls.Add(this.dttmDataPedido);
            this.grpBxPedido.Controls.Add(this.lblDataate);
            this.grpBxPedido.Controls.Add(this.lblDataPed);
            this.grpBxPedido.Controls.Add(this.lblCod);
            this.grpBxPedido.Controls.Add(this.lblTipoPed);
            this.grpBxPedido.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpBxPedido.Location = new System.Drawing.Point(6, 19);
            this.grpBxPedido.Name = "grpBxPedido";
            this.grpBxPedido.Size = new System.Drawing.Size(305, 170);
            this.grpBxPedido.TabIndex = 8;
            this.grpBxPedido.TabStop = false;
            this.grpBxPedido.Text = "Dados Pedido";
            // 
            // txtCodPed
            // 
            this.txtCodPed.Location = new System.Drawing.Point(10, 35);
            this.txtCodPed.Name = "txtCodPed";
            this.txtCodPed.Size = new System.Drawing.Size(92, 20);
            this.txtCodPed.TabIndex = 27;
            // 
            // cmBxTipoPed
            // 
            this.cmBxTipoPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBxTipoPed.FormattingEnabled = true;
            this.cmBxTipoPed.Items.AddRange(new object[] {
            "",
            "N = Normal",
            "C = Complemento de preço"});
            this.cmBxTipoPed.Location = new System.Drawing.Point(108, 35);
            this.cmBxTipoPed.Name = "cmBxTipoPed";
            this.cmBxTipoPed.Size = new System.Drawing.Size(173, 21);
            this.cmBxTipoPed.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.rdbtnPendente);
            this.groupBox2.Controls.Add(this.rdbtnEfetivado);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.Location = new System.Drawing.Point(18, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 42);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Situação do Pedido:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // rdbtnPendente
            // 
            this.rdbtnPendente.AutoSize = true;
            this.rdbtnPendente.Location = new System.Drawing.Point(103, 19);
            this.rdbtnPendente.Name = "rdbtnPendente";
            this.rdbtnPendente.Size = new System.Drawing.Size(71, 17);
            this.rdbtnPendente.TabIndex = 1;
            this.rdbtnPendente.TabStop = true;
            this.rdbtnPendente.Text = "Pendente";
            this.rdbtnPendente.UseVisualStyleBackColor = true;
            this.rdbtnPendente.CheckedChanged += new System.EventHandler(this.rdbtnPendente_CheckedChanged);
            // 
            // rdbtnEfetivado
            // 
            this.rdbtnEfetivado.AutoSize = true;
            this.rdbtnEfetivado.Location = new System.Drawing.Point(27, 20);
            this.rdbtnEfetivado.Name = "rdbtnEfetivado";
            this.rdbtnEfetivado.Size = new System.Drawing.Size(70, 17);
            this.rdbtnEfetivado.TabIndex = 0;
            this.rdbtnEfetivado.TabStop = true;
            this.rdbtnEfetivado.Text = "Efetivado";
            this.rdbtnEfetivado.UseVisualStyleBackColor = true;
            this.rdbtnEfetivado.CheckedChanged += new System.EventHandler(this.rdbtnEfetivado_CheckedChanged);
            // 
            // dttmDataPedidoate
            // 
            this.dttmDataPedidoate.Checked = false;
            this.dttmDataPedidoate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmDataPedidoate.Location = new System.Drawing.Point(133, 128);
            this.dttmDataPedidoate.Name = "dttmDataPedidoate";
            this.dttmDataPedidoate.ShowCheckBox = true;
            this.dttmDataPedidoate.Size = new System.Drawing.Size(115, 20);
            this.dttmDataPedidoate.TabIndex = 25;
            // 
            // dttmDataPedido
            // 
            this.dttmDataPedido.Checked = false;
            this.dttmDataPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmDataPedido.Location = new System.Drawing.Point(12, 128);
            this.dttmDataPedido.Name = "dttmDataPedido";
            this.dttmDataPedido.ShowCheckBox = true;
            this.dttmDataPedido.Size = new System.Drawing.Size(115, 20);
            this.dttmDataPedido.TabIndex = 24;
            // 
            // lblDataate
            // 
            this.lblDataate.AutoSize = true;
            this.lblDataate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataate.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDataate.Location = new System.Drawing.Point(133, 112);
            this.lblDataate.Name = "lblDataate";
            this.lblDataate.Size = new System.Drawing.Size(51, 13);
            this.lblDataate.TabIndex = 22;
            this.lblDataate.Text = "Data até:";
            // 
            // lblDataPed
            // 
            this.lblDataPed.AutoSize = true;
            this.lblDataPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPed.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDataPed.Location = new System.Drawing.Point(9, 112);
            this.lblDataPed.Name = "lblDataPed";
            this.lblDataPed.Size = new System.Drawing.Size(48, 13);
            this.lblDataPed.TabIndex = 20;
            this.lblDataPed.Text = "Data de:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblCod.Location = new System.Drawing.Point(9, 19);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 16;
            this.lblCod.Text = "Código:";
            // 
            // lblTipoPed
            // 
            this.lblTipoPed.AutoSize = true;
            this.lblTipoPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPed.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTipoPed.Location = new System.Drawing.Point(105, 20);
            this.lblTipoPed.Name = "lblTipoPed";
            this.lblTipoPed.Size = new System.Drawing.Size(81, 13);
            this.lblTipoPed.TabIndex = 7;
            this.lblTipoPed.Text = "Tipo do pedido:";
            // 
            // dtGrdConPDV
            // 
            this.dtGrdConPDV.AllowUserToAddRows = false;
            this.dtGrdConPDV.AllowUserToDeleteRows = false;
            this.dtGrdConPDV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdConPDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtGrdConPDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdConPDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStatus,
            this.ClmnCodPed,
            this.ClmnDtPed,
            this.ColSituacao,
            this.Cliente,
            this.DtEmissão,
            this.ColDtEntrega,
            this.ColCodProd,
            this.ColDescricao,
            this.ColQuantidade,
            this.ClmnValPed,
            this.ColValorTotal});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrdConPDV.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtGrdConPDV.Location = new System.Drawing.Point(6, 210);
            this.dtGrdConPDV.Name = "dtGrdConPDV";
            this.dtGrdConPDV.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdConPDV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtGrdConPDV.Size = new System.Drawing.Size(1125, 222);
            this.dtGrdConPDV.TabIndex = 0;
            // 
            // ColStatus
            // 
            this.ColStatus.DataPropertyName = "ImageStatus";
            this.ColStatus.HeaderText = "";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            this.ColStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColStatus.Width = 30;
            // 
            // ClmnCodPed
            // 
            this.ClmnCodPed.DataPropertyName = "NRPEDIDO";
            this.ClmnCodPed.HeaderText = "Num Ped.";
            this.ClmnCodPed.Name = "ClmnCodPed";
            this.ClmnCodPed.ReadOnly = true;
            // 
            // ClmnDtPed
            // 
            this.ClmnDtPed.DataPropertyName = "TIPO";
            this.ClmnDtPed.HeaderText = "Tipo Ped.";
            this.ClmnDtPed.Name = "ClmnDtPed";
            this.ClmnDtPed.ReadOnly = true;
            this.ClmnDtPed.Width = 80;
            // 
            // ColSituacao
            // 
            this.ColSituacao.DataPropertyName = "SITUACAO";
            this.ColSituacao.HeaderText = "Situação";
            this.ColSituacao.Name = "ColSituacao";
            this.ColSituacao.ReadOnly = true;
            this.ColSituacao.Width = 80;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "RAZAOSOCIAL";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // DtEmissão
            // 
            this.DtEmissão.DataPropertyName = "DATAEMISSAO";
            this.DtEmissão.HeaderText = "Data Emissão";
            this.DtEmissão.Name = "DtEmissão";
            this.DtEmissão.ReadOnly = true;
            // 
            // ColDtEntrega
            // 
            this.ColDtEntrega.DataPropertyName = "DATAENTREGA";
            this.ColDtEntrega.HeaderText = "Data Entrega";
            this.ColDtEntrega.Name = "ColDtEntrega";
            this.ColDtEntrega.ReadOnly = true;
            // 
            // ColCodProd
            // 
            this.ColCodProd.DataPropertyName = "CODPRODUTO";
            this.ColCodProd.HeaderText = "Código Produto";
            this.ColCodProd.Name = "ColCodProd";
            this.ColCodProd.ReadOnly = true;
            // 
            // ColDescricao
            // 
            this.ColDescricao.DataPropertyName = "DESCRICAO";
            this.ColDescricao.HeaderText = "Descrição Produto";
            this.ColDescricao.Name = "ColDescricao";
            this.ColDescricao.ReadOnly = true;
            this.ColDescricao.Width = 120;
            // 
            // ColQuantidade
            // 
            this.ColQuantidade.DataPropertyName = "QUANTIDADE";
            this.ColQuantidade.HeaderText = "Quantidade";
            this.ColQuantidade.Name = "ColQuantidade";
            this.ColQuantidade.ReadOnly = true;
            // 
            // ClmnValPed
            // 
            this.ClmnValPed.DataPropertyName = "VALOR";
            this.ClmnValPed.HeaderText = "Preço Unitário";
            this.ClmnValPed.Name = "ClmnValPed";
            this.ClmnValPed.ReadOnly = true;
            // 
            // ColValorTotal
            // 
            this.ColValorTotal.DataPropertyName = "ValorTotal";
            this.ColValorTotal.HeaderText = "Valor Total";
            this.ColValorTotal.Name = "ColValorTotal";
            this.ColValorTotal.ReadOnly = true;
            // 
            // iTEMPEDIDOBindingSource
            // 
            this.iTEMPEDIDOBindingSource.DataMember = "ITEMPEDIDO";
            this.iTEMPEDIDOBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // cOMERCIALDataSet
            // 
            this.cOMERCIALDataSet.DataSetName = "COMERCIALDataSet";
            this.cOMERCIALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTEMPEDIDOTableAdapter
            // 
            this.iTEMPEDIDOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ITEMPEDIDOTableAdapter = this.iTEMPEDIDOTableAdapter;
            this.tableAdapterManager.MODULOTableAdapter = null;
            this.tableAdapterManager.NOTAFISCALTableAdapter = null;
            this.tableAdapterManager.PEDIDOTableAdapter = this.pEDIDOTableAdapter;
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
            // pEDIDOTableAdapter
            // 
            this.pEDIDOTableAdapter.ClearBeforeFill = true;
            // 
            // pEDIDOBindingSource
            // 
            this.pEDIDOBindingSource.DataMember = "PEDIDO";
            this.pEDIDOBindingSource.DataSource = this.cOMERCIALDataSet;
            // 
            // txtCodProd
            // 
            this.txtCodProd.getText = "";
            this.txtCodProd.Image = ((System.Drawing.Image)(resources.GetObject("txtCodProd.Image")));
            this.txtCodProd.Location = new System.Drawing.Point(15, 35);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.ShowButton = false;
            this.txtCodProd.Size = new System.Drawing.Size(98, 25);
            this.txtCodProd.TabIndex = 109;
            this.txtCodProd.ButtonClick += new System.EventHandler(this.txtCodProd_ButtonClick);
            // 
            // FrmConPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 482);
            this.Controls.Add(this.tbCntrlConPDV);
            this.Name = "FrmConPDV";
            this.Text = "Consulta Pedido de Vendas";
            this.Load += new System.EventHandler(this.FrmConPDV_Load);
            this.Leave += new System.EventHandler(this.FrmConPDV_Leave);
            this.tbCntrlConPDV.ResumeLayout(false);
            this.tbPgConCli.ResumeLayout(false);
            this.grpBxFiltro.ResumeLayout(false);
            this.grpSituacao.ResumeLayout(false);
            this.grpSituacao.PerformLayout();
            this.grpBxTpRel.ResumeLayout(false);
            this.grpBxTpRel.PerformLayout();
            this.grpBxCli.ResumeLayout(false);
            this.grpBxCli.PerformLayout();
            this.grpBxPedido.ResumeLayout(false);
            this.grpBxPedido.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdConPDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMPEDIDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMERCIALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrlConPDV;
        private System.Windows.Forms.TabPage tbPgConCli;
        private System.Windows.Forms.GroupBox grpBxFiltro;
        private System.Windows.Forms.GroupBox grpBxPedido;
        private System.Windows.Forms.Label lblDataPed;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblTipoPed;
        private System.Windows.Forms.Label lblDataate;
        private System.Windows.Forms.GroupBox grpBxCli;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.GroupBox grpBxTpRel;
        private System.Windows.Forms.DateTimePicker dttmDataPedido;
        private System.Windows.Forms.DateTimePicker dttmDataPedidoate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rdbtnPendente;
        private System.Windows.Forms.RadioButton rdbtnEfetivado;
        private System.Windows.Forms.ComboBox cmBxTipoPed;
        public TextButton txtCodProd;
        private System.Windows.Forms.TextBox txtCodPed;
        public System.Windows.Forms.DataGridView dtGrdConPDV;
        public System.Windows.Forms.RadioButton rdbProd;
        public System.Windows.Forms.RadioButton rdbped;
        private COMERCIALDataSet cOMERCIALDataSet;
        private System.Windows.Forms.BindingSource iTEMPEDIDOBindingSource;
        private Comercial.COMERCIALDataSetTableAdapters.ITEMPEDIDOTableAdapter iTEMPEDIDOTableAdapter;
        private Comercial.COMERCIALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Comercial.COMERCIALDataSetTableAdapters.PEDIDOTableAdapter pEDIDOTableAdapter;
        private System.Windows.Forms.BindingSource pEDIDOBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCodPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDtPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtEmissão;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnValPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValorTotal;
        private System.Windows.Forms.Label lblPendente;
        private System.Windows.Forms.GroupBox grpSituacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblteztoPendente;
        private System.Windows.Forms.Label lblCancelado;
        private System.Windows.Forms.Label lblEfetivado;
    }
}