using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace usb_drvDet
{
    class Program
    {
        static void Main(string[] args)
        {
            var drives = DriveInfo.GetDrives();
            int USBDrv = 1;
            while (USBDrv ==1 )
            {
                USBDrv = 0; //set to 0 just before checking

                //for each drive look and see if it removable
                foreach (var drive in drives)
                {
                    if (drive.DriveType == DriveType.Removable)
                    {
                        //found a usb drive so show a message that always on top and set the varible USBDrv to 1
                        MessageBox.Show("Please remove the the USB drive and Click OK to Continue", "USB Drive Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                        USBDrv = 1;
                    }
                }
            }
            Environment.Exit(0);
        }
    }
}
