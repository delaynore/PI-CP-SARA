namespace MyApp
{
    partial class CreateAdvertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAdvertForm));
            this.ImageCar = new System.Windows.Forms.PictureBox();
            this.OpenFileDialogButton = new System.Windows.Forms.Button();
            this.DeletePictureButton = new System.Windows.Forms.Button();
            this.BackToMainFormButton = new System.Windows.Forms.Button();
            this.InfoCreateAdvButton = new System.Windows.Forms.Button();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.YearRelease = new System.Windows.Forms.Label();
            this.BodyTypeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KmAgeLabel = new System.Windows.Forms.Label();
            this.LeftOrRightSteeringWheelLabel = new System.Windows.Forms.Label();
            this.TypeDriveLabel = new System.Windows.Forms.Label();
            this.GearBoxLabel = new System.Windows.Forms.Label();
            this.MotorLabel = new System.Windows.Forms.Label();
            this.AboutCarLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCar)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageCar
            // 
            this.ImageCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageCar.Location = new System.Drawing.Point(312, 8);
            this.ImageCar.Name = "ImageCar";
            this.ImageCar.Size = new System.Drawing.Size(344, 216);
            this.ImageCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageCar.TabIndex = 0;
            this.ImageCar.TabStop = false;
            // 
            // OpenFileDialogButton
            // 
            this.OpenFileDialogButton.Location = new System.Drawing.Point(312, 232);
            this.OpenFileDialogButton.Name = "OpenFileDialogButton";
            this.OpenFileDialogButton.Size = new System.Drawing.Size(160, 32);
            this.OpenFileDialogButton.TabIndex = 1;
            this.OpenFileDialogButton.Text = "Загрузить";
            this.OpenFileDialogButton.UseVisualStyleBackColor = true;
            // 
            // DeletePictureButton
            // 
            this.DeletePictureButton.Location = new System.Drawing.Point(496, 232);
            this.DeletePictureButton.Name = "DeletePictureButton";
            this.DeletePictureButton.Size = new System.Drawing.Size(160, 32);
            this.DeletePictureButton.TabIndex = 2;
            this.DeletePictureButton.Text = "Удалить фото";
            this.DeletePictureButton.UseVisualStyleBackColor = true;
            // 
            // BackToMainFormButton
            // 
            this.BackToMainFormButton.Location = new System.Drawing.Point(8, 8);
            this.BackToMainFormButton.Name = "BackToMainFormButton";
            this.BackToMainFormButton.Size = new System.Drawing.Size(128, 24);
            this.BackToMainFormButton.TabIndex = 3;
            this.BackToMainFormButton.Text = "Назад";
            this.BackToMainFormButton.UseVisualStyleBackColor = true;
            this.BackToMainFormButton.Click += new System.EventHandler(this.BackToMainFormButton_Click);
            // 
            // InfoCreateAdvButton
            // 
            this.InfoCreateAdvButton.BackColor = System.Drawing.SystemColors.Info;
            this.InfoCreateAdvButton.Location = new System.Drawing.Point(142, 8);
            this.InfoCreateAdvButton.Name = "InfoCreateAdvButton";
            this.InfoCreateAdvButton.Size = new System.Drawing.Size(87, 24);
            this.InfoCreateAdvButton.TabIndex = 4;
            this.InfoCreateAdvButton.Text = "Справка";
            this.InfoCreateAdvButton.UseVisualStyleBackColor = false;
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Location = new System.Drawing.Point(8, 79);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(43, 15);
            this.BrandLabel.TabIndex = 5;
            this.BrandLabel.Text = "Марка";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(8, 117);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(50, 15);
            this.ModelLabel.TabIndex = 6;
            this.ModelLabel.Text = "Модель";
            // 
            // YearRelease
            // 
            this.YearRelease.AutoSize = true;
            this.YearRelease.Location = new System.Drawing.Point(8, 151);
            this.YearRelease.Name = "YearRelease";
            this.YearRelease.Size = new System.Drawing.Size(75, 15);
            this.YearRelease.TabIndex = 7;
            this.YearRelease.Text = "Год выпуска";
            // 
            // BodyTypeLabel
            // 
            this.BodyTypeLabel.AutoSize = true;
            this.BodyTypeLabel.Location = new System.Drawing.Point(8, 189);
            this.BodyTypeLabel.Name = "BodyTypeLabel";
            this.BodyTypeLabel.Size = new System.Drawing.Size(38, 15);
            this.BodyTypeLabel.TabIndex = 8;
            this.BodyTypeLabel.Text = "Кузов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите информацию о машине";
            // 
            // KmAgeLabel
            // 
            this.KmAgeLabel.AutoSize = true;
            this.KmAgeLabel.Location = new System.Drawing.Point(8, 219);
            this.KmAgeLabel.Name = "KmAgeLabel";
            this.KmAgeLabel.Size = new System.Drawing.Size(48, 15);
            this.KmAgeLabel.TabIndex = 10;
            this.KmAgeLabel.Text = "Пробег";
            // 
            // LeftOrRightSteeringWheelLabel
            // 
            this.LeftOrRightSteeringWheelLabel.AutoSize = true;
            this.LeftOrRightSteeringWheelLabel.Location = new System.Drawing.Point(8, 258);
            this.LeftOrRightSteeringWheelLabel.Name = "LeftOrRightSteeringWheelLabel";
            this.LeftOrRightSteeringWheelLabel.Size = new System.Drawing.Size(56, 15);
            this.LeftOrRightSteeringWheelLabel.TabIndex = 11;
            this.LeftOrRightSteeringWheelLabel.Text = "Тип руля";
            // 
            // TypeDriveLabel
            // 
            this.TypeDriveLabel.AutoSize = true;
            this.TypeDriveLabel.Location = new System.Drawing.Point(8, 299);
            this.TypeDriveLabel.Name = "TypeDriveLabel";
            this.TypeDriveLabel.Size = new System.Drawing.Size(49, 15);
            this.TypeDriveLabel.TabIndex = 12;
            this.TypeDriveLabel.Text = "Привод";
            // 
            // GearBoxLabel
            // 
            this.GearBoxLabel.AutoSize = true;
            this.GearBoxLabel.Location = new System.Drawing.Point(8, 336);
            this.GearBoxLabel.Name = "GearBoxLabel";
            this.GearBoxLabel.Size = new System.Drawing.Size(102, 15);
            this.GearBoxLabel.TabIndex = 13;
            this.GearBoxLabel.Text = "Коробка передач";
            // 
            // MotorLabel
            // 
            this.MotorLabel.AutoSize = true;
            this.MotorLabel.Location = new System.Drawing.Point(8, 377);
            this.MotorLabel.Name = "MotorLabel";
            this.MotorLabel.Size = new System.Drawing.Size(63, 15);
            this.MotorLabel.TabIndex = 14;
            this.MotorLabel.Text = "Двигатель";
            // 
            // AboutCarLabel
            // 
            this.AboutCarLabel.AutoSize = true;
            this.AboutCarLabel.Location = new System.Drawing.Point(317, 296);
            this.AboutCarLabel.Name = "AboutCarLabel";
            this.AboutCarLabel.Size = new System.Drawing.Size(66, 15);
            this.AboutCarLabel.TabIndex = 15;
            this.AboutCarLabel.Text = "Состояние";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 314);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Расскажите о машине";
            this.textBox1.Size = new System.Drawing.Size(339, 78);
            this.textBox1.TabIndex = 16;
            // 
            // CreateAdvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(673, 461);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AboutCarLabel);
            this.Controls.Add(this.MotorLabel);
            this.Controls.Add(this.GearBoxLabel);
            this.Controls.Add(this.TypeDriveLabel);
            this.Controls.Add(this.LeftOrRightSteeringWheelLabel);
            this.Controls.Add(this.KmAgeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BodyTypeLabel);
            this.Controls.Add(this.YearRelease);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.InfoCreateAdvButton);
            this.Controls.Add(this.BackToMainFormButton);
            this.Controls.Add(this.DeletePictureButton);
            this.Controls.Add(this.OpenFileDialogButton);
            this.Controls.Add(this.ImageCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAdvertForm";
            this.Text = "Создать обьявление";
            ((System.ComponentModel.ISupportInitialize)(this.ImageCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ImageCar;
        private Button OpenFileDialogButton;
        private Button DeletePictureButton;
        private Button BackToMainFormButton;
        private Button InfoCreateAdvButton;
        private Label BrandLabel;
        private Label ModelLabel;
        private Label YearRelease;
        private Label BodyTypeLabel;
        private Label label1;
        private Label KmAgeLabel;
        private Label LeftOrRightSteeringWheelLabel;
        private Label TypeDriveLabel;
        private Label GearBoxLabel;
        private Label MotorLabel;
        private Label AboutCarLabel;
        private TextBox textBox1;
    }
}