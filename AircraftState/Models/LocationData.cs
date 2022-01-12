using System;
using System.Runtime.InteropServices;

namespace AircraftState.Models
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct LocationData
    {
        public double latitude;   //setttable
        public double longitude;  //settable
        public Int32 altitude;    //settable
        public double heading;    //settable
    }
}