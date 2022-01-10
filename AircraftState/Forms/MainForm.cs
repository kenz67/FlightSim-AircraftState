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

            var noseDown = Math.Round(planeData.elevtorTrim, 3) >= 0 ? string.Empty : "Nose Down";
            textBoxTrim.Text = $"{Math.Abs(planeData.elevtorTrim):N3} {(Math.Round(planeData.elevtorTrim, 3) > 0 ? "Nose Up" : noseDown) }";

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

        public void ShowSimEnvironmentDataOnForm(MasterData envData)
        {
            //todo: make aircraft selection combo-box so you cacn select other planes?
            labelAircraft.Text = envData.title;
            Title = envData.title;
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            var dataFromDb = new DbData().GetData(Title);
            bool sendFuel;
            bool sendLocation;

            if (!dataFromDb.validData)
            {
                MessageBox.Show("No data found in db", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DbSettings.Settings.ShowApplyForm)
            {
                var sendToSimForm = new SendToSimForm();
                sendToSimForm.ApplyData(Title, dataFromDb);
                sendToSimForm.ShowDialog();
                if (!sendToSimForm.OK)
                {
                    return;
                }

                sendFuel = sendToSimForm.SendFuel;
                sendLocation = sendToSimForm.SendLocation;
            }
            else
            {
                sendFuel = DbSettings.Settings.SetFuel;
                sendLocation = DbSettings.Settings.SetLocation;
            }

            SimConnect.SendDataToSim(dataFromDb, sendFuel, sendLocation);
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

            toolStripStatusLabelConnected.Text = "Connected to sim";
            toolStripStatusLabelConnected.BackColor = Color.MediumBlue;
            toolStripStatusLabelConnected.ForeColor = Color.White;
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsDialog = new SettingForm();
            settingsDialog.ShowDialog();
        }

        private void ButtonSaveToDb_Click(object sender, EventArgs e)
        {
            SimConnect.SaveDataToDb();
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
