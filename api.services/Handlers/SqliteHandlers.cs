using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace api.services.Handlers
{
    public class SqliteHandlers
    {
        public static string ConnectionString = string.Empty;

        public static string GetJson(string query)
        {
            DataTable dt = new DataTable();
            dt = GetDataTable(query);
            String json = JsonConvert.SerializeObject(dt, Formatting.Indented);
            return json;
        }
        public static DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            SqliteConnection conn = new SqliteConnection(ConnectionString);
            conn.Open();
            SqliteCommand command = new SqliteCommand(query,conn);
            command.CommandText = query;
            SqliteDataReader reader = command.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            conn.Close();
            return dt;
        }
        public static bool Exec(string query)

        {
            bool result = false;
            //creo la conexion
            SqliteConnection conn = new SqliteConnection(ConnectionString);
            //crea un comando 
            SqliteCommand commend = new SqliteCommand(query, conn);
            conn.Open();// abro la conecion
            try
            {
                commend.ExecuteNonQuery();
                result = true;
            }
            catch (System.Exception e)
            {
                result = false;
                String resultado = e.Message;
            }

            conn.Close();// cierro la conexion
            return result;
        }

    }
}
