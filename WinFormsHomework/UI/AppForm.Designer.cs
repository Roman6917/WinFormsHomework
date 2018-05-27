using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WinFormsHomework.POCO;

namespace WinFormsHomework.UI
{
    partial class AppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Dispose

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelCounter = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonPolygonColor = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelFigureChecked = new System.Windows.Forms.Label();
            this.informationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.headerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerMenu
            // 
            this.headerMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.headerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.shapesMenu,
            this.informationMenu});
            this.headerMenu.Location = new System.Drawing.Point(0, 0);
            this.headerMenu.Name = "headerMenu";
            this.headerMenu.Size = new System.Drawing.Size(1269, 33);
            this.headerMenu.TabIndex = 0;
            this.headerMenu.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.newToolStripMenuItem1,
            this.toolStripSeparator2,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(50, 29);
            this.fileMenu.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(140, 30);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.New_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.Open_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(137, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.Save_Click);
            // 
            // shapesMenu
            // 
            this.shapesMenu.Name = "shapesMenu";
            this.shapesMenu.Size = new System.Drawing.Size(81, 29);
            this.shapesMenu.Text = "Shapes";
            this.shapesMenu.Click += new System.EventHandler(this.ShapesMenu_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = Color.FromArgb(136, 231, 133);
            this.panelMain.Location = new System.Drawing.Point(0, 35);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 500);
            this.panelMain.TabIndex = 4;
            this.panelMain.Click += new System.EventHandler(this.PanelMain_Click);
            this.panelMain.DoubleClick += new System.EventHandler(this.PanelMain_DoubleClick);
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.BackColor = System.Drawing.Color.White;
            this.labelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCounter.Location = new System.Drawing.Point(151, 35);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(20, 25);
            this.labelCounter.TabIndex = 4;
            this.labelCounter.Text = "Додайте 4 точки щоб утворити чотириктуник";
            // 
            // buttonPolygonColor
            // 
            this.buttonPolygonColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPolygonColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPolygonColor.ForeColor = System.Drawing.Color.Black;
            this.buttonPolygonColor.Location = new System.Drawing.Point(800, 290);
            this.buttonPolygonColor.Name = "buttonPolygonColor";
            this.buttonPolygonColor.Size = new System.Drawing.Size(250, 50);
            this.buttonPolygonColor.TabIndex = 4;
            this.buttonPolygonColor.Text = "Змінити колір";
            this.buttonPolygonColor.UseVisualStyleBackColor = false;
            this.buttonPolygonColor.Visible = false;
            this.buttonPolygonColor.Click += new System.EventHandler(this.PolygonColor_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.White;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular
                , System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(0, 501);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(850, 50);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Нажміть лівою кнопокю мишки два рази на полотні, щоб додати точку(за або проти го" +
    "динникової стрілки)\r\nЩоб вибрати фігуру(якщо ви її вже створили), клацніть на не" +
    "ї правою кнопкою миші";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = Color.FromArgb(127, 255, 126);
            this.buttonCancel.Location = new System.Drawing.Point(1040, 290);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(246, 49);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Відмінити";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelFigureChecked
            // 
            this.labelFigureChecked.AutoSize = true;
            this.labelFigureChecked.BackColor = Color.FromArgb(255, 241, 174);
            this.labelFigureChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFigureChecked.Location = new System.Drawing.Point(800, 82);
            this.labelFigureChecked.Name = "labelFigureChecked";
            this.labelFigureChecked.Size = new System.Drawing.Size(474, 200);
            this.labelFigureChecked.TabIndex = 10;
            this.labelFigureChecked.Text = "Ви вибрали фігуру\r\n\r\nЩоб пересувати її клацніть правою кнопкою\r\nмиші один раз в точку," +
                                           " куди бажаєте \r\nпересунути(на полотні)\r\n\r\nЩоб змінити колір нажміть кнопку " +
    "змінити колір\r\n                        \r\n";
            this.labelFigureChecked.Visible = false;
            // 
            // informationMenu
            // 
            this.informationMenu.Name = "informationMenu";
            this.informationMenu.Size = new System.Drawing.Size(118, 29);
            this.informationMenu.Text = "Information";
            this.informationMenu.Click += new System.EventHandler(this.InformationMenu_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(255, 225, 208);
            this.ClientSize = new System.Drawing.Size(1269, 570);
            this.Controls.Add(this.labelFigureChecked);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPolygonColor);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.headerMenu);
            this.MainMenuStrip = this.headerMenu;
            this.Name = "AppForm";
            this.Text = "Drawing Qquadrilaterals";
            this.headerMenu.ResumeLayout(false);
            this.headerMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Form components control

        /// <summary>
        /// Reset form to initial state
        /// </summary>
        private void Reset()
        {
            panelMain.Refresh();
            labelCounter.Visible = true;
            buttonPolygonColor.Visible = false;
            labelCounter.Text = "Додайте ще 4 точки щоб утворити чотириктуник";
            _quadrilaterals = new List<Quadrilateral>();
            _quadrilateralToDraw = new Quadrilateral();
            _activeQquadrilateral = null;
            buttonCancel.Visible = false;
            labelFigureChecked.Visible = false;
            _isFigureChecked = false;
            _doubleClickCounter = 0;
        }

        #endregion

        private MenuStrip headerMenu;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem newToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem shapesMenu;
        private Panel panelMain;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private Label labelCounter;
        private ColorDialog colorDialog1;
        private Button buttonPolygonColor;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label labelInfo;
        private Button buttonCancel;
        private Label labelFigureChecked;
        private ToolStripMenuItem informationMenu;
    }
}

