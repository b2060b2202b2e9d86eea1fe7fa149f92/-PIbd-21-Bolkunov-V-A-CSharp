using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_bolkunov
{
	class Ship: Vehicle
	{
		protected readonly int shipWidth = 50;
		protected readonly int shipHeight = 120;

		protected Direction lastDirection = Direction.Right;

		public Ship(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}

		protected Ship(int maxSpeed, float weight, Color mainColor, int shipWidth, int shipHeight):this(maxSpeed,weight,mainColor)
		{
			this.shipHeight = shipHeight;
			this.shipWidth = shipWidth;
		}

		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 500 / Weight;
			float offsetMult = 1.5f;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (posX + step < pictureWidth - shipHeight * offsetMult)
					{
						posX += step;
					}
					break;
				//влево
				case Direction.Left:
					if (posX - step - shipHeight * offsetMult > 0)
					{
						posX -= step;
					}
					break;
				//вверх
				case Direction.Up:
					if (posY - step - shipHeight * offsetMult > 0)
					{
						posY -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (posY + step < pictureHeight - shipHeight * offsetMult)
					{
						posY += step;
					}
					break;
			}
			lastDirection = direction;
		}

		public override void DrawTransport(Graphics g)
		{
			Pen blackPen = new Pen(Color.Black);
			Pen mainPen = new Pen(MainColor);
			blackPen.Width = 10;
			mainPen.Width = 5;

			Brush mainBrush = new SolidBrush(MainColor);
			Brush blackBrush = new SolidBrush(Color.Black);
			Brush smokeBrush = new SolidBrush(Color.DarkGray);
			Brush brownBrush = new SolidBrush(Color.SaddleBrown);
			Brush fireBrush = new SolidBrush(Color.OrangeRed);

			PointF[] boatPolygonPoints = new PointF[6];
			if (lastDirection == Direction.Left || lastDirection == Direction.Right)
			{
				boatPolygonPoints[0] = new PointF(posX - (shipHeight * 2 / 3), posY - (shipWidth / 2));
				boatPolygonPoints[1] = new PointF(posX + (shipHeight * 2 / 3), posY - (shipWidth / 2));
				boatPolygonPoints[2] = new PointF(posX + shipHeight, posY);
				boatPolygonPoints[3] = new PointF(posX + (shipHeight * 2 / 3), posY + (shipWidth / 2));
				boatPolygonPoints[4] = new PointF(posX - (shipHeight * 2 / 3), posY + (shipWidth / 2));
				boatPolygonPoints[5] = new PointF(posX - shipHeight, posY);
			}
			else
			{
				boatPolygonPoints[0] = new PointF(posX - (shipWidth / 2), posY - (shipHeight * 2 / 3));
				boatPolygonPoints[1] = new PointF(posX - (shipWidth / 2), posY + (shipHeight * 2 / 3));
				boatPolygonPoints[2] = new PointF(posX, posY + shipHeight);
				boatPolygonPoints[3] = new PointF(posX + (shipWidth / 2), posY + (shipHeight * 2 / 3));
				boatPolygonPoints[4] = new PointF(posX + (shipWidth / 2), posY - (shipHeight * 2 / 3));
				boatPolygonPoints[5] = new PointF(posX, posY - shipHeight);
			}
			g.DrawPolygon(blackPen, boatPolygonPoints);
			g.FillPolygon(mainBrush, boatPolygonPoints);

			PointF[] innerSturcturePolygonPoints = new PointF[] { boatPolygonPoints[0], boatPolygonPoints[2], boatPolygonPoints[4] };
			g.DrawPolygon(blackPen, innerSturcturePolygonPoints);
			g.FillPolygon(blackBrush, innerSturcturePolygonPoints);

			PointF[] innerSturcture2PolygonPoints = new PointF[] { boatPolygonPoints[1], boatPolygonPoints[3], boatPolygonPoints[5] };
			g.DrawPolygon(blackPen, innerSturcture2PolygonPoints);
			g.FillPolygon(mainBrush, innerSturcture2PolygonPoints);

		}
	}
}
