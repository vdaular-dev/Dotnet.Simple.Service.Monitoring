﻿using Microsoft.Extensions.Diagnostics.HealthChecks;
using Simple.Service.Monitoring.Library.Models;
using Simple.Service.Monitoring.Library.Monitoring.Abstractions;
using Simple.Service.Monitoring.Library.Options;
using System;

namespace Simple.Service.Monitoring.Extensions
{
    public interface IServiceMonitoringConfigurationService
    {
        IServiceMonitoringConfigurationService WithAdditionalCheck(ServiceHealthCheck monitor);
        IServiceMonitoringConfigurationService WithApplicationSettings();
        IServiceMonitoringConfigurationService WithRuntimeSettings(MonitorOptions options);
        IServiceMonitoringConfigurationService WithAdditionalPublisherObserver(IReportObserver observer, bool useAlertingRules = true);
        IServiceMonitoringConfigurationService WithAdditionalPublishing(ServiceHealthCheck monitor);
        IServiceMonitoringConfigurationService WithAdditionalPublisher(PublisherBase publisher);
    }
}
