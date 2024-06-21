using Microsoft.Win32;

SystemEvents.SessionSwitch += new SessionSwitchEventHandler(SystemEvents_SessionSwitch);

Console.WriteLine("Monitoring SessionSwitch Events...Press Enter to quit.");
Console.ReadLine();

SystemEvents.SessionSwitch -= SystemEvents_SessionSwitch;
Console.WriteLine("Monitoring stopped.");

void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
{
    if (e.Reason == SessionSwitchReason.SessionLock)
    {
        //I left my desk
        Console.WriteLine("Locked");
    }
    else if (e.Reason == SessionSwitchReason.SessionUnlock)
    {
        //I returned to my desk
        Console.WriteLine("Unlocked");
    }
}