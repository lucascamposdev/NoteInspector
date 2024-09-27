using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

public class MySqlConnectionWrapper : IDatabaseConnection
{
    private MySqlConnection _connection;

    public MySqlConnectionWrapper(string connectionString)
    {
        _connection = new MySqlConnection(connectionString);
    }

    public void Open()
    {
        _connection.Open();
    }

    public void Close()
    {
        _connection.Close();
    }

}
