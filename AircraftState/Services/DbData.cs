using AircraftState.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AircraftState.Services
{
    public class DbData
    {
        public PlaneData GetData(string plane)
        {
            using (var connection = new SQLiteConnection($"Data Source={DbCommon.DbName}"))
            {
                connection.Open();

                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.Parameters.AddWithValue("@plane", plane);
                    cmd.CommandText = "SELECT data FROM planeData WHERE Plane = @plane";

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            var d = rdr.GetString(0);
                            var data = JsonConvert.DeserializeObject<PlaneData>(d);
                            data.validData = true;
                            return data;
                        }
                    }
                }
            }

            return new PlaneData { validData = false };
        }

        public void SaveData(string plane, PlaneData data)
        {
            using (var connection = new SQLiteConnection($"Data Source={DbCommon.DbName}"))
            {
                connection.Open();

                using (var cmd = connection.CreateCommand())
                {
                    cmd.Parameters.AddWithValue("@key", plane);
                    cmd.Parameters.AddWithValue("@data", JsonConvert.SerializeObject(data));

                    cmd.CommandText = "DELETE FROM planeData WHERE plane = @key";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO planeData (plane, data) VALUES (@key, @data)";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<string> GetSavedPlanes()
        {
            var result = new List<string>();
            using (var connection = new SQLiteConnection($"Data Source={DbCommon.DbName}"))
            {
                connection.Open();

                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT plane FROM planeData ORDER BY plane";

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            result.Add(rdr.GetString(0));
                        }
                    }
                }
            }

            return result;
        }

        public void DeleteSavedProfile(string Profile)
        {
            using (var connection = new SQLiteConnection($"Data Source={DbCommon.DbName}"))
            {
                connection.Open();

                using (var cmd = connection.CreateCommand())
                {
                    cmd.Parameters.AddWithValue("@key", Profile);

                    cmd.CommandText = "DELETE FROM planeData WHERE plane = @key";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}