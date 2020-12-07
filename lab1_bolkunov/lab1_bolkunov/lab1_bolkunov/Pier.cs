using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_bolkunov
{
    public class Pier<T> where T: class, ITransport
    {
        private readonly List<T> places;
        private int maxCount;

        private readonly int pictureWidth;
        private readonly int pictureHeight;

        private readonly int placeSizeWidth = 350;
        private readonly int placeSizeHeight = 100;

        public Pier(int picWidth, int picHeight)
        {
            int width = picWidth / placeSizeWidth;
            int height = picHeight / placeSizeHeight;
            maxCount = width * height;
            places = new List<T>();
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static bool operator +(Pier<T> p, T ship)
        {
            if(p.places.Count >= p.maxCount)
            {
                throw new PierOverflowException();
            }
            p.places.Add(ship);
            return true;
        }

        public static T operator -(Pier<T> p, int index)
        {
            if(index <= -1 || index >= p.places.Count)
            {
                throw new PierShipNotFoundException(index);
            }

            T ship = p.places[index];
            p.places.RemoveAt(index);
            return ship;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            int height = pictureHeight / placeSizeHeight;
            for (int i = 0; i < places.Count; i++)
            {
                places[i].SetPosition(i / height * placeSizeWidth + placeSizeWidth / 2, i % height * placeSizeHeight + placeSizeHeight / 2, pictureWidth, pictureHeight);
                places[i].DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + placeSizeWidth / 2, j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, (pictureHeight / placeSizeHeight) * placeSizeHeight);
            }
        }

        public T GetElementAt(int index)
        {
            if (index < 0 || index >= places.Count)
            {
                return null;
            }
            return places[index];
        }
    }
}
