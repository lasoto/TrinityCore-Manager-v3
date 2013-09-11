using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace TrinityCore_Manager.Misc
{

    static class VisualStudio
    {

        private const string VS10RegKey = @"Software\Microsoft\VisualStudio\10.0";
        private const string VS11RegKey = @"Software\Microsoft\VisualStudio\11.0";

        private const string DevEnvKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\devenv.exe";
        private const string VC10Key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\VCExpress.exe";

        private const string MSBuild4Key = @"SOFTWARE\Microsoft\MSBuild\ToolsVersions\4.0";


        public static VSVersion Version
        {
            get
            {

                RegistryKey vs10 = Registry.LocalMachine.OpenSubKey(VS10RegKey);
                RegistryKey vs11 = Registry.LocalMachine.OpenSubKey(VS11RegKey);

                if (vs11 != null && vs11.GetValueNames().Length > 0)
                    return VSVersion.VisualStudio11;
                if (vs10 != null && vs10.GetValueNames().Length > 0)
                    return VSVersion.VisualStudio10;


                return VSVersion.None;

            }
        }

        public static VSEnvironment Environment
        {
            get
            {

                RegistryKey dev = Registry.LocalMachine.OpenSubKey(DevEnvKey);
                RegistryKey vc = Registry.LocalMachine.OpenSubKey(VC10Key);

                if (dev != null)
                    return VSEnvironment.DevEnv;
                if (vc != null)
                    return VSEnvironment.VCExpress;

                return VSEnvironment.None;

            }
        }

        public static string GetCompilerPath()
        {

            RegistryKey regKey = Registry.LocalMachine.OpenSubKey(MSBuild4Key);

            if (regKey == null)
                return String.Empty;

            var toolPath = regKey.GetValue("MSBuildToolsPath");

            if (toolPath == null)
                return String.Empty;

            return Path.Combine(toolPath.ToString(), "MSBuild.exe");

        }

    }

    public enum VSVersion
    {
        None,
        VisualStudio10,
        VisualStudio11
    }

    public enum VSEnvironment
    {
        None,
        DevEnv,
        VCExpress
    }

}
