using DjX.Providers.Abstractions;

namespace DjX.Providers;

public class TimeProvider : ITimeProvider
{
    public DateTime Now => DateTime.Now;
    public DateTime Today => DateTime.Today;
}
