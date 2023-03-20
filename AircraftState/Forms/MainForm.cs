using AircraftState.Models;
using AircraftState.Services;
using AircraftState.Services.Helpers;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AircraftState.Forms
{
    public partial class MainForm : Form
    {
        private readonly ISimConnectService SimConnect;
        public string Title { get; set; } = string.Empty;

        public MainForm()
        {
            string appDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\AircraftState";
            if (!Directory.Exists(appDir))
            {
                Directory.CreateDirectory(appDir);
            }

            var CreateDb = new ConfigureDb();

            CreateDb.InitDb();
            InitializeComponent();

            // this.BackColor = Color.White;
            SimConnect = new SimConnectService(this);
            //SimConnect = new TestConnectClass(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelConnected.Text = "Not connected to sim";
            toolStripStatusLabelConnected.BackColor = Color.Red;
            toolStripStatusLabelConnected.ForeColor = Color.White;

            var toolTipButtonSend = new ToolTip();
            toolTipButtonSend.SetToolTip(buttonSend, "Send saved data to the sim, usually at the start of the flight");

            var toolTipButtonSave = new ToolTip();
            toolTipButtonSave.SetToolTip(buttonSaveToDb, "Save the current data from the sim for future use, usually at end of the flight");

            var toolTipButtonConnect = new ToolTip();
            toolTipButtonConnect.SetToolTip(buttonConnect, "Reconnect to sim if connection has been lost");

            this.Text = $"Aircraft State - {Application.ProductVersion}";

            // calculate when build was done

            //var days = int.Parse(Application.ProductVersion.Split('.')[2]);
            //var seconds = int.Parse(Application.ProductVersion.Split('.')[3]) * 2;
            //var builddate = DateTime.Parse("2000-01-01T00:00:00").AddDays(days).ToShortDateString();
            //var buildtime = DateTime.Now.Subtract(DateTime.Now.TimeOfDay).AddSeconds(seconds).ToShortTimeString();
        }

        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == SimConnectService.WM_USER_SIMCONNECT)
            {
                if (SimConnect.Sim != null)
                {
                    try
                    {
                        SimConnect.Sim.ReceiveMessage();
                    }
                    catch /*(Exception ex)*/
                    {
                        toolStripStatusLabelConnected.Text = "Connection to sim lost";
                        toolStripStatusLabelConnected.BackColor = Color.Red;
                        toolStripStatusLabelConnected.ForeColor = Color.White;
                    }
                }
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }

        public void ShowSimDataOnForm(PlaneData planeData)
        {
            UpdateMainTab(planeData);
            UpdateExtendedTab(planeData);

            if (string.IsNullOrEmpty(Title))
            {
                SimConnect.GetSimEnvInfo();
            }

            if (ApplicationStatic.ReadyToAutoSave)
            {
                toolStripStatusAutoSave.Text = "Autosave";
            }
            else
            {
                toolStripStatusAutoSave.Text = string.Empty;
            }
        }

        private void UpdateMainTab(PlaneData planeData)
        {
            toolStripStatusLabelConnected.Text = "Connected to sim";
            toolStripStatusLabelConnected.BackColor = Color.MediumBlue;
            toolStripStatusLabelConnected.ForeColor = Color.White;

            textBoxCom1Active.Text = planeData.com1Active.ToString("N3");
            textBoxCom1Standby.Text = planeData.com1Standby.ToString("N3");
            textBoxCom2Active.Text = planeData.com2Active.ToString("N3");
            textBoxCom2Standby.Text = planeData.com2Standby.ToString("N3");
            textBoxNav1Active.Text = planeData.nav1Active.ToString("N2");
            textBoxNav1Standby.Text = planeData.nav1Standby.ToString("N2");
            textBoxNav2Active.Text = planeData.nav2Active.ToString("N2");
            textBoxNav2Standby.Text = planeData.nav2Standby.ToString("N2");
            textBoxAdfActive.Text = Math.Round(1000 * planeData.adfActive, 1).ToString("000.0");
            textBoxAdfStandby.Text = Math.Round(1000 * planeData.adfStandby, 1).ToString("000.0");

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

            textBoxOtherParkingBrake.Text = Formatter.GetOnOff(planeData.parkingBrake);
            textBoxOtherKolhsman.Text = planeData.kohlsman.ToString("N2");
            textBoxOtherHeadingBug.Text = planeData.headingBug.ToString();

            textBoxFlaps.Text = planeData.flapsIndex.ToString();

            var noseDown = Math.Round(planeData.elevtorTrim, 3) >= 0 ? string.Empty : "Nose Down";
            var rudderLeft = Math.Round(planeData.rudderTrim, 1) >= 0 ? string.Empty : "% L";
            var aileronLeft = Math.Round(planeData.aileronTrim, 1) >= 0 ? string.Empty : "% L";
            textBoxTrim.Text = $"{Math.Abs(planeData.elevtorTrim):N3} {(Math.Round(planeData.elevtorTrim, 3) > 0 ? "Nose Up" : noseDown) }";
            textBoxRudderTrim.Text = $"{Math.Abs(planeData.rudderTrim):N3} {(Math.Round(planeData.rudderTrim, 1) > 0 ? "% R" : rudderLeft)}";
            textBoxAileronTrim.Text = $"{Math.Abs(planeData.aileronTrim):N3} {(Math.Round(planeData.aileronTrim, 1) > 0 ? "% R" : aileronLeft)}";
        }

        private void UpdateExtendedTab(PlaneData planeData)
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
            tbBatteryVolts.Text = planeData.batteryVoltage.ToString("N2");
        }

        public void ShowSimEnvironmentDataOnForm(MasterData envData)
        {
            labelAircraft.Text = envData.title;
            Title = envData.title;
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            bool sendFuel;
            bool sendLocation;
            bool sendExtended;

            if (DbSettings.Settings.ShowApplyForm)
            {
                var sendToSimForm = new SendToSimForm();
                sendToSimForm.ApplyData(Title);
                sendToSimForm.ShowDialog();
                if (!sendToSimForm.OK)
                {
                    return;
                }

                sendFuel = sendToSimForm.SendFuel;
                sendLocation = sendToSimForm.SendLocation;
                sendExtended = sendToSimForm.SendExtendedData;
                SimConnect.SendDataToSim(sendToSimForm.PlaneData, sendFuel, sendLocation, sendExtended);
            }
            else
            {
                var dataFromDb = new DbData().GetData(Title);
                if (!dataFromDb.validData)
                {
                    MessageBox.Show("No data found in db", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                sendFuel = DbSettings.Settings.SetFuel;
                sendLocation = DbSettings.Settings.SetLocation;
                sendExtended = DbSettings.Settings.SendExtendedData;
                SimConnect.SendDataToSim(dataFromDb, sendFuel, sendLocation, sendExtended);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (!SimConnect.ConnectToSim())
            {
                MessageBox.Show("Error Connecting", "Connect to sim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                toolStripStatusLabelConnected.Text = "Connected to sim";
                toolStripStatusLabelConnected.BackColor = Color.MediumBlue;
                toolStripStatusLabelConnected.ForeColor = Color.White;
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsDialog = new SettingForm();
            settingsDialog.ShowDialog();
        }

        private void ButtonSaveToDb_Click(object sender, EventArgs e)
        {
            if (DbSettings.Settings.ShowSaveAs)
            {
                var settingsName = Prompt.ShowDialog("Save Settings to Database", "Name to save as", "Save", Title, true);
                if (!string.IsNullOrEmpty(settingsName))
                {
                    SimConnect.SaveDataToDb(settingsName);
                }
            }
            else
            {
                SimConnect.SaveDataToDb(Title);
            }
        }

        public void ShowMessageBox(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var helpDialog = new Help();
            helpDialog.ShowDialog();
        }
    }
}