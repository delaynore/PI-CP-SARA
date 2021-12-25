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
            this.TextAboutCar = new System.Windows.Forms.TextBox();
            this.BrandText = new System.Windows.Forms.TextBox();
            this.ModelText = new System.Windows.Forms.TextBox();
            this.YearsComboBox = new System.Windows.Forms.ComboBox();
            this.BodyComboBox = new System.Windows.Forms.ComboBox();
            this.KmAgeText = new System.Windows.Forms.TextBox();
            this.SteeringWheelText = new System.Windows.Forms.ComboBox();
            this.TypeDriveText = new System.Windows.Forms.ComboBox();
            this.GearBoxText = new System.Windows.Forms.ComboBox();
            this.MotorText = new System.Windows.Forms.ComboBox();
            this.ClearFormButton = new System.Windows.Forms.Button();
            this.SaveAdvButton = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageCar
            // 
            this.ImageCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageCar.Location = new System.Drawing.Point(314, 44);
            this.ImageCar.Name = "ImageCar";
            this.ImageCar.Size = new System.Drawing.Size(344, 216);
            this.ImageCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageCar.TabIndex = 0;
            this.ImageCar.TabStop = false;
            // 
            // OpenFileDialogButton
            // 
            this.OpenFileDialogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFileDialogButton.Location = new System.Drawing.Point(314, 268);
            this.OpenFileDialogButton.Name = "OpenFileDialogButton";
            this.OpenFileDialogButton.Size = new System.Drawing.Size(160, 32);
            this.OpenFileDialogButton.TabIndex = 1;
            this.OpenFileDialogButton.Text = "Загрузить";
            this.OpenFileDialogButton.UseVisualStyleBackColor = true;
            this.OpenFileDialogButton.Click += new System.EventHandler(this.OpenFileDialogButton_Click);
            // 
            // DeletePictureButton
            // 
            this.DeletePictureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletePictureButton.Location = new System.Drawing.Point(498, 268);
            this.DeletePictureButton.Name = "DeletePictureButton";
            this.DeletePictureButton.Size = new System.Drawing.Size(160, 32);
            this.DeletePictureButton.TabIndex = 2;
            this.DeletePictureButton.Text = "Удалить фото";
            this.DeletePictureButton.UseVisualStyleBackColor = true;
            this.DeletePictureButton.Click += new System.EventHandler(this.DeletePictureButton_Click);
            // 
            // BackToMainFormButton
            // 
            this.BackToMainFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMainFormButton.Location = new System.Drawing.Point(10, 44);
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
            this.InfoCreateAdvButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoCreateAdvButton.Location = new System.Drawing.Point(144, 44);
            this.InfoCreateAdvButton.Name = "InfoCreateAdvButton";
            this.InfoCreateAdvButton.Size = new System.Drawing.Size(87, 24);
            this.InfoCreateAdvButton.TabIndex = 4;
            this.InfoCreateAdvButton.Text = "Справка";
            this.InfoCreateAdvButton.UseVisualStyleBackColor = false;
            this.InfoCreateAdvButton.Click += new System.EventHandler(this.InfoCreateAdvButton_Click);
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Location = new System.Drawing.Point(64, 113);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(43, 15);
            this.BrandLabel.TabIndex = 5;
            this.BrandLabel.Text = "Марка";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(57, 147);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(50, 15);
            this.ModelLabel.TabIndex = 6;
            this.ModelLabel.Text = "Модель";
            // 
            // YearRelease
            // 
            this.YearRelease.AutoSize = true;
            this.YearRelease.Location = new System.Drawing.Point(32, 181);
            this.YearRelease.Name = "YearRelease";
            this.YearRelease.Size = new System.Drawing.Size(75, 15);
            this.YearRelease.TabIndex = 7;
            this.YearRelease.Text = "Год выпуска";
            // 
            // BodyTypeLabel
            // 
            this.BodyTypeLabel.AutoSize = true;
            this.BodyTypeLabel.Location = new System.Drawing.Point(69, 215);
            this.BodyTypeLabel.Name = "BodyTypeLabel";
            this.BodyTypeLabel.Size = new System.Drawing.Size(38, 15);
            this.BodyTypeLabel.TabIndex = 8;
            this.BodyTypeLabel.Text = "Кузов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите информацию о машине";
            // 
            // KmAgeLabel
            // 
            this.KmAgeLabel.AutoSize = true;
            this.KmAgeLabel.Location = new System.Drawing.Point(59, 249);
            this.KmAgeLabel.Name = "KmAgeLabel";
            this.KmAgeLabel.Size = new System.Drawing.Size(48, 15);
            this.KmAgeLabel.TabIndex = 10;
            this.KmAgeLabel.Text = "Пробег";
            // 
            // LeftOrRightSteeringWheelLabel
            // 
            this.LeftOrRightSteeringWheelLabel.AutoSize = true;
            this.LeftOrRightSteeringWheelLabel.Location = new System.Drawing.Point(51, 283);
            this.LeftOrRightSteeringWheelLabel.Name = "LeftOrRightSteeringWheelLabel";
            this.LeftOrRightSteeringWheelLabel.Size = new System.Drawing.Size(56, 15);
            this.LeftOrRightSteeringWheelLabel.TabIndex = 11;
            this.LeftOrRightSteeringWheelLabel.Text = "Тип руля";
            // 
            // TypeDriveLabel
            // 
            this.TypeDriveLabel.AutoSize = true;
            this.TypeDriveLabel.Location = new System.Drawing.Point(58, 317);
            this.TypeDriveLabel.Name = "TypeDriveLabel";
            this.TypeDriveLabel.Size = new System.Drawing.Size(49, 15);
            this.TypeDriveLabel.TabIndex = 12;
            this.TypeDriveLabel.Text = "Привод";
            // 
            // GearBoxLabel
            // 
            this.GearBoxLabel.AutoSize = true;
            this.GearBoxLabel.Location = new System.Drawing.Point(5, 351);
            this.GearBoxLabel.Name = "GearBoxLabel";
            this.GearBoxLabel.Size = new System.Drawing.Size(102, 15);
            this.GearBoxLabel.TabIndex = 13;
            this.GearBoxLabel.Text = "Коробка передач";
            // 
            // MotorLabel
            // 
            this.MotorLabel.AutoSize = true;
            this.MotorLabel.Location = new System.Drawing.Point(44, 385);
            this.MotorLabel.Name = "MotorLabel";
            this.MotorLabel.Size = new System.Drawing.Size(63, 15);
            this.MotorLabel.TabIndex = 14;
            this.MotorLabel.Text = "Двигатель";
            // 
            // AboutCarLabel
            // 
            this.AboutCarLabel.AutoSize = true;
            this.AboutCarLabel.Location = new System.Drawing.Point(319, 303);
            this.AboutCarLabel.Name = "AboutCarLabel";
            this.AboutCarLabel.Size = new System.Drawing.Size(65, 15);
            this.AboutCarLabel.TabIndex = 15;
            this.AboutCarLabel.Text = "Описание:";
            // 
            // TextAboutCar
            // 
            this.TextAboutCar.Location = new System.Drawing.Point(319, 319);
            this.TextAboutCar.Multiline = true;
            this.TextAboutCar.Name = "TextAboutCar";
            this.TextAboutCar.PlaceholderText = "Расскажите о машине";
            this.TextAboutCar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextAboutCar.Size = new System.Drawing.Size(339, 120);
            this.TextAboutCar.TabIndex = 16;
            // 
            // BrandText
            // 
            this.BrandText.Location = new System.Drawing.Point(117, 110);
            this.BrandText.MaxLength = 50;
            this.BrandText.Name = "BrandText";
            this.BrandText.Size = new System.Drawing.Size(158, 23);
            this.BrandText.TabIndex = 17;
            // 
            // ModelText
            // 
            this.ModelText.Location = new System.Drawing.Point(117, 144);
            this.ModelText.MaxLength = 50;
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(158, 23);
            this.ModelText.TabIndex = 18;
            // 
            // YearsComboBox
            // 
            this.YearsComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YearsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearsComboBox.FormattingEnabled = true;
            this.YearsComboBox.Location = new System.Drawing.Point(117, 178);
            this.YearsComboBox.Name = "YearsComboBox";
            this.YearsComboBox.Size = new System.Drawing.Size(158, 23);
            this.YearsComboBox.TabIndex = 19;
            this.YearsComboBox.SelectedIndexChanged += new System.EventHandler(this.YearsComboBox_SelectedIndexChanged);
            // 
            // BodyComboBox
            // 
            this.BodyComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BodyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BodyComboBox.FormattingEnabled = true;
            this.BodyComboBox.Items.AddRange(new object[] {
            "Внедорожник",
            "Кабриолет",
            "Купе",
            "Седан",
            "Универсал",
            "Хетчбек"});
            this.BodyComboBox.Location = new System.Drawing.Point(117, 212);
            this.BodyComboBox.Name = "BodyComboBox";
            this.BodyComboBox.Size = new System.Drawing.Size(121, 23);
            this.BodyComboBox.Sorted = true;
            this.BodyComboBox.TabIndex = 20;
            // 
            // KmAgeText
            // 
            this.KmAgeText.Location = new System.Drawing.Point(117, 246);
            this.KmAgeText.MaxLength = 10;
            this.KmAgeText.Name = "KmAgeText";
            this.KmAgeText.Size = new System.Drawing.Size(121, 23);
            this.KmAgeText.TabIndex = 21;
            // 
            // SteeringWheelText
            // 
            this.SteeringWheelText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SteeringWheelText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SteeringWheelText.FormattingEnabled = true;
            this.SteeringWheelText.Items.AddRange(new object[] {
            "Левый",
            "Правый"});
            this.SteeringWheelText.Location = new System.Drawing.Point(117, 280);
            this.SteeringWheelText.Name = "SteeringWheelText";
            this.SteeringWheelText.Size = new System.Drawing.Size(121, 23);
            this.SteeringWheelText.TabIndex = 22;
            // 
            // TypeDriveText
            // 
            this.TypeDriveText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TypeDriveText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeDriveText.FormattingEnabled = true;
            this.TypeDriveText.Items.AddRange(new object[] {
            "Передний",
            "Задний",
            "Полный"});
            this.TypeDriveText.Location = new System.Drawing.Point(117, 314);
            this.TypeDriveText.Name = "TypeDriveText";
            this.TypeDriveText.Size = new System.Drawing.Size(121, 23);
            this.TypeDriveText.TabIndex = 23;
            // 
            // GearBoxText
            // 
            this.GearBoxText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GearBoxText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GearBoxText.FormattingEnabled = true;
            this.GearBoxText.Items.AddRange(new object[] {
            "Механическая",
            "Автомат",
            "Робот"});
            this.GearBoxText.Location = new System.Drawing.Point(117, 348);
            this.GearBoxText.Name = "GearBoxText";
            this.GearBoxText.Size = new System.Drawing.Size(121, 23);
            this.GearBoxText.TabIndex = 24;
            // 
            // MotorText
            // 
            this.MotorText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MotorText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MotorText.FormattingEnabled = true;
            this.MotorText.Items.AddRange(new object[] {
            "Бензиновый",
            "Дизельный",
            "Электрический"});
            this.MotorText.Location = new System.Drawing.Point(117, 382);
            this.MotorText.Name = "MotorText";
            this.MotorText.Size = new System.Drawing.Size(121, 23);
            this.MotorText.TabIndex = 25;
            this.MotorText.SelectedIndexChanged += new System.EventHandler(this.MotorText_SelectedIndexChanged);
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearFormButton.Location = new System.Drawing.Point(10, 452);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(128, 24);
            this.ClearFormButton.TabIndex = 26;
            this.ClearFormButton.Text = "Очистить";
            this.ClearFormButton.UseVisualStyleBackColor = true;
            this.ClearFormButton.Click += new System.EventHandler(this.ClearFormButton_Click);
            // 
            // SaveAdvButton
            // 
            this.SaveAdvButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveAdvButton.Location = new System.Drawing.Point(482, 452);
            this.SaveAdvButton.Name = "SaveAdvButton";
            this.SaveAdvButton.Size = new System.Drawing.Size(176, 24);
            this.SaveAdvButton.TabIndex = 27;
            this.SaveAdvButton.Text = "Сохранить";
            this.SaveAdvButton.UseVisualStyleBackColor = true;
            this.SaveAdvButton.Click += new System.EventHandler(this.SaveAdvButton_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(72, 419);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(35, 15);
            this.PriceLabel.TabIndex = 28;
            this.PriceLabel.Text = "Цена";
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(117, 416);
            this.PriceText.MaxLength = 10;
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(121, 23);
            this.PriceText.TabIndex = 29;
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = global::MyApp.Resource1.close;
            this.CloseButton.Location = new System.Drawing.Point(633, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 22);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 30;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::MyApp.Resource1.minimize;
            this.pictureBox2.Location = new System.Drawing.Point(602, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // CreateAdvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(670, 488);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.SaveAdvButton);
            this.Controls.Add(this.ClearFormButton);
            this.Controls.Add(this.MotorText);
            this.Controls.Add(this.GearBoxText);
            this.Controls.Add(this.TypeDriveText);
            this.Controls.Add(this.SteeringWheelText);
            this.Controls.Add(this.KmAgeText);
            this.Controls.Add(this.BodyComboBox);
            this.Controls.Add(this.YearsComboBox);
            this.Controls.Add(this.ModelText);
            this.Controls.Add(this.BrandText);
            this.Controls.Add(this.TextAboutCar);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateAdvertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать обьявление";
            this.Load += new System.EventHandler(this.CreateAdvertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private TextBox TextAboutCar;
        private TextBox BrandText;
        private TextBox ModelText;
        private ComboBox YearsComboBox;
        private ComboBox BodyComboBox;
        private TextBox KmAgeText;
        private ComboBox SteeringWheelText;
        private ComboBox TypeDriveText;
        private ComboBox GearBoxText;
        private ComboBox MotorText;
        private Button ClearFormButton;
        private Button SaveAdvButton;
        private Label PriceLabel;
        private TextBox PriceText;
        private PictureBox CloseButton;
        private PictureBox pictureBox2;
    }
}