﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Forecast.Models
{
    public class HostInformation
    {
        /// <summary>
        /// The certificate found on the host 
        /// </summary>
        public CertInfo Cert { get; set; }

        /// <summary>
        /// Indicates if a ping/connection was able to be made to the host
        /// </summary>
        public bool CouldPingHostName { get; set; }

        /// <summary>
        /// Indicates if the target address family was present on the DNS entries.
        /// </summary>
        public bool HasTargetAddressFamily { get; set; }
        /// <summary>
        /// The host name
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// Indicates if the host name was valid
        /// </summary>
        public bool HostValid { get; set; }

        /// <summary>
        /// The list of IP addresses that matches the target family
        /// </summary>
        public List<AddressInformation> AddressInformation { get; set; }
        /// <summary>
        /// The port the host is listening on.
        /// </summary>
        public ushort Port { get; set; }

        /// <summary>
        /// The address family the host is listening on.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AddressFamily AddressFamily { get; set; }
    }
}
