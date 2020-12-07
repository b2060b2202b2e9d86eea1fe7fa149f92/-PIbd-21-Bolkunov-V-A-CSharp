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
        private readonly PierCollection pierCollection;

        public FormPier()
        {
            InitializeComponent();
            pierCollection = new PierCollection(pierPictureBox.Width, pierPictureBox.Height);
        }

        private void ReloadPiers()
        {
            int index = piersListBox.SelectedIndex;

            piersListBox.Items.Clear();

            piersListBox.Items.AddRange(pierCollection.Keys.ToArray());

            if (piersListBox.Items.Count > 0 && (index == -1 || index >= piersListBox.Items.Count))
            {
                piersListBox.SelectedIndex = 0;
            }
            else if (piersListBox.Items.Count > 0 && index > -1 && index < piersListBox.Items.Count)
            {
                piersListBox.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (piersListBox.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pierPictureBox.Width, pierPictureBox.Height);
                Graphics gr = Graphics.FromImage(bmp);
                pierCollection[piersListBox.SelectedItem.ToString()].Draw(gr);
                pierPictureBox.Image = bmp;
            }
        }


        private void AddPierButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(pierNameTextBox.Text))
            {
                MessageBox.Show("Введите название пристани", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pierCollection.AddPier(pierNameTextBox.Text);
                ReloadPiers();
            }
        }

        private void RemovePierButton_Click(object sender, EventArgs e)
        {
            if (piersListBox.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить пристань {piersListBox.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pierCollection.RemovePier(pierNameTextBox.Text);
                    ReloadPiers();
                }
            }
        }

        private void ParkShipButton_Click(object sender, EventArgs e)
        {
            if (piersListBox.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var ship = new Ship(150, 1500, dialog.Color);
                    if (pierCollection[piersListBox.SelectedItem.ToString()] + ship)
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

        private void ParkMotorShipButton_Click(object sender, EventArgs e)
        {
            if (piersListBox.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var ship = new MotorShip(100, 1000, dialog.Color, dialogDop.Color, true, true, true, true);
                        if (pierCollection[piersListBox.SelectedItem.ToString()] + ship)
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
        }

        private void TakeShipButton_Click(object sender, EventArgs e)
        {
            if (piersListBox.SelectedIndex > -1 && parkingPlaceMaskedTextBox.Text != "")
            {
                var ship = pierCollection[piersListBox.SelectedItem.ToString()] - Convert.ToInt32(parkingPlaceMaskedTextBox.Text);
                if (ship != null)
                {
                    var form = new FormShip();
                    form.SetShip(ship);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void PiersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
