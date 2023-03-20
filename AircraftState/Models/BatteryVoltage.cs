using System.Runtime.InteropServices;

namespace AircraftState.Models
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct BatteryVoltage
    {
        public double batteryVoltage;    //settable
    }
}