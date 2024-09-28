using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteInspector
{
    public partial class TableViewScreen : Form
    {
        private DataTable _data;
        public TableViewScreen(string tableName, DataTable data)
        {
            InitializeComponent();
            _data = data;
            tableView.DataSource = data;
            lbl_tableName.Text = tableName;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close(); 
                return true; 
            }

            return base.ProcessCmdKey(ref msg, keyData); 
        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            string searchValue = input_buscar.Text;

            if (string.IsNullOrEmpty(searchValue))
            {
                tableView.DataSource = _data; 
                return;
            }

            string filterExpression = "";
            foreach (DataColumn column in _data.Columns)
            {
                if (column.DataType == typeof(string) || column.DataType == typeof(int) || column.DataType == typeof(double) || column.DataType == typeof(decimal))
                {
                    if (!string.IsNullOrEmpty(filterExpression))
                        filterExpression += " OR ";
                    filterExpression += $"CONVERT([{column.ColumnName}], 'System.String') LIKE '%{searchValue}%'";
                }
            }

            DataView dv = new DataView(_data);
            dv.RowFilter = filterExpression;

            tableView.DataSource = dv;

            if (dv.Count == 0)
            {
                MessageBox.Show("Nenhum valor encontrado.");
            }
        }

        private void input_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Filtrar_Click(sender, EventArgs.Empty);

                e.Handled = true; 
            }
        }
    }
}
