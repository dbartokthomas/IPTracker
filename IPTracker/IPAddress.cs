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
        public static IPAddress GetExternalIp(IPAddressService finder = IPAddressService.WhatIsMyIpDotOrg)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Enum of the services we support
    /// </summary>
    public enum IPAddressService
    {
        /// <summary>
        /// Whatismyip.org
        /// </summary>
        WhatIsMyIpDotOrg    
    }
}
