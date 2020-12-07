using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_bolkunov
{
	public partial class FormShipConfig : Form
	{
		Ship ship = null;
		private event Action<Ship> eventAddShip;

		public FormShipConfig()
		{
			InitializeComponent();
			cancelButton.Click += (s, a) => { Close(); };

			greenPanel.MouseDown += colorPanel_MouseDown;
			orangePanel.MouseDown += colorPanel_MouseDown;
			pinkPanel.MouseDown += colorPanel_MouseDown;
			redPanel.MouseDown += colorPanel_MouseDown;
			whitePanel.MouseDown += colorPanel_MouseDown;
			blackPanel.MouseDown += colorPanel_MouseDown;
			bluePanel.MouseDown += colorPanel_MouseDown;
			yellowPanel.MouseDown += colorPanel_MouseDown;
		}

		public void DrawShip()
		{
			if(ship != null)
			{
				Bitmap bmp = new Bitmap(previewPictureBox.Width, previewPictureBox.Height);
				Graphics gr = Graphics.FromImage(bmp);
				ship.SetPosition(previewPictureBox.Width/2, previewPictureBox.Height/2, previewPictureBox.Width, previewPictureBox.Height);
				ship.DrawTransport(gr);
				previewPictureBox.Image = bmp;
			}
		}

		public void AddEvent(Action<Ship> eventHandler)
		{
			if(eventAddShip is null)
			{
				eventAddShip = new Action<Ship>(eventHandler);
			}
			else
			{
				eventAddShip += eventHandler;
			}
		}

		private void regularShipLabel_MouseDown(object sender, MouseEventArgs e)
		{
			DoDragDrop(regularShipLabel.Text, DragDropEffects.Copy | DragDropEffects.Move);
		}

		private void motorShipLabel_MouseDown(object sender, MouseEventArgs e)
		{
			DoDragDrop(motorShipLabel.Text, DragDropEffects.Copy | DragDropEffects.Move);
		}

		private void previewPanel_DragEnter(object sender, DragEventArgs e)
		{
			if(e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void previewPanel_DragDrop(object sender, DragEventArgs e)
		{
			switch(e.Data.GetData(DataFormats.Text).ToString())
			{
				case "Обычный корабль":
					ship = new Ship((int)speedNumericUpDown.Value, (int)weightNumericUpDown.Value, Color.HotPink);
					break;
				case "Теплоход":
					ship = new MotorShip((int)speedNumericUpDown.Value, (int)weightNumericUpDown.Value, Color.HotPink, Color.Aqua,
						additionalBoatCheckBox.Checked, helicopterPadCheckBox.Checked, smokeCheckBox.Checked, fireCheckBox.Checked);
					break;
			}
			DrawShip();
		}

		private void colorPanel_MouseDown(object sender, MouseEventArgs args)
		{
			DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Copy | DragDropEffects.Move);
		}

		private void colorLabel_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(Color)))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void mainColorLabel_DragDrop(object sender, DragEventArgs e)
		{
            var color = (Color)(e.Data.GetData(typeof(Color)));
            ship?.SetMainColor(color);
            DrawShip();
		}

		private void additionalColorLabel_DragDrop(object sender, DragEventArgs e)
		{
			var color = (Color)(e.Data.GetData(typeof(Color)));
			if (ship != null && ship is MotorShip)
				((MotorShip)ship).SetAdditionalColor(color);
            DrawShip();
        }

		private void addButton_Click(object sender, EventArgs args)
		{
			eventAddShip?.Invoke(ship);
			Close();
		}
	}
}
