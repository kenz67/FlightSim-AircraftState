namespace AircraftState.enums
{
    public enum EVENT_IDS
    {
        NO_EVENT,

        COM_RADIO_SET_HZ,
        COM_STBY_RADIO_SET_HZ,
        COM2_RADIO_SET_HZ,
        COM2_STBY_RADIO_SET_HZ,
        NAV1_RADIO_SET_HZ,
        NAV1_STBY_SET_HZ,
        NAV2_RADIO_SET_HZ,
        NAV2_STBY_SET_HZ,
        ADF_SET,
        ADF_STBY_SET,
        ADF1_RADIO_SWAP,
        OBS1,
        OBS2,
        ADF_CARD_SET,
        FUEL_LEFT,
        FUEL_RIGHT,
        FUEL_SELECTOR_SET,
        PARKING_BRAKE_SET,
        HEADING_BUG_SET,
        KOHLSMAN_SET,
        FLAPS_UP,
        FLAPS_1,
        FLAPS_2,
        FLAPS_3,
        FLAPS_4,
        FLAPS_DOWN,

        COM_STBY_RADIO_SWAP,
        // Pause

        //Lights
        NAV_LIGHT,

        BEACON_LIGHT,
        LANDING_LIGHT,
        TAXI_LIGHT,
        STROBE_LIGHT,
        PANEL_LIGHT,
        RECOGNITION_LIGHT,
        WING_LIGHT,
        CABIN_LIGHT,
        LOGO_LIGHT,

        //Power
        MASTER_BATTERY,
        MASTER_ALTERNATOR,
        AVIONICS_MASTER,
        ELECTRICAL_BATTERY_BUS_VOLTAGE,
    }
}