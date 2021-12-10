﻿using AircraftState.Models;
using Microsoft.FlightSimulator.SimConnect;

namespace AircraftState.Services
{
    public interface ISimConnectService
    {
        SimConnect Sim { get; }

        void CloseConnection();
        bool Connected();
        bool ConnectToSim();
        void GetSimEnvInfo();

        void SaveDataToDb();
        void SendDataToSim(PlaneData data);
    }
}