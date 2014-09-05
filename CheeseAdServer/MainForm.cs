using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CheeseAdServer.utils;

namespace CheeseAdServer {
    public partial class MainForm : Form {
        private static String TAG = "MainForm";

        private TimePickerForm timePicker   = null;
        private ControlServer server        = null;

        public MainForm() {
            timePicker = new TimePickerForm(this);
            InitializeComponent();
        }

        private void refresh_bt_Click(object sender, EventArgs e) {
            //ControlClient.Connect("192.168.1.101", "Hello World\n 1 \n 2 \n");
            // Create server and start
            server = new ControlServer(); 
            server.start();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            updateUI();
        }

        public void updateUI() {
            // 1. fetch config
            ScheduleConfig config = LocalDatabase.getInstance().getConfig();

            // 2. Initial UI control text from the config
            // Monday
            mon_startup_edit_bt.Text = config.get(ScheduleConfig.MON_STARTUP_TIME_KEY);
            mon_shutdown_edit_bt.Text = config.get(ScheduleConfig.MON_SHUTDOWN_TIME_KEY);
            mon_enable_ck.Checked = config.get(ScheduleConfig.MON_SCHEDULE_ENABLE_KEY).Equals(ScheduleConfig.SCHEDULE_ENABLE);
            // Tuesday
            tues_startup_edit_bt.Text = config.get(ScheduleConfig.TUES_STARTUP_TIME_KEY);
            tues_shutdown_edit_bt.Text = config.get(ScheduleConfig.TUES_SHUTDOWN_TIME_KEY);
            tues_enable_ck.Checked = config.get(ScheduleConfig.TUES_SCHEDULE_ENABLE_KEY).Equals(ScheduleConfig.SCHEDULE_ENABLE);
            // Wednesday
            wed_startup_edit_bt.Text = config.get(ScheduleConfig.WED_STARTUP_TIME_KEY);
            wed_shutdown_edit_bt.Text = config.get(ScheduleConfig.WED_SHUTDOWN_TIME_KEY);
            wed_enable_ck.Checked = config.get(ScheduleConfig.WED_SCHEDULE_ENABLE_KEY).Equals(ScheduleConfig.SCHEDULE_ENABLE);
            // Thursday
            thur_startup_edit_bt.Text = config.get(ScheduleConfig.THUR_STARTUP_TIME_KEY);
            thur_shutdown_edit_bt.Text = config.get(ScheduleConfig.THUR_SHUTDOWN_TIME_KEY);
            thur_enable_ck.Checked = config.get(ScheduleConfig.THUR_SCHEDULE_ENABLE_KEY).Equals(ScheduleConfig.SCHEDULE_ENABLE);
            // Friday
            fri_startup_edit_bt.Text = config.get(ScheduleConfig.FRI_STARTUP_TIME_KEY);
            fri_shutdown_edit_bt.Text = config.get(ScheduleConfig.FRI_SHUTDOWN_TIME_KEY);
            fri_enable_ck.Checked = config.get(ScheduleConfig.FRI_SCHEDULE_ENABLE_KEY).Equals(ScheduleConfig.SCHEDULE_ENABLE);
            // Saturday
            sat_startup_edit_bt.Text = config.get(ScheduleConfig.SAT_STARTUP_TIME_KEY);
            sat_shutdown_edit_bt.Text = config.get(ScheduleConfig.SAT_SHUTDOWN_TIME_KEY);
            sat_enable_ck.Checked = config.get(ScheduleConfig.SAT_SCHEDULE_ENABLE_KEY).Equals(ScheduleConfig.SCHEDULE_ENABLE);
            // Sunday
            sun_startup_edit_bt.Text = config.get(ScheduleConfig.SUN_STARTUP_TIME_KEY);
            sun_shutdown_edit_bt.Text = config.get(ScheduleConfig.SUN_SHUTDOWN_TIME_KEY);
            sun_enable_ck.Checked = config.get(ScheduleConfig.SUN_SCHEDULE_ENABLE_KEY).Equals(ScheduleConfig.SCHEDULE_ENABLE);
            // Global
            global_startup_edit_bt.Text = config.get(ScheduleConfig.GLOBAL_STARTUP_TIME_KEY);
            global_shutdown_edit_bt.Text = config.get(ScheduleConfig.GLOBAL_SHUTDOWN_TIME_KEY);
            //global_enable_ck.Checked = config.get(ScheduleConfig.GLOBAL_SCHEDULE_ENABLE_KEY).Equals(ScheduleConfig.SCHEDULE_ENABLE);

        }

        private void schedule_edit_bt_Click(object sender, EventArgs e) {
            Button edit_bt = (Button)sender;
            Log.d(TAG, edit_bt.Tag.ToString());
            timePicker.timePickerShow(edit_bt.Tag.ToString());
        }

        private void schedule_enable_CheckedChanged(object sender, EventArgs e) {
            CheckBox cb = (CheckBox)sender;
            Log.d(TAG, "Change enable state: " + cb.Tag);
            ScheduleConfig config = LocalDatabase.getInstance().getConfig();
            if (cb.Tag.ToString().Equals(ScheduleConfig.GLOBAL_SCHEDULE_ENABLE_KEY)) {
                // Update all schedule enable state
                foreach(String key in ScheduleConfig.SCHEDULE_ENABLE_KEYS){
                    config.set(key, cb.Checked ? ScheduleConfig.SCHEDULE_ENABLE : ScheduleConfig.SCHEDULE_DISABLE);
                }
                LocalDatabase.getInstance().saveConfig(config);
                updateUI();

            } else {
                // Only update the config which the checkbox stand  for
                config.set(cb.Tag.ToString(), cb.Checked ? ScheduleConfig.SCHEDULE_ENABLE : ScheduleConfig.SCHEDULE_DISABLE);
                LocalDatabase.getInstance().saveConfig(config);
            }
            // Persist schedule config

        }

    }
}
