namespace NoteInspector
{
    partial class FilaJobScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilaJobScreen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_tableName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filaJobView = new System.Windows.Forms.DataGridView();
            this.logJobView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_BuscarLogJob = new System.Windows.Forms.Button();
            this.select_JobId = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filaJobView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logJobView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            // lbl_tableName
            // 
            this.lbl_tableName.AutoSize = true;
            this.lbl_tableName.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tableName.ForeColor = System.Drawing.Color.White;
            this.lbl_tableName.Location = new System.Drawing.Point(46, 19);
            this.lbl_tableName.Name = "lbl_tableName";
            this.lbl_tableName.Size = new System.Drawing.Size(97, 28);
            this.lbl_tableName.TabIndex = 0;
            this.lbl_tableName.Text = "Fila Job";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_tableName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1537, 63);
            this.panel1.TabIndex = 4;
            // 
            // filaJobView
            // 
            this.filaJobView.AllowUserToOrderColumns = true;
            this.filaJobView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.filaJobView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filaJobView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.filaJobView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.filaJobView.ColumnHeadersHeight = 25;
            this.filaJobView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.filaJobView.DefaultCellStyle = dataGridViewCellStyle2;
            this.filaJobView.EnableHeadersVisualStyles = false;
            this.filaJobView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.filaJobView.Location = new System.Drawing.Point(0, 60);
            this.filaJobView.Name = "filaJobView";
            this.filaJobView.RowHeadersVisible = false;
            this.filaJobView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filaJobView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.filaJobView.RowTemplate.Height = 24;
            this.filaJobView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.filaJobView.Size = new System.Drawing.Size(1537, 173);
            this.filaJobView.TabIndex = 23;
            // 
            // logJobView
            // 
            this.logJobView.AllowUserToOrderColumns = true;
            this.logJobView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.logJobView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logJobView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logJobView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.logJobView.ColumnHeadersHeight = 25;
            this.logJobView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logJobView.DefaultCellStyle = dataGridViewCellStyle5;
            this.logJobView.EnableHeadersVisualStyles = false;
            this.logJobView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.logJobView.Location = new System.Drawing.Point(0, 299);
            this.logJobView.Name = "logJobView";
            this.logJobView.RowHeadersVisible = false;
            this.logJobView.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logJobView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.logJobView.RowTemplate.Height = 24;
            this.logJobView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.logJobView.Size = new System.Drawing.Size(1537, 173);
            this.logJobView.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btn_BuscarLogJob);
            this.panel2.Controls.Add(this.select_JobId);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1537, 63);
            this.panel2.TabIndex = 24;
            // 
            // btn_BuscarLogJob
            // 
            this.btn_BuscarLogJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_BuscarLogJob.BackColor = System.Drawing.Color.Black;
            this.btn_BuscarLogJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarLogJob.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarLogJob.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BuscarLogJob.Location = new System.Drawing.Point(295, 17);
            this.btn_BuscarLogJob.Name = "btn_BuscarLogJob";
            this.btn_BuscarLogJob.Size = new System.Drawing.Size(103, 31);
            this.btn_BuscarLogJob.TabIndex = 27;
            this.btn_BuscarLogJob.Text = "Buscar";
            this.btn_BuscarLogJob.UseVisualStyleBackColor = false;
            this.btn_BuscarLogJob.Click += new System.EventHandler(this.btn_BuscarLogJob_Click);
            // 
            // select_JobId
            // 
            this.select_JobId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_JobId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_JobId.FormattingEnabled = true;
            this.select_JobId.Location = new System.Drawing.Point(167, 16);
            this.select_JobId.Name = "select_JobId";
            this.select_JobId.Size = new System.Drawing.Size(121, 31);
            this.select_JobId.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log Job";
            // 
            // FilaJobScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 473);
            this.Controls.Add(this.logJobView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.filaJobView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FilaJobScreen";
            this.Text = "Fila Job";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filaJobView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logJobView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_tableName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView filaJobView;
        private System.Windows.Forms.DataGridView logJobView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox select_JobId;
        private System.Windows.Forms.Button btn_BuscarLogJob;
    }
}