using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheeseAdServer
{
    class LocalDatabase
    {
        private static LocalDatabase instance   = null;

        private LocalDatabase() {

        }

        public static LocalDatabase getInstance() {
            if (instance == null) {
                instance = new LocalDatabase();
            }
            return instance;
        }

        public ScheduleConfig getConfig() {
            return null;
        }

        public void saveConfig(ScheduleConfig config) {

        }
    }
}
