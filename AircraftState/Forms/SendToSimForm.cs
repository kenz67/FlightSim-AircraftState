using AircraftState.enums;
using AircraftState.Models;
using AircraftState.Services;
using AircraftState.Services.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AircraftState.Forms
{
    public partial class SendToSimForm : Form
    {
        public bool OK = false;
        public bool sendFuel = false;
        public bool sendLocation = false;

        public SendToSimForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxSendFuel.Checked = DbSettings.Settings.SetFuel;
            checkBoxSendLocation.Checked = DbSettings.Settings.SetLocation;
        }

        public void ApplyData(string plane, PlaneData planeData)
        {
            labelAircraft.Text = plane;

            textBoxCom1Active.Text = planeData.com1Active.ToString("N3");
            textBoxCom1Standby.Text = planeData.com1Standby.ToString("N3");
            textBoxCom2Active.Text = planeData.com2Active.ToString("N3");
            textBoxCom2Standby.Text = planeData.com2Standby.ToString("N3");
            textBoxNav1Active.Text = planeData.nav1Active.ToString("N2");
            textBoxNav1Standby.Text = planeData.nav1Standby.ToString("N2");
            textBoxNav2Active.Text = planeData.nav2Active.ToString("N2");
            textBoxNav2Standby.Text = planeData.nav2Standby.ToString("N2");
            textBoxAdfActive.Text = (1000 * planeData.adfActive).ToString("000.0");
            textBoxAdfStandby.Text = (1000 * planeData.adfStandby).ToString("000.0");

            textBoxObsObs1.Text = planeData.obs1.ToString("N0");
            textBoxObsObs2.Text = planeData.obs2.ToString("N0");
            textBoxObsAdf.Text = planeData.adfCard.ToString("N0");

            textBoxLocationLat.Text = Formatter.GetLatLong(planeData.latitude, true);
            textBoxLocationLong.Text = Formatter.GetLatLong(planeData.longitude, false);

            textBoxLocationAltitude.Text = planeData.altitude.ToString();
            textBoxLocationHeading.Text = planeData.heading.ToString("N0");

            textBoxFuelLeft.Text = planeData.fuelLeft.ToString("N2");
            textBoxFuelRight.Text = planeData.fuelRight.ToString("N2");
            switch (planeData.fuelSelector)
            {
                case 0: textBoxFuelSelector.Text = "Off"; break;
                case 1: textBoxFuelSelector.Text = "Both"; break;
                case 2: textBoxFuelSelector.Text = "Left"; break;
                case 3: textBoxFuelSelector.Text = "Right"; break;
                default: textBoxFuelSelector.Text = planeData.fuelSelector.ToString(); break;
            }

            textBoxOtherParkingBrake.Text = planeData.parkingBrake ? "On" : "Off";
            textBoxOtherKolhsman.Text = planeData.kohlsman.ToString("N2");
            textBoxOtherHeadingBug.Text = planeData.headingBug.ToString();
            textBoxFlaps.Text = planeData.flapsIndex.ToString();
            textBoxTrim.Text = $"{Math.Abs(planeData.elevtorTrim):N2} {(Math.Round(planeData.elevtorTrim, 2) > 0 ? "Nose Up" : (Math.Round(planeData.elevtorTrim, 2) < 0 ? "Nose Down" : String.Empty))}";
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            OK = true;

            if (checkBoxHide.Checked)
            {
                DbSettings.SaveSettings(SettingDefinitions.ShowApplyForm, false);
            }

            sendFuel = checkBoxSendFuel.Checked;
            sendLocation = checkBoxSendLocation.Checked;

            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
