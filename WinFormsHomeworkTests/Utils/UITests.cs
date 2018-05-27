using System.Linq;
using System.Windows.Forms;
using WinFormsHomework.Utils;
using Xunit;

namespace WinFormsHomeworkTests.Utils
{
	public class UITests
	{
		[Fact]
		public void EnableTest()
		{
			var controls = new Control[] {new Button {Enabled = false}};
			UI.Enable(controls);
			Assert.True(controls.Any(p => p.Enabled));
		}

		[Fact]
		public void DisableTest()
		{
			var controls = new Control[]
			{
				new Button {Enabled = true},
				new Button {Enabled = true},
				new Button {Enabled = true},
				new Button {Enabled = true}
			};
			UI.Disable(controls);
			Assert.True(controls.Any(p => p.Enabled == false));
		}

		[Fact]
		public void HideTest()
		{
			var controls = new Control[]
			{
				new Button {Visible = true},
				new Button {Visible = true},
				new Button {Visible = true},
				new Button {Visible = true}
			};
			UI.Hide(controls);
			Assert.True(controls.Any(p => p.Visible == false));
		}

		[Fact]
		public void ShowTest()
		{
			var controls = new Control[]
			{
				new Button {Visible = false},
				new Button {Visible = false},
				new Button {Visible = false},
				new Button {Visible = false}
			};
			UI.Show(controls);
			Assert.True(controls.Any(p => p.Visible));
		}

		[Fact]
		public void CreateOpenFileDialogTest()
		{
			Assert.NotNull(UI.CreateOpenFileDialog());
		}

		[Fact]
		public void CreateInformationWindowTest()
		{
			Assert.NotNull(UI.CreateInformationWindow());
		}

		[Fact]
		public void CreateSaveFileDialogTest()
		{
			Assert.NotNull(UI.CreateSaveFileDialog());
		}
	}
}