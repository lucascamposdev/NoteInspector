using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoteInspector
{
    public partial class FilaJobScreen : Form
    {
        private readonly LoadingManager _loadingManager = new LoadingManager();
        private readonly InspectRepository _repository;

        public FilaJobScreen(DataTable data)
        {
            InitializeComponent();
            filaJobView.DataSource = data;
            _repository = InspectRepository.Instance;

            // Adicionando os ID'S da fila job para que o log job possa buscar
            foreach (DataRow row in data.Rows)
            {
                select_JobId.Items.Add(row["NU_ID"].ToString());
            }
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

        private async void btn_BuscarLogJob_Click(object sender, EventArgs e)
        {
            _loadingManager.Loading(this, false);
            var selectedJob = select_JobId.SelectedItem.ToString();

            if (String.IsNullOrEmpty(selectedJob))
            {
                MessageBox.Show("Selecione um job.");
                _loadingManager.Stop(this);
                return;
            }

            logJobView.DataSource = await _repository.GetLogJob(selectedJob);
            _loadingManager.Stop(this);
        }
    }
}
