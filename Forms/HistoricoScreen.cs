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
    public partial class HistoricoScreen : Form
    {
        public HistoricoScreen(DataTable HistoricoCCData,DataTable HistoricoKitData)
        {
            InitializeComponent();
            historicoCCView.DataSource = HistoricoCCData;
            historicoKitView.DataSource = HistoricoKitData;
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
    }
}
