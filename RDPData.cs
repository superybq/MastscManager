﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MstscManager
{
    public static class RDPData
    {
        private const string data = @"screen mode id:i:1
use multimon:i:0
desktopwidth:i:{4}
desktopheight:i:{5}
session bpp:i:{6}
winposstr:s:0,1,0,0,1920,1040
compression:i:1
keyboardhook:i:2
audiocapturemode:i:0
videoplaybackmode:i:1
connection type:i:7
networkautodetect:i:1
bandwidthautodetect:i:1
displayconnectionbar:i:1
enableworkspacereconnect:i:0
disable wallpaper:i:0
allow font smoothing:i:0
allow desktop composition:i:0
disable full window drag:i:1
disable menu anims:i:1
disable themes:i:0
disable cursor setting:i:0
bitmapcachepersistenable:i:1
full address:s:{0}
audiomode:i:0
redirectprinters:i:0
redirectcomports:i:0
redirectsmartcards:i:1
redirectclipboard:i:1
redirectposdevices:i:0
autoreconnection enabled:i:1
authentication level:i:2
prompt for credentials:i:0
negotiate security layer:i:1
remoteapplicationmode:i:0
alternate shell:s:
shell working directory:s:
gatewayhostname:s:
gatewayusagemethod:i:4
gatewaycredentialssource:i:4
gatewayprofileusagemethod:i:0
promptcredentialonce:i:0
gatewaybrokeringtype:i:0
use redirection server name:i:0
rdgiskdcproxy:i:0
kdcproxyname:s:
drivestoredirect:s:
username:s:{1}
domain:s:{3}
password 51:b:{2}
";

        public static string GetRDPData(string address, string username, string password, string domain, string desktopwidth, string desktopheight, string color)
        {
            byte[] secret = Encoding.Unicode.GetBytes(password);
            byte[] encryptedSecret = RDPCodeTools.Protect(secret);
            string res = string.Empty;
            foreach (byte b in encryptedSecret)
            {
                res += b.ToString("X2");
            }

            return string.Format(data, address, username, res, domain, desktopwidth, desktopheight, color);
        }
    }
}
