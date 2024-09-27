using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteInspector
{
    public partial class InspectScreen : Form
    {
        private readonly InspectRepository _repository;

        private string NOTA;
        private string DE_ID_KAFFA;
        private int? NU_PACOTE_ID;

        private DataTable VW_IMPORTACAO;

        private readonly LoadingManager _loadingManager = new LoadingManager();

        public InspectScreen(string selectedDatabase, string connectionString)
        {
            InitializeComponent();
            _repository = new InspectRepository(connectionString);
        }

        private void InspectScreen_Click(object sender, EventArgs e)
        {
            if (_loadingManager.isLoading)
            {
                return;
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            StartScreen screen = new StartScreen();
            screen.Show();

            this.Close();
        }

        private void LimparTela()
        {
            kaffaImportacaoView.DataSource = null;
            statusView.DataSource = null;
            errosView.DataSource = null;

            NOTA = null;
            DE_ID_KAFFA = null;
            NU_PACOTE_ID = null;
            VW_IMPORTACAO = null;

            lbl_chavesAssociadasNumber.Text = "0";
            lbl_chavesAssociadasNumber.ForeColor = Color.Black;
        }

        private async void btn_ProcurarNota_Click(object sender, EventArgs e)
        {
            _loadingManager.Loading(this, false);

            if (String.IsNullOrEmpty(input_nota.Text))
            {
                MessageBox.Show("Insira o número da nota");
                _loadingManager.Stop(this);
                return;
            }

            NOTA = input_nota.Text;

            try
            {
                // Tabela principal
                DataTable kaffaImportacaoTable = await _repository.GetKaffaImportacao(NOTA);

                if (kaffaImportacaoTable.Rows.Count > 0)
                {
                    kaffaImportacaoView.DataSource = kaffaImportacaoTable;

                    // Seta as variaveis globais DE_ID_CCKAFFA e NU_PACOTE_ID
                    GetDE_ID_KAFFA(kaffaImportacaoTable);
                    NU_PACOTE_ID = Convert.ToInt32(kaffaImportacaoTable.Rows[0]["NU_PACOTE_ID"]);
                }
                else
                {
                    MessageBox.Show("Nota não encontrada.");
                    LimparTela();
                    _loadingManager.Stop(this);
                    return;
                }

                // Alimenta as demais tabelas (Status, Erros, VW)
                statusView.DataSource = await _repository.GetStatusTable(DE_ID_KAFFA);
                errosView.DataSource = await _repository.GetErrosTable(DE_ID_KAFFA);

                VW_IMPORTACAO = await _repository.GetVwImportacao(NU_PACOTE_ID.Value);
                CountChavesAssociadas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _loadingManager.Stop(this);
        }

        private void GetDE_ID_KAFFA(DataTable kaffaImportacaoTable)
        {
            string ID_KAFFA;

            if (String.IsNullOrEmpty(kaffaImportacaoTable.Rows[0]["DE_ID_KAFFA_CC"].ToString()))
            {
                ID_KAFFA = kaffaImportacaoTable.Rows[0]["DE_ID_KAFFA_PROJETO"].ToString();
            }
            else
            {
                ID_KAFFA = kaffaImportacaoTable.Rows[0]["DE_ID_KAFFA_CC"].ToString();
            }

            string[] splitted = ID_KAFFA.Split('_');

            if (splitted.Length > 1)
            {
                DE_ID_KAFFA = splitted[1];
            }
            else
            {
                MessageBox.Show("Erro ao setar a variável DE_ID_KAFFA_CC.");
            }
        }

        private void CountChavesAssociadas()
        {
            int contagem = 0;

            foreach (DataRow row in VW_IMPORTACAO.Rows) 
            {
                if (row["TABELA"] != DBNull.Value) 
                {
                    string valorColuna = row["TABELA"].ToString();

                    if (valorColuna == "NEOSDE.TB_IMP_KAFFA_CHAVE_ASSOCIADA")
                    {
                        contagem++;
                    }
                }
            }

            if(contagem > 1)
            {
                lbl_chavesAssociadasNumber.ForeColor = Color.Red;
            }
            else
            {
                lbl_chavesAssociadasNumber.ForeColor= Color.Black;
            }

            lbl_chavesAssociadasNumber.Text = contagem.ToString();
        }

        private async void btn_atualizarErros_Click(object sender, EventArgs e)
        {
            _loadingManager.Loading(this, false);
            if (!String.IsNullOrEmpty(DE_ID_KAFFA))
            {
                errosView.DataSource = await _repository.GetErrosTable(DE_ID_KAFFA);
            }
            else
            {
                MessageBox.Show("Faça a busca pela nota primeiro.");
            }
            _loadingManager.Stop(this);
        }

        private async void btn_atualizarKaffaImportacao_Click(object sender, EventArgs e)
        {
            _loadingManager.Loading(this, false);
            if (!String.IsNullOrEmpty(NOTA))
            {
                kaffaImportacaoView.DataSource = await _repository.GetKaffaImportacao(NOTA);
            }
            else
            {
                MessageBox.Show("Faça a busca pela nota primeiro.");
            }
            _loadingManager.Stop(this);
        }
    }
}
