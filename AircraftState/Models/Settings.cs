﻿namespace AircraftState.Models
{
    public class Settings
    {
        public bool SetLocation { get; set; } = false;
        public bool SetFuel { get; set; } = false;
        public bool ShowApplyForm { get; set; } = true;
        public bool AutoSave { get; set; } = false;
        public bool ShowSaveAs { get; set; } = true;
        public bool SendExtendedData { get; set; } = true;
    }
}