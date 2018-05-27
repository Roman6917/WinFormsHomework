using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormsHomework.BL;
using WinFormsHomework.POCO;
using WinFormsHomework.Utils;

namespace WinFormsHomework.UI
{
	public partial class AppForm : Form
	{
		private readonly Graphics _graphics;
		private Quadrilateral _quadrilateralToDraw;
		private Quadrilateral _activeQquadrilateral;
		private List<Quadrilateral> _quadrilaterals;
		private bool _isFigureChecked;
		private static int _doubleClickCounter;

		public AppForm()
		{
			InitializeComponent();
			_graphics = panelMain.CreateGraphics();
			_quadrilaterals = new List<Quadrilateral>();
			_quadrilateralToDraw = new Quadrilateral();
			_isFigureChecked = false;
			_doubleClickCounter = 0;
		}

		private void New_Click(object sender, EventArgs e)
		{
			Reset();
		}

		private void Open_Click(object sender, EventArgs e)
		{
			openFileDialog1 = Utils.UI.CreateOpenFileDialog();
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				Reset();
				_quadrilaterals = QuadrilateralBl.DeserializeList(openFileDialog1.FileName);
				Graphic.Redraw(panelMain, _graphics, _quadrilaterals);
			}
		}

		private void Save_Click(object sender, EventArgs e)
		{
			saveFileDialog1 = Utils.UI.CreateSaveFileDialog();

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				QuadrilateralBl.SerializeList(_quadrilaterals, saveFileDialog1.FileName);
			}
		}

		private void PanelMain_DoubleClick(object sender, EventArgs e)
		{
			var mouseEvent = e as MouseEventArgs;
			if (mouseEvent != null && mouseEvent.Button == MouseButtons.Left)
			{
				var point = new Point(mouseEvent.Location.X, mouseEvent.Location.Y);
				if (_quadrilateralToDraw.AddPoint(point) == false && _doubleClickCounter == 3)
				{
					_quadrilaterals.Add(_quadrilateralToDraw);
					_quadrilateralToDraw = new Quadrilateral();
					Graphic.Redraw(panelMain, _graphics, _quadrilaterals);
					_doubleClickCounter = 0;
				}
				else
				{
					_doubleClickCounter++;
				}

				Utils.UI.SetTextToLabel(labelCounter,
					$"Додайте ще {Quadrilateral.SIZE - _quadrilateralToDraw.Count()} точки щоб утворити {Quadrilateral.SIZE}-кутник ");
			}
		}

		private void PolygonColor_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK && _activeQquadrilateral != null)
			{
				_quadrilaterals.Remove(_activeQquadrilateral);
				_activeQquadrilateral.Color = colorDialog1.Color;
				_quadrilaterals.Add(_activeQquadrilateral);
				Graphic.Redraw(panelMain, _graphics, _quadrilaterals);
			}
		}

		private void ShapesMenu_Click(object sender, EventArgs e)
		{
			Utils.UI.LoadShapesMenu(shapesMenu, ShapesMenuDropDown_Click);
		}

		private void ShapesMenuDropDown_Click(object sender, EventArgs e)
		{
			var filename = (sender as ToolStripMenuItem)?.Text;
			_quadrilaterals.AddRange(QuadrilateralBl.LoadFigures(filename));
			Graphic.Redraw(panelMain, _graphics, _quadrilaterals);
		}

		private void PanelMain_Click(object sender, EventArgs e)
		{
			var mouseEvent = e as MouseEventArgs;
			if (mouseEvent != null && mouseEvent.Button == MouseButtons.Right)
			{
				var point = new Point(mouseEvent.Location.X, mouseEvent.Location.Y);

				if (!_isFigureChecked)
				{
					_activeQquadrilateral = _quadrilaterals.FirstOrDefault(p => Geometry.IsInPolygon(p.ToArray(), point));
					if (_activeQquadrilateral != null)
					{
						_isFigureChecked = true;
						Utils.UI.Show(labelFigureChecked, buttonCancel, buttonPolygonColor);
					}
				}
				else
				{
					if (_activeQquadrilateral == null)
					{
						throw new ApplicationException("error, this figure does not exist ... ");
					}

					_quadrilaterals.Remove(_activeQquadrilateral);
					_activeQquadrilateral = QuadrilateralBl.MoveToPoint(_activeQquadrilateral, point);
					_quadrilaterals.Add(_activeQquadrilateral);
					Graphic.Redraw(panelMain, _graphics, _quadrilaterals);
				}
			}
		}

		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			_isFigureChecked = false;
			Utils.UI.Hide(labelFigureChecked, buttonCancel, buttonPolygonColor);
		}

		private void InformationMenu_Click(object sender, EventArgs e)
		{
			if (Utils.UI.CreateInformationWindow() == DialogResult.Yes)
			{
				Close();
			}
		}
	}
}