using AircraftState.Forms;
using AircraftState.Models;
using Microsoft.FlightSimulator.SimConnect;
using System;

namespace AircraftState.Services
{
    internal class TestConnectClass : ISimConnectService
    {
        private readonly MainForm form;
        private bool connected = false;
        private PlaneData data = new PlaneData();

        public SimConnect Sim => throw new NotImplementedException();

        public TestConnectClass(MainForm mainForm)
        {
            form = mainForm;
        }

        public void CloseConnection()
        {
            //nothing needed for test class
        }

        public bool Connected()
        {
            return connected;
        }

        public bool ConnectToSim()
        {
            var r = new Random();

            connected = true;

            data = new PlaneData
            {
                adfActive = GetAdf(r),
                adfCard = r.Next(0, 360),
                adfStandby = GetAdf(r),
                altitude = r.Next(0, 3000),
                com1Active = GetCom(r),
                com1Standby = GetCom(r),
                com2Active = GetCom(r),
                com2Standby = GetCom(r),
                nav1Active = GetNav(r),
                nav1Standby = GetNav(r),
                nav2Active = GetNav(r),
                nav2Standby = GetNav(r),
                fuelLeft = r.NextDouble() * 100,
                fuelRight = r.NextDouble() * 100,
                fuelSelector = r.Next(1, 5),
                heading = r.Next(0, 360),
                headingBug = r.Next(0, 360),
                kohlsman = GetKolhman(r),
                latitude = 0,
                longitude = 0,
                masterBattery = true,
                obs1 = r.Next(0, 360),
                obs2 = r.Next(0, 360),
                parkingBrake = !r.Next(0, 1).Equals(0)
            };

            form.ShowSimDataOnForm(data);
            return true;
        }

        private double GetCom(Random r)
        {
            return r.Next(118, 137) + r.NextDouble();
        }

        private double GetNav(Random r)
        {
            return r.Next(108, 118) + r.NextDouble();
        }

        private double GetKolhman(Random r)
        {
            return 30 + r.NextDouble();
        }

        private double GetAdf(Random r)
        {
            double adf = r.Next(r.Next(0, 1000));
            return adf / 1000;
        }

        public void GetSimEnvInfo()
        {
            var masterData = new MasterData { title = "Test Mode" };
            form.ShowSimEnvironmentDataOnForm(masterData);
        }

        public void SaveDataToDb()
        {
            var db = new DbData();
            db.SaveData(form.Title, data);
        }
        public void SendDataToSim(PlaneData data, bool sendFuel, bool sendLocation)
        {
            //nothing for test mode here
        }
    }
}
