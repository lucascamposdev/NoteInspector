using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteInspector
{
    public partial class MainScreen : Form
    {
        private readonly InspectRepository _repository;
        private readonly LoadingManager _loadingManager = new LoadingManager();

        private DataTable KAFFA_IMPORTACAO;
        private DataTable VW_IMPORTACAO;
        private DataTable TB_ERROS;

        private string NOTA;
        private int? NU_PACOTE_ID;
        private string DE_ID_KAFFA;
        private int? NU_COD_PROJETO_CC;
        private int? NU_COD_PROJETO_KIT;

        public MainScreen(string selectedDatabase)
        {
            InitializeComponent();
            _repository = InspectRepository.Instance;
            lbl_databaseName.Text = selectedDatabase;
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

            KAFFA_IMPORTACAO = null;
            TB_ERROS = null;
            VW_IMPORTACAO = null;

            NOTA = null;
            NU_PACOTE_ID = null;
            DE_ID_KAFFA = null;
            NU_COD_PROJETO_CC = null;
            NU_COD_PROJETO_KIT = null;

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
                KAFFA_IMPORTACAO = await _repository.GetKaffaImportacao(NOTA);

                if (KAFFA_IMPORTACAO.Rows.Count > 0)
                {
                    kaffaImportacaoView.DataSource = KAFFA_IMPORTACAO;

                    // Seta as variaveis globais
                    GetDE_ID_KAFFA(KAFFA_IMPORTACAO);
                    NU_PACOTE_ID = Convert.ToInt32(KAFFA_IMPORTACAO.Rows[0]["NU_PACOTE_ID"]);
                    TB_ERROS = await _repository.GetErrosTable(DE_ID_KAFFA);
                    VW_IMPORTACAO = await _repository.GetVwImportacao(NU_PACOTE_ID.Value);
                }
                else
                {
                    MessageBox.Show("Nota não encontrada.");
                    LimparTela();
                    _loadingManager.Stop(this);
                    return;
                }

                // Alimenta as tabelas principais (Status, Erros)
                statusView.DataSource = await _repository.GetStatusTable(DE_ID_KAFFA);
                errosView.DataSource = TB_ERROS;

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

        private int? GetFirstIntValueFromColumn(string ColumnName, DataTable table)
        {
            int? val = null;

            foreach (DataRow row in table.Rows)
            {
                if (int.TryParse(row[ColumnName].ToString(), out int value))
                {
                    val = value;
                    break;
                }
            }

            return val;
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

        private void btn_openVwImportacaoTable_Click(object sender, EventArgs e)
        {

            if(VW_IMPORTACAO == null) 
            {
                MessageBox.Show("Faça a busca pela nota primeiro.");
                return; 
            }

            TableViewScreen screen = new TableViewScreen("VW_IMPORTACAO_KAFFA", VW_IMPORTACAO);
            screen.Show();
        }

        private async void btn_openFilaJobTable_Click(object sender, EventArgs e)
        {
            _loadingManager.Loading(this, false);
            if (NU_PACOTE_ID.HasValue)
            {
                DataTable data = await _repository.GetFilaJob(NU_PACOTE_ID.Value);
                FilaJobScreen screen = new FilaJobScreen(data);
                screen.Show();
            }
            else
            {
                MessageBox.Show("Faça a busca pela nota primeiro.");
            }
            _loadingManager.Stop(this);
        }

        private void btn_openErrosTable_Click(object sender, EventArgs e)
        {
            if (TB_ERROS == null)
            {
                MessageBox.Show("Faça a busca pela nota primeiro.");
                return;
            }

            TableViewScreen screen = new TableViewScreen("TB_ERROS_IMPORTACAO_KAFFA", TB_ERROS);
            screen.Show();
        }

        private async void btn_openVwImportacaoPVTable_Click(object sender, EventArgs e)
        {
            _loadingManager.Loading(this, false);
            if (NU_PACOTE_ID.HasValue)
            {
                DataTable data = await _repository.GetVwImportacaoPV(NU_PACOTE_ID.Value);
                TableViewScreen screen = new TableViewScreen("VW_IMPORTACAO_KAFFA_PV", data);
                screen.Show();
            }
            else
            {
                MessageBox.Show("Faça a busca pela nota primeiro.");
            }
            _loadingManager.Stop(this);
        }

        private async void btn_openHistoricoTable_Click(object sender, EventArgs e)
        {
            _loadingManager.Loading(this, false);
            if (NU_PACOTE_ID.HasValue)
            {
                NU_COD_PROJETO_CC =
                    GetFirstIntValueFromColumn("NU_COD_PROJETO_CC", KAFFA_IMPORTACAO);
                NU_COD_PROJETO_KIT =
                    GetFirstIntValueFromColumn("NU_COD_PROJETO_KIT", KAFFA_IMPORTACAO);

                DataTable HistoricoCCdata = new DataTable();
                DataTable HistoricoKitData = new DataTable();

                if (NU_COD_PROJETO_CC.HasValue)
                {
                HistoricoCCdata = await _repository.GetHistorico(NU_COD_PROJETO_CC.Value);
                }

                if (NU_COD_PROJETO_KIT.HasValue)
                {
                    HistoricoKitData = await _repository.GetHistorico(NU_COD_PROJETO_KIT.Value);
                }

                HistoricoScreen screen = new HistoricoScreen(HistoricoCCdata, HistoricoKitData);
                screen.Show();
            }
            else
            {
                MessageBox.Show("Faça a busca pela nota primeiro.");
            }
            _loadingManager.Stop(this);
        }
    }
}
