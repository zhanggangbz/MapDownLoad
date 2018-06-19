using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LogHelper
{
    public static readonly log4net.ILog loginfo = log4net.LogManager.GetLogger("log4net");

    public static void WriteLog(string info)
    {

        if (loginfo.IsInfoEnabled)
        {
            loginfo.Info(info);
        }
    }
}
