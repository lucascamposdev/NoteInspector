﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class InspectRepository
{
    private string _connectionString;

    public InspectRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<DataTable> GetKaffaImportacao(string NOTA)
    {
        string query = $"SELECT * FROM tb_kaffa_projeto_importacao WHERE NO_NOME_PROJETO_KIT LIKE '%{NOTA}%' order by 3 desc;";

        var dataTable = await ExecuteSelect(query);

        return dataTable;
    }

    public async Task<DataTable> GetStatusTable(string DE_ID_CCKAFFA)
    {
        string query = $"SELECT * FROM NEOSDE.tb_status_importacao_kaffa WHERE NU_KAFFA_ID like '%{DE_ID_CCKAFFA}%' order by dt_envio desc;";

        var dataTable = await ExecuteSelect(query);

        return dataTable;
    }

    public async Task<DataTable> GetErrosTable(string DE_ID_CCKAFFA)
    {
        string query = $"SELECT * FROM neosde.TB_ERROS_IMPORTACAO_KAFFA WHERE NU_KAFFA_ID LIKE '%{DE_ID_CCKAFFA}%' order by dt_envio desc;";

        var dataTable = await ExecuteSelect(query);

        return dataTable;
    }

    public async Task<DataTable> GetVwImportacao(int NU_PACOTE_ID)
    {
        string query = $"SELECT * FROM neosde.vw_importacao_kaffa WHERE NU_PACOTE_ID = {NU_PACOTE_ID};";

        var dataTable = await ExecuteSelect(query);

        return dataTable;
    }

    private async Task<DataTable> ExecuteSelect(string query)
    {
        DataTable dataTable = new DataTable();

        try
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        await Task.Run(() => adapter.Fill(dataTable));
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
