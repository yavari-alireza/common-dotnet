﻿using log4net;

namespace Appson.Common.Logging
{
    public static class CommonStaticLogs
    {
        public static readonly ILog Debug = LogManager.GetLogger("Debug");
        public static readonly ILog ScheduledTask = LogManager.GetLogger("ScheduledTask");
	    public static readonly ILog UserAgent = LogManager.GetLogger("UserAgent");
    }
}