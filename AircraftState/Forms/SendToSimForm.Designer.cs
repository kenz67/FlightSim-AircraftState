namespace AircraftState.Forms
{
    partial class SendToSimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendToSimForm));
            this.buttonSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAircraft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxHide = new System.Windows.Forms.CheckBox();
            this.checkBoxSendFuel = new System.Windows.Forms.CheckBox();
            this.checkBoxSendLocation = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSettingsFrom = new System.Windows.Forms.ComboBox();
            this.buttonDeleteProfile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTrim = new System.Windows.Forms.TextBox();
            this.textBoxOtherParkingBrake = new System.Windows.Forms.TextBox();
            this.textBoxFlaps = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelOtherParkBreak = new System.Windows.Forms.Label();
            this.groupBoxOther = new System.Windows.Forms.GroupBox();
            this.textBoxOtherHeadingBug = new System.Windows.Forms.TextBox();
            this.textBoxOtherKolhsman = new System.Windows.Forms.TextBox();
            this.labelOtherHeadingBug = new System.Windows.Forms.Label();
            this.labelOtherKohlsman = new System.Windows.Forms.Label();
            this.groupBoxOBS = new System.Windows.Forms.GroupBox();
            this.textBoxObsAdf = new System.Windows.Forms.TextBox();
            this.textBoxObsObs2 = new System.Windows.Forms.TextBox();
            this.textBoxObsObs1 = new System.Windows.Forms.TextBox();
            this.labelObsAdf = new System.Windows.Forms.Label();
            this.labelObsObs2 = new System.Windows.Forms.Label();
            this.labelObsObs1 = new System.Windows.Forms.Label();
            this.groupLocation = new System.Windows.Forms.GroupBox();
            this.textBoxLocationHeading = new System.Windows.Forms.TextBox();
            this.labelHeading = new System.Windows.Forms.Label();
            this.textBoxLocationAltitude = new System.Windows.Forms.TextBox();
            this.textBoxLocationLat = new System.Windows.Forms.TextBox();
            this.textBoxLocationLong = new System.Windows.Forms.TextBox();
            this.labelAltitude = new System.Windows.Forms.Label();
            this.labelLocationLat = new System.Windows.Forms.Label();
            this.labelLocationLong = new System.Windows.Forms.Label();
            this.groupFuel = new System.Windows.Forms.GroupBox();
            this.textBoxFuelSelector = new System.Windows.Forms.TextBox();
            this.textBoxFuelRight = new System.Windows.Forms.TextBox();
            this.textBoxFuelLeft = new System.Windows.Forms.TextBox();
            this.labelFuelSelector = new System.Windows.Forms.Label();
            this.labelFuelRight = new System.Windows.Forms.Label();
            this.labelFuelLeft = new System.Windows.Forms.Label();
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
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxOther.SuspendLayout();
            this.groupBoxOBS.SuspendLayout();
            this.groupLocation.SuspendLayout();
            this.groupFuel.SuspendLayout();
            this.groupBoxRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSend.Location = new System.Drawing.Point(46, 521);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 37);
            this.buttonSend.TabIndex = 22;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Current Aircraft: ";
            // 
            // labelAircraft
            // 
            this.labelAircraft.AutoSize = true;
            this.labelAircraft.Location = new System.Drawing.Point(168, 45);
            this.labelAircraft.Name = "labelAircraft";
            this.labelAircraft.Size = new System.Drawing.Size(0, 13);
            this.labelAircraft.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Data will be sent to the Sim";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(163, 520);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 37);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // checkBoxHide
            // 
            this.checkBoxHide.AutoSize = true;
            this.checkBoxHide.Location = new System.Drawing.Point(46, 488);
            this.checkBoxHide.Name = "checkBoxHide";
            this.checkBoxHide.Size = new System.Drawing.Size(194, 17);
            this.checkBoxHide.TabIndex = 25;
            this.checkBoxHide.Text = "Hide this window for future requests";
            this.checkBoxHide.UseVisualStyleBackColor = true;
            // 
            // checkBoxSendFuel
            // 
            this.checkBoxSendFuel.AutoSize = true;
            this.checkBoxSendFuel.Location = new System.Drawing.Point(298, 498);
            this.checkBoxSendFuel.Name = "checkBoxSendFuel";
            this.checkBoxSendFuel.Size = new System.Drawing.Size(100, 17);
            this.checkBoxSendFuel.TabIndex = 29;
            this.checkBoxSendFuel.Text = "Send Fuel Data";
            this.checkBoxSendFuel.UseVisualStyleBackColor = true;
            // 
            // checkBoxSendLocation
            // 
            this.checkBoxSendLocation.AutoSize = true;
            this.checkBoxSendLocation.Location = new System.Drawing.Point(298, 524);
            this.checkBoxSendLocation.Name = "checkBoxSendLocation";
            this.checkBoxSendLocation.Size = new System.Drawing.Size(121, 17);
            this.checkBoxSendLocation.TabIndex = 30;
            this.checkBoxSendLocation.Text = "Send Location Data";
            this.checkBoxSendLocation.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Apply Settings From: ";
            // 
            // comboBoxSettingsFrom
            // 
            this.comboBoxSettingsFrom.FormattingEnabled = true;
            this.comboBoxSettingsFrom.Location = new System.Drawing.Point(171, 70);
            this.comboBoxSettingsFrom.Name = "comboBoxSettingsFrom";
            this.comboBoxSettingsFrom.Size = new System.Drawing.Size(322, 21);
            this.comboBoxSettingsFrom.TabIndex = 32;
            this.comboBoxSettingsFrom.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSettingsFrom_SelectedIndexChanged);
            // 
            // buttonDeleteProfile
            // 
            this.buttonDeleteProfile.Location = new System.Drawing.Point(517, 70);
            this.buttonDeleteProfile.Name = "buttonDeleteProfile";
            this.buttonDeleteProfile.Size = new System.Drawing.Size(111, 23);
            this.buttonDeleteProfile.TabIndex = 33;
            this.buttonDeleteProfile.Text = "Delete Profile";
            this.buttonDeleteProfile.UseVisualStyleBackColor = true;
            this.buttonDeleteProfile.Click += new System.EventHandler(this.ButtonDeleteProfile_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(38, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 383);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBoxOther);
            this.tabPage1.Controls.Add(this.groupBoxOBS);
            this.tabPage1.Controls.Add(this.groupLocation);
            this.tabPage1.Controls.Add(this.groupFuel);
            this.tabPage1.Controls.Add(this.groupBoxRadio);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Data";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extended Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxTrim);
            this.groupBox1.Controls.Add(this.textBoxOtherParkingBrake);
            this.groupBox1.Controls.Add(this.textBoxFlaps);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelOtherParkBreak);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(232, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 127);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plane Configuration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Trim:";
            // 
            // textBoxTrim
            // 
            this.textBoxTrim.Location = new System.Drawing.Point(75, 84);
            this.textBoxTrim.Name = "textBoxTrim";
            this.textBoxTrim.ReadOnly = true;
            this.textBoxTrim.Size = new System.Drawing.Size(98, 20);
            this.textBoxTrim.TabIndex = 16;
            // 
            // textBoxOtherParkingBrake
            // 
            this.textBoxOtherParkingBrake.Location = new System.Drawing.Point(117, 58);
            this.textBoxOtherParkingBrake.Name = "textBoxOtherParkingBrake";
            this.textBoxOtherParkingBrake.ReadOnly = true;
            this.textBoxOtherParkingBrake.Size = new System.Drawing.Size(56, 20);
            this.textBoxOtherParkingBrake.TabIndex = 11;
            // 
            // textBoxFlaps
            // 
            this.textBoxFlaps.Location = new System.Drawing.Point(117, 32);
            this.textBoxFlaps.Name = "textBoxFlaps";
            this.textBoxFlaps.ReadOnly = true;
            this.textBoxFlaps.Size = new System.Drawing.Size(56, 20);
            this.textBoxFlaps.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Flaps:";
            // 
            // labelOtherParkBreak
            // 
            this.labelOtherParkBreak.AutoSize = true;
            this.labelOtherParkBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherParkBreak.Location = new System.Drawing.Point(6, 61);
            this.labelOtherParkBreak.Name = "labelOtherParkBreak";
            this.labelOtherParkBreak.Size = new System.Drawing.Size(91, 13);
            this.labelOtherParkBreak.TabIndex = 4;
            this.labelOtherParkBreak.Text = "Parking Brake:";
            // 
            // groupBoxOther
            // 
            this.groupBoxOther.Controls.Add(this.textBoxOtherHeadingBug);
            this.groupBoxOther.Controls.Add(this.textBoxOtherKolhsman);
            this.groupBoxOther.Controls.Add(this.labelOtherHeadingBug);
            this.groupBoxOther.Controls.Add(this.labelOtherKohlsman);
            this.groupBoxOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOther.Location = new System.Drawing.Point(508, 6);
            this.groupBoxOther.Name = "groupBoxOther";
            this.groupBoxOther.Size = new System.Drawing.Size(205, 107);
            this.groupBoxOther.TabIndex = 31;
            this.groupBoxOther.TabStop = false;
            this.groupBoxOther.Text = "Other";
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
            // groupBoxOBS
            // 
            this.groupBoxOBS.Controls.Add(this.textBoxObsAdf);
            this.groupBoxOBS.Controls.Add(this.textBoxObsObs2);
            this.groupBoxOBS.Controls.Add(this.textBoxObsObs1);
            this.groupBoxOBS.Controls.Add(this.labelObsAdf);
            this.groupBoxOBS.Controls.Add(this.labelObsObs2);
            this.groupBoxOBS.Controls.Add(this.labelObsObs1);
            this.groupBoxOBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOBS.Location = new System.Drawing.Point(29, 210);
            this.groupBoxOBS.Name = "groupBoxOBS";
            this.groupBoxOBS.Size = new System.Drawing.Size(176, 127);
            this.groupBoxOBS.TabIndex = 33;
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
            this.groupLocation.Location = new System.Drawing.Point(307, 6);
            this.groupLocation.Name = "groupLocation";
            this.groupLocation.Size = new System.Drawing.Size(176, 142);
            this.groupLocation.TabIndex = 32;
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
            // groupFuel
            // 
            this.groupFuel.Controls.Add(this.textBoxFuelSelector);
            this.groupFuel.Controls.Add(this.textBoxFuelRight);
            this.groupFuel.Controls.Add(this.textBoxFuelLeft);
            this.groupFuel.Controls.Add(this.labelFuelSelector);
            this.groupFuel.Controls.Add(this.labelFuelRight);
            this.groupFuel.Controls.Add(this.labelFuelLeft);
            this.groupFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupFuel.Location = new System.Drawing.Point(437, 210);
            this.groupFuel.Name = "groupFuel";
            this.groupFuel.Size = new System.Drawing.Size(164, 127);
            this.groupFuel.TabIndex = 30;
            this.groupFuel.TabStop = false;
            this.groupFuel.Text = "Fuel";
            // 
            // textBoxFuelSelector
            // 
            this.textBoxFuelSelector.Location = new System.Drawing.Point(83, 92);
            this.textBoxFuelSelector.Name = "textBoxFuelSelector";
            this.textBoxFuelSelector.ReadOnly = true;
            this.textBoxFuelSelector.Size = new System.Drawing.Size(56, 20);
            this.textBoxFuelSelector.TabIndex = 11;
            // 
            // textBoxFuelRight
            // 
            this.textBoxFuelRight.Location = new System.Drawing.Point(83, 66);
            this.textBoxFuelRight.Name = "textBoxFuelRight";
            this.textBoxFuelRight.ReadOnly = true;
            this.textBoxFuelRight.Size = new System.Drawing.Size(56, 20);
            this.textBoxFuelRight.TabIndex = 9;
            // 
            // textBoxFuelLeft
            // 
            this.textBoxFuelLeft.Location = new System.Drawing.Point(83, 40);
            this.textBoxFuelLeft.Name = "textBoxFuelLeft";
            this.textBoxFuelLeft.ReadOnly = true;
            this.textBoxFuelLeft.Size = new System.Drawing.Size(56, 20);
            this.textBoxFuelLeft.TabIndex = 7;
            // 
            // labelFuelSelector
            // 
            this.labelFuelSelector.AutoSize = true;
            this.labelFuelSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelSelector.Location = new System.Drawing.Point(10, 95);
            this.labelFuelSelector.Name = "labelFuelSelector";
            this.labelFuelSelector.Size = new System.Drawing.Size(58, 13);
            this.labelFuelSelector.TabIndex = 4;
            this.labelFuelSelector.Text = "Selector:";
            // 
            // labelFuelRight
            // 
            this.labelFuelRight.AutoSize = true;
            this.labelFuelRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelRight.Location = new System.Drawing.Point(10, 69);
            this.labelFuelRight.Name = "labelFuelRight";
            this.labelFuelRight.Size = new System.Drawing.Size(41, 13);
            this.labelFuelRight.TabIndex = 3;
            this.labelFuelRight.Text = "Right:";
            // 
            // labelFuelLeft
            // 
            this.labelFuelLeft.AutoSize = true;
            this.labelFuelLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelLeft.Location = new System.Drawing.Point(14, 43);
            this.labelFuelLeft.Name = "labelFuelLeft";
            this.labelFuelLeft.Size = new System.Drawing.Size(33, 13);
            this.labelFuelLeft.TabIndex = 2;
            this.labelFuelLeft.Text = "Left:";
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
            this.groupBoxRadio.Location = new System.Drawing.Point(29, 6);
            this.groupBoxRadio.Name = "groupBoxRadio";
            this.groupBoxRadio.Size = new System.Drawing.Size(253, 188);
            this.groupBoxRadio.TabIndex = 29;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "For future expansion";
            // 
            // SendToSimForm
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonDeleteProfile);
            this.Controls.Add(this.comboBoxSettingsFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxSendLocation);
            this.Controls.Add(this.checkBoxSendFuel);
            this.Controls.Add(this.checkBoxHide);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelAircraft);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendToSimForm";
            this.Text = "Send Data To Sim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxOther.ResumeLayout(false);
            this.groupBoxOther.PerformLayout();
            this.groupBoxOBS.ResumeLayout(false);
            this.groupBoxOBS.PerformLayout();
            this.groupLocation.ResumeLayout(false);
            this.groupLocation.PerformLayout();
            this.groupFuel.ResumeLayout(false);
            this.groupFuel.PerformLayout();
            this.groupBoxRadio.ResumeLayout(false);
            this.groupBoxRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAircraft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxHide;
        private System.Windows.Forms.CheckBox checkBoxSendFuel;
        private System.Windows.Forms.CheckBox checkBoxSendLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSettingsFrom;
        private System.Windows.Forms.Button buttonDeleteProfile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTrim;
        private System.Windows.Forms.TextBox textBoxOtherParkingBrake;
        private System.Windows.Forms.TextBox textBoxFlaps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelOtherParkBreak;
        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.TextBox textBoxOtherHeadingBug;
        private System.Windows.Forms.TextBox textBoxOtherKolhsman;
        private System.Windows.Forms.Label labelOtherHeadingBug;
        private System.Windows.Forms.Label labelOtherKohlsman;
        private System.Windows.Forms.GroupBox groupBoxOBS;
        private System.Windows.Forms.TextBox textBoxObsAdf;
        private System.Windows.Forms.TextBox textBoxObsObs2;
        private System.Windows.Forms.TextBox textBoxObsObs1;
        private System.Windows.Forms.Label labelObsAdf;
        private System.Windows.Forms.Label labelObsObs2;
        private System.Windows.Forms.Label labelObsObs1;
        private System.Windows.Forms.GroupBox groupLocation;
        private System.Windows.Forms.TextBox textBoxLocationHeading;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.TextBox textBoxLocationAltitude;
        private System.Windows.Forms.TextBox textBoxLocationLat;
        private System.Windows.Forms.TextBox textBoxLocationLong;
        private System.Windows.Forms.Label labelAltitude;
        private System.Windows.Forms.Label labelLocationLat;
        private System.Windows.Forms.Label labelLocationLong;
        private System.Windows.Forms.GroupBox groupFuel;
        private System.Windows.Forms.TextBox textBoxFuelSelector;
        private System.Windows.Forms.TextBox textBoxFuelRight;
        private System.Windows.Forms.TextBox textBoxFuelLeft;
        private System.Windows.Forms.Label labelFuelSelector;
        private System.Windows.Forms.Label labelFuelRight;
        private System.Windows.Forms.Label labelFuelLeft;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
    }
}

