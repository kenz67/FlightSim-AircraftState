using AircraftState.enums;
using Newtonsoft.Json;
using System.Data.SQLite;
using System.IO;

namespace AircraftState.Services
{
    public class ConfigureDb
    {
        private const string DbName = "AircraftState.sqlite";

        public void InitDb()
        {
            if (!File.Exists(DbName))
            {
                SQLiteConnection.CreateFile(DbName);
            }

            //SqliteConnection.Create
            using (var connection = new SQLiteConnection($"Data Source={DbName}"))
            {
                connection.Open();

                CreateSettingTable(connection);
                CreateDataTable(connection);

                LoadSettingTable(connection);
            }
        }

        private void LoadSettingTable(SQLiteConnection conn)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = $@"
                WITH v AS (
	                SELECT '{SettingDefinitions.ApplyLocation}' as DataKey, 'false' as DataValue UNION
	                SELECT '{SettingDefinitions.ApplyFuel}', 'true' UNION
                    SELECT '{SettingDefinitions.ShowApplyForm}', 'true'
                )
                INSERT INTO settings (DataKey, DataValue)
                    SELECT DataKey, DataValue FROM v t1
                    WHERE NOT EXISTS (SELECT 1 FROM settings t2 WHERE t1.DataKey = t2.DataKey);
            ";

                cmd.ExecuteNonQuery();
            }
        }

        private void CreateSettingTable(SQLiteConnection conn)
        {
            using (SQLiteCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS settings (
                    DataKey VARCHAR(100) NOT NULL PRIMARY KEY,
                    DataValue VARCHAR(100) NOT NULL
            )";

                cmd.ExecuteNonQuery();
            }
        }

        public void CreateDataTable(SQLiteConnection conn)
        { 
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS planeData (
                    plane VARCHAR(100) NOT NULL PRIMARY KEY,
                    data TEXT
                    )
                ";

                cmd.ExecuteNonQuery();
            }
        }    
    }
}
