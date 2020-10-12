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
		private ITransport transport;

		public FormShip()
		{
			InitializeComponent();
		}

		private void Draw()
		{
			if (transport != null)
			{
				Bitmap bmp = new Bitmap(shipPictureBox.Width, shipPictureBox.Height);
				Graphics gr = Graphics.FromImage(bmp);
				transport.DrawTransport(gr);
				shipPictureBox.Image = bmp;
			}
		}

		private void createShipButton_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			transport = new Ship(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.HotPink);
			transport.SetPosition(200+rnd.Next(10, 100), 200+rnd.Next(10, 100), shipPictureBox.Width, shipPictureBox.Height);
			Draw();
		}
		
		private void createMotorShipButton_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			transport = new MotorShip(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.HotPink, Color.SkyBlue, true, true, true, true);
			transport.SetPosition(200+rnd.Next(10, 100), 200+rnd.Next(10, 100), shipPictureBox.Width, shipPictureBox.Height);
			Draw();
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			if (transport != null)
			{
				string name = (sender as Button).Name;
				switch (name)
				{
					case "upButton":
						transport.MoveTransport(Direction.Up);
						break;
					case "downButton":
						transport.MoveTransport(Direction.Down);
						break;
					case "leftButton":
						transport.MoveTransport(Direction.Left);
						break;
					case "rightButton":
						transport.MoveTransport(Direction.Right);
						break;
				}
				Draw();
			}
		}
	}
}
