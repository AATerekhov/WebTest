using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace WebTest
{
    public class MyHaelphCheck : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            return new HealthCheckResult(HealthStatus.Healthy);
        }
    }
}
