using System;
using Avalonia.Controls;
using AvaloniaDesktopSpecificHeads.Services;

namespace AvaloniaDesktopSpecificHeads.Mac.Services;

internal class MacPlatformService : IPlatformService
{
    public void ShowMessage()
    {
        var window = new Window
        {
            Content = "This is Mac"
        };
        // Call some Mac specific APIs
    }
}
