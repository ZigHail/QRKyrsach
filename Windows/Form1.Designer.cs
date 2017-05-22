namespace Windows
{
    partial class Form1
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
            this.QRPictureBox = new System.Windows.Forms.PictureBox();
            this.EAN13PictureBox = new System.Windows.Forms.PictureBox();
            this.ean13TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.ShelfDateLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.backgruondColorButton = new System.Windows.Forms.Button();
            this.moduleColorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.applyButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.openButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QRPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EAN13PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // QRPictureBox
            // 
            this.QRPictureBox.Location = new System.Drawing.Point(25, 285);
            this.QRPictureBox.Name = "QRPictureBox";
            this.QRPictureBox.Size = new System.Drawing.Size(365, 213);
            this.QRPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRPictureBox.TabIndex = 0;
            this.QRPictureBox.TabStop = false;
            // 
            // EAN13PictureBox
            // 
            this.EAN13PictureBox.Location = new System.Drawing.Point(475, 285);
            this.EAN13PictureBox.Name = "EAN13PictureBox";
            this.EAN13PictureBox.Size = new System.Drawing.Size(355, 213);
            this.EAN13PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EAN13PictureBox.TabIndex = 1;
            this.EAN13PictureBox.TabStop = false;
            // 
            // ean13TextBox
            // 
            this.ean13TextBox.Location = new System.Drawing.Point(153, 35);
            this.ean13TextBox.Name = "ean13TextBox";
            this.ean13TextBox.Size = new System.Drawing.Size(237, 22);
            this.ean13TextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Штрих-код";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Знайти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Назва";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Виробник";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Термін придатності";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ціна";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(210, 226);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 17);
            this.priceLabel.TabIndex = 12;
            // 
            // ShelfDateLabel
            // 
            this.ShelfDateLabel.AutoSize = true;
            this.ShelfDateLabel.Location = new System.Drawing.Point(207, 179);
            this.ShelfDateLabel.Name = "ShelfDateLabel";
            this.ShelfDateLabel.Size = new System.Drawing.Size(0, 17);
            this.ShelfDateLabel.TabIndex = 11;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(204, 131);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(0, 17);
            this.manufacturerLabel.TabIndex = 10;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(204, 80);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 17);
            this.nameLabel.TabIndex = 9;
            // 
            // backgruondColorButton
            // 
            this.backgruondColorButton.Location = new System.Drawing.Point(25, 585);
            this.backgruondColorButton.Name = "backgruondColorButton";
            this.backgruondColorButton.Size = new System.Drawing.Size(99, 41);
            this.backgruondColorButton.TabIndex = 13;
            this.backgruondColorButton.Text = "Фон";
            this.backgruondColorButton.UseVisualStyleBackColor = true;
            this.backgruondColorButton.Click += new System.EventHandler(this.backgruondColorButton_Click);
            // 
            // moduleColorButton
            // 
            this.moduleColorButton.Location = new System.Drawing.Point(153, 585);
            this.moduleColorButton.Name = "moduleColorButton";
            this.moduleColorButton.Size = new System.Drawing.Size(98, 41);
            this.moduleColorButton.TabIndex = 14;
            this.moduleColorButton.Text = "Модуль";
            this.moduleColorButton.UseVisualStyleBackColor = true;
            this.moduleColorButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(280, 585);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(110, 41);
            this.applyButton.TabIndex = 15;
            this.applyButton.Text = "Застосувати";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(20, 523);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(370, 56);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(629, 35);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(135, 57);
            this.openButton.TabIndex = 17;
            this.openButton.Text = "Завантажити фото";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(779, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 57);
            this.button3.TabIndex = 18;
            this.button3.Text = "Сфотографувати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 669);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.moduleColorButton);
            this.Controls.Add(this.backgruondColorButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.ShelfDateLabel);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ean13TextBox);
            this.Controls.Add(this.EAN13PictureBox);
            this.Controls.Add(this.QRPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.QRPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EAN13PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QRPictureBox;
        private System.Windows.Forms.PictureBox EAN13PictureBox;
        private System.Windows.Forms.TextBox ean13TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label ShelfDateLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button backgruondColorButton;
        private System.Windows.Forms.Button moduleColorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button button3;
    }
}

