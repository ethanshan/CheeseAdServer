using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheeseAdServer
{
    class ScheduleConfig
    {
        public static String DEFAULT_STARTUP_TIME = "6:30";
        public static String DEFAULT_SHUTDOWN_TIME = "18:30";

        // Schedule enable/disable
        public static int SCHEDULE_DISABLE = 0;
        public static int SCHEDULE_ENABLE = 1;

        // Monday config
        private String mon_startup_time = DEFAULT_STARTUP_TIME;
        public System.String Mon_startup_time
        {
            get { return mon_startup_time; }
            set { mon_startup_time = value; }
        }
        private String mon_shutdown_time = DEFAULT_SHUTDOWN_TIME;
        public System.String Mon_shutdown_time
        {
            get { return mon_shutdown_time; }
            set { mon_shutdown_time = value; }
        }
        private int mon_schedule_enable = SCHEDULE_ENABLE;
        public int Mon_schedule_enable
        {
            get { return mon_schedule_enable; }
            set { mon_schedule_enable = value; }
        }
        // Tuesday config
        private String tues_startup_time = DEFAULT_STARTUP_TIME;
        public System.String Tues_startup_time
        {
            get { return tues_startup_time; }
            set { tues_startup_time = value; }
        }
        private String tues_shutdown_time = DEFAULT_SHUTDOWN_TIME;
        public System.String Tues_shutdown_time
        {
            get { return tues_shutdown_time; }
            set { tues_shutdown_time = value; }
        }
        private int tues_schedule_enable = SCHEDULE_ENABLE;
        public int Tues_schedule_enable
        {
            get { return tues_schedule_enable; }
            set { tues_schedule_enable = value; }
        }
        // Wednesday config
        private String wed_startup_time = DEFAULT_STARTUP_TIME;
        public System.String Wed_startup_time
        {
            get { return wed_startup_time; }
            set { wed_startup_time = value; }
        }
        private String wed_shutdown_time = DEFAULT_SHUTDOWN_TIME;
        public System.String Wed_shutdown_time
        {
            get { return wed_shutdown_time; }
            set { wed_shutdown_time = value; }
        }
        private int wed_schedule_enable = SCHEDULE_ENABLE;
        public int Wed_schedule_enable
        {
            get { return wed_schedule_enable; }
            set { wed_schedule_enable = value; }
        }
        // Thursday config
        private String thur_startup_time = DEFAULT_STARTUP_TIME;
        public System.String Thur_startup_time
        {
            get { return thur_startup_time; }
            set { thur_startup_time = value; }
        }
        private String thur_shutdown_time = DEFAULT_SHUTDOWN_TIME;
        public System.String Thur_shutdown_time
        {
            get { return thur_shutdown_time; }
            set { thur_shutdown_time = value; }
        }
        private int thur_schedule_enable = SCHEDULE_ENABLE;
        public int Thur_schedule_enable
        {
            get { return thur_schedule_enable; }
            set { thur_schedule_enable = value; }
        }
        // Friday config
        private String fri_startup_time = DEFAULT_STARTUP_TIME;
        public System.String Fri_startup_time
        {
            get { return fri_startup_time; }
            set { fri_startup_time = value; }
        }
        private String fri_shutdown_time = DEFAULT_SHUTDOWN_TIME;
        public System.String Fri_shutdown_time
        {
            get { return fri_shutdown_time; }
            set { fri_shutdown_time = value; }
        }
        private int fri_schedule_enable = SCHEDULE_ENABLE;
        public int Fri_schedule_enable
        {
            get { return fri_schedule_enable; }
            set { fri_schedule_enable = value; }
        }
        // Saturday config
        private String sat_startup_time = DEFAULT_STARTUP_TIME;
        public System.String Sat_startup_time
        {
            get { return sat_startup_time; }
            set { sat_startup_time = value; }
        }
        private String sat_shutdown_time = DEFAULT_SHUTDOWN_TIME;
        public System.String Sat_shutdown_time
        {
            get { return sat_shutdown_time; }
            set { sat_shutdown_time = value; }
        }
        private int sat_schedule_enable = SCHEDULE_ENABLE;
        public int Sat_schedule_enable
        {
            get { return sat_schedule_enable; }
            set { sat_schedule_enable = value; }
        }
        // Sunday config
        private String sun_startup_time = DEFAULT_STARTUP_TIME;
        public System.String Sun_startup_time
        {
            get { return sun_startup_time; }
            set { sun_startup_time = value; }
        }
        private String sun_shutdown_time = DEFAULT_SHUTDOWN_TIME;
        public System.String Sun_shutdown_time
        {
            get { return sun_shutdown_time; }
            set { sun_shutdown_time = value; }
        }
        private int sun_schedule_enable = SCHEDULE_ENABLE;
        public int Sun_schedule_enable
        {
            get { return sun_schedule_enable; }
            set { sun_schedule_enable = value; }
        }


    }
}
