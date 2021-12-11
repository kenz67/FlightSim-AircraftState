using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftState.Services
{
    public static class DbCommon
    {
        public static readonly string DbName = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\AircraftState\\AircraftState.sqlite";
    }
}
