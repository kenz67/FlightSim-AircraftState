﻿using AircraftState.enums;
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
        public bool SendExtendedData { get; set; }

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

                if (comboBoxSettingsFrom.FindStringExact(Plane) != -1)
                {
                    comboBoxSettingsFrom.SelectedText = Plane;
                }
                else
                {
                    comboBoxSettingsFrom.SelectedIndex = 0;
                }
            }
            else
            {
                comboBoxSettingsFrom.Items.Add("No saved data to send");
                comboBoxSettingsFrom.SelectedIndex = 0;
            }

            checkBoxSendFuel.Checked = DbSettings.Settings.SetFuel;
            checkBoxSendLocation.Checked = DbSettings.Settings.SetLocation;
            checkBoxSendExtendedData.Checked = DbSettings.Settings.SendExtendedData;
        }

        public void ApplyData(string plane)
        {
            if (string.IsNullOrEmpty(labelAircraft.Text))
            {
                labelAircraft.Text = plane;
            }
            Plane = plane;

            PlaneData = dbData.GetData(plane);
            MainDataTab(PlaneData);
            ExtendedTab(PlaneData);
        }

        private void MainDataTab(PlaneData PlaneData)
        {
            textBoxCom1Active.Text = PlaneData.com1Active.ToString("N3");
            textBoxCom1Standby.Text = PlaneData.com1Standby.ToString("N3");
            textBoxCom2Active.Text = PlaneData.com2Active.ToString("N3");
            textBoxCom2Standby.Text = PlaneData.com2Standby.ToString("N3");
            textBoxNav1Active.Text = PlaneData.nav1Active.ToString("N2");
            textBoxNav1Standby.Text = PlaneData.nav1Standby.ToString("N2");
            textBoxNav2Active.Text = PlaneData.nav2Active.ToString("N2");
            textBoxNav2Standby.Text = PlaneData.nav2Standby.ToString("N2");
            textBoxAdfActive.Text = Math.Round(1000 * PlaneData.adfActive, 1).ToString("000.0");
            textBoxAdfStandby.Text = Math.Round(1000 * PlaneData.adfStandby, 1).ToString("000.0");

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
            var rudderLeft = Math.Round(PlaneData.rudderTrim, 3) >= 0 ? string.Empty : "% Lft";
            var aileronLeft = Math.Round(PlaneData.aileronTrim, 3) >= 0 ? string.Empty : "% Lft";

            textBoxTrim.Text = $"{Math.Abs(PlaneData.elevtorTrim):N2} {(Math.Round(PlaneData.elevtorTrim, 2) > 0 ? "Nose Up" : nodeDown)}";            
            textBoxRudderTrim.Text = $"{Math.Abs(PlaneData.rudderTrim):N3} {(Math.Round(PlaneData.rudderTrim, 1) > 0 ? "% Rgt" : rudderLeft)}";
            textBoxAileronTrim.Text = $"{Math.Abs(PlaneData.aileronTrim):N3} {(Math.Round(PlaneData.aileronTrim, 1) > 0 ? "% Rgt" : aileronLeft)}";

            if (PlaneData.batteryVoltage == 0)
            {
                PlaneData.batteryVoltage = 25;
            }
            tbBatteryVolts.Text = PlaneData.batteryVoltage.ToString();
        }

        private void ExtendedTab(PlaneData planeData)
        {
            textBoxMasterBattery.Text = Formatter.GetOnOff(planeData.masterBattery);
            textBoxMasterAlt.Text = Formatter.GetOnOff(planeData.masterAlternator);
            textBoxAvionicsMaster.Text = Formatter.GetOnOff(planeData.masterAvionics);
            textBoxNavLight.Text = Formatter.GetOnOff(planeData.lightNav);
            textBoxBeaconLight.Text = Formatter.GetOnOff(planeData.lightBeacon);
            textBoxLandingLight.Text = Formatter.GetOnOff(planeData.lightLanding);
            textBoxTaxiLight.Text = Formatter.GetOnOff(planeData.lightTaxi);
            textBoxStrobeLight.Text = Formatter.GetOnOff(planeData.lightStrobe);
            textBoxPanelLight.Text = Formatter.GetOnOff(planeData.lightPanel);
            textBoxCabinLight.Text = Formatter.GetOnOff(planeData.lightCabin);
            textBoxLogoLight.Text = Formatter.GetOnOff(planeData.lightLogo);
            textBox2WingLight.Text = Formatter.GetOnOff(planeData.lightWing);
            textBoxRecognitionLight.Text = Formatter.GetOnOff(planeData.lightRecognition);
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
            SendExtendedData = checkBoxSendExtendedData.Checked;

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

        private void ButtonDeleteProfile_Click(object sender, EventArgs e)
        {
            var selectedItem = comboBoxSettingsFrom.FindStringExact(comboBoxSettingsFrom.Text);

            new DbData().DeleteSavedProfile(comboBoxSettingsFrom.Text);
            comboBoxSettingsFrom.Items.RemoveAt(selectedItem);
            comboBoxSettingsFrom.SelectedIndex = 0;
        }
    }
}