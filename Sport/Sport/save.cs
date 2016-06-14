using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;


namespace Sport
{
    class save
    {
        public static string site_name = "";
        public static string site_URL = "";
        static string regKeyName = "HKEY_CURRENT_USER\\SOFTWARE\\project";

        public static void WriteParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("SiteName", site_name);
                rk.SetValue("SiteURL", site_URL);

            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        public static void ReadParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk != null)
                {
                    site_name = (string)rk.GetValue("SiteName");
                    site_URL = (string)rk.GetValue("SiteURL");
                }

            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

    }
}
