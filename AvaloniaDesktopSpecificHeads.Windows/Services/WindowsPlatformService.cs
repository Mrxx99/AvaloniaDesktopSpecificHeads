using System.Windows;
using AvaloniaDesktopSpecificHeads.Services;

namespace AvaloniaDesktopSpecificHeads.Windows.Services;

internal class WindowsPlatformService : IPlatformService
{
    public void ShowMessage()
    {
        MessageBox.Show("This is windows");
    }
}
