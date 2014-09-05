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
            ScheduleConfig config = new ScheduleConfig();
            Log.d(TAG, config.toString());

            // 1. Load xml config file
            XmlDocument xmlDoc = new XmlDocument();
            try {
                xmlDoc.Load(CONFIG_PATH);
            } catch (Exception e) {
                Log.d(TAG, "Load " + CONFIG_PATH + " error: " + e.StackTrace);
                return config;
            }


            // 2. Fetch schedule auto startup/shutdown time  from xml config file
            XmlNodeList str_list = xmlDoc.SelectNodes("//string");
            foreach (XmlNode node in str_list)
            {
                XmlElement xe = (XmlElement)node;
                if (xe.GetAttribute("name") != null) {
                    Log.d(TAG, xe.GetAttribute("name"));
                }
                if (xe.InnerText != null) {
                    Log.d(TAG, xe.InnerText);
                    config.set(xe.GetAttribute("name"), xe.InnerText);
                }
            }

            // 3. Fetch schedule enable info from xml config file
            XmlNodeList int_list = xmlDoc.SelectNodes("//int");
            foreach (XmlNode node in int_list)
            {
                XmlElement xe = (XmlElement)node;
                if (xe.GetAttribute("name") != null) {
                    Log.d(TAG, xe.GetAttribute("name"));
                }
                if (xe.GetAttribute("value") != null) {
                    Log.d(TAG, xe.GetAttribute("value"));
                    config.set(xe.GetAttribute("name"), xe.GetAttribute("value"));
                }
            }
            return config;
        }

        public void saveConfig(ScheduleConfig config) {
            XmlDocument doc = new XmlDocument();

            XmlNode header = doc.CreateXmlDeclaration("1.0", "utf-8", "yes"); 
            doc.AppendChild(header);

            XmlElement root = doc.CreateElement("map");
            doc.AppendChild(root);

            // All startup time
            foreach (String key in ScheduleConfig.STARTUP_TIME_KEYS) {
                XmlElement startup_time_e = doc.CreateElement("string");
                XmlAttribute startup_time_name = doc.CreateAttribute("name");
                startup_time_name.Value = key;
                startup_time_e.Attributes.Append(startup_time_name);
                startup_time_e.InnerText = config.get(key);
                root.AppendChild(startup_time_e);
            }
            // All shutdown time
            foreach (String key in ScheduleConfig.SHUTDOWN_TIME_KEYS) {
                XmlElement shutdown_time_e = doc.CreateElement("string");
                XmlAttribute shutdown_time_name = doc.CreateAttribute("name");
                shutdown_time_name.Value = key;
                shutdown_time_e.Attributes.Append(shutdown_time_name);
                shutdown_time_e.InnerText = config.get(key);
                root.AppendChild(shutdown_time_e);
            }
            // All schedule enable
            foreach (String key in ScheduleConfig.SCHEDULE_ENABLE_KEYS) {
                XmlElement schedule_enable_e = doc.CreateElement("int");
                XmlAttribute schedule_enable_name = doc.CreateAttribute("name");
                schedule_enable_name.Value = key;
                schedule_enable_e.Attributes.Append(schedule_enable_name);
                XmlAttribute schedule_enable_value = doc.CreateAttribute("value");
                schedule_enable_value.Value = config.get(key);
                schedule_enable_e.Attributes.Append(schedule_enable_value);
                root.AppendChild(schedule_enable_e);
            }
            doc.Save(CONFIG_PATH);
        }
    }
}
