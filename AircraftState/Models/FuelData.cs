using System.Runtime.InteropServices;

namespace AircraftState.Models
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct FuelData
    {
        public double fuelLeft;    //settable
        public double fuelRight;    //settable
    }
}