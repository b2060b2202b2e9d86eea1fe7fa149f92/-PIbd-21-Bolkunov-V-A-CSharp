namespace lab1_bolkunov
{
    partial class FormPier
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
            this.parkShipButton = new System.Windows.Forms.Button();
            this.pierPictureBox = new System.Windows.Forms.PictureBox();
            this.parkMotorShipButton = new System.Windows.Forms.Button();
            this.takeShipGroupBox = new System.Windows.Forms.GroupBox();
            this.placeLabel = new System.Windows.Forms.Label();
            this.parkingPlaceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.takeShipButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pierPictureBox)).BeginInit();
            this.takeShipGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // parkShipButton
            // 
            this.parkShipButton.Location = new System.Drawing.Point(1131, 12);
            this.parkShipButton.Name = "parkShipButton";
            this.parkShipButton.Size = new System.Drawing.Size(141, 23);
            this.parkShipButton.TabIndex = 2;
            this.parkShipButton.Text = "Припарковать корабль";
            this.parkShipButton.UseVisualStyleBackColor = true;
            this.parkShipButton.Click += new System.EventHandler(this.ParkShipButton_Click);
            // 
            // pierPictureBox
            // 
            this.pierPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pierPictureBox.Location = new System.Drawing.Point(0, 0);
            this.pierPictureBox.Name = "pierPictureBox";
            this.pierPictureBox.Size = new System.Drawing.Size(1113, 761);
            this.pierPictureBox.TabIndex = 1;
            this.pierPictureBox.TabStop = false;
            // 
            // parkMotorShipButton
            // 
            this.parkMotorShipButton.Location = new System.Drawing.Point(1131, 41);
            this.parkMotorShipButton.Name = "parkMotorShipButton";
            this.parkMotorShipButton.Size = new System.Drawing.Size(141, 23);
            this.parkMotorShipButton.TabIndex = 3;
            this.parkMotorShipButton.Text = "Припарковать теплоход";
            this.parkMotorShipButton.UseVisualStyleBackColor = true;
            this.parkMotorShipButton.Click += new System.EventHandler(this.ParkMotorShipButton_Click);
            // 
            // takeShipGroupBox
            // 
            this.takeShipGroupBox.Controls.Add(this.takeShipButton);
            this.takeShipGroupBox.Controls.Add(this.parkingPlaceMaskedTextBox);
            this.takeShipGroupBox.Controls.Add(this.placeLabel);
            this.takeShipGroupBox.Location = new System.Drawing.Point(1131, 70);
            this.takeShipGroupBox.Name = "takeShipGroupBox";
            this.takeShipGroupBox.Size = new System.Drawing.Size(141, 91);
            this.takeShipGroupBox.TabIndex = 4;
            this.takeShipGroupBox.TabStop = false;
            this.takeShipGroupBox.Text = "Забрать корабль";
            // 
            // placeLabel
            // 
            this.placeLabel.AutoSize = true;
            this.placeLabel.Location = new System.Drawing.Point(31, 28);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(42, 13);
            this.placeLabel.TabIndex = 0;
            this.placeLabel.Text = "Место:";
            // 
            // parkingPlaceMaskedTextBox
            // 
            this.parkingPlaceMaskedTextBox.Location = new System.Drawing.Point(79, 25);
            this.parkingPlaceMaskedTextBox.Mask = "00";
            this.parkingPlaceMaskedTextBox.Name = "parkingPlaceMaskedTextBox";
            this.parkingPlaceMaskedTextBox.Size = new System.Drawing.Size(29, 20);
            this.parkingPlaceMaskedTextBox.TabIndex = 1;
            this.parkingPlaceMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.parkingPlaceMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // takeShipButton
            // 
            this.takeShipButton.Location = new System.Drawing.Point(34, 51);
            this.takeShipButton.Name = "takeShipButton";
            this.takeShipButton.Size = new System.Drawing.Size(75, 23);
            this.takeShipButton.TabIndex = 5;
            this.takeShipButton.Text = "Забрать";
            this.takeShipButton.UseVisualStyleBackColor = true;
            this.takeShipButton.Click += new System.EventHandler(this.TakeShipButton_Click);
            // 
            // FormPier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.takeShipGroupBox);
            this.Controls.Add(this.parkMotorShipButton);
            this.Controls.Add(this.parkShipButton);
            this.Controls.Add(this.pierPictureBox);
            this.Name = "FormPier";
            this.Text = "FormPier";
            ((System.ComponentModel.ISupportInitialize)(this.pierPictureBox)).EndInit();
            this.takeShipGroupBox.ResumeLayout(false);
            this.takeShipGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pierPictureBox;
        private System.Windows.Forms.Button parkShipButton;
        private System.Windows.Forms.Button parkMotorShipButton;
        private System.Windows.Forms.GroupBox takeShipGroupBox;
        private System.Windows.Forms.Button takeShipButton;
        private System.Windows.Forms.MaskedTextBox parkingPlaceMaskedTextBox;
        private System.Windows.Forms.Label placeLabel;
    }
}