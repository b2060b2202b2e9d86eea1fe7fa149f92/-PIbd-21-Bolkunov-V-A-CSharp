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
    public partial class FormPier : Form
    {
        private readonly Pier<Ship> pier;

        public FormPier()
        {
            InitializeComponent();
            pier = new Pier<Ship>(pierPictureBox.Width, pierPictureBox.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pierPictureBox.Width, pierPictureBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            pier.Draw(gr);
            pierPictureBox.Image = bmp;
        }

        private void ParkShipButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new Ship(150, 1500, dialog.Color);

                if (pier + ship)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Пристань переполнена");
                }
            }
        }

        private void ParkMotorShipButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var ship = new MotorShip(100, 1000, dialog.Color, dialogDop.Color, true, true, true, true);
                    if (pier + ship)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Пристань переполнена");
                    }
                }
            }
        }

        private void TakeShipButton_Click(object sender, EventArgs e)
        {
            if (parkingPlaceMaskedTextBox.Text != "")
            {
                var ship = pier - Convert.ToInt32(parkingPlaceMaskedTextBox.Text);
                if (ship != null)
                {
                    var form = new FormShip();
                    form.SetShip(ship);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
