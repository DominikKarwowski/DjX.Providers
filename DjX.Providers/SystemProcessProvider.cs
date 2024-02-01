using DjX.Providers.Abstractions;
using System.Diagnostics;

namespace DjX.Providers;
public class SystemProcessProvider : ISystemProcessProvider
{
    public Process StartProcess(string fileName, string arguments) =>
        Process.Start(fileName, arguments);
}
