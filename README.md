# Determine programmatically pending reboot status for a Windows machine in C#
By using ISystemInformation interface (wuapi.dll), you can check, if the Windows Update Agent (WUA) requires a reboot of the system.

ISystemInformation::get_RebootRequired
Gets a Boolean value that indicates whether a system restart is required to complete the installation or uninstallation of one or more updates.

<img src="images/win10rebootpending.png">


# Further readings
https://www.prugg.at/2019/06/19/determine-programmatically-pending-reboot-status-for-a-windows-machine-in-c-and-powershell/
