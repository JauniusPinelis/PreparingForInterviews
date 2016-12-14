using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SolutionRunner.Runners
{

    
    public abstract class Runner
    {
        private readonly ILog log;

        public Runner()
        {
            log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        }

        protected void Log(string message)
        {
            this.log.Error(message);
        }
        
        private void Run()
        {

        }
    }
}
