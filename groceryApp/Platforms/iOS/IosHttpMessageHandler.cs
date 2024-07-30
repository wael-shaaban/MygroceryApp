﻿using groceryApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groceryApp.Platforms.iOS
{
    public class IosHttpMessageHandler : IPlatformMessageHanger
    {
        public HttpMessageHandler GetHttpMessageHandler() =>
        new NSUrlSessionHandler
        {
            TrustOverrideForUrl = (sender, url, trust) => url.StartsWith("https://localhost")
        };
    }
}