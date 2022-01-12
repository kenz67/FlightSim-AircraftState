using AircraftState.enums;
using AircraftState.Models;
using System.Data.SQLite;

namespace AircraftState.Services
{
    public static class DbSettings
    {
        private static Settings settings = null;

        public static Settings Settings { get => GetSettings(); private set => settings = value; }

        private static Settings GetSettings()
        {
            if (settings == null)
            {
                ReadSettings();
            }

            return settings;
        }

        private static void ReadSettings()
        {
            settings = new Settings();

            using (var connection = new SQLiteConnection($"Data Source={DbCommon.DbName}"))
            {
                connection.Open();

                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT DataKey, DataValue FROM settings";

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            switch (rdr.GetString(0))
                            {
                                case SettingDefinitions.ApplyLocation: settings.SetLocation = rdr.GetString(1).Equals("true"); break;
                                case SettingDefinitions.ApplyFuel: settings.SetFuel = rdr.GetString(1).Equals("true"); break;
                                case SettingDefinitions.ShowApplyForm: settings.ShowApplyForm = rdr.GetString(1).Equals("true"); break;
                                case SettingDefinitions.AutoSave: settings.AutoSave = rdr.GetString(1).Equals("true"); break;
                            }
                        }
                    }
                }

                connection.Close();
            }
        }

        public static void SaveSettings(string settingName, bool settingValue)
        {
            using (var connection = new SQLiteConnection($"Data Source={DbCommon.DbName}"))
            {
                connection.Open();
                SetSetting(connection, settingName, settingValue);
            }

            ReadSettings();
        }

        public static void SaveAllSettings(Settings settings)
        {
            using (var connection = new SQLiteConnection($"Data Source={DbCommon.DbName}"))
            {
                connection.Open();
                SetSetting(connection, SettingDefinitions.ApplyLocation, settings.SetLocation);
                SetSetting(connection, SettingDefinitions.ApplyFuel, settings.SetFuel);
                SetSetting(connection, SettingDefinitions.ShowApplyForm, settings.ShowApplyForm);
                SetSetting(connection, SettingDefinitions.AutoSave, settings.AutoSave);

                ReadSettings();
            }
        }

        private static void SetSetting(SQLiteConnection conn, string key, bool value)
        {
            using (var cmd = new SQLiteCommand(conn))
            {
                cmd.Parameters.AddWithValue("@key", key);
                cmd.Parameters.AddWithValue("@value", value.ToString().ToLower());
                cmd.CommandText = "UPDATE settings SET DataValue = @value WHERE DataKey = @key";
                cmd.ExecuteNonQuery();
            }
        }
    }
}