using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CheeseAdServer.utils;

namespace CheeseAdServer
{
    /**
     * The form used to display DataTimePicker control
     */ 
    public partial class TimePickerForm : Form
    {

        public static String TAG = "TimePickerForm";

        private MainForm mainForm = null;
        private String key  = null;

        public TimePickerForm(MainForm mainForm)
        {
            InitializeComponent();
            initTimePicker();
            this.mainForm = mainForm;
        }

        private void initTimePicker()
        {
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm";
            timePicker.ShowUpDown = true;
        }

        /**
         * Listening edit schedule time button click action.
         * 1. If click is not global button, then update the 
         * button related schedule time config.
         * 2. If click is global startup/shutdown time button,
         * then update the related startup/shutdown from Monday 
         * to Sunday
         */
        private void ok_bt_Click(object sender, EventArgs e)
        {
            Log.d(TAG, timePicker.Text);
            Button bt = (Button)sender;
            String selected_time = timePicker.Text;
            ScheduleConfig config = LocalDatabase.getInstance().getConfig();
            // 1. Click global startup time edit button
            if (key.Equals(ScheduleConfig.GLOBAL_STARTUP_TIME_KEY)) {
                foreach (String r_key in ScheduleConfig.STARTUP_TIME_KEYS) {
                    config.set(r_key, selected_time); 
                }
            } 
            // 2. Click global shutdown time edit button
            else if (key.Equals(ScheduleConfig.GLOBAL_SHUTDOWN_TIME_KEY)) {
                foreach (String r_key in ScheduleConfig.SHUTDOWN_TIME_KEYS) {
                    config.set(r_key, selected_time); 
                }
            } 
            // 3. Click specific startup or shutdown time edit button
            else {
                // Save select schedule time to local database
                config.set(key, selected_time);
            }
            // 4. Persist store config 
            LocalDatabase.getInstance().saveConfig(config);
            // 5. Update MainForm UI
            mainForm.updateUI();
            // 6. Hide self
            this.Hide();
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void timePickerShow(String key) {
            Log.d(TAG, "Prepare to set " + key);
            this.key = key;
            this.Show();
        }
    }
}
