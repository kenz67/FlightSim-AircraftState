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
            checkBoxShowSaveAs.Checked = DbSettings.Settings.ShowSaveAs;

            toolTip.SetToolTip(checkBoxShowSummary, "If checked, A summary page will be shown before sending to sim. If not, data sent without showing summary");
            toolTip.SetToolTip(checkBoxAutoSave, "If checked, State will be sent to the DB automatically when the combination of Master Battery, Master Alt and Avionics Master are all turned off");
            toolTip.SetToolTip(checkBoxUpdateFuel, "If checked, Fuel will be updated when sending data to the sim.  If not, default fuel will be used");
            toolTip.SetToolTip(checkBoxUpdatePlaneLocation, "If checked, the aircraft location will be updated when sending data to the sim.  If not, default location will be used");
            toolTip.SetToolTip(checkBoxShowSaveAs, "If checked, when clicking save to Db a popup will prompt for the name to save as");
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            var settings = new Settings
            {
                AutoSave = checkBoxAutoSave.Checked,
                ShowApplyForm = checkBoxShowSummary.Checked,
                SetFuel = checkBoxUpdateFuel.Checked,
                SetLocation = checkBoxUpdatePlaneLocation.Checked,
                ShowSaveAs = checkBoxShowSaveAs.Checked,
            };

            DbSettings.SaveAllSettings(settings);
            this.Close();
        }
    }
}