﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet.Simple.Service.Monitoring.Library.Monitoring.Exceptions.AlertBehaviour
{
    public class AlertBehaviourException : Exception
    {
        public AlertBehaviourException(string message) : base(message)
        {
        }
    }
}
