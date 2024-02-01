using System.Diagnostics;

namespace DjX.Providers.Abstractions;

public interface ISystemProcessProvider
{
    Process StartProcess(string fileName, string arguments);
}
