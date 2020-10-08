using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_bolkunov
{
	public abstract class Vehicle:ITransport
	{
		protected float posX;
		protected float posY;
		
		protected int pictureWidth;
		protected int pictureHeight;

		public int MaxSpeed { protected set; get; }
		public float Weight { protected set; get; }

		public Color MainColor { protected set; get; }

		public abstract void DrawTransport(Graphics g);
		public abstract void MoveTransport(Direction direction);

		public void SetPosition(int x, int y, int width, int height)
		{
			posX = x;
			posY = y;
			pictureWidth = width;
			pictureHeight = height;
		}
	}
}
