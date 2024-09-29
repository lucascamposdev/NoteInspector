using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class ConnectionPool
{
    public static Dictionary<string, string> Strings = new Dictionary<string, string>()
    {
        {"Coelba", "Server=localhost;Database=neosde;Uid=root;Pwd=lucasz12;Port=3306;"},
        {"Cosern", "Server=localhost;Database=neosde;Uid=root;Pwd=lucasz12;Port=3306;"},
        {"Celpe", "Server=localhost;Database=neosde;Uid=root;Pwd=lucasz12;Port=3306;"},
    };

    public static string _connectionString;
}
