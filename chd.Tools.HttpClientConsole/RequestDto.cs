using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Principal;
using System.Text;

namespace chd.Tools.HttpClientConsole
{
    public class RequestDto
    {
        public DateTime Time { get; set; } = DateTime.Now;
        public string Host { get; set; } = Environment.MachineName;
    }
}
