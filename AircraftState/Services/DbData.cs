using AircraftState.Models;
using System.Data.SQLite;

namespace AircraftState.Services
{
    public class DbData
    {
        private const string DbName = "AircraftState.sqlite";   //todo: move this
        public PlaneData GetData(string plane)
        {
            using (var connection = new SQLiteConnection($"Data Source={DbName}"))
            {
                connection.Open();

                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.Parameters.AddWithValue("@plane", plane);
                    cmd.CommandText = @"SELECT 
                            adfActive,
                            AdfCard,
                            adfStandBy,
                            Altitude ,
                            Com1Active,
                            Com1StandBy,
                            Com2Active,
                            Com2StandBy,
                            FuelLeft,
                            FuelRight,
                            FuelSelector,
                            Heading,
                            HeadingBug,
                            Kohlsman,
                            Latitude,
                            Longitude,
                            Nav1Active,
                            Nav1StandBy,
                            Nav2Active,
                            Nav2StandBy,
                            Obs1,
                            Obs2,
                            ParkingBrake,
                            Flaps
                        FROM data 
                        WHERE Plane = @plane";

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            return new PlaneData
                            {
                                adfActive = rdr.GetDouble(0),
                                adfCard = rdr.GetDouble(1),
                                adfStandby = rdr.GetDouble(2),
                                altitude = rdr.GetInt32(3),
                                com1Active = rdr.GetDouble(4),
                                com1Standby = rdr.GetDouble(5),
                                com2Active = rdr.GetDouble(6),
                                com2Standby = rdr.GetDouble(7),
                                fuelLeft = rdr.GetDouble(8),
                                fuelRight = rdr.GetDouble(9),
                                fuelSelector = rdr.GetInt32(10),
                                heading = rdr.GetDouble(11),
                                headingBug = rdr.GetDouble(12),
                                kohlsman = rdr.GetDouble(13),
                                latitude = rdr.GetDouble(14),
                                longitude = rdr.GetDouble(15),
                                nav1Active = rdr.GetDouble(16),
                                nav1Standby = rdr.GetDouble(17),
                                masterBattery = null,
                                nav2Active = rdr.GetDouble(18),
                                nav2Standby = rdr.GetDouble(19),
                                obs1 = rdr.GetDouble(20),
                                obs2 = rdr.GetDouble(21),
                                parkingBrake = rdr.GetBoolean(22),
                                flapsIndex = rdr.GetInt32(23),
                                validData = true
                            };
                        }
                    }
                }
            }

            return new PlaneData { validData = false };
        }

        public void SaveData(string plane, PlaneData Data)
        {
            using (var connection = new SQLiteConnection($"Data Source={DbName}"))
            {
                connection.Open();

                using (SQLiteCommand cmd = connection.CreateCommand())
                {
                    cmd.Parameters.AddWithValue("@plane", plane);
                    cmd.Parameters.AddWithValue("@adfActive", Data.adfActive);
                    cmd.Parameters.AddWithValue("@AdfCard", Data.adfCard);
                    cmd.Parameters.AddWithValue("@adfStandBy", Data.adfStandby);
                    cmd.Parameters.AddWithValue("@Altitude", Data.altitude);
                    cmd.Parameters.AddWithValue("@Com1Active", Data.com1Active);
                    cmd.Parameters.AddWithValue("@Com1StandBy", Data.com1Standby);
                    cmd.Parameters.AddWithValue("@Com2Active", Data.com2Active);
                    cmd.Parameters.AddWithValue("@Com2StandBy", Data.com2Standby);
                    cmd.Parameters.AddWithValue("@FuelLeft", Data.fuelLeft);
                    cmd.Parameters.AddWithValue("@FuelRight", Data.fuelRight);
                    cmd.Parameters.AddWithValue("@FuelSelector", Data.fuelSelector);
                    cmd.Parameters.AddWithValue("@Heading", Data.heading);
                    cmd.Parameters.AddWithValue("@HeadingBug", Data.headingBug);
                    cmd.Parameters.AddWithValue("@Kohlsman", Data.kohlsman);
                    cmd.Parameters.AddWithValue("@Latitude", Data.latitude);
                    cmd.Parameters.AddWithValue("@Longitude", Data.longitude);
                    cmd.Parameters.AddWithValue("@Nav1Active", Data.nav1Active);
                    cmd.Parameters.AddWithValue("@Nav1StandBy", Data.nav1Standby);
                    cmd.Parameters.AddWithValue("@Nav2Active", Data.nav2Active);
                    cmd.Parameters.AddWithValue("@Nav2StandBy", Data.nav2Standby);
                    cmd.Parameters.AddWithValue("@Obs1", Data.obs1);
                    cmd.Parameters.AddWithValue("@Obs2", Data.obs2);
                    cmd.Parameters.AddWithValue("@ParkingBrake", Data.parkingBrake);
                    cmd.Parameters.AddWithValue("@Flaps", Data.flapsIndex);

                    cmd.CommandText = "DELETE FROM data WHERE Plane = @plane";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"
                        INSERT INTO [data]
                                   ([Plane]
                                   ,[Latitude]
                                   ,[Longitude]
                                   ,[Altitude]
                                   ,[Heading]
                                   ,[Com1Active]
                                   ,[Com1StandBy]
                                   ,[Com2Active]
                                   ,[Com2StandBy]
                                   ,[Nav1Active]
                                   ,[Nav1StandBy]
                                   ,[Nav2Active]
                                   ,[Nav2StandBy]
                                   ,[adfActive]
                                   ,[adfStandBy]
                                   ,[Obs1]
                                   ,[Obs2]
                                   ,[AdfCard]
                                   ,[FuelLeft]
                                   ,[FuelRight]
                                   ,[FuelSelector]
                                   ,[ParkingBrake]
                                   ,[Kohlsman]
                                   ,[HeadingBug]
                                   ,[Flaps])
                             VALUES
                                   (@plane
                                   ,@Latitude
                                   ,@Longitude
                                   ,@Altitude
                                   ,@Heading
                                   ,@Com1Active
                                   ,@Com1StandBy
                                   ,@Com2Active
                                   ,@Com2StandBy
                                   ,@Nav1Active
                                   ,@Nav1StandBy
                                   ,@Nav2Active
                                   ,@Nav2StandBy
                                   ,@adfActive
                                   ,@adfStandBy
                                   ,@Obs1
                                   ,@Obs2
                                   ,@AdfCard
                                   ,@FuelLeft
                                   ,@FuelRight
                                   ,@FuelSelector
                                   ,@ParkingBrake
                                   ,@Kohlsman
                                   ,@HeadingBug
                                   ,@Flaps);
                        ";

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
