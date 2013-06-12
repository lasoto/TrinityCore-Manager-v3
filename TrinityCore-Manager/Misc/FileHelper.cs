using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCore_Manager.Misc
{
    static class FileHelper
    {

        public static void DeleteDirectory(string directory)
        {
            string[] files = Directory.GetFiles(directory);
            string[] dirs = Directory.GetDirectories(directory);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(directory, true);

        }

        public static void CopyDirectory(string directory, string dest)
        {

            if (!Directory.Exists(dest))
                Directory.CreateDirectory(dest);

            string[] files = Directory.GetFiles(directory);

            foreach (string file in files)
            {

                string filename = Path.GetFileName(file);
                string dFolder = Path.Combine(dest, filename);

                File.Copy(file, dFolder, true);

            }

            string[] dirs = Directory.GetDirectories(directory);

            foreach (string dir in dirs)
            {

                string dirname = Path.GetFileName(dir);
                string dFolder = Path.Combine(dest, dirname);
                CopyDirectory(dir, dFolder);

            }

        }

    }
}
