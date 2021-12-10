﻿namespace AircraftState.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBoxRadio = new System.Windows.Forms.GroupBox();
            this.textBoxAdfStandby = new System.Windows.Forms.TextBox();
            this.textBoxAdfActive = new System.Windows.Forms.TextBox();
            this.textBoxNav2Standby = new System.Windows.Forms.TextBox();
            this.textBoxNav2Active = new System.Windows.Forms.TextBox();
            this.textBoxNav1Standby = new System.Windows.Forms.TextBox();
            this.textBoxNav1Active = new System.Windows.Forms.TextBox();
            this.textBoxCom2Standby = new System.Windows.Forms.TextBox();
            this.textBoxCom2Active = new System.Windows.Forms.TextBox();
            this.textBoxCom1Standby = new System.Windows.Forms.TextBox();
            this.textBoxCom1Active = new System.Windows.Forms.TextBox();
            this.labelAdf = new System.Windows.Forms.Label();
            this.labelNav2 = new System.Windows.Forms.Label();
            this.labelNav1 = new System.Windows.Forms.Label();
            this.labelCom2 = new System.Windows.Forms.Label();
            this.labelCom1 = new System.Windows.Forms.Label();
            this.labelStandBy = new System.Windows.Forms.Label();
            this.labelActive = new System.Windows.Forms.Label();
            this.groupFuel = new System.Windows.Forms.GroupBox();
            this.textBoxFuelSelector = new System.Windows.Forms.TextBox();
            this.textBoxFuelRight = new System.Windows.Forms.TextBox();
            this.textBoxFuelLeft = new System.Windows.Forms.TextBox();
            this.labelFuelSelector = new System.Windows.Forms.Label();
            this.labelFuelRight = new System.Windows.Forms.Label();
            this.labelFuelLeft = new System.Windows.Forms.Label();
            this.groupLocation = new System.Windows.Forms.GroupBox();
            this.textBoxLocationHeading = new System.Windows.Forms.TextBox();
            this.labelHeading = new System.Windows.Forms.Label();
            this.textBoxLocationAltitude = new System.Windows.Forms.TextBox();
            this.textBoxLocationLat = new System.Windows.Forms.TextBox();
            this.textBoxLocationLong = new System.Windows.Forms.TextBox();
            this.labelAltitude = new System.Windows.Forms.Label();
            this.labelLocationLat = new System.Windows.Forms.Label();
            this.labelLocationLong = new System.Windows.Forms.Label();
            this.groupBoxOBS = new System.Windows.Forms.GroupBox();
            this.textBoxObsAdf = new System.Windows.Forms.TextBox();
            this.textBoxObsObs2 = new System.Windows.Forms.TextBox();
            this.textBoxObsObs1 = new System.Windows.Forms.TextBox();
            this.labelObsAdf = new System.Windows.Forms.Label();
            this.labelObsObs2 = new System.Windows.Forms.Label();
            this.labelObsObs1 = new System.Windows.Forms.Label();
            this.groupBoxOther = new System.Windows.Forms.GroupBox();
            this.textBoxOtherParkingBrake = new System.Windows.Forms.TextBox();
            this.textBoxOtherHeadingBug = new System.Windows.Forms.TextBox();
            this.textBoxOtherKolhsman = new System.Windows.Forms.TextBox();
            this.labelOtherParkBreak = new System.Windows.Forms.Label();
            this.labelOtherHeadingBug = new System.Windows.Forms.Label();
            this.labelOtherKohlsman = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonSaveToDb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAircraft = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFlaps = new System.Windows.Forms.TextBox();
            this.groupBoxRadio.SuspendLayout();
            this.groupFuel.SuspendLayout();
            this.groupLocation.SuspendLayout();
            this.groupBoxOBS.SuspendLayout();
            this.groupBoxOther.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRadio
            // 
            this.groupBoxRadio.Controls.Add(this.textBoxAdfStandby);
            this.groupBoxRadio.Controls.Add(this.textBoxAdfActive);
            this.groupBoxRadio.Controls.Add(this.textBoxNav2Standby);
            this.groupBoxRadio.Controls.Add(this.textBoxNav2Active);
            this.groupBoxRadio.Controls.Add(this.textBoxNav1Standby);
            this.groupBoxRadio.Controls.Add(this.textBoxNav1Active);
            this.groupBoxRadio.Controls.Add(this.textBoxCom2Standby);
            this.groupBoxRadio.Controls.Add(this.textBoxCom2Active);
            this.groupBoxRadio.Controls.Add(this.textBoxCom1Standby);
            this.groupBoxRadio.Controls.Add(this.textBoxCom1Active);
            this.groupBoxRadio.Controls.Add(this.labelAdf);
            this.groupBoxRadio.Controls.Add(this.labelNav2);
            this.groupBoxRadio.Controls.Add(this.labelNav1);
            this.groupBoxRadio.Controls.Add(this.labelCom2);
            this.groupBoxRadio.Controls.Add(this.labelCom1);
            this.groupBoxRadio.Controls.Add(this.labelStandBy);
            this.groupBoxRadio.Controls.Add(this.labelActive);
            this.groupBoxRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRadio.Location = new System.Drawing.Point(30, 78);
            this.groupBoxRadio.Name = "groupBoxRadio";
            this.groupBoxRadio.Size = new System.Drawing.Size(253, 188);
            this.groupBoxRadio.TabIndex = 1;
            this.groupBoxRadio.TabStop = false;
            this.groupBoxRadio.Text = "Radios";
            // 
            // textBoxAdfStandby
            // 
            this.textBoxAdfStandby.Location = new System.Drawing.Point(171, 151);
            this.textBoxAdfStandby.Name = "textBoxAdfStandby";
            this.textBoxAdfStandby.ReadOnly = true;
            this.textBoxAdfStandby.Size = new System.Drawing.Size(56, 20);
            this.textBoxAdfStandby.TabIndex = 16;
            // 
            // textBoxAdfActive
            // 
            this.textBoxAdfActive.Location = new System.Drawing.Point(89, 151);
            this.textBoxAdfActive.Name = "textBoxAdfActive";
            this.textBoxAdfActive.ReadOnly = true;
            this.textBoxAdfActive.Size = new System.Drawing.Size(56, 20);
            this.textBoxAdfActive.TabIndex = 15;
            // 
            // textBoxNav2Standby
            // 
            this.textBoxNav2Standby.Location = new System.Drawing.Point(171, 125);
            this.textBoxNav2Standby.Name = "textBoxNav2Standby";
            this.textBoxNav2Standby.ReadOnly = true;
            this.textBoxNav2Standby.Size = new System.Drawing.Size(56, 20);
            this.textBoxNav2Standby.TabIndex = 14;
            // 
            // textBoxNav2Active
            // 
            this.textBoxNav2Active.Location = new System.Drawing.Point(89, 125);
            this.textBoxNav2Active.Name = "textBoxNav2Active";
            this.textBoxNav2Active.ReadOnly = true;
            this.textBoxNav2Active.Size = new System.Drawing.Size(56, 20);
            this.textBoxNav2Active.TabIndex = 13;
            // 
            // textBoxNav1Standby
            // 
            this.textBoxNav1Standby.Location = new System.Drawing.Point(171, 99);
            this.textBoxNav1Standby.Name = "textBoxNav1Standby";
            this.textBoxNav1Standby.ReadOnly = true;
            this.textBoxNav1Standby.Size = new System.Drawing.Size(56, 20);
            this.textBoxNav1Standby.TabIndex = 12;
            // 
            // textBoxNav1Active
            // 
            this.textBoxNav1Active.Location = new System.Drawing.Point(89, 99);
            this.textBoxNav1Active.Name = "textBoxNav1Active";
            this.textBoxNav1Active.ReadOnly = true;
            this.textBoxNav1Active.Size = new System.Drawing.Size(56, 20);
            this.textBoxNav1Active.TabIndex = 11;
            // 
            // textBoxCom2Standby
            // 
            this.textBoxCom2Standby.Location = new System.Drawing.Point(171, 70);
            this.textBoxCom2Standby.Name = "textBoxCom2Standby";
            this.textBoxCom2Standby.ReadOnly = true;
            this.textBoxCom2Standby.Size = new System.Drawing.Size(56, 20);
            this.textBoxCom2Standby.TabIndex = 10;
            // 
            // textBoxCom2Active
            // 
            this.textBoxCom2Active.Location = new System.Drawing.Point(89, 70);
            this.textBoxCom2Active.Name = "textBoxCom2Active";
            this.textBoxCom2Active.ReadOnly = true;
            this.textBoxCom2Active.Size = new System.Drawing.Size(56, 20);
            this.textBoxCom2Active.TabIndex = 9;
            // 
            // textBoxCom1Standby
            // 
            this.textBoxCom1Standby.Location = new System.Drawing.Point(171, 44);
            this.textBoxCom1Standby.Name = "textBoxCom1Standby";
            this.textBoxCom1Standby.ReadOnly = true;
            this.textBoxCom1Standby.Size = new System.Drawing.Size(56, 20);
            this.textBoxCom1Standby.TabIndex = 8;
            // 
            // textBoxCom1Active
            // 
            this.textBoxCom1Active.Location = new System.Drawing.Point(89, 44);
            this.textBoxCom1Active.Name = "textBoxCom1Active";
            this.textBoxCom1Active.ReadOnly = true;
            this.textBoxCom1Active.Size = new System.Drawing.Size(56, 20);
            this.textBoxCom1Active.TabIndex = 7;
            // 
            // labelAdf
            // 
            this.labelAdf.AutoSize = true;
            this.labelAdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdf.Location = new System.Drawing.Point(26, 151);
            this.labelAdf.Name = "labelAdf";
            this.labelAdf.Size = new System.Drawing.Size(35, 13);
            this.labelAdf.TabIndex = 6;
            this.labelAdf.Text = "ADF:";
            // 
            // labelNav2
            // 
            this.labelNav2.AutoSize = true;
            this.labelNav2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNav2.Location = new System.Drawing.Point(26, 125);
            this.labelNav2.Name = "labelNav2";
            this.labelNav2.Size = new System.Drawing.Size(45, 13);
            this.labelNav2.TabIndex = 5;
            this.labelNav2.Text = "Nav 2:";
            // 
            // labelNav1
            // 
            this.labelNav1.AutoSize = true;
            this.labelNav1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNav1.Location = new System.Drawing.Point(27, 99);
            this.labelNav1.Name = "labelNav1";
            this.labelNav1.Size = new System.Drawing.Size(45, 13);
            this.labelNav1.TabIndex = 4;
            this.labelNav1.Text = "Nav 1:";
            // 
            // labelCom2
            // 
            this.labelCom2.AutoSize = true;
            this.labelCom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCom2.Location = new System.Drawing.Point(26, 70);
            this.labelCom2.Name = "labelCom2";
            this.labelCom2.Size = new System.Drawing.Size(46, 13);
            this.labelCom2.TabIndex = 3;
            this.labelCom2.Text = "Com 2:";
            // 
            // labelCom1
            // 
            this.labelCom1.AutoSize = true;
            this.labelCom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCom1.Location = new System.Drawing.Point(27, 44);
            this.labelCom1.Name = "labelCom1";
            this.labelCom1.Size = new System.Drawing.Size(46, 13);
            this.labelCom1.TabIndex = 2;
            this.labelCom1.Text = "Com 1:";
            // 
            // labelStandBy
            // 
            this.labelStandBy.AutoSize = true;
            this.labelStandBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStandBy.Location = new System.Drawing.Point(169, 20);
            this.labelStandBy.Name = "labelStandBy";
            this.labelStandBy.Size = new System.Drawing.Size(58, 13);
            this.labelStandBy.TabIndex = 1;
            this.labelStandBy.Text = "Stand By";
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActive.Location = new System.Drawing.Point(102, 20);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(43, 13);
            this.labelActive.TabIndex = 0;
            this.labelActive.Text = "Active";
            // 
            // groupFuel
            // 
            this.groupFuel.Controls.Add(this.textBoxFuelSelector);
            this.groupFuel.Controls.Add(this.textBoxFuelRight);
            this.groupFuel.Controls.Add(this.textBoxFuelLeft);
            this.groupFuel.Controls.Add(this.labelFuelSelector);
            this.groupFuel.Controls.Add(this.labelFuelRight);
            this.groupFuel.Controls.Add(this.labelFuelLeft);
            this.groupFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupFuel.Location = new System.Drawing.Point(421, 290);
            this.groupFuel.Name = "groupFuel";
            this.groupFuel.Size = new System.Drawing.Size(176, 127);
            this.groupFuel.TabIndex = 17;
            this.groupFuel.TabStop = false;
            this.groupFuel.Text = "Fuel";
            // 
            // textBoxFuelSelector
            // 
            this.textBoxFuelSelector.Location = new System.Drawing.Point(90, 87);
            this.textBoxFuelSelector.Name = "textBoxFuelSelector";
            this.textBoxFuelSelector.ReadOnly = true;
            this.textBoxFuelSelector.Size = new System.Drawing.Size(56, 20);
            this.textBoxFuelSelector.TabIndex = 11;
            // 
            // textBoxFuelRight
            // 
            this.textBoxFuelRight.Location = new System.Drawing.Point(90, 58);
            this.textBoxFuelRight.Name = "textBoxFuelRight";
            this.textBoxFuelRight.ReadOnly = true;
            this.textBoxFuelRight.Size = new System.Drawing.Size(56, 20);
            this.textBoxFuelRight.TabIndex = 9;
            // 
            // textBoxFuelLeft
            // 
            this.textBoxFuelLeft.Location = new System.Drawing.Point(90, 32);
            this.textBoxFuelLeft.Name = "textBoxFuelLeft";
            this.textBoxFuelLeft.ReadOnly = true;
            this.textBoxFuelLeft.Size = new System.Drawing.Size(56, 20);
            this.textBoxFuelLeft.TabIndex = 7;
            // 
            // labelFuelSelector
            // 
            this.labelFuelSelector.AutoSize = true;
            this.labelFuelSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelSelector.Location = new System.Drawing.Point(28, 87);
            this.labelFuelSelector.Name = "labelFuelSelector";
            this.labelFuelSelector.Size = new System.Drawing.Size(58, 13);
            this.labelFuelSelector.TabIndex = 4;
            this.labelFuelSelector.Text = "Selector:";
            // 
            // labelFuelRight
            // 
            this.labelFuelRight.AutoSize = true;
            this.labelFuelRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelRight.Location = new System.Drawing.Point(27, 58);
            this.labelFuelRight.Name = "labelFuelRight";
            this.labelFuelRight.Size = new System.Drawing.Size(41, 13);
            this.labelFuelRight.TabIndex = 3;
            this.labelFuelRight.Text = "Right:";
            // 
            // labelFuelLeft
            // 
            this.labelFuelLeft.AutoSize = true;
            this.labelFuelLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelLeft.Location = new System.Drawing.Point(28, 32);
            this.labelFuelLeft.Name = "labelFuelLeft";
            this.labelFuelLeft.Size = new System.Drawing.Size(33, 13);
            this.labelFuelLeft.TabIndex = 2;
            this.labelFuelLeft.Text = "Left:";
            // 
            // groupLocation
            // 
            this.groupLocation.Controls.Add(this.textBoxLocationHeading);
            this.groupLocation.Controls.Add(this.labelHeading);
            this.groupLocation.Controls.Add(this.textBoxLocationAltitude);
            this.groupLocation.Controls.Add(this.textBoxLocationLat);
            this.groupLocation.Controls.Add(this.textBoxLocationLong);
            this.groupLocation.Controls.Add(this.labelAltitude);
            this.groupLocation.Controls.Add(this.labelLocationLat);
            this.groupLocation.Controls.Add(this.labelLocationLong);
            this.groupLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLocation.Location = new System.Drawing.Point(308, 78);
            this.groupLocation.Name = "groupLocation";
            this.groupLocation.Size = new System.Drawing.Size(176, 142);
            this.groupLocation.TabIndex = 18;
            this.groupLocation.TabStop = false;
            this.groupLocation.Text = "Location";
            // 
            // textBoxLocationHeading
            // 
            this.textBoxLocationHeading.Location = new System.Drawing.Point(101, 114);
            this.textBoxLocationHeading.Name = "textBoxLocationHeading";
            this.textBoxLocationHeading.ReadOnly = true;
            this.textBoxLocationHeading.Size = new System.Drawing.Size(56, 20);
            this.textBoxLocationHeading.TabIndex = 13;
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.Location = new System.Drawing.Point(27, 114);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(58, 13);
            this.labelHeading.TabIndex = 12;
            this.labelHeading.Text = "Heading:";
            // 
            // textBoxLocationAltitude
            // 
            this.textBoxLocationAltitude.Location = new System.Drawing.Point(102, 87);
            this.textBoxLocationAltitude.Name = "textBoxLocationAltitude";
            this.textBoxLocationAltitude.ReadOnly = true;
            this.textBoxLocationAltitude.Size = new System.Drawing.Size(56, 20);
            this.textBoxLocationAltitude.TabIndex = 11;
            // 
            // textBoxLocationLat
            // 
            this.textBoxLocationLat.Location = new System.Drawing.Point(102, 58);
            this.textBoxLocationLat.Name = "textBoxLocationLat";
            this.textBoxLocationLat.ReadOnly = true;
            this.textBoxLocationLat.Size = new System.Drawing.Size(56, 20);
            this.textBoxLocationLat.TabIndex = 9;
            // 
            // textBoxLocationLong
            // 
            this.textBoxLocationLong.Location = new System.Drawing.Point(102, 32);
            this.textBoxLocationLong.Name = "textBoxLocationLong";
            this.textBoxLocationLong.ReadOnly = true;
            this.textBoxLocationLong.Size = new System.Drawing.Size(56, 20);
            this.textBoxLocationLong.TabIndex = 7;
            // 
            // labelAltitude
            // 
            this.labelAltitude.AutoSize = true;
            this.labelAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltitude.Location = new System.Drawing.Point(28, 87);
            this.labelAltitude.Name = "labelAltitude";
            this.labelAltitude.Size = new System.Drawing.Size(54, 13);
            this.labelAltitude.TabIndex = 4;
            this.labelAltitude.Text = "Altitude:";
            // 
            // labelLocationLat
            // 
            this.labelLocationLat.AutoSize = true;
            this.labelLocationLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationLat.Location = new System.Drawing.Point(27, 58);
            this.labelLocationLat.Name = "labelLocationLat";
            this.labelLocationLat.Size = new System.Drawing.Size(57, 13);
            this.labelLocationLat.TabIndex = 3;
            this.labelLocationLat.Text = "Latitude:";
            // 
            // labelLocationLong
            // 
            this.labelLocationLong.AutoSize = true;
            this.labelLocationLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationLong.Location = new System.Drawing.Point(28, 32);
            this.labelLocationLong.Name = "labelLocationLong";
            this.labelLocationLong.Size = new System.Drawing.Size(67, 13);
            this.labelLocationLong.TabIndex = 2;
            this.labelLocationLong.Text = "Longitude:";
            // 
            // groupBoxOBS
            // 
            this.groupBoxOBS.Controls.Add(this.textBoxObsAdf);
            this.groupBoxOBS.Controls.Add(this.textBoxObsObs2);
            this.groupBoxOBS.Controls.Add(this.textBoxObsObs1);
            this.groupBoxOBS.Controls.Add(this.labelObsAdf);
            this.groupBoxOBS.Controls.Add(this.labelObsObs2);
            this.groupBoxOBS.Controls.Add(this.labelObsObs1);
            this.groupBoxOBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOBS.Location = new System.Drawing.Point(30, 290);
            this.groupBoxOBS.Name = "groupBoxOBS";
            this.groupBoxOBS.Size = new System.Drawing.Size(176, 119);
            this.groupBoxOBS.TabIndex = 19;
            this.groupBoxOBS.TabStop = false;
            this.groupBoxOBS.Text = "OBS";
            // 
            // textBoxObsAdf
            // 
            this.textBoxObsAdf.Location = new System.Drawing.Point(102, 87);
            this.textBoxObsAdf.Name = "textBoxObsAdf";
            this.textBoxObsAdf.ReadOnly = true;
            this.textBoxObsAdf.Size = new System.Drawing.Size(56, 20);
            this.textBoxObsAdf.TabIndex = 11;
            // 
            // textBoxObsObs2
            // 
            this.textBoxObsObs2.Location = new System.Drawing.Point(102, 58);
            this.textBoxObsObs2.Name = "textBoxObsObs2";
            this.textBoxObsObs2.ReadOnly = true;
            this.textBoxObsObs2.Size = new System.Drawing.Size(56, 20);
            this.textBoxObsObs2.TabIndex = 9;
            // 
            // textBoxObsObs1
            // 
            this.textBoxObsObs1.Location = new System.Drawing.Point(102, 32);
            this.textBoxObsObs1.Name = "textBoxObsObs1";
            this.textBoxObsObs1.ReadOnly = true;
            this.textBoxObsObs1.Size = new System.Drawing.Size(56, 20);
            this.textBoxObsObs1.TabIndex = 7;
            // 
            // labelObsAdf
            // 
            this.labelObsAdf.AutoSize = true;
            this.labelObsAdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObsAdf.Location = new System.Drawing.Point(28, 87);
            this.labelObsAdf.Name = "labelObsAdf";
            this.labelObsAdf.Size = new System.Drawing.Size(35, 13);
            this.labelObsAdf.TabIndex = 4;
            this.labelObsAdf.Text = "ADF:";
            // 
            // labelObsObs2
            // 
            this.labelObsObs2.AutoSize = true;
            this.labelObsObs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObsObs2.Location = new System.Drawing.Point(27, 58);
            this.labelObsObs2.Name = "labelObsObs2";
            this.labelObsObs2.Size = new System.Drawing.Size(43, 13);
            this.labelObsObs2.TabIndex = 3;
            this.labelObsObs2.Text = "OBS2:";
            // 
            // labelObsObs1
            // 
            this.labelObsObs1.AutoSize = true;
            this.labelObsObs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObsObs1.Location = new System.Drawing.Point(28, 32);
            this.labelObsObs1.Name = "labelObsObs1";
            this.labelObsObs1.Size = new System.Drawing.Size(43, 13);
            this.labelObsObs1.TabIndex = 2;
            this.labelObsObs1.Text = "OBS1:";
            // 
            // groupBoxOther
            // 
            this.groupBoxOther.Controls.Add(this.textBoxOtherHeadingBug);
            this.groupBoxOther.Controls.Add(this.textBoxOtherKolhsman);
            this.groupBoxOther.Controls.Add(this.labelOtherHeadingBug);
            this.groupBoxOther.Controls.Add(this.labelOtherKohlsman);
            this.groupBoxOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOther.Location = new System.Drawing.Point(547, 78);
            this.groupBoxOther.Name = "groupBoxOther";
            this.groupBoxOther.Size = new System.Drawing.Size(205, 100);
            this.groupBoxOther.TabIndex = 18;
            this.groupBoxOther.TabStop = false;
            this.groupBoxOther.Text = "Other";
            // 
            // textBoxOtherParkingBrake
            // 
            this.textBoxOtherParkingBrake.Location = new System.Drawing.Point(108, 55);
            this.textBoxOtherParkingBrake.Name = "textBoxOtherParkingBrake";
            this.textBoxOtherParkingBrake.ReadOnly = true;
            this.textBoxOtherParkingBrake.Size = new System.Drawing.Size(56, 20);
            this.textBoxOtherParkingBrake.TabIndex = 11;
            // 
            // textBoxOtherHeadingBug
            // 
            this.textBoxOtherHeadingBug.Location = new System.Drawing.Point(121, 58);
            this.textBoxOtherHeadingBug.Name = "textBoxOtherHeadingBug";
            this.textBoxOtherHeadingBug.ReadOnly = true;
            this.textBoxOtherHeadingBug.Size = new System.Drawing.Size(56, 20);
            this.textBoxOtherHeadingBug.TabIndex = 9;
            // 
            // textBoxOtherKolhsman
            // 
            this.textBoxOtherKolhsman.Location = new System.Drawing.Point(121, 32);
            this.textBoxOtherKolhsman.Name = "textBoxOtherKolhsman";
            this.textBoxOtherKolhsman.ReadOnly = true;
            this.textBoxOtherKolhsman.Size = new System.Drawing.Size(56, 20);
            this.textBoxOtherKolhsman.TabIndex = 7;
            // 
            // labelOtherParkBreak
            // 
            this.labelOtherParkBreak.AutoSize = true;
            this.labelOtherParkBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherParkBreak.Location = new System.Drawing.Point(14, 58);
            this.labelOtherParkBreak.Name = "labelOtherParkBreak";
            this.labelOtherParkBreak.Size = new System.Drawing.Size(91, 13);
            this.labelOtherParkBreak.TabIndex = 4;
            this.labelOtherParkBreak.Text = "Parking Brake:";
            // 
            // labelOtherHeadingBug
            // 
            this.labelOtherHeadingBug.AutoSize = true;
            this.labelOtherHeadingBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherHeadingBug.Location = new System.Drawing.Point(27, 58);
            this.labelOtherHeadingBug.Name = "labelOtherHeadingBug";
            this.labelOtherHeadingBug.Size = new System.Drawing.Size(84, 13);
            this.labelOtherHeadingBug.TabIndex = 3;
            this.labelOtherHeadingBug.Text = "Heading Bug:";
            // 
            // labelOtherKohlsman
            // 
            this.labelOtherKohlsman.AutoSize = true;
            this.labelOtherKohlsman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherKohlsman.Location = new System.Drawing.Point(28, 32);
            this.labelOtherKohlsman.Name = "labelOtherKohlsman";
            this.labelOtherKohlsman.Size = new System.Drawing.Size(65, 13);
            this.labelOtherKohlsman.TabIndex = 2;
            this.labelOtherKohlsman.Text = "Kohlsman:";
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSend.Location = new System.Drawing.Point(698, 330);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 22;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConnected});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelConnected
            // 
            this.toolStripStatusLabelConnected.Name = "toolStripStatusLabelConnected";
            this.toolStripStatusLabelConnected.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusLabelConnected.Text = "Unkown";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(698, 388);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 25;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // buttonSaveToDb
            // 
            this.buttonSaveToDb.Location = new System.Drawing.Point(698, 359);
            this.buttonSaveToDb.Name = "buttonSaveToDb";
            this.buttonSaveToDb.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveToDb.TabIndex = 26;
            this.buttonSaveToDb.Text = "SaveTo Db";
            this.buttonSaveToDb.UseVisualStyleBackColor = true;
            this.buttonSaveToDb.Click += new System.EventHandler(this.ButtonSaveToDb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Aircraft: ";
            // 
            // labelAircraft
            // 
            this.labelAircraft.AutoSize = true;
            this.labelAircraft.Location = new System.Drawing.Point(97, 44);
            this.labelAircraft.Name = "labelAircraft";
            this.labelAircraft.Size = new System.Drawing.Size(0, 13);
            this.labelAircraft.TabIndex = 21;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxOtherParkingBrake);
            this.groupBox1.Controls.Add(this.textBoxFlaps);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelOtherParkBreak);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(226, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plane Configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Flaps:";
            // 
            // textBoxFlaps
            // 
            this.textBoxFlaps.Location = new System.Drawing.Point(107, 29);
            this.textBoxFlaps.Name = "textBoxFlaps";
            this.textBoxFlaps.ReadOnly = true;
            this.textBoxFlaps.Size = new System.Drawing.Size(56, 20);
            this.textBoxFlaps.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSaveToDb);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelAircraft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxOther);
            this.Controls.Add(this.groupBoxOBS);
            this.Controls.Add(this.groupLocation);
            this.Controls.Add(this.groupFuel);
            this.Controls.Add(this.groupBoxRadio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Aircraft State";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxRadio.ResumeLayout(false);
            this.groupBoxRadio.PerformLayout();
            this.groupFuel.ResumeLayout(false);
            this.groupFuel.PerformLayout();
            this.groupLocation.ResumeLayout(false);
            this.groupLocation.PerformLayout();
            this.groupBoxOBS.ResumeLayout(false);
            this.groupBoxOBS.PerformLayout();
            this.groupBoxOther.ResumeLayout(false);
            this.groupBoxOther.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxRadio;
        private System.Windows.Forms.TextBox textBoxAdfStandby;
        private System.Windows.Forms.TextBox textBoxAdfActive;
        private System.Windows.Forms.TextBox textBoxNav2Standby;
        private System.Windows.Forms.TextBox textBoxNav2Active;
        private System.Windows.Forms.TextBox textBoxNav1Standby;
        private System.Windows.Forms.TextBox textBoxNav1Active;
        private System.Windows.Forms.TextBox textBoxCom2Standby;
        private System.Windows.Forms.TextBox textBoxCom2Active;
        private System.Windows.Forms.TextBox textBoxCom1Standby;
        private System.Windows.Forms.TextBox textBoxCom1Active;
        private System.Windows.Forms.Label labelAdf;
        private System.Windows.Forms.Label labelNav2;
        private System.Windows.Forms.Label labelNav1;
        private System.Windows.Forms.Label labelCom2;
        private System.Windows.Forms.Label labelCom1;
        private System.Windows.Forms.Label labelStandBy;
        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.GroupBox groupFuel;
        private System.Windows.Forms.TextBox textBoxFuelSelector;
        private System.Windows.Forms.TextBox textBoxFuelRight;
        private System.Windows.Forms.TextBox textBoxFuelLeft;
        private System.Windows.Forms.Label labelFuelSelector;
        private System.Windows.Forms.Label labelFuelRight;
        private System.Windows.Forms.Label labelFuelLeft;
        private System.Windows.Forms.GroupBox groupLocation;
        private System.Windows.Forms.TextBox textBoxLocationHeading;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.TextBox textBoxLocationAltitude;
        private System.Windows.Forms.TextBox textBoxLocationLat;
        private System.Windows.Forms.TextBox textBoxLocationLong;
        private System.Windows.Forms.Label labelAltitude;
        private System.Windows.Forms.Label labelLocationLat;
        private System.Windows.Forms.Label labelLocationLong;
        private System.Windows.Forms.GroupBox groupBoxOBS;
        private System.Windows.Forms.TextBox textBoxObsAdf;
        private System.Windows.Forms.TextBox textBoxObsObs2;
        private System.Windows.Forms.TextBox textBoxObsObs1;
        private System.Windows.Forms.Label labelObsAdf;
        private System.Windows.Forms.Label labelObsObs2;
        private System.Windows.Forms.Label labelObsObs1;
        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.TextBox textBoxOtherParkingBrake;
        private System.Windows.Forms.TextBox textBoxOtherHeadingBug;
        private System.Windows.Forms.TextBox textBoxOtherKolhsman;
        private System.Windows.Forms.Label labelOtherParkBreak;
        private System.Windows.Forms.Label labelOtherHeadingBug;
        private System.Windows.Forms.Label labelOtherKohlsman;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnected;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonSaveToDb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAircraft;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFlaps;
        private System.Windows.Forms.Label label2;
    }
}

