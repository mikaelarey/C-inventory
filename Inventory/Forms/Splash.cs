using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Inventory.BusinessLayer;

namespace Inventory.Forms
{
    public partial class Splash : Form
    {
        Timer timer;

        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer = new Timer
            {
                Interval = 2000
            };

            timer.Start();
            timer.Tick += new System.EventHandler(OnTimerEvent);
        }

        private void Check_AppSettings()
        {
            BL_Splash.Set_AppSettings();
            
            if (BL_Splash.isFirstRun())
            {
                BL_AppSettings.Create_Directories();
                // Show AppSetting Form
                AppSettings.AppSettings appSettings = new AppSettings.AppSettings();
                appSettings.ShowDialog();
            }
            else
            {
                // Show Login Form
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            timer.Stop();
            Check_AppSettings();
        }
    }
}
