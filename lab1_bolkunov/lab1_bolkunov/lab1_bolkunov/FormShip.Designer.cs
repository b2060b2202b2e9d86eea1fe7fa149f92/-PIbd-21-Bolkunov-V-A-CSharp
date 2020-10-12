namespace lab1_bolkunov
{
	partial class FormShip
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.createShipButton = new System.Windows.Forms.Button();
			this.upButton = new System.Windows.Forms.Button();
			this.rightButton = new System.Windows.Forms.Button();
			this.downButton = new System.Windows.Forms.Button();
			this.leftButton = new System.Windows.Forms.Button();
			this.shipPictureBox = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.shipPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// createShipButton
			// 
			this.createShipButton.Location = new System.Drawing.Point(10, 10);
			this.createShipButton.Margin = new System.Windows.Forms.Padding(15);
			this.createShipButton.Name = "createShipButton";
			this.createShipButton.Size = new System.Drawing.Size(120, 30);
			this.createShipButton.TabIndex = 1;
			this.createShipButton.Text = "Создать корабль";
			this.createShipButton.UseVisualStyleBackColor = true;
			this.createShipButton.Click += new System.EventHandler(this.createShipButton_Click);
			// 
			// upButton
			// 
			this.upButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.upButton.BackgroundImage = global::lab1_bolkunov.Properties.Resources.Up1;
			this.upButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.upButton.Cursor = System.Windows.Forms.Cursors.PanNorth;
			this.upButton.Location = new System.Drawing.Point(1106, 683);
			this.upButton.Name = "upButton";
			this.upButton.Size = new System.Drawing.Size(30, 30);
			this.upButton.TabIndex = 5;
			this.upButton.UseVisualStyleBackColor = true;
			this.upButton.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// rightButton
			// 
			this.rightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.rightButton.BackgroundImage = global::lab1_bolkunov.Properties.Resources.Right;
			this.rightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.rightButton.Cursor = System.Windows.Forms.Cursors.PanEast;
			this.rightButton.Location = new System.Drawing.Point(1142, 719);
			this.rightButton.Name = "rightButton";
			this.rightButton.Size = new System.Drawing.Size(30, 30);
			this.rightButton.TabIndex = 4;
			this.rightButton.UseVisualStyleBackColor = true;
			this.rightButton.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// downButton
			// 
			this.downButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.downButton.BackgroundImage = global::lab1_bolkunov.Properties.Resources.Down;
			this.downButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.downButton.Cursor = System.Windows.Forms.Cursors.PanSouth;
			this.downButton.Location = new System.Drawing.Point(1106, 719);
			this.downButton.Name = "downButton";
			this.downButton.Size = new System.Drawing.Size(30, 30);
			this.downButton.TabIndex = 3;
			this.downButton.UseVisualStyleBackColor = true;
			this.downButton.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// leftButton
			// 
			this.leftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.leftButton.BackgroundImage = global::lab1_bolkunov.Properties.Resources.Left;
			this.leftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.leftButton.Cursor = System.Windows.Forms.Cursors.PanWest;
			this.leftButton.Location = new System.Drawing.Point(1070, 719);
			this.leftButton.Name = "leftButton";
			this.leftButton.Size = new System.Drawing.Size(30, 30);
			this.leftButton.TabIndex = 2;
			this.leftButton.UseVisualStyleBackColor = true;
			this.leftButton.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// shipPictureBox
			// 
			this.shipPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.shipPictureBox.Location = new System.Drawing.Point(0, 0);
			this.shipPictureBox.Name = "shipPictureBox";
			this.shipPictureBox.Size = new System.Drawing.Size(1184, 761);
			this.shipPictureBox.TabIndex = 0;
			this.shipPictureBox.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(148, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 31);
			this.button1.TabIndex = 6;
			this.button1.Text = "Создать теплоход";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.createMotorShipButton_Click);
			// 
			// FormShip
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 761);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.upButton);
			this.Controls.Add(this.rightButton);
			this.Controls.Add(this.downButton);
			this.Controls.Add(this.leftButton);
			this.Controls.Add(this.createShipButton);
			this.Controls.Add(this.shipPictureBox);
			this.Name = "FormShip";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Теплоходик";
			((System.ComponentModel.ISupportInitialize)(this.shipPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox shipPictureBox;
		private System.Windows.Forms.Button createShipButton;
		private System.Windows.Forms.Button leftButton;
		private System.Windows.Forms.Button downButton;
		private System.Windows.Forms.Button rightButton;
		private System.Windows.Forms.Button upButton;
		private System.Windows.Forms.Button button1;
	}
}

