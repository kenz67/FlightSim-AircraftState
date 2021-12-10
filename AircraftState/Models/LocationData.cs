using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
