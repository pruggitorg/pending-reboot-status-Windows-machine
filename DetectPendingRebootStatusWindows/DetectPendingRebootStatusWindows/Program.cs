using System;
using WUApiLib;

namespace DetectPendingRebootStatusWindows
{
    class Program
    {
        static void Main(string[] args)
        {
            ISystemInformation systemInfo = new SystemInformation();

            Console.WriteLine(systemInfo.RebootRequired.ToString());

            Console.ReadLine();
        }
    }
}
