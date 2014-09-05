using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CheeseAdServer.utils {
    abstract class AbstractThread {

        private Thread thread = null;

        abstract public void run();

        public void start() {
            if (thread == null) {
                thread = new Thread(run);
            }
            thread.Start();
        }
    }
}
