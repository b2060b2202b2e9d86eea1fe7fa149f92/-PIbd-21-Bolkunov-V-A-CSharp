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
	public partial class FormShip : Form
	{
		private MotorShip ship;

		public FormShip()
		{
			InitializeComponent();
		}

		private void Draw()
		{
			if (ship != null)
			{
				Bitmap bmp = new Bitmap(shipPictureBox.Width, shipPictureBox.Height);
				Graphics gr = Graphics.FromImage(bmp);
				ship.DrawTransport(gr);
				shipPictureBox.Image = bmp;
			}
		}

		private void createShipButton_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			ship = new MotorShip(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.HotPink, Color.SkyBlue, true, true, true, true);
			ship.SetPosition(200+rnd.Next(10, 100), 200+rnd.Next(10, 100), shipPictureBox.Width, shipPictureBox.Height);
			Draw();
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			if (ship != null)
			{
				string name = (sender as Button).Name;
				switch (name)
				{
					case "upButton":
						ship.MoveTransport(Direction.Up);
						break;
					case "downButton":
						ship.MoveTransport(Direction.Down);
						break;
					case "leftButton":
						ship.MoveTransport(Direction.Left);
						break;
					case "rightButton":
						ship.MoveTransport(Direction.Right);
						break;
				}
				Draw();
			}
		}
	}
}
