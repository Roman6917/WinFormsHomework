using System;
using System.Windows.Forms;
using AppForm = WinFormsHomework.UI.AppForm;

namespace WinFormsHomework
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			try
			{
				Application.Run(new AppForm());
			}
			catch (Exception e)
			{
				Console.WriteLine($@"{e.Source}{e.Message}");
			}
		}
	}
}