using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteInspector
{
    public partial class StartScreen : Form
    {

        private LoadingManager loadingManager = new LoadingManager();
        public StartScreen()
        {
            InitializeComponent();

            comboBox1.Items.Add("");
            comboBox1.Items.Add("Coelba");
            comboBox1.Items.Add("Cosern");
            comboBox1.Items.Add("Celpe");

            comboBox1.SelectedIndex = 0;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedDatabase = comboBox1.SelectedItem.ToString();

            if(string.IsNullOrEmpty(selectedDatabase))
            {
                MessageBox.Show("Please, select a database.");
                loadingManager.Stop(this);
                return;
            }

            if (ConnectionString.Strings.TryGetValue(selectedDatabase, out string connectionString))
            {
                InspectScreen screen = new InspectScreen(selectedDatabase, connectionString);
                screen.Show();

                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Banco de dados não encontrado.");
            }
        }
    }
}
