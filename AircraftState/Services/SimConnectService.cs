using AircraftState.enums;
using AircraftState.Forms;
using AircraftState.Models;
using Microsoft.FlightSimulator.SimConnect;
using System;

namespace AircraftState.Services
{
    public class SimConnectService : ISimConnectService
    {
        public const int WM_USER_SIMCONNECT = 0x0402;
        private readonly MainForm fForm;
        private PlaneData planeData = new PlaneData();

        private SimConnect sim;
        public SimConnect Sim { get => sim; }

        public SimConnectService(MainForm mainForm)
        {
            fForm = mainForm;
            ConnectToSim();
            SetupEvents();
        }

        public bool Connected()
        {
            return sim != null;
        }
        private void SetupEvents()
        {
            try
            {
                sim.OnRecvOpen += new SimConnect.RecvOpenEventHandler(SimConnect_OnRecvOpen);
                sim.OnRecvQuit += new SimConnect.RecvQuitEventHandler(SimConnect_OnRecvQuit);
                //Sim.OnRecvEvent += new SimConnect.RecvEventEventHandler(SimConnect_OnRecvEvent);
                sim.OnRecvException += new SimConnect.RecvExceptionEventHandler(SimConnect_OnRecvException);

                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "PLANE LATITUDE", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "PLANE LONGITUDE", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "PLANE ALTITUDE", "feet", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "PLANE HEADING DEGREES MAGNETIC", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "COM ACTIVE FREQUENCY:1", "Mhz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "COM STANDBY FREQUENCY:1", "Mhz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "COM ACTIVE FREQUENCY:2", "Mhz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "COM STANDBY FREQUENCY:2", "Mhz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "NAV ACTIVE FREQUENCY:1", "Mhz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "NAV STANDBY FREQUENCY:1", "Mhz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "NAV ACTIVE FREQUENCY:2", "Mhz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "NAV STANDBY FREQUENCY:2", "Mhz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "ADF ACTIVE FREQUENCY:1", "Mhz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "ADF STANDBY FREQUENCY:1", "Mhz", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "NAV OBS:1", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "NAV OBS:2", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "ADF CARD", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "FUEL TANK LEFT MAIN QUANTITY", "gallons", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "FUEL TANK RIGHT MAIN QUANTITY", "gallons", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "FUEL TANK SELECTOR:1", "enum", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "BRAKE PARKING INDICATOR", "bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "KOHLSMAN SETTING HG", "inHg", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "AUTOPILOT HEADING LOCK DIR", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "FLAPS HANDLE INDEX", "number", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneDataStructure, "ELECTRICAL MASTER BATTERY", "bool", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);

                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneFuelData, "FUEL TANK LEFT MAIN QUANTITY", "gallons", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneFuelData, "FUEL TANK RIGHT MAIN QUANTITY", "gallons", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneLocationData, "PLANE LATITUDE", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneLocationData, "PLANE LONGITUDE", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneLocationData, "PLANE ALTITUDE", "feet", SIMCONNECT_DATATYPE.INT32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                sim.AddToDataDefinition(DATA_DEFINITIONS.SimPlaneLocationData, "PLANE HEADING DEGREES MAGNETIC", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);

                sim.AddToDataDefinition(DATA_DEFINITIONS.SimEnvironmentDataStructure, "Title", null, SIMCONNECT_DATATYPE.STRING256, 0.0f, SimConnect.SIMCONNECT_UNUSED);

                sim.RegisterDataDefineStruct<PlaneData>(DATA_DEFINITIONS.SimPlaneDataStructure);
                sim.RegisterDataDefineStruct<MasterData>(DATA_DEFINITIONS.SimEnvironmentDataStructure);
                sim.RegisterDataDefineStruct<MasterData>(DATA_DEFINITIONS.SimPlaneFuelData);
                sim.RegisterDataDefineStruct<MasterData>(DATA_DEFINITIONS.SimPlaneLocationData);
                sim.RegisterDataDefineStruct<MasterData>(DATA_DEFINITIONS.SimFlapsData);

                sim.OnRecvSimobjectData += new SimConnect.RecvSimobjectDataEventHandler(SimConnect_OnRecvSimobjectData);
                sim.RequestDataOnSimObject(DATA_REQUESTS_TYPES.DataRequest, DATA_DEFINITIONS.SimPlaneDataStructure, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_PERIOD.SECOND, SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT, 0, 0, 0);
                sim.RequestDataOnSimObject(DATA_REQUESTS_TYPES.SimEnvironmentReq, DATA_DEFINITIONS.SimEnvironmentDataStructure, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_PERIOD.SECOND, SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT, 0, 0, 0);

                sim.MapClientEventToSimEvent(EVENT_IDS.COM_RADIO_SET_HZ, "COM_RADIO_SET_HZ");
                sim.MapClientEventToSimEvent(EVENT_IDS.COM_STBY_RADIO_SET_HZ, "COM_STBY_RADIO_SET_HZ");
                sim.MapClientEventToSimEvent(EVENT_IDS.COM2_RADIO_SET_HZ, "COM2_RADIO_SET_HZ");
                sim.MapClientEventToSimEvent(EVENT_IDS.COM2_STBY_RADIO_SET_HZ, "COM2_STBY_RADIO_SET_HZ");
                sim.MapClientEventToSimEvent(EVENT_IDS.NAV1_RADIO_SET_HZ, "NAV1_RADIO_SET_HZ");
                sim.MapClientEventToSimEvent(EVENT_IDS.NAV1_STBY_SET_HZ, "NAV1_STBY_SET_HZ");
                sim.MapClientEventToSimEvent(EVENT_IDS.NAV2_RADIO_SET_HZ, "NAV2_RADIO_SET_HZ");
                sim.MapClientEventToSimEvent(EVENT_IDS.NAV2_STBY_SET_HZ, "NAV2_STBY_SET_HZ");
                sim.MapClientEventToSimEvent(EVENT_IDS.ADF1_RADIO_SWAP, "ADF1_RADIO_SWAP");
                sim.MapClientEventToSimEvent(EVENT_IDS.ADF_SET, "ADF_COMPLETE_SET");
                sim.MapClientEventToSimEvent(EVENT_IDS.ADF_STBY_SET, "ADF_STBY_SET");
                sim.MapClientEventToSimEvent(EVENT_IDS.OBS1, "VOR1_SET");
                sim.MapClientEventToSimEvent(EVENT_IDS.OBS2, "VOR2_SET");
                sim.MapClientEventToSimEvent(EVENT_IDS.ADF_CARD_SET, "ADF_CARD_SET");
                sim.MapClientEventToSimEvent(EVENT_IDS.FUEL_SELECTOR_SET, "FUEL_SELECTOR_SET");
                sim.MapClientEventToSimEvent(EVENT_IDS.PARKING_BRAKE_SET, "PARKING_BRAKE_SET");
                sim.MapClientEventToSimEvent(EVENT_IDS.HEADING_BUG_SET, "HEADING_BUG_SET");
                sim.MapClientEventToSimEvent(EVENT_IDS.KOHLSMAN_SET, "KOHLSMAN_SET");
                sim.MapClientEventToSimEvent(EVENT_IDS.FLAPS_UP, "FLAPS_UP");
                sim.MapClientEventToSimEvent(EVENT_IDS.FLAPS_1, "FLAPS_1");
                sim.MapClientEventToSimEvent(EVENT_IDS.FLAPS_2, "FLAPS_2");
                sim.MapClientEventToSimEvent(EVENT_IDS.FLAPS_3, "FLAPS_3");
                sim.MapClientEventToSimEvent(EVENT_IDS.FLAPS_4, "FLAPS_4");
                sim.MapClientEventToSimEvent(EVENT_IDS.FLAPS_DOWN, "FLAPS_DOWN");

                sim.MapClientEventToSimEvent(EVENT_IDS.COM_STBY_RADIO_SWAP, "COM_STBY_RADIO_SWAP");

                //sim.SubscribeToSystemEvent(MY_SIMCONENCT_EVENT_IDS.Pause, "Pause");
            }
            catch /* (COMException ex) */
            {              
            }
        }

        public void SendDataToSim(PlaneData data, bool sendFuel, bool sendLocation)
        {
            //COM
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.COM_RADIO_SET_HZ, ConvertCom(data.com1Standby), GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.COM_RADIO_SET_HZ, ConvertCom(data.com1Active), GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.COM_STBY_RADIO_SET_HZ, ConvertCom(data.com1Standby), GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.COM2_RADIO_SET_HZ, ConvertCom(data.com2Active), GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.COM2_STBY_RADIO_SET_HZ, ConvertCom(data.com2Standby), GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);

            //NAV
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.NAV1_RADIO_SET_HZ, ConvertNav(data.nav1Active), GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.NAV1_STBY_SET_HZ, ConvertNav(data.nav1Standby), GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.NAV2_RADIO_SET_HZ, ConvertNav(data.nav2Active), GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.NAV2_STBY_SET_HZ, ConvertNav(data.nav2Standby), GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);

            //ADF - note, couldn't get ADF to set, so set standby and swap
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.ADF_STBY_SET, ConvertAdf(data.adfActive), GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.ADF1_RADIO_SWAP, 0, GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.ADF_STBY_SET, ConvertAdf(data.adfStandby), GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);

            //OBS, ADF Card
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.OBS1, (uint)data.obs1, GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.OBS2, (uint)data.obs2, GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.ADF_CARD_SET, (uint)data.adfCard, GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);

            //Fuel Selector
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.FUEL_SELECTOR_SET, (uint)data.fuelSelector, GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);

            //Parking Brake Set
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.PARKING_BRAKE_SET, (uint)(data.parkingBrake ? 1 : 0), GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);

            //Heading Bug
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.HEADING_BUG_SET, (uint)data.headingBug, GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);

            //Kohlman
            sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.KOHLSMAN_SET, ConvertKohlsman(data.kohlsman), GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);

            //Flaps
            switch (data.flapsIndex)
            {
                case 0:
                    sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.FLAPS_UP, 0, GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                    break;
                case 1:
                    sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.FLAPS_1, 0, GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                    break;
                case 2:
                    sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.FLAPS_2, 0, GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                    break;
                case 3:
                    sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.FLAPS_3, 0, GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                    break;
                case 4:
                    sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.FLAPS_4, 0, GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                    break;
                default:
                    sim.TransmitClientEvent(SimConnect.SIMCONNECT_OBJECT_ID_USER, EVENT_IDS.FLAPS_DOWN, 0, GROUPID.MAX, SIMCONNECT_EVENT_FLAG.GROUPID_IS_PRIORITY);
                    break;
            }

            if (sendFuel)
            {
                var fuelData = new FuelData { fuelLeft = data.fuelLeft, fuelRight = data.fuelRight };
                sim.SetDataOnSimObject(DATA_DEFINITIONS.SimPlaneFuelData, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_DATA_SET_FLAG.DEFAULT, fuelData);
            }

            if (sendLocation)
            {
                var locationData = new LocationData { altitude = data.altitude, heading = data.heading, latitude = data.latitude, longitude = data.longitude };
                sim.SetDataOnSimObject(DATA_DEFINITIONS.SimPlaneLocationData, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_DATA_SET_FLAG.DEFAULT, locationData);
            }
        }

        private uint ConvertKohlsman(double value)
        {
            var x = (uint)(value * 541.8);
            return x;
        }

        private uint ConvertNav(double value)
        {
            return (uint)(Math.Round(value, 2) * 1000000);
        }

        private uint ConvertAdf(double adf)
        {
            return Dec2Bcd(adf * 100000);
        }

        public static uint Dec2Bcd(uint num)
        {
            return HornerScheme(num, 10, 0x10);
        }

        public static uint Dec2Bcd(double num)
        {
            return Dec2Bcd((uint)(num * 100));
        }


        private static uint HornerScheme(uint Num, uint Divider, uint Factor)
        {
            uint Remainder, Quotient, Result = 0;
            Remainder = Num % Divider;
            Quotient = Num / Divider;

            if (!(Quotient == 0 && Remainder == 0))
                Result += HornerScheme(Quotient, Divider, Factor) * Factor + Remainder;

            return Result;
        }

        private uint ConvertCom(double value)
        {
            return (uint)(Math.Round(value,3) * 1000000);
        }

        public void GetSimEnvInfo()
        {
            sim.RequestDataOnSimObject(DATA_REQUESTS_TYPES.SimEnvironmentReq, DATA_DEFINITIONS.SimEnvironmentDataStructure, SimConnect.SIMCONNECT_OBJECT_ID_USER, SIMCONNECT_PERIOD.ONCE, SIMCONNECT_DATA_REQUEST_FLAG.DEFAULT, 0, 0, 0);
        }

        public bool ConnectToSim()
        {
            if (sim != null)
                return true;

            try
            {
                sim = new SimConnect("MainForm", fForm.Handle, WM_USER_SIMCONNECT, null, 0);
                return true;
            }
            catch /*(COMException ex)*/
            {
                return false;
            }
        }

        private void SimConnect_OnRecvSimobjectData(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA data)
        {
            switch ((DATA_REQUESTS_TYPES)data.dwRequestID)
            {
                case DATA_REQUESTS_TYPES.DataRequest:
                    planeData = (PlaneData)data.dwData[0];

                    if (!(planeData.masterBattery ?? true))
                    {
                        //put logic here to save data on master batter off, make sure only once.......
                    }
                    fForm.ShowSimDataOnForm(planeData);
                    break;

                case DATA_REQUESTS_TYPES.SimEnvironmentReq:
                    MasterData s2 = (MasterData)data.dwData[0];
                    fForm.ShowSimEnvironmentDataOnForm(s2);
                    break;

                default:
                    break;
            }
        }

        //void SimConnect_OnRecvEvent(SimConnect sender, SIMCONNECT_RECV_EVENT data)
        //{
        //    switch ((MY_SIMCONENCT_EVENT_IDS)(data.uEventID))
        //    {
        //        //case EVENTS.FlightPlanActivated:
        //        //    int n = 5;
        //        //    break;
        //        //case EVENTS.FlightPlanDeactivated:
        //        //    int aa = 7;
        //        //    break;
        //        //case EVENTS.SimStop:
        //        //    int x = 6;
        //        //    break;
        //        //case EVENTS.SimStart:
        //        //    int z = 7;
        //        //    break;
        //        default:
        //            break;
        //    }
        //}

        private void SimConnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
        {
        }

        private void SimConnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
        {
            CloseConnection();
        }

        private void SimConnect_OnRecvException(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
        {
            // return "Exception received: " + data.dwException;
        }

        public void CloseConnection()
        {
            if (sim != null)
            {
                sim.Dispose();
                sim = null;
            }
        }

        public void SaveDataToDb()
        {
            var db = new DbData();
            db.SaveData(fForm.Title, planeData);
        }
    }
}
