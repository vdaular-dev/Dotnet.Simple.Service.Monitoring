﻿using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CuttingEdge.Conditions;
using Dotnet.Simple.Service.Monitoring.Library.Models;
using Dotnet.Simple.Service.Monitoring.Library.Models.TransportSettings;
using Dotnet.Simple.Service.Monitoring.Library.Monitoring.Abstractions;
using Dotnet.Simple.Service.Monitoring.Library.Monitoring.Exceptions.AlertBehaviour;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Dotnet.Simple.Service.Monitoring.Library.Monitoring.Implementations.Publishers
{
    public class EmailAlertingPublisher : PublisherBase
    {
        private EmailTransportSettings _emailTransportSettings;
        public EmailAlertingPublisher(IHealthChecksBuilder healthChecksBuilder, 
            ServiceHealthCheck healthCheck, 
            AlertTransportSettings alertTransportSettings) : 
            base(healthChecksBuilder, healthCheck, alertTransportSettings)
        {
            _emailTransportSettings = (EmailTransportSettings)alertTransportSettings;
        }

        public override Task PublishAsync(HealthReport report, CancellationToken cancellationToken)
        {
            base.PublishAsync(report, cancellationToken);

            var entry = report
                .Entries
                .FirstOrDefault(x => x.Key == this._healthCheck.Name);

            if (entry.Key != this._healthCheck.Name) return Task.CompletedTask;

            //Do work

            return Task.CompletedTask;
        }

        protected internal override void Validate()
        {
            Condition.Requires(_emailTransportSettings.From)
                .IsNotNull();
            Condition.Requires(_emailTransportSettings.SmtpHost)
                .IsNotNull();
            Condition.Requires(_emailTransportSettings.To)
                .IsNotNull();
        }

        protected internal override void SetPublishing()
        {
            this._healthChecksBuilder.Services.AddSingleton<IHealthCheckPublisher>(sp =>
            {
                return this;
            });
        }
    }
}
