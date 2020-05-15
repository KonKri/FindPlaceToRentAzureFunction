﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FindPlaceToRent.Function.Models.Configuration
{
    public class SmtpSettings
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public bool EnableSsl { get; set; }
        public string From { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Recipients { get; set; }
    }
}