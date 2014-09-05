using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CheeseAdServer
{
    class ScheduleConfig
    {
        public static String DEFAULT_STARTUP_TIME       = "6:30";
        public static String DEFAULT_SHUTDOWN_TIME      = "18:30";
        public static String DEFAULT_WEB_URL            = "http://192.168.0.15/show/index";
        public static String DEFAULT_SCHEDULE_STATE     = "1";

        // Schedule enable/disable
        public static String SCHEDULE_DISABLE           = "0";
        public static String SCHEDULE_ENABLE            = "1";

        // ----------------Monday to Sunday key value----------------
        public static String MON_STARTUP_TIME_KEY           = "mon_startup_time";
        public static String MON_SHUTDOWN_TIME_KEY          = "mon_shutdown_time";
        public static String MON_SCHEDULE_ENABLE_KEY        = "mon_schedule_enable";
        public static String TUES_STARTUP_TIME_KEY          = "tues_startup_time";
        public static String TUES_SHUTDOWN_TIME_KEY         = "tues_shutdown_time";
        public static String TUES_SCHEDULE_ENABLE_KEY       = "tues_schedule_enable";
        public static String WED_STARTUP_TIME_KEY           = "wed_startup_time";
        public static String WED_SHUTDOWN_TIME_KEY          = "wed_shutdown_time";
        public static String WED_SCHEDULE_ENABLE_KEY        = "wed_schedule_enable";
        public static String THUR_STARTUP_TIME_KEY          = "thur_startup_time";
        public static String THUR_SHUTDOWN_TIME_KEY         = "thur_shutdown_time";
        public static String THUR_SCHEDULE_ENABLE_KEY       = "thur_schedule_enable";
        public static String FRI_STARTUP_TIME_KEY           = "fri_startup_time";
        public static String FRI_SHUTDOWN_TIME_KEY          = "fri_shutdown_time";
        public static String FRI_SCHEDULE_ENABLE_KEY        = "fri_schedule_enable";
        public static String SAT_STARTUP_TIME_KEY           = "sat_startup_time";
        public static String SAT_SHUTDOWN_TIME_KEY          = "sat_shutdown_time";
        public static String SAT_SCHEDULE_ENABLE_KEY        = "sat_schedule_enable";
        public static String SUN_STARTUP_TIME_KEY           = "sun_startup_time";
        public static String SUN_SHUTDOWN_TIME_KEY          = "sun_shutdown_time";
        public static String SUN_SCHEDULE_ENABLE_KEY        = "sun_schedule_enable";
        public static String GLOBAL_STARTUP_TIME_KEY        = "global_startup_time";
        public static String GLOBAL_SHUTDOWN_TIME_KEY       = "global_shutdown_time";
        public static String GLOBAL_SCHEDULE_ENABLE_KEY     = "global_schedule_enable";

        // ---------------- Auto open web url key ------------------------
        public static String WEB_URL_KEY                = "web_url";

        //private HashTable configs = new HashTable();        
        private Hashtable configs                       = null;

        public static ArrayList STARTUP_TIME_KEYS = new ArrayList(){
            MON_STARTUP_TIME_KEY,
            TUES_STARTUP_TIME_KEY,
            WED_STARTUP_TIME_KEY,
            THUR_STARTUP_TIME_KEY,
            FRI_STARTUP_TIME_KEY,
            SAT_STARTUP_TIME_KEY,
            SUN_STARTUP_TIME_KEY,
            GLOBAL_STARTUP_TIME_KEY
        };

        public static ArrayList SHUTDOWN_TIME_KEYS = new ArrayList() {
            MON_SHUTDOWN_TIME_KEY,
            TUES_SHUTDOWN_TIME_KEY,
            WED_SHUTDOWN_TIME_KEY,
            THUR_SHUTDOWN_TIME_KEY,
            FRI_SHUTDOWN_TIME_KEY,
            SAT_SHUTDOWN_TIME_KEY,
            SUN_SHUTDOWN_TIME_KEY,
            GLOBAL_SHUTDOWN_TIME_KEY
        };

        public static ArrayList SCHEDULE_ENABLE_KEYS = new ArrayList() {
            MON_SCHEDULE_ENABLE_KEY,
            TUES_SCHEDULE_ENABLE_KEY,
            WED_SCHEDULE_ENABLE_KEY,
            THUR_SCHEDULE_ENABLE_KEY,
            FRI_SCHEDULE_ENABLE_KEY,
            SAT_SCHEDULE_ENABLE_KEY,
            SUN_SCHEDULE_ENABLE_KEY,
            GLOBAL_SCHEDULE_ENABLE_KEY
        };

        public String get(String key) {
            return (String)configs[key];
        }

        public void set(String key, String value) {
            configs[key] = value;
        }

        public ScheduleConfig() {
            // 1. Initial config hashtable with default values
            configs = new Hashtable();
            // Monday
            configs.Add(MON_STARTUP_TIME_KEY, DEFAULT_STARTUP_TIME); 
            configs.Add(MON_SHUTDOWN_TIME_KEY, DEFAULT_SHUTDOWN_TIME);
            configs.Add(MON_SCHEDULE_ENABLE_KEY, DEFAULT_SCHEDULE_STATE);
            // Tuesday
            configs.Add(TUES_STARTUP_TIME_KEY, DEFAULT_STARTUP_TIME); 
            configs.Add(TUES_SHUTDOWN_TIME_KEY, DEFAULT_SHUTDOWN_TIME);
            configs.Add(TUES_SCHEDULE_ENABLE_KEY, DEFAULT_SCHEDULE_STATE);
            // Wednesday
            configs.Add(WED_STARTUP_TIME_KEY, DEFAULT_STARTUP_TIME); 
            configs.Add(WED_SHUTDOWN_TIME_KEY, DEFAULT_SHUTDOWN_TIME);
            configs.Add(WED_SCHEDULE_ENABLE_KEY, DEFAULT_SCHEDULE_STATE);
            // Thursday
            configs.Add(THUR_STARTUP_TIME_KEY, DEFAULT_STARTUP_TIME); 
            configs.Add(THUR_SHUTDOWN_TIME_KEY, DEFAULT_SHUTDOWN_TIME);
            configs.Add(THUR_SCHEDULE_ENABLE_KEY, DEFAULT_SCHEDULE_STATE);
            // FRIDAY
            configs.Add(FRI_STARTUP_TIME_KEY, DEFAULT_STARTUP_TIME); 
            configs.Add(FRI_SHUTDOWN_TIME_KEY, DEFAULT_SHUTDOWN_TIME);
            configs.Add(FRI_SCHEDULE_ENABLE_KEY, DEFAULT_SCHEDULE_STATE);
            // SATURDAY
            configs.Add(SAT_STARTUP_TIME_KEY, DEFAULT_STARTUP_TIME); 
            configs.Add(SAT_SHUTDOWN_TIME_KEY, DEFAULT_SHUTDOWN_TIME);
            configs.Add(SAT_SCHEDULE_ENABLE_KEY, DEFAULT_SCHEDULE_STATE);
            // SUNDAY
            configs.Add(SUN_STARTUP_TIME_KEY, DEFAULT_STARTUP_TIME); 
            configs.Add(SUN_SHUTDOWN_TIME_KEY, DEFAULT_SHUTDOWN_TIME);
            configs.Add(SUN_SCHEDULE_ENABLE_KEY, DEFAULT_SCHEDULE_STATE);
            // Global
            configs.Add(GLOBAL_STARTUP_TIME_KEY, DEFAULT_STARTUP_TIME); 
            configs.Add(GLOBAL_SHUTDOWN_TIME_KEY, DEFAULT_SHUTDOWN_TIME);
            configs.Add(GLOBAL_SCHEDULE_ENABLE_KEY, DEFAULT_SCHEDULE_STATE);
            // Web URL
            configs.Add(WEB_URL_KEY, DEFAULT_WEB_URL);
            
        }

        /**
         *  Used for debugging 
         */
        public String toString() {
            StringBuilder sb = new StringBuilder();
            foreach (String key in configs.Keys) {
                sb.Append(key + ":" + configs[key] + "\n");
            }
            return sb.ToString();
        }

    }
}
