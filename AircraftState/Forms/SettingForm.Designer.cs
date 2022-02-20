
namespace AircraftState.Forms
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.checkBoxUpdatePlaneLocation = new System.Windows.Forms.CheckBox();
            this.checkBoxUpdateFuel = new System.Windows.Forms.CheckBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxShowSummary = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoSave = new System.Windows.Forms.CheckBox();
            this.checkBoxShowSaveAs = new System.Windows.Forms.CheckBox();
            this.checkBoxSendExtendedData = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxUpdatePlaneLocation
            // 
            this.checkBoxUpdatePlaneLocation.AutoSize = true;
            this.checkBoxUpdatePlaneLocation.Location = new System.Drawing.Point(31, 107);
            this.checkBoxUpdatePlaneLocation.Name = "checkBoxUpdatePlaneLocation";
            this.checkBoxUpdatePlaneLocation.Size = new System.Drawing.Size(135, 17);
            this.checkBoxUpdatePlaneLocation.TabIndex = 0;
            this.checkBoxUpdatePlaneLocation.Text = "Update Plane Location";
            this.checkBoxUpdatePlaneLocation.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpdateFuel
            // 
            this.checkBoxUpdateFuel.AllowDrop = true;
            this.checkBoxUpdateFuel.AutoSize = true;
            this.checkBoxUpdateFuel.Location = new System.Drawing.Point(31, 130);
            this.checkBoxUpdateFuel.Name = "checkBoxUpdateFuel";
            this.checkBoxUpdateFuel.Size = new System.Drawing.Size(84, 17);
            this.checkBoxUpdateFuel.TabIndex = 1;
            this.checkBoxUpdateFuel.Text = "Update Fuel";
            this.checkBoxUpdateFuel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(31, 193);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(141, 193);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            // 
            // checkBoxShowSummary
            // 
            this.checkBoxShowSummary.AllowDrop = true;
            this.checkBoxShowSummary.AutoSize = true;
            this.checkBoxShowSummary.Location = new System.Drawing.Point(31, 14);
            this.checkBoxShowSummary.Name = "checkBoxShowSummary";
            this.checkBoxShowSummary.Size = new System.Drawing.Size(229, 17);
            this.checkBoxShowSummary.TabIndex = 4;
            this.checkBoxShowSummary.Text = "Show summary page before sending to Sim";
            this.checkBoxShowSummary.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoSave
            // 
            this.checkBoxAutoSave.AllowDrop = true;
            this.checkBoxAutoSave.AutoSize = true;
            this.checkBoxAutoSave.Location = new System.Drawing.Point(31, 37);
            this.checkBoxAutoSave.Name = "checkBoxAutoSave";
            this.checkBoxAutoSave.Size = new System.Drawing.Size(101, 17);
            this.checkBoxAutoSave.TabIndex = 5;
            this.checkBoxAutoSave.Text = "Auto save to db";
            this.checkBoxAutoSave.UseVisualStyleBackColor = false;
            // 
            // checkBoxShowSaveAs
            // 
            this.checkBoxShowSaveAs.AutoSize = true;
            this.checkBoxShowSaveAs.Location = new System.Drawing.Point(31, 61);
            this.checkBoxShowSaveAs.Name = "checkBoxShowSaveAs";
            this.checkBoxShowSaveAs.Size = new System.Drawing.Size(188, 17);
            this.checkBoxShowSaveAs.TabIndex = 6;
            this.checkBoxShowSaveAs.Text = "Show Save As when saving to Db";
            this.checkBoxShowSaveAs.UseVisualStyleBackColor = true;
            // 
            // checkBoxSendExtendedData
            // 
            this.checkBoxSendExtendedData.AutoSize = true;
            this.checkBoxSendExtendedData.Location = new System.Drawing.Point(31, 153);
            this.checkBoxSendExtendedData.Name = "checkBoxSendExtendedData";
            this.checkBoxSendExtendedData.Size = new System.Drawing.Size(125, 17);
            this.checkBoxSendExtendedData.TabIndex = 7;
            this.checkBoxSendExtendedData.Text = "Send Extended Data";
            this.checkBoxSendExtendedData.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(264, 233);
            this.Controls.Add(this.checkBoxSendExtendedData);
            this.Controls.Add(this.checkBoxShowSaveAs);
            this.Controls.Add(this.checkBoxAutoSave);
            this.Controls.Add(this.checkBoxShowSummary);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.checkBoxUpdateFuel);
            this.Controls.Add(this.checkBoxUpdatePlaneLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxUpdatePlaneLocation;
        private System.Windows.Forms.CheckBox checkBoxUpdateFuel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxShowSummary;
        private System.Windows.Forms.CheckBox checkBoxAutoSave;
        private System.Windows.Forms.CheckBox checkBoxShowSaveAs;
        private System.Windows.Forms.CheckBox checkBoxSendExtendedData;
    }
}