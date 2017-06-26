using CommonLib.Components;
using CommonLib.Configurations;
using CommonLib.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration
                .Create()
                .UseAutofac()
                .UseLog4Net()
                .RegisterUnhandledExceptionHandler();
            //测试应用程序级别的异常日志
            String str = null;
            str.ToString();
            //类级别的日志
            ILogger _logger = ObjectContainer.Resolve<ILoggerFactory>().Create(typeof(Program));
            _logger.Debug("ddd");
            _logger.Info("132342");
            _logger.Error("agadfad");
        }
    }
}
