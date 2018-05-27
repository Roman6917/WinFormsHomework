using System.IO;

namespace WinFormsHomework.Utils
{
	public static class IOUtils
	{
		private const string DATA_FOLDER_NAME = "Data";
		private const string BIN_DEBUG_FOLDER_NAME = "bin\\Debug";

		public static string GetDataDirectoryPath()
		{
			return Directory.GetCurrentDirectory().Replace(BIN_DEBUG_FOLDER_NAME, DATA_FOLDER_NAME);
		}
	}
}