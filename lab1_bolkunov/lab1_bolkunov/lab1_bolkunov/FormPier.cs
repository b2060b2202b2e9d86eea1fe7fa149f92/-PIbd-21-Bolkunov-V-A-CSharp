using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace lab1_bolkunov
{
    public partial class FormPier : Form
    {
        private readonly Logger logger;

        private readonly PierCollection pierCollection;

        public FormPier()
        {
            InitializeComponent();
            pierCollection = new PierCollection(pierPictureBox.Width, pierPictureBox.Height);
            logger = LogManager.GetCurrentClassLogger();
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
                logger.Warn($"Ошибка при добавлении пристани: название пристани было пустым");
            }
            else
            {
                logger.Info($"Добавили пристань {pierNameTextBox.Text}");
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
                    logger.Info($"Удалили пристань {pierNameTextBox.Text}");
                    pierCollection.RemovePier(pierNameTextBox.Text);
                    ReloadPiers();
                }
            }
            else
            {
                MessageBox.Show("Не была выбрана пристань");
                logger.Warn($"Ошибка при удалениии пристани: не была выбрана пристань");
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
                        logger.Warn($"Ошибка при добавлении корабля на пристань: пристань переполнена");
                    }
                }
            }
            else
            {
                MessageBox.Show("Не была выбрана пристань");
                logger.Warn($"Ошибка при добавлении корабля на пристань: не была выбрана пристань");
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
                            logger.Warn($"Ошибка при добавлении теплохода на пристань: пристань переполнена");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Не была выбрана пристань");
                logger.Warn($"Ошибка при добавлении теплохода на пристань: не была выбрана пристань");
            }
        }

        private void TakeShipButton_Click(object sender, EventArgs e)
        {
            if (piersListBox.SelectedIndex > -1 && parkingPlaceMaskedTextBox.Text != "")
            {
                try
                {
                    var ship = pierCollection[piersListBox.SelectedItem.ToString()] - Convert.ToInt32(parkingPlaceMaskedTextBox.Text);
                    if (ship != null)
                    {
                        var form = new FormShip();
                        form.SetShip(ship);
                        form.ShowDialog();
                        logger.Info($"Изъят корабль {ship} с места {parkingPlaceMaskedTextBox.Text}");
                    }
                    Draw();
                }
                catch (PierShipNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Корабль не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Ошибка при заборе корабля с пристани: корабль не найден");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Неизвестная ошибка при заборе корабля с пристани");
                }
            }
            else
            {
                MessageBox.Show("Не была выбрана пристань или не был указан номер корабля");
                logger.Warn($"Ошибка при заборе корабля с пристани: не была выбрана пристань или не был указан номер корабля");
            }
        }

        private void PiersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на пристань {piersListBox.SelectedItem.ToString()}");
            Draw();
        }

        private void createShipButton_Click(object sender, EventArgs e)
        {
            var formShipConfig = new FormShipConfig();
            formShipConfig.AddEvent(AddShip);
            formShipConfig.Show();
        }

        private void AddShip(Ship ship)
        {
            if (ship != null && piersListBox.SelectedIndex > -1)
            {
                try
                {
                    if (pierCollection[piersListBox.SelectedItem.ToString()] + ship)
                    {
                        Draw();
                        logger.Info($"Добавлен корабль {ship}");
                    }
                    else
                    {
                        MessageBox.Show("Пристань переполнена");
                        logger.Warn($"Ошибка при добавлении корабля на пристань: пристань переполнена");
                    }
                }
                catch(PierOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Ошибка при добавлении корабля на пристань: пристань переполнена");
                }
                catch (PierShipAlreadyExistsException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Ошибка при добавлении корабля на пристань: такой корабль уже существует");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Неизвестная ошибка при добавлении корабля на пристань");
                }
            }
        }

        private void pierNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(((TextBox)sender).Text.Contains(PierCollection.separator) || ((TextBox)sender).Text.Contains(Ship.separator))
            {
                ((TextBox)sender).Text.Replace(PierCollection.separator.ToString(),"");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pierCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранено!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Неизвестная ошибка при сохранении");
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pierCollection.LoadData(loadFileDialog.FileName);
                    MessageBox.Show("Загружено!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + loadFileDialog.FileName);
                    ReloadPiers();
                    Draw();
                }
                catch (PierShipCannotBeAddedException ex)
                {
                    MessageBox.Show(ex.Message, "Невозможно добавить корабля на причал при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Ошибка при загрузке из файла: невозможно добавить корабля на причал");
                }
                catch (FileFormatException ex)
                {
                    MessageBox.Show(ex.Message, "Неверный формат файла при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Ошибка при загрузке из файла: неверный формат файла");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Неизвестная ошибка при загрузке из файла");
                }
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (piersListBox.SelectedIndex > -1)
            {
                pierCollection[piersListBox.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}
