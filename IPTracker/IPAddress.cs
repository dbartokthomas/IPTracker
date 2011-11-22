using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPTracker
{
    public class IPAddress
    {
        public string IP { get; private set; }

        /// <summary>
        /// Try and fetch the External IP Address
        /// </summary>
        /// <param name="finder"></param>
        /// <returns></returns>
        public static IPAddress GetExternalIp(IPAddressFinder finder = IPAddressFinder.WhatIsMyIpDotOrg)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Enum of the providers we support
    /// </summary>
    public enum IPAddressFinder
    {
        /// <summary>
        /// Whatismyip.org
        /// </summary>
        WhatIsMyIpDotOrg    
    }
}
