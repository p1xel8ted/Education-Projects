/*
* Author: Ben Logan
* Student ID: 30013164
*/

using System;
using System.Windows.Forms;
using ABC_Management_Studio.Properties;

namespace ABC_Management_Studio
{
    /// <summary>
    ///     Used for settings. At the moment the only configurable setting is the amount of semesters in
    ///     a year.
    /// </summary>
    internal partial class FrmSettings : Form
    {
        internal FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Semesters = Util.Int(cmbSemesters.SelectedItem.ToString());
            Settings.Default.Save();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            cmbSemesters.SelectedIndex = Util.Int(Settings.Default.Semesters) - 1;
        }
    }
}