using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Donna
{
    internal class App_Info
    {
        public static string app_version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
    }
}
