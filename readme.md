usb_drvDet 1.0
Written by jgeau in c# requires .net 4.0 or higher

usb_drvDet.exe is just a simple tool that displays a dialog box asking the user to remove the USB drive if one is found on the machine.

The message box is always on top so the user can't send it behind other apps.

It doesn't not require admin rights

This was originally written to run in WinPE just before a reboot in order to prompt the user to remove and boot disks that may be inserted. If no disk is in the drive it will exit with code 0.

.Net must be included in your WinPE image for this to work in WinPE.


