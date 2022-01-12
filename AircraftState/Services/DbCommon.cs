using System;

namespace AircraftState.Services
{
    public static class DbCommon
    {
        public static readonly string DbName = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\AircraftState\\AircraftState.sqlite";
    }
}