using DotEnv.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class ConnectionPool
{
    public static Dictionary<string, string> Strings = new Dictionary<string, string>()
    {
        {"Coelba", "COELBA_CONNECTION_STRING".GetEnv()},
        {"Cosern", "COSERN_CONNECTION_STRING".GetEnv()},
        {"Celpe", "CELPE_CONNECTION_STRING".GetEnv()},
    };

    public static string _connectionString;
}
