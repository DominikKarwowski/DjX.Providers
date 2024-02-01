namespace DjX.Providers.Abstractions;

public interface ITimeProvider
{
    DateTime Now { get; }
    DateTime Today { get; }
}