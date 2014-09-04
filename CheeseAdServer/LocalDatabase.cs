using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using CheeseAdServer.utils;

namespace CheeseAdServer
{
    class LocalDatabase
    {
        private static LocalDatabase instance   = null;
        public static String CONFIG_PATH        = "schedule_data.xml";
        private static String TAG               = "LocalDatabase";

        private LocalDatabase() {

        }

        public static LocalDatabase getInstance() {
            if (instance == null) {
                instance = new LocalDatabase();
            }
            return instance;
        }

        /**
         * Fetch config from local xml file, encapsulate info to 
         * ScheduleConfig object
         */
        public ScheduleConfig getConfig() {
            // 1. Load xml config file
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(CONFIG_PATH);

            ScheduleConfig config = new ScheduleConfig();

            // 2. Fetch schedule auto startup/shutdown time  from xml config file
            XmlNodeList str_list = xmlDoc.SelectNodes("//string");
            foreach (XmlNode node in str_list)
            {
                XmlElement xe = (XmlElement)node;
                Log.d(TAG, xe.GetAttribute("name"));
                Log.d(TAG, xe.InnerText);
                config.set(xe.GetAttribute("name"), xe.InnerText);
            }

            // 3. Fetch schedule enable info from xml config file
            XmlNodeList int_list = xmlDoc.SelectNodes("//int");
            foreach (XmlNode node in int_list)
            {
                XmlElement xe = (XmlElement)node;
                Log.d(TAG, xe.GetAttribute("name"));
                Log.d(TAG, xe.GetAttribute("value"));
                config.set(xe.GetAttribute("name"), xe.GetAttribute("value"));
            }
            return config;
        }

        public void saveConfig(ScheduleConfig config) {

        }
    }
}
