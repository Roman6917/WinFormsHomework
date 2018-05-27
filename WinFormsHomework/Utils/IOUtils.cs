using System.IO;

namespace Quadrilateral_Task2.Utils
{
    public static class IOUtils
    {
        public const string DATA_FOLDER_NAME = "Data";
        public const string BIN_DEBUG_FOLDER_NAME = "bin\\Debug";

        public static string GetDataDirectoryPath()
        {
            return Directory.GetCurrentDirectory().Replace(BIN_DEBUG_FOLDER_NAME, DATA_FOLDER_NAME);
        }
    }
}
