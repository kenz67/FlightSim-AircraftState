using AircraftState.enums;
using AircraftState.Models;
using AircraftState.Services;
using AircraftState.Services.Helpers;
using System;
using System.Windows.Forms;

namespace AircraftState.Forms
{
    public partial class SendToSimForm : Form
    {
        public bool OK { get; set; }
        public bool SendFuel { get; set; }
        public bool SendLocation { get; set; }
        public PlaneData PlaneData { get; private set; }

        private string Plane;
        private readonly DbData dbData;

        public SendToSimForm()
        {
            InitializeComponent();
            dbData = new DbData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var data = dbData.GetSavedPlanes().ToArray();

            comboBoxSettingsFrom.Items.Clear();

            if (data?.Length > 0)
            {
                comboBoxSettingsFrom.Items.Add("Select stored data to send");
                comboBoxSettingsFrom.Items.AddRange(dbData.GetSavedPlanes().ToArray());
                comboBoxSettingsFrom.SelectedText = Plane;
            }
            else
            {
                comboBoxSettingsFrom.Items.Add("No saved data to send");
                comboBoxSettingsFrom.SelectedIndex = 0;
            }

            checkBoxSendFuel.Checked = DbSettings.Settings.SetFuel;
            checkBoxSendLocation.Checked = DbSettings.Settings.SetLocation;
        }

        public void ApplyData(string plane)
        {
            if (string.IsNullOrEmpty(labelAircraft.Text))
            {
                labelAircraft.Text = plane;
            }
            Plane = plane;

            PlaneData = dbData.GetData(plane);

            textBoxCom1Active.Text = PlaneData.com1Active.ToString("N3");
            textBoxCom1Standby.Text = PlaneData.com1Standby.ToString("N3");
            textBoxCom2Active.Text = PlaneData.com2Active.ToString("N3");
            textBoxCom2Standby.Text = PlaneData.com2Standby.ToString("N3");
            textBoxNav1Active.Text = PlaneData.nav1Active.ToString("N2");
            textBoxNav1Standby.Text = PlaneData.nav1Standby.ToString("N2");
            textBoxNav2Active.Text = PlaneData.nav2Active.ToString("N2");
            textBoxNav2Standby.Text = PlaneData.nav2Standby.ToString("N2");
            textBoxAdfActive.Text = Math.Round(1000 * PlaneData.adfActive, 1).ToString("000.0");
            textBoxAdfStandby.Text = Math.Round(1000 * PlaneData.adfActive, 1).ToString("000.0");

            textBoxObsObs1.Text = PlaneData.obs1.ToString("N0");
            textBoxObsObs2.Text = PlaneData.obs2.ToString("N0");
            textBoxObsAdf.Text = PlaneData.adfCard.ToString("N0");

            textBoxLocationLat.Text = Formatter.GetLatLong(PlaneData.latitude, true);
            textBoxLocationLong.Text = Formatter.GetLatLong(PlaneData.longitude, false);

            textBoxLocationAltitude.Text = PlaneData.altitude.ToString();
            textBoxLocationHeading.Text = PlaneData.heading.ToString("N0");

            textBoxFuelLeft.Text = PlaneData.fuelLeft.ToString("N2");
            textBoxFuelRight.Text = PlaneData.fuelRight.ToString("N2");
            switch (PlaneData.fuelSelector)
            {
                case 0: textBoxFuelSelector.Text = "Off"; break;
                case 1: textBoxFuelSelector.Text = "Both"; break;
                case 2: textBoxFuelSelector.Text = "Left"; break;
                case 3: textBoxFuelSelector.Text = "Right"; break;
                default: textBoxFuelSelector.Text = PlaneData.fuelSelector.ToString(); break;
            }

            textBoxOtherParkingBrake.Text = PlaneData.parkingBrake ? "On" : "Off";
            textBoxOtherKolhsman.Text = PlaneData.kohlsman.ToString("N2");
            textBoxOtherHeadingBug.Text = PlaneData.headingBug.ToString();
            textBoxFlaps.Text = PlaneData.flapsIndex.ToString();
            var nodeDown = Math.Round(PlaneData.elevtorTrim, 2) < 0 ? "Nose Down" : String.Empty;
            textBoxTrim.Text = $"{Math.Abs(PlaneData.elevtorTrim):N2} {(Math.Round(PlaneData.elevtorTrim, 2) > 0 ? "Nose Up" : nodeDown)}";
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            OK = true;

            if (checkBoxHide.Checked)
            {
                DbSettings.SaveSettings(SettingDefinitions.ShowApplyForm, false);
            }

            SendFuel = checkBoxSendFuel.Checked;
            SendLocation = checkBoxSendLocation.Checked;

            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxSettingsFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyData(comboBoxSettingsFrom.SelectedItem.ToString());
        }
    }
}