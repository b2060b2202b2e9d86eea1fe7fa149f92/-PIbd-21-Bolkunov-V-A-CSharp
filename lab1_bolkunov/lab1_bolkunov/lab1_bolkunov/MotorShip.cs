using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_bolkunov
{
	public class MotorShip : Ship, IEquatable<MotorShip>
	{
		public Color AdditionalColor { private set; get; }

		public bool AdditionalBoat { private set; get; }
		public bool HelicopterPad { private set; get; }
		public bool Smoke { private set; get; }
		public bool Fire { private set; get; }

		private readonly int pipeCount;
		private readonly int pipeRadius;

		public MotorShip(int maxSpeed, float weight, Color mainColor, Color additionalColor, 
			bool additionalBoat, bool helipad, bool smoke, bool fire):base(maxSpeed,weight,mainColor)
		{
			AdditionalColor = additionalColor;

			AdditionalBoat = additionalBoat;
			HelicopterPad = helipad;
			Smoke = smoke;
			Fire = fire;

			Random rnd = new Random();
			pipeCount = rnd.Next(2, 6);
			pipeRadius = rnd.Next(12, 16);
		}

		public MotorShip(string str):base(str)
		{
			string[] strs = str.Split(separator);
			if (strs.Length == 8)
			{
				MaxSpeed = System.Convert.ToInt32(strs[0]);
				Weight = System.Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
				AdditionalColor = Color.FromName(strs[3]);

				AdditionalBoat = System.Convert.ToBoolean(strs[4]);
				HelicopterPad = System.Convert.ToBoolean(strs[5]);
				Smoke = System.Convert.ToBoolean(strs[6]);
				Fire = System.Convert.ToBoolean(strs[7]);
			}
		}

		public void SetAdditionalColor(Color color)
		{
			AdditionalColor = color;
		}

		public override void DrawTransport(Graphics g)
		{
			base.DrawTransport(g);

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
					boatPoint = new PointF(posX + (shipWidth / 2), posY  - (shipHeight * 2 / 3));
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
				g.FillEllipse(additionalBrush,rect);
				g.DrawEllipse(thinBlackPen, rect);

				//SMOKE
				if (Smoke)
				{
					int despertionRadius = 15;
					for (int j = 0; j < 5 + rnd.Next(10); j++)
					{
						int rad = 2 + rnd.Next(10);
						g.FillEllipse(smokeBrush, new Rectangle((int)(pipePoint.X - despertionRadius + rnd.Next(despertionRadius+1)), 
							(int)(pipePoint.Y - despertionRadius + rnd.Next(despertionRadius+1)), rad, rad));
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
					g.FillPie(fireBrush, new Rectangle((int)(posX - despertionRadius + rnd.Next(despertionRadius*2)), (int)(posY - despertionRadius + rnd.Next(despertionRadius*2)), rad, rad), (float)(rnd.NextDouble()* 360), (float)(rnd.NextDouble() * 360));
				}
			}
		}

        public bool Equals(MotorShip ship)
        {
            if (!((Ship)ship).Equals(this) || 
				AdditionalColor != ship.AdditionalColor || AdditionalBoat != ship.AdditionalBoat ||
                Fire != ship.Fire || HelicopterPad != ship.HelicopterPad || Smoke != ship.Smoke)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is MotorShip ship))
            {
                return false;
            }
            return Equals(ship);
        }

        public override string ToString()
		{
			return $"{base.ToString()}{separator}{AdditionalColor.Name}" +
									$"{separator}{AdditionalBoat}" +
									$"{separator}{HelicopterPad}" +
									$"{separator}{Smoke}" +
									$"{separator}{Fire}";
		}
	}
}
