using AircraftState.Models;
using AircraftState.Services;
using System;
using System.Windows.Forms;

namespace AircraftState.Forms
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();

            var toolTip = new ToolTip();

            checkBoxShowSummary.Checked = DbSettings.Settings.ShowApplyForm;
            checkBoxUpdateFuel.Checked = DbSettings.Settings.SetFuel;
            checkBoxUpdatePlaneLocation.Checked = DbSettings.Settings.SetLocation;

            toolTip.SetToolTip(checkBoxShowSummary, "If checked, A summary page will be shown before sending to sim. If not, data sent without showing summary");
            toolTip.SetToolTip(checkBoxAutoSave, "If checked, State will be sent to the DB automatically when the combination of Master Battery, Master Alt and Avionics Master are all turned off");
            toolTip.SetToolTip(checkBoxUpdateFuel, "If checked, Fuel will be updated when sending data to the sim.  If not, default fuel will be used");
            toolTip.SetToolTip(checkBoxUpdatePlaneLocation, "If checked, the aircraft location will be updated when sending data to the sim.  If not, default location will be used");
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            var settings = new Settings
            {
                AutoSave = checkBoxAutoSave.Checked,
                ShowApplyForm = checkBoxShowSummary.Checked,
                SetFuel = checkBoxUpdateFuel.Checked,
                SetLocation = checkBoxUpdatePlaneLocation.Checked
            };

            DbSettings.SaveAllSettings(settings);
            this.Close();
        }
    }
}