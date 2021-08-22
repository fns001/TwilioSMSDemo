﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwilioSMSDemo.Models
{
    public class SmsAlertArgs
    {
        public string Message { get; set; }
        public string Description { get; set; }
        public Blazorise.Color Color { get; set; }
    }
}
