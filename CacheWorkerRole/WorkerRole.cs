using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;
using Microsoft.WindowsAzure.Storage;

namespace CacheWorkerRole
{
    public class WorkerRole : RoleEntryPoint
    {
        // 不需要其他實作即可支援快取背景工作角色。 
        // 其他功能可能會影響快取服務的效能。 
        // 如需有關專用快取背景工作角色和快取服務的資訊， 
        // 請參閱 MSDN 說明文件，網址: http://go.microsoft.com/fwlink/?LinkID=247285
    }
}
