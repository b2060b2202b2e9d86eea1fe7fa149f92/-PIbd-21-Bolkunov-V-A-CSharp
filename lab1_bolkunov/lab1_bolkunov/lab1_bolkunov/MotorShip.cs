using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_bolkunov
{
	class MotorShip
	{
		private float posX;
		private float posY;

		private int pictureWidth;
		private int pictureHeight;

		private readonly int shipWidth = 50;
		private readonly int shipHeight = 120;

		public int MaxSpeed { private set; get; }
		public float Weight { private set; get; }

		public Color MainColor { private set; get; }
		public Color AdditionalColor { private set; get; }

		public bool AdditionalBoat { private set; get; }
		public bool HelicopterPad { private set; get; }
		public bool Smoke { private set; get; }
		public bool Fire { private set; get; }

		private Direction lastDirection = Direction.Right;

		private readonly int pipeCount;
		private readonly int pipeRadius;

		public MotorShip(int maxSpeed, float weight, Color mainColor, Color additionalColor, bool additionalBoat, bool helipad, bool smoke, bool fire)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			AdditionalColor = additionalColor;

			AdditionalBoat = additionalBoat;
			HelicopterPad = helipad;
			Smoke = smoke;
			Fire = fire;

			Random rnd = new Random();
			pipeCount = rnd.Next(2, 6);
			pipeRadius = rnd.Next(12, 16);
		}

		public void SetPosition(int x, int y, int width, int height)
		{
			posX = x;
			posY = y;
			pictureWidth = width;
			pictureHeight = height;
		}

		public void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 500 / Weight;
			float offsetMult = 1.5f;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (posX + step < pictureWidth - shipHeight* offsetMult)
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
					if (posY - step - shipHeight * offsetMult  > 0)
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

		public void DrawTransport(Graphics g)
		{
			Random rnd = new Random();

			Pen thickBlackPen = new Pen(Color.Black);
			Pen thinBlackPen = new Pen(Color.Black);
			Pen additionlPen = new Pen(AdditionalColor);
			Pen mainPen = new Pen(MainColor);
			thickBlackPen.Width = 10;
			thinBlackPen.Width = 2;
			additionlPen.Width = 10;
			mainPen.Width = 5;

			Brush mainBrush = new SolidBrush(MainColor);
			Brush additionalBrush = new SolidBrush(AdditionalColor);
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
			g.DrawPolygon(thickBlackPen, boatPolygonPoints);
			g.FillPolygon(mainBrush, boatPolygonPoints);

			PointF[] innerSturcturePolygonPoints = new PointF[] { boatPolygonPoints[0], boatPolygonPoints[2], boatPolygonPoints[4] };
			g.DrawPolygon(thickBlackPen, innerSturcturePolygonPoints);
			g.FillPolygon(blackBrush, innerSturcturePolygonPoints);

			PointF[] innerSturcture2PolygonPoints = new PointF[] { boatPolygonPoints[1], boatPolygonPoints[3], boatPolygonPoints[5] };
			g.DrawPolygon(thickBlackPen, innerSturcture2PolygonPoints);
			g.FillPolygon(mainBrush, innerSturcture2PolygonPoints);

			//BOAT
			if (AdditionalBoat)
			{
				PointF boatPoint;
				if (lastDirection == Direction.Left || lastDirection == Direction.Right)
				{
					boatPoint = new PointF(posX - (shipHeight * 2 / 3), posY + (shipWidth / 2));
					g.FillEllipse(brownBrush, new Rectangle((int)boatPoint.X, (int)boatPoint.Y, (int)(shipHeight / 3), (int)(shipWidth / 3)));
				}
				else
				{
					boatPoint = new PointF(posX + (shipWidth / 2), posY - (shipHeight * 2 / 3));
					g.FillEllipse(brownBrush, new Rectangle((int)boatPoint.X, (int)boatPoint.Y, (int)(shipWidth / 3), (int)(shipHeight / 3)));
				}
			}

			//PAD
			if (HelicopterPad)
			{
				int helipadSidesOffset = 3;
				var helipadRect =
					new Rectangle((int)(posX - shipWidth / 2 + helipadSidesOffset),
					(int)(posY - shipWidth / 2 + helipadSidesOffset),
					shipWidth - helipadSidesOffset * 2,
					shipWidth - helipadSidesOffset * 2);

				g.FillRectangle(blackBrush, helipadRect);
				g.DrawRectangle(additionlPen, helipadRect);
			}

			//PIPES AND SMOKE
			for (int i = 0; i < pipeCount; i++)
			{
				//PIPES
				if (HelicopterPad & i == (int)pipeCount / 2) continue;

				PointF pipePoint;
				if (lastDirection == Direction.Left || lastDirection == Direction.Right)
				{
					pipePoint = new PointF(posX + (-pipeCount / 2 + i) * pipeRadius * 3, posY);
				}
				else
				{
					pipePoint = new PointF(posX, posY + (-pipeCount / 2 + i) * pipeRadius * 3);
				}

				var rect = new Rectangle((int)pipePoint.X - pipeRadius, (int)pipePoint.Y - pipeRadius, pipeRadius * 2, pipeRadius * 2);
				g.FillEllipse(additionalBrush, rect);
				g.DrawEllipse(thinBlackPen, rect);

				//SMOKE
				if (Smoke)
				{
					int despertionRadius = 15;
					for (int j = 0; j < 5 + rnd.Next(10); j++)
					{
						int rad = 2 + rnd.Next(10);
						g.FillEllipse(smokeBrush, new Rectangle((int)(pipePoint.X - despertionRadius + rnd.Next(despertionRadius + 1)),
							(int)(pipePoint.Y - despertionRadius + rnd.Next(despertionRadius + 1)), rad, rad));
					}
				}
			}

			//FIRE
			if (Fire)
			{
				int despertionRadius = 15;
				for (int i = 0; i < 30 + rnd.Next(25); i++)
				{
					int rad = 5 + rnd.Next(10);
					g.FillPie(fireBrush, new Rectangle((int)(posX - despertionRadius + rnd.Next(despertionRadius * 2)), (int)(posY - despertionRadius + rnd.Next(despertionRadius * 2)), rad, rad), (float)(rnd.NextDouble() * 360), (float)(rnd.NextDouble() * 360));
				}
			}
		}
	}
}
