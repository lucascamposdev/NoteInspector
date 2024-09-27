using System.Drawing;
using System.Windows.Forms;

namespace NoteInspector
{
    partial class InspectScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Color MainColor = System.Drawing.Color.DarkSlateGray;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectScreen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_databaseName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_atualizarKaffaImportacao = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errosView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_atualizarErros = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_chavesAssociadasNumber = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusView = new System.Windows.Forms.DataGridView();
            this.kaffaImportacaoView = new System.Windows.Forms.DataGridView();
            this.btn_openVwImportacaoTable = new System.Windows.Forms.Button();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input_nota = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errosView)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaffaImportacaoView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(1400, 16);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(124, 32);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.input_nota);
            this.panel1.Controls.Add(this.btn_procurar);
            this.panel1.Controls.Add(this.lbl_databaseName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_voltar);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1546, 63);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_databaseName
            // 
            this.lbl_databaseName.AutoSize = true;
            this.lbl_databaseName.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_databaseName.ForeColor = System.Drawing.Color.White;
            this.lbl_databaseName.Location = new System.Drawing.Point(46, 19);
            this.lbl_databaseName.Name = "lbl_databaseName";
            this.lbl_databaseName.Size = new System.Drawing.Size(90, 28);
            this.lbl_databaseName.TabIndex = 0;
            this.lbl_databaseName.Text = "Coelba";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.btn_atualizarKaffaImportacao);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1506, 40);
            this.panel2.TabIndex = 13;
            // 
            // btn_atualizarKaffaImportacao
            // 
            this.btn_atualizarKaffaImportacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_atualizarKaffaImportacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizarKaffaImportacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_atualizarKaffaImportacao.Location = new System.Drawing.Point(1400, 6);
            this.btn_atualizarKaffaImportacao.Name = "btn_atualizarKaffaImportacao";
            this.btn_atualizarKaffaImportacao.Size = new System.Drawing.Size(99, 27);
            this.btn_atualizarKaffaImportacao.TabIndex = 3;
            this.btn_atualizarKaffaImportacao.Text = "Atualizar";
            this.btn_atualizarKaffaImportacao.UseVisualStyleBackColor = true;
            this.btn_atualizarKaffaImportacao.Click += new System.EventHandler(this.btn_atualizarKaffaImportacao_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(41, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kaffa Importação";
            // 
            // errosView
            // 
            this.errosView.AllowUserToOrderColumns = true;
            this.errosView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.errosView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.errosView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle61.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle61.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.errosView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle61;
            this.errosView.ColumnHeadersHeight = 25;
            this.errosView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.errosView.EnableHeadersVisualStyles = false;
            this.errosView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.errosView.Location = new System.Drawing.Point(12, 548);
            this.errosView.Name = "errosView";
            this.errosView.RowHeadersVisible = false;
            this.errosView.RowHeadersWidth = 51;
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errosView.RowsDefaultCellStyle = dataGridViewCellStyle62;
            this.errosView.RowTemplate.Height = 24;
            this.errosView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.errosView.Size = new System.Drawing.Size(1506, 173);
            this.errosView.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.panel4.Controls.Add(this.btn_atualizarErros);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(12, 508);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1506, 40);
            this.panel4.TabIndex = 14;
            // 
            // btn_atualizarErros
            // 
            this.btn_atualizarErros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_atualizarErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizarErros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_atualizarErros.Location = new System.Drawing.Point(1400, 6);
            this.btn_atualizarErros.Name = "btn_atualizarErros";
            this.btn_atualizarErros.Size = new System.Drawing.Size(99, 27);
            this.btn_atualizarErros.TabIndex = 2;
            this.btn_atualizarErros.Text = "Atualizar";
            this.btn_atualizarErros.UseVisualStyleBackColor = true;
            this.btn_atualizarErros.Click += new System.EventHandler(this.btn_atualizarErros_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(41, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Erros";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(17, 737);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(37, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(56, 741);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chaves Associadas:";
            // 
            // lbl_chavesAssociadasNumber
            // 
            this.lbl_chavesAssociadasNumber.AutoSize = true;
            this.lbl_chavesAssociadasNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chavesAssociadasNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_chavesAssociadasNumber.Location = new System.Drawing.Point(243, 739);
            this.lbl_chavesAssociadasNumber.Name = "lbl_chavesAssociadasNumber";
            this.lbl_chavesAssociadasNumber.Size = new System.Drawing.Size(27, 31);
            this.lbl_chavesAssociadasNumber.TabIndex = 19;
            this.lbl_chavesAssociadasNumber.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 289);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1506, 40);
            this.panel3.TabIndex = 20;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(41, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status";
            // 
            // statusView
            // 
            this.statusView.AllowUserToOrderColumns = true;
            this.statusView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.statusView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle63.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statusView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle63;
            this.statusView.ColumnHeadersHeight = 25;
            this.statusView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.statusView.EnableHeadersVisualStyles = false;
            this.statusView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.statusView.Location = new System.Drawing.Point(12, 329);
            this.statusView.Name = "statusView";
            this.statusView.RowHeadersVisible = false;
            this.statusView.RowHeadersWidth = 51;
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusView.RowsDefaultCellStyle = dataGridViewCellStyle64;
            this.statusView.RowTemplate.Height = 24;
            this.statusView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.statusView.Size = new System.Drawing.Size(1506, 173);
            this.statusView.TabIndex = 21;
            // 
            // kaffaImportacaoView
            // 
            this.kaffaImportacaoView.AllowUserToOrderColumns = true;
            this.kaffaImportacaoView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.kaffaImportacaoView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kaffaImportacaoView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle65.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle65.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kaffaImportacaoView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle65;
            this.kaffaImportacaoView.ColumnHeadersHeight = 25;
            this.kaffaImportacaoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kaffaImportacaoView.EnableHeadersVisualStyles = false;
            this.kaffaImportacaoView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.kaffaImportacaoView.Location = new System.Drawing.Point(12, 110);
            this.kaffaImportacaoView.Name = "kaffaImportacaoView";
            this.kaffaImportacaoView.RowHeadersVisible = false;
            this.kaffaImportacaoView.RowHeadersWidth = 51;
            dataGridViewCellStyle66.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaffaImportacaoView.RowsDefaultCellStyle = dataGridViewCellStyle66;
            this.kaffaImportacaoView.RowTemplate.Height = 24;
            this.kaffaImportacaoView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.kaffaImportacaoView.Size = new System.Drawing.Size(1506, 173);
            this.kaffaImportacaoView.TabIndex = 22;
            // 
            // btn_openVwImportacaoTable
            // 
            this.btn_openVwImportacaoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openVwImportacaoTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openVwImportacaoTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.btn_openVwImportacaoTable.Location = new System.Drawing.Point(285, 740);
            this.btn_openVwImportacaoTable.Name = "btn_openVwImportacaoTable";
            this.btn_openVwImportacaoTable.Size = new System.Drawing.Size(75, 32);
            this.btn_openVwImportacaoTable.TabIndex = 23;
            this.btn_openVwImportacaoTable.Text = "Ver";
            this.btn_openVwImportacaoTable.UseVisualStyleBackColor = true;
            // 
            // btn_procurar
            // 
            this.btn_procurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_procurar.BackColor = System.Drawing.Color.Black;
            this.btn_procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_procurar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procurar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_procurar.Location = new System.Drawing.Point(854, 20);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(103, 29);
            this.btn_procurar.TabIndex = 5;
            this.btn_procurar.Text = "Buscar";
            this.btn_procurar.UseVisualStyleBackColor = false;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(566, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nota:";
            // 
            // input_nota
            // 
            this.input_nota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.input_nota.BackColor = System.Drawing.SystemColors.HighlightText;
            this.input_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_nota.Location = new System.Drawing.Point(632, 21);
            this.input_nota.Name = "input_nota";
            this.input_nota.Size = new System.Drawing.Size(213, 27);
            this.input_nota.TabIndex = 3;
            // 
            // InspectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1533, 791);
            this.Controls.Add(this.btn_openVwImportacaoTable);
            this.Controls.Add(this.kaffaImportacaoView);
            this.Controls.Add(this.statusView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbl_chavesAssociadasNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.errosView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "InspectScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note Inspector";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errosView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaffaImportacaoView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Panel panel1;
        private Panel panel2;
        private Label label5;
        private DataGridView errosView;
        private PictureBox pictureBox2;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox6;
        private Label label4;
        private Label lbl_chavesAssociadasNumber;
        private Button btn_atualizarErros;
        private PictureBox pictureBox1;
        private Label lbl_databaseName;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label2;
        private DataGridView statusView;
        private DataGridView kaffaImportacaoView;
        private Button btn_openVwImportacaoTable;
        private Button btn_atualizarKaffaImportacao;
        private TextBox input_nota;
        private Button btn_procurar;
        private Label label1;
    }
}