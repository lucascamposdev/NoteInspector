using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Threading.Tasks;

public class InspectRepository
{
    private static InspectRepository _instance;
    private static readonly object _lock = new object();

    public static InspectRepository Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new InspectRepository();
                    }
                }
            }
            return _instance;
        }
    }

    public async Task<DataTable> GetKaffaImportacao(string NOTA)
    {
        string query = $"SELECT * FROM NEOSDE.tb_kaffa_projeto_importacao WHERE NO_NOME_PROJETO_KIT LIKE '%{NOTA}%' order by 3 desc";
        
        var dataTable = await ExecuteSelect(query);

        return dataTable;
    }

    public async Task<DataTable> GetStatusTable(string DE_ID_CCKAFFA)
    {
        string query = $"SELECT * FROM NEOSDE.tb_status_importacao_kaffa WHERE NU_KAFFA_ID like '%{DE_ID_CCKAFFA}%' order by dt_envio desc";

        var dataTable = await ExecuteSelect(query);

        return dataTable;
    }

    public async Task<DataTable> GetErrosTable(string DE_ID_CCKAFFA)
    {
        string query = $"SELECT * FROM neosde.TB_ERROS_IMPORTACAO_KAFFA WHERE NU_KAFFA_ID LIKE '%{DE_ID_CCKAFFA}%' order by dt_envio desc";

        var dataTable = await ExecuteSelect(query);

        return dataTable;
    }

    public async Task<DataTable> GetVwImportacao(int NU_PACOTE_ID)
    {
        string query = $"SELECT * FROM neosde.vw_importacao_kaffa WHERE NU_PACOTE_ID = {NU_PACOTE_ID}";

        var dataTable = await ExecuteSelect(query);

        return dataTable;
    }

    public async Task<DataTable> GetFilaJob(int NU_PACOTE_ID)
    {
        string query = $"SELECT * FROM neosde.tb_fila_job WHERE DE_PARAMETROS_JSON LIKE '%{NU_PACOTE_ID}%' order by DT_INCLUSAO desc";

        var dataTable = await ExecuteSelect(query);

        return dataTable;
    }

    public async Task<DataTable> GetLogJob(string NU_ID_FILA_JOB)
    {
        string query = $"SELECT * FROM neosde.tb_log_job WHERE NU_ID_FILA_JOB = {NU_ID_FILA_JOB} order by DT_INCLUSAO desc";

        var dataTable = await ExecuteSelect(query);

        return dataTable;
    }

    private async Task<DataTable> ExecuteSelect(string query)
    {
        DataTable dataTable = new DataTable();
        
        try
        {
            using (var connection = new OracleConnection(ConnectionPool._connectionString))
            {
                await connection.OpenAsync();

                using (var command = new OracleCommand(query, connection))
                {
                    using (var adapter = new OracleDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao executar a query: " + ex.Message);
        }
    
        return dataTable;

    }


}
