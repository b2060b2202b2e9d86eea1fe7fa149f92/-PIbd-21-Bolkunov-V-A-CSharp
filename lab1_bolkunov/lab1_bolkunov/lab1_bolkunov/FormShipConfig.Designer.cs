namespace lab1_bolkunov
{
	partial class FormShipConfig
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.parametersGroupBox = new System.Windows.Forms.GroupBox();
			this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.speedNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.smokeCheckBox = new System.Windows.Forms.CheckBox();
			this.fireCheckBox = new System.Windows.Forms.CheckBox();
			this.helicopterPadCheckBox = new System.Windows.Forms.CheckBox();
			this.additionalBoatCheckBox = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.typeGroupBox = new System.Windows.Forms.GroupBox();
			this.motorShipLabel = new System.Windows.Forms.Label();
			this.regularShipLabel = new System.Windows.Forms.Label();
			this.previewPictureBox = new System.Windows.Forms.PictureBox();
			this.previewPanel = new System.Windows.Forms.Panel();
			this.colorsGroupBox = new System.Windows.Forms.GroupBox();
			this.additionalColorLabel = new System.Windows.Forms.Label();
			this.mainColorLabel = new System.Windows.Forms.Label();
			this.orangePanel = new System.Windows.Forms.Panel();
			this.yellowPanel = new System.Windows.Forms.Panel();
			this.greenPanel = new System.Windows.Forms.Panel();
			this.redPanel = new System.Windows.Forms.Panel();
			this.blackPanel = new System.Windows.Forms.Panel();
			this.bluePanel = new System.Windows.Forms.Panel();
			this.whitePanel = new System.Windows.Forms.Panel();
			this.pinkPanel = new System.Windows.Forms.Panel();
			this.addButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.parametersGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).BeginInit();
			this.typeGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
			this.previewPanel.SuspendLayout();
			this.colorsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// parametersGroupBox
			// 
			this.parametersGroupBox.Controls.Add(this.weightNumericUpDown);
			this.parametersGroupBox.Controls.Add(this.speedNumericUpDown);
			this.parametersGroupBox.Controls.Add(this.smokeCheckBox);
			this.parametersGroupBox.Controls.Add(this.fireCheckBox);
			this.parametersGroupBox.Controls.Add(this.helicopterPadCheckBox);
			this.parametersGroupBox.Controls.Add(this.additionalBoatCheckBox);
			this.parametersGroupBox.Controls.Add(this.label2);
			this.parametersGroupBox.Controls.Add(this.label1);
			this.parametersGroupBox.Location = new System.Drawing.Point(12, 220);
			this.parametersGroupBox.Name = "parametersGroupBox";
			this.parametersGroupBox.Size = new System.Drawing.Size(473, 115);
			this.parametersGroupBox.TabIndex = 0;
			this.parametersGroupBox.TabStop = false;
			this.parametersGroupBox.Text = "Параметры";
			// 
			// weightNumericUpDown
			// 
			this.weightNumericUpDown.Location = new System.Drawing.Point(92, 83);
			this.weightNumericUpDown.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
			this.weightNumericUpDown.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
			this.weightNumericUpDown.Name = "weightNumericUpDown";
			this.weightNumericUpDown.Size = new System.Drawing.Size(55, 20);
			this.weightNumericUpDown.TabIndex = 6;
			this.weightNumericUpDown.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
			// 
			// speedNumericUpDown
			// 
			this.speedNumericUpDown.Location = new System.Drawing.Point(92, 32);
			this.speedNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.speedNumericUpDown.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            0});
			this.speedNumericUpDown.Name = "speedNumericUpDown";
			this.speedNumericUpDown.Size = new System.Drawing.Size(55, 20);
			this.speedNumericUpDown.TabIndex = 1;
			this.speedNumericUpDown.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
			// 
			// smokeCheckBox
			// 
			this.smokeCheckBox.AutoSize = true;
			this.smokeCheckBox.Checked = true;
			this.smokeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.smokeCheckBox.Location = new System.Drawing.Point(283, 88);
			this.smokeCheckBox.Name = "smokeCheckBox";
			this.smokeCheckBox.Size = new System.Drawing.Size(51, 17);
			this.smokeCheckBox.TabIndex = 5;
			this.smokeCheckBox.Text = "Дым";
			this.smokeCheckBox.UseVisualStyleBackColor = true;
			// 
			// fireCheckBox
			// 
			this.fireCheckBox.AutoSize = true;
			this.fireCheckBox.Checked = true;
			this.fireCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.fireCheckBox.Location = new System.Drawing.Point(283, 65);
			this.fireCheckBox.Name = "fireCheckBox";
			this.fireCheckBox.Size = new System.Drawing.Size(60, 17);
			this.fireCheckBox.TabIndex = 4;
			this.fireCheckBox.Text = "Пожар";
			this.fireCheckBox.UseVisualStyleBackColor = true;
			// 
			// helicopterPadCheckBox
			// 
			this.helicopterPadCheckBox.AutoSize = true;
			this.helicopterPadCheckBox.Checked = true;
			this.helicopterPadCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.helicopterPadCheckBox.Location = new System.Drawing.Point(283, 42);
			this.helicopterPadCheckBox.Name = "helicopterPadCheckBox";
			this.helicopterPadCheckBox.Size = new System.Drawing.Size(145, 17);
			this.helicopterPadCheckBox.TabIndex = 3;
			this.helicopterPadCheckBox.Text = "Вертолетная площадка";
			this.helicopterPadCheckBox.UseVisualStyleBackColor = true;
			// 
			// additionalBoatCheckBox
			// 
			this.additionalBoatCheckBox.AutoSize = true;
			this.additionalBoatCheckBox.Checked = true;
			this.additionalBoatCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.additionalBoatCheckBox.Location = new System.Drawing.Point(283, 19);
			this.additionalBoatCheckBox.Name = "additionalBoatCheckBox";
			this.additionalBoatCheckBox.Size = new System.Drawing.Size(141, 17);
			this.additionalBoatCheckBox.TabIndex = 1;
			this.additionalBoatCheckBox.Text = "Спасательная шлюпка";
			this.additionalBoatCheckBox.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Вес корабля:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Максимальная скорсть:";
			// 
			// typeGroupBox
			// 
			this.typeGroupBox.Controls.Add(this.motorShipLabel);
			this.typeGroupBox.Controls.Add(this.regularShipLabel);
			this.typeGroupBox.Location = new System.Drawing.Point(12, 12);
			this.typeGroupBox.Name = "typeGroupBox";
			this.typeGroupBox.Size = new System.Drawing.Size(168, 202);
			this.typeGroupBox.TabIndex = 1;
			this.typeGroupBox.TabStop = false;
			this.typeGroupBox.Text = "Тип корабля";
			// 
			// motorShipLabel
			// 
			this.motorShipLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.motorShipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.motorShipLabel.Location = new System.Drawing.Point(16, 117);
			this.motorShipLabel.Name = "motorShipLabel";
			this.motorShipLabel.Size = new System.Drawing.Size(131, 59);
			this.motorShipLabel.TabIndex = 3;
			this.motorShipLabel.Text = "Теплоход";
			this.motorShipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.motorShipLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.motorShipLabel_MouseDown);
			// 
			// regularShipLabel
			// 
			this.regularShipLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.regularShipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.regularShipLabel.Location = new System.Drawing.Point(16, 33);
			this.regularShipLabel.Name = "regularShipLabel";
			this.regularShipLabel.Size = new System.Drawing.Size(131, 59);
			this.regularShipLabel.TabIndex = 2;
			this.regularShipLabel.Text = "Обычный корабль";
			this.regularShipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.regularShipLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.regularShipLabel_MouseDown);
			// 
			// previewPictureBox
			// 
			this.previewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.previewPictureBox.Location = new System.Drawing.Point(0, 0);
			this.previewPictureBox.Name = "previewPictureBox";
			this.previewPictureBox.Size = new System.Drawing.Size(298, 202);
			this.previewPictureBox.TabIndex = 2;
			this.previewPictureBox.TabStop = false;
			this.previewPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.previewPanel_DragDrop);
			this.previewPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.previewPanel_DragEnter);
			// 
			// previewPanel
			// 
			this.previewPanel.AllowDrop = true;
			this.previewPanel.Controls.Add(this.previewPictureBox);
			this.previewPanel.Location = new System.Drawing.Point(186, 12);
			this.previewPanel.Name = "previewPanel";
			this.previewPanel.Size = new System.Drawing.Size(298, 202);
			this.previewPanel.TabIndex = 3;
			this.previewPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.previewPanel_DragDrop);
			this.previewPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.previewPanel_DragEnter);
			// 
			// colorsGroupBox
			// 
			this.colorsGroupBox.Controls.Add(this.additionalColorLabel);
			this.colorsGroupBox.Controls.Add(this.mainColorLabel);
			this.colorsGroupBox.Controls.Add(this.orangePanel);
			this.colorsGroupBox.Controls.Add(this.yellowPanel);
			this.colorsGroupBox.Controls.Add(this.greenPanel);
			this.colorsGroupBox.Controls.Add(this.redPanel);
			this.colorsGroupBox.Controls.Add(this.blackPanel);
			this.colorsGroupBox.Controls.Add(this.bluePanel);
			this.colorsGroupBox.Controls.Add(this.whitePanel);
			this.colorsGroupBox.Controls.Add(this.pinkPanel);
			this.colorsGroupBox.Location = new System.Drawing.Point(493, 12);
			this.colorsGroupBox.Name = "colorsGroupBox";
			this.colorsGroupBox.Size = new System.Drawing.Size(226, 199);
			this.colorsGroupBox.TabIndex = 4;
			this.colorsGroupBox.TabStop = false;
			this.colorsGroupBox.Text = "Цвета";
			// 
			// additionalColorLabel
			// 
			this.additionalColorLabel.AllowDrop = true;
			this.additionalColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.additionalColorLabel.Location = new System.Drawing.Point(123, 16);
			this.additionalColorLabel.Name = "additionalColorLabel";
			this.additionalColorLabel.Size = new System.Drawing.Size(95, 65);
			this.additionalColorLabel.TabIndex = 1;
			this.additionalColorLabel.Text = "Доплнительный цвет";
			this.additionalColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.additionalColorLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.additionalColorLabel_DragDrop);
			this.additionalColorLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.colorLabel_DragEnter);
			// 
			// mainColorLabel
			// 
			this.mainColorLabel.AllowDrop = true;
			this.mainColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mainColorLabel.Location = new System.Drawing.Point(6, 16);
			this.mainColorLabel.Name = "mainColorLabel";
			this.mainColorLabel.Size = new System.Drawing.Size(98, 65);
			this.mainColorLabel.TabIndex = 0;
			this.mainColorLabel.Text = "Основной цвет";
			this.mainColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mainColorLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainColorLabel_DragDrop);
			this.mainColorLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.colorLabel_DragEnter);
			// 
			// orangePanel
			// 
			this.orangePanel.BackColor = System.Drawing.Color.OrangeRed;
			this.orangePanel.Location = new System.Drawing.Point(178, 107);
			this.orangePanel.Name = "orangePanel";
			this.orangePanel.Size = new System.Drawing.Size(40, 40);
			this.orangePanel.TabIndex = 5;
			// 
			// yellowPanel
			// 
			this.yellowPanel.BackColor = System.Drawing.Color.Yellow;
			this.yellowPanel.Location = new System.Drawing.Point(178, 153);
			this.yellowPanel.Name = "yellowPanel";
			this.yellowPanel.Size = new System.Drawing.Size(40, 40);
			this.yellowPanel.TabIndex = 3;
			// 
			// greenPanel
			// 
			this.greenPanel.BackColor = System.Drawing.Color.Olive;
			this.greenPanel.Location = new System.Drawing.Point(123, 107);
			this.greenPanel.Name = "greenPanel";
			this.greenPanel.Size = new System.Drawing.Size(40, 40);
			this.greenPanel.TabIndex = 6;
			// 
			// redPanel
			// 
			this.redPanel.BackColor = System.Drawing.Color.DarkRed;
			this.redPanel.Location = new System.Drawing.Point(123, 153);
			this.redPanel.Name = "redPanel";
			this.redPanel.Size = new System.Drawing.Size(40, 40);
			this.redPanel.TabIndex = 3;
			// 
			// blackPanel
			// 
			this.blackPanel.BackColor = System.Drawing.Color.Black;
			this.blackPanel.Location = new System.Drawing.Point(64, 107);
			this.blackPanel.Name = "blackPanel";
			this.blackPanel.Size = new System.Drawing.Size(40, 40);
			this.blackPanel.TabIndex = 7;
			// 
			// bluePanel
			// 
			this.bluePanel.BackColor = System.Drawing.Color.DarkTurquoise;
			this.bluePanel.Location = new System.Drawing.Point(6, 107);
			this.bluePanel.Name = "bluePanel";
			this.bluePanel.Size = new System.Drawing.Size(40, 40);
			this.bluePanel.TabIndex = 4;
			// 
			// whitePanel
			// 
			this.whitePanel.BackColor = System.Drawing.Color.White;
			this.whitePanel.Location = new System.Drawing.Point(64, 153);
			this.whitePanel.Name = "whitePanel";
			this.whitePanel.Size = new System.Drawing.Size(40, 40);
			this.whitePanel.TabIndex = 3;
			// 
			// pinkPanel
			// 
			this.pinkPanel.BackColor = System.Drawing.Color.HotPink;
			this.pinkPanel.Location = new System.Drawing.Point(6, 153);
			this.pinkPanel.Name = "pinkPanel";
			this.pinkPanel.Size = new System.Drawing.Size(40, 40);
			this.pinkPanel.TabIndex = 2;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(616, 262);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(95, 31);
			this.addButton.TabIndex = 5;
			this.addButton.Text = "Добавить";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(616, 300);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(95, 31);
			this.cancelButton.TabIndex = 6;
			this.cancelButton.Text = "Отмена";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// FormShipConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(723, 343);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.colorsGroupBox);
			this.Controls.Add(this.previewPanel);
			this.Controls.Add(this.typeGroupBox);
			this.Controls.Add(this.parametersGroupBox);
			this.Name = "FormShipConfig";
			this.Text = "FormShipConfig";
			this.parametersGroupBox.ResumeLayout(false);
			this.parametersGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).EndInit();
			this.typeGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
			this.previewPanel.ResumeLayout(false);
			this.colorsGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox parametersGroupBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown weightNumericUpDown;
		private System.Windows.Forms.NumericUpDown speedNumericUpDown;
		private System.Windows.Forms.CheckBox smokeCheckBox;
		private System.Windows.Forms.CheckBox fireCheckBox;
		private System.Windows.Forms.CheckBox helicopterPadCheckBox;
		private System.Windows.Forms.CheckBox additionalBoatCheckBox;
		private System.Windows.Forms.GroupBox typeGroupBox;
		private System.Windows.Forms.Label motorShipLabel;
		private System.Windows.Forms.Label regularShipLabel;
		private System.Windows.Forms.PictureBox previewPictureBox;
		private System.Windows.Forms.Panel previewPanel;
		private System.Windows.Forms.GroupBox colorsGroupBox;
		private System.Windows.Forms.Label additionalColorLabel;
		private System.Windows.Forms.Panel orangePanel;
		private System.Windows.Forms.Panel yellowPanel;
		private System.Windows.Forms.Panel greenPanel;
		private System.Windows.Forms.Panel redPanel;
		private System.Windows.Forms.Panel blackPanel;
		private System.Windows.Forms.Panel bluePanel;
		private System.Windows.Forms.Panel whitePanel;
		private System.Windows.Forms.Panel pinkPanel;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label mainColorLabel;
    }
}