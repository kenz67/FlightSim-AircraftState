using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AircraftState.Forms
{
    public static class Prompt
    {
        public static string ShowDialog(string caption, string text, string btnLabel = "Ok", string defaultVal = "", bool showCancel = false)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                //  StartPosition = FormStartPosition.CenterScreen
            };

            const int btnRight = 350;
            const int btnLeft = 225;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400, Text = defaultVal };
            Button confirmation = new Button() { Text = btnLabel, Left = (showCancel ? btnLeft : btnRight), Width = 100, Top = 80, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "Cancel", Left = btnRight, Width = 100, Top = 80, DialogResult = DialogResult.Cancel };
            confirmation.Click += (sender, e) => prompt.Close();
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            if (showCancel)
            {
                prompt.Controls.Add(cancel);
            }
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}