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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.input_nota = new System.Windows.Forms.TextBox();
            this.btn_ProcurarNota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btn_reenvioCheckin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            // btn_Voltar
            // 
            this.btn_Voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.ForeColor = System.Drawing.Color.White;
            this.btn_Voltar.Location = new System.Drawing.Point(1400, 16);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(124, 32);
            this.btn_Voltar.TabIndex = 1;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.input_nota);
            this.panel1.Controls.Add(this.btn_ProcurarNota);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Voltar);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1546, 63);
            this.panel1.TabIndex = 2;
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
            // btn_ProcurarNota
            // 
            this.btn_ProcurarNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_ProcurarNota.BackColor = System.Drawing.Color.Black;
            this.btn_ProcurarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProcurarNota.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProcurarNota.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ProcurarNota.Location = new System.Drawing.Point(854, 20);
            this.btn_ProcurarNota.Name = "btn_ProcurarNota";
            this.btn_ProcurarNota.Size = new System.Drawing.Size(103, 29);
            this.btn_ProcurarNota.TabIndex = 5;
            this.btn_ProcurarNota.Text = "Buscar";
            this.btn_ProcurarNota.UseVisualStyleBackColor = false;
            this.btn_ProcurarNota.Click += new System.EventHandler(this.btn_ProcurarNota_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.btn_atualizarKaffaImportacao);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(7, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1520, 40);
            this.panel2.TabIndex = 13;
            // 
            // btn_atualizarKaffaImportacao
            // 
            this.btn_atualizarKaffaImportacao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.btn_atualizarKaffaImportacao.FlatAppearance.BorderSize = 0;
            this.btn_atualizarKaffaImportacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizarKaffaImportacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizarKaffaImportacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_atualizarKaffaImportacao.Location = new System.Drawing.Point(1411, 6);
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
            this.errosView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.errosView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.errosView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.errosView.ColumnHeadersHeight = 25;
            this.errosView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.errosView.EnableHeadersVisualStyles = false;
            this.errosView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.errosView.Location = new System.Drawing.Point(7, 543);
            this.errosView.Name = "errosView";
            this.errosView.RowHeadersVisible = false;
            this.errosView.RowHeadersWidth = 51;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errosView.RowsDefaultCellStyle = dataGridViewCellStyle26;
            this.errosView.RowTemplate.Height = 24;
            this.errosView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.errosView.Size = new System.Drawing.Size(1520, 173);
            this.errosView.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.panel4.Controls.Add(this.btn_atualizarErros);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(7, 503);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1520, 40);
            this.panel4.TabIndex = 14;
            // 
            // btn_atualizarErros
            // 
            this.btn_atualizarErros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.btn_atualizarErros.FlatAppearance.BorderSize = 0;
            this.btn_atualizarErros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizarErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizarErros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_atualizarErros.Location = new System.Drawing.Point(1411, 6);
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
            this.pictureBox6.Location = new System.Drawing.Point(12, 734);
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
            this.label4.Location = new System.Drawing.Point(51, 738);
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
            this.lbl_chavesAssociadasNumber.Location = new System.Drawing.Point(238, 736);
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
            this.panel3.Location = new System.Drawing.Point(7, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1520, 40);
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
            this.statusView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statusView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.statusView.ColumnHeadersHeight = 25;
            this.statusView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.statusView.EnableHeadersVisualStyles = false;
            this.statusView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.statusView.Location = new System.Drawing.Point(7, 324);
            this.statusView.Name = "statusView";
            this.statusView.RowHeadersVisible = false;
            this.statusView.RowHeadersWidth = 51;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusView.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.statusView.RowTemplate.Height = 24;
            this.statusView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.statusView.Size = new System.Drawing.Size(1520, 173);
            this.statusView.TabIndex = 21;
            // 
            // kaffaImportacaoView
            // 
            this.kaffaImportacaoView.AllowUserToOrderColumns = true;
            this.kaffaImportacaoView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.kaffaImportacaoView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kaffaImportacaoView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kaffaImportacaoView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kaffaImportacaoView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.kaffaImportacaoView.ColumnHeadersHeight = 25;
            this.kaffaImportacaoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kaffaImportacaoView.EnableHeadersVisualStyles = false;
            this.kaffaImportacaoView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.kaffaImportacaoView.Location = new System.Drawing.Point(7, 105);
            this.kaffaImportacaoView.Name = "kaffaImportacaoView";
            this.kaffaImportacaoView.RowHeadersVisible = false;
            this.kaffaImportacaoView.RowHeadersWidth = 51;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaffaImportacaoView.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.kaffaImportacaoView.RowTemplate.Height = 24;
            this.kaffaImportacaoView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.kaffaImportacaoView.Size = new System.Drawing.Size(1520, 173);
            this.kaffaImportacaoView.TabIndex = 22;
            // 
            // btn_openVwImportacaoTable
            // 
            this.btn_openVwImportacaoTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openVwImportacaoTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openVwImportacaoTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.btn_openVwImportacaoTable.Location = new System.Drawing.Point(280, 737);
            this.btn_openVwImportacaoTable.Name = "btn_openVwImportacaoTable";
            this.btn_openVwImportacaoTable.Size = new System.Drawing.Size(75, 32);
            this.btn_openVwImportacaoTable.TabIndex = 23;
            this.btn_openVwImportacaoTable.Text = "Ver";
            this.btn_openVwImportacaoTable.UseVisualStyleBackColor = true;
            this.btn_openVwImportacaoTable.Click += new System.EventHandler(this.btn_openVwImportacaoTable_Click);
            // 
            // btn_reenvioCheckin
            // 
            this.btn_reenvioCheckin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_reenvioCheckin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reenvioCheckin.FlatAppearance.BorderSize = 0;
            this.btn_reenvioCheckin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reenvioCheckin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_reenvioCheckin.Location = new System.Drawing.Point(1331, 734);
            this.btn_reenvioCheckin.Name = "btn_reenvioCheckin";
            this.btn_reenvioCheckin.Size = new System.Drawing.Size(186, 38);
            this.btn_reenvioCheckin.TabIndex = 24;
            this.btn_reenvioCheckin.Text = "Reenvio Checkin";
            this.btn_reenvioCheckin.UseVisualStyleBackColor = false;
            // 
            // InspectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1533, 793);
            this.Controls.Add(this.btn_reenvioCheckin);
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
        private System.Windows.Forms.Button btn_Voltar;
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
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label2;
        private DataGridView statusView;
        private DataGridView kaffaImportacaoView;
        private Button btn_openVwImportacaoTable;
        private Button btn_atualizarKaffaImportacao;
        private TextBox input_nota;
        private Button btn_ProcurarNota;
        private Label label1;
        private Button btn_reenvioCheckin;
    }
}