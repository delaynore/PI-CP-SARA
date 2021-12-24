namespace MyApp
{
    partial class OpenAdvert
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
            this.PriceText = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SaveAdvButton = new System.Windows.Forms.Button();
            this.MotorText = new System.Windows.Forms.ComboBox();
            this.GearBoxText = new System.Windows.Forms.ComboBox();
            this.TypeDriveText = new System.Windows.Forms.ComboBox();
            this.SteeringWheelText = new System.Windows.Forms.ComboBox();
            this.KmAgeText = new System.Windows.Forms.TextBox();
            this.BodyComboBox = new System.Windows.Forms.ComboBox();
            this.ModelText = new System.Windows.Forms.TextBox();
            this.BrandText = new System.Windows.Forms.TextBox();
            this.TextAboutCar = new System.Windows.Forms.TextBox();
            this.AboutCarLabel = new System.Windows.Forms.Label();
            this.MotorLabel = new System.Windows.Forms.Label();
            this.GearBoxLabel = new System.Windows.Forms.Label();
            this.TypeDriveLabel = new System.Windows.Forms.Label();
            this.LeftOrRightSteeringWheelLabel = new System.Windows.Forms.Label();
            this.KmAgeLabel = new System.Windows.Forms.Label();
            this.BodyTypeLabel = new System.Windows.Forms.Label();
            this.YearRelease = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.BackToMainFormButton = new System.Windows.Forms.Button();
            this.DeletePictureButton = new System.Windows.Forms.Button();
            this.OpenFileDialogButton = new System.Windows.Forms.Button();
            this.ImageCar = new System.Windows.Forms.PictureBox();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.YearText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCar)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(121, 352);
            this.PriceText.MaxLength = 10;
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(121, 23);
            this.PriceText.TabIndex = 59;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(76, 355);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(35, 15);
            this.PriceLabel.TabIndex = 58;
            this.PriceLabel.Text = "Цена";
            // 
            // SaveAdvButton
            // 
            this.SaveAdvButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveAdvButton.Location = new System.Drawing.Point(492, 417);
            this.SaveAdvButton.Name = "SaveAdvButton";
            this.SaveAdvButton.Size = new System.Drawing.Size(176, 24);
            this.SaveAdvButton.TabIndex = 57;
            this.SaveAdvButton.Text = "Сохранить";
            this.SaveAdvButton.UseVisualStyleBackColor = true;
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
            this.MotorText.Location = new System.Drawing.Point(121, 318);
            this.MotorText.Name = "MotorText";
            this.MotorText.Size = new System.Drawing.Size(121, 23);
            this.MotorText.TabIndex = 55;
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
            this.GearBoxText.Location = new System.Drawing.Point(121, 284);
            this.GearBoxText.Name = "GearBoxText";
            this.GearBoxText.Size = new System.Drawing.Size(121, 23);
            this.GearBoxText.TabIndex = 54;
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
            this.TypeDriveText.Location = new System.Drawing.Point(121, 250);
            this.TypeDriveText.Name = "TypeDriveText";
            this.TypeDriveText.Size = new System.Drawing.Size(121, 23);
            this.TypeDriveText.TabIndex = 53;
            // 
            // SteeringWheelText
            // 
            this.SteeringWheelText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SteeringWheelText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SteeringWheelText.FormattingEnabled = true;
            this.SteeringWheelText.Items.AddRange(new object[] {
            "Левый",
            "Правый"});
            this.SteeringWheelText.Location = new System.Drawing.Point(121, 216);
            this.SteeringWheelText.Name = "SteeringWheelText";
            this.SteeringWheelText.Size = new System.Drawing.Size(121, 23);
            this.SteeringWheelText.TabIndex = 52;
            // 
            // KmAgeText
            // 
            this.KmAgeText.Location = new System.Drawing.Point(121, 182);
            this.KmAgeText.MaxLength = 10;
            this.KmAgeText.Name = "KmAgeText";
            this.KmAgeText.Size = new System.Drawing.Size(121, 23);
            this.KmAgeText.TabIndex = 51;
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
            this.BodyComboBox.Location = new System.Drawing.Point(121, 148);
            this.BodyComboBox.Name = "BodyComboBox";
            this.BodyComboBox.Size = new System.Drawing.Size(121, 23);
            this.BodyComboBox.Sorted = true;
            this.BodyComboBox.TabIndex = 50;
            // 
            // ModelText
            // 
            this.ModelText.Location = new System.Drawing.Point(121, 80);
            this.ModelText.MaxLength = 50;
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(158, 23);
            this.ModelText.TabIndex = 48;
            // 
            // BrandText
            // 
            this.BrandText.Location = new System.Drawing.Point(121, 46);
            this.BrandText.MaxLength = 50;
            this.BrandText.Name = "BrandText";
            this.BrandText.Size = new System.Drawing.Size(158, 23);
            this.BrandText.TabIndex = 47;
            // 
            // TextAboutCar
            // 
            this.TextAboutCar.Location = new System.Drawing.Point(329, 284);
            this.TextAboutCar.Multiline = true;
            this.TextAboutCar.Name = "TextAboutCar";
            this.TextAboutCar.PlaceholderText = "Расскажите о машине";
            this.TextAboutCar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextAboutCar.Size = new System.Drawing.Size(339, 120);
            this.TextAboutCar.TabIndex = 46;
            // 
            // AboutCarLabel
            // 
            this.AboutCarLabel.AutoSize = true;
            this.AboutCarLabel.Location = new System.Drawing.Point(329, 266);
            this.AboutCarLabel.Name = "AboutCarLabel";
            this.AboutCarLabel.Size = new System.Drawing.Size(66, 15);
            this.AboutCarLabel.TabIndex = 45;
            this.AboutCarLabel.Text = "Состояние";
            // 
            // MotorLabel
            // 
            this.MotorLabel.AutoSize = true;
            this.MotorLabel.Location = new System.Drawing.Point(48, 321);
            this.MotorLabel.Name = "MotorLabel";
            this.MotorLabel.Size = new System.Drawing.Size(63, 15);
            this.MotorLabel.TabIndex = 44;
            this.MotorLabel.Text = "Двигатель";
            // 
            // GearBoxLabel
            // 
            this.GearBoxLabel.AutoSize = true;
            this.GearBoxLabel.Location = new System.Drawing.Point(9, 287);
            this.GearBoxLabel.Name = "GearBoxLabel";
            this.GearBoxLabel.Size = new System.Drawing.Size(102, 15);
            this.GearBoxLabel.TabIndex = 43;
            this.GearBoxLabel.Text = "Коробка передач";
            // 
            // TypeDriveLabel
            // 
            this.TypeDriveLabel.AutoSize = true;
            this.TypeDriveLabel.Location = new System.Drawing.Point(62, 253);
            this.TypeDriveLabel.Name = "TypeDriveLabel";
            this.TypeDriveLabel.Size = new System.Drawing.Size(49, 15);
            this.TypeDriveLabel.TabIndex = 42;
            this.TypeDriveLabel.Text = "Привод";
            // 
            // LeftOrRightSteeringWheelLabel
            // 
            this.LeftOrRightSteeringWheelLabel.AutoSize = true;
            this.LeftOrRightSteeringWheelLabel.Location = new System.Drawing.Point(55, 219);
            this.LeftOrRightSteeringWheelLabel.Name = "LeftOrRightSteeringWheelLabel";
            this.LeftOrRightSteeringWheelLabel.Size = new System.Drawing.Size(56, 15);
            this.LeftOrRightSteeringWheelLabel.TabIndex = 41;
            this.LeftOrRightSteeringWheelLabel.Text = "Тип руля";
            // 
            // KmAgeLabel
            // 
            this.KmAgeLabel.AutoSize = true;
            this.KmAgeLabel.Location = new System.Drawing.Point(63, 185);
            this.KmAgeLabel.Name = "KmAgeLabel";
            this.KmAgeLabel.Size = new System.Drawing.Size(48, 15);
            this.KmAgeLabel.TabIndex = 40;
            this.KmAgeLabel.Text = "Пробег";
            // 
            // BodyTypeLabel
            // 
            this.BodyTypeLabel.AutoSize = true;
            this.BodyTypeLabel.Location = new System.Drawing.Point(73, 151);
            this.BodyTypeLabel.Name = "BodyTypeLabel";
            this.BodyTypeLabel.Size = new System.Drawing.Size(38, 15);
            this.BodyTypeLabel.TabIndex = 38;
            this.BodyTypeLabel.Text = "Кузов";
            // 
            // YearRelease
            // 
            this.YearRelease.AutoSize = true;
            this.YearRelease.Location = new System.Drawing.Point(36, 117);
            this.YearRelease.Name = "YearRelease";
            this.YearRelease.Size = new System.Drawing.Size(75, 15);
            this.YearRelease.TabIndex = 37;
            this.YearRelease.Text = "Год выпуска";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(61, 83);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(50, 15);
            this.ModelLabel.TabIndex = 36;
            this.ModelLabel.Text = "Модель";
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Location = new System.Drawing.Point(68, 49);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(43, 15);
            this.BrandLabel.TabIndex = 35;
            this.BrandLabel.Text = "Марка";
            // 
            // BackToMainFormButton
            // 
            this.BackToMainFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMainFormButton.Location = new System.Drawing.Point(20, 9);
            this.BackToMainFormButton.Name = "BackToMainFormButton";
            this.BackToMainFormButton.Size = new System.Drawing.Size(128, 24);
            this.BackToMainFormButton.TabIndex = 33;
            this.BackToMainFormButton.Text = "Назад";
            this.BackToMainFormButton.UseVisualStyleBackColor = true;
            // 
            // DeletePictureButton
            // 
            this.DeletePictureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletePictureButton.Location = new System.Drawing.Point(508, 233);
            this.DeletePictureButton.Name = "DeletePictureButton";
            this.DeletePictureButton.Size = new System.Drawing.Size(160, 32);
            this.DeletePictureButton.TabIndex = 32;
            this.DeletePictureButton.Text = "Удалить фото";
            this.DeletePictureButton.UseVisualStyleBackColor = true;
            // 
            // OpenFileDialogButton
            // 
            this.OpenFileDialogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFileDialogButton.Location = new System.Drawing.Point(324, 233);
            this.OpenFileDialogButton.Name = "OpenFileDialogButton";
            this.OpenFileDialogButton.Size = new System.Drawing.Size(160, 32);
            this.OpenFileDialogButton.TabIndex = 31;
            this.OpenFileDialogButton.Text = "Загрузить";
            this.OpenFileDialogButton.UseVisualStyleBackColor = true;
            // 
            // ImageCar
            // 
            this.ImageCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageCar.Location = new System.Drawing.Point(324, 9);
            this.ImageCar.Name = "ImageCar";
            this.ImageCar.Size = new System.Drawing.Size(344, 216);
            this.ImageCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageCar.TabIndex = 30;
            this.ImageCar.TabStop = false;
            // 
            // StatusText
            // 
            this.StatusText.Location = new System.Drawing.Point(121, 381);
            this.StatusText.MaxLength = 10;
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(121, 23);
            this.StatusText.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "Статус";
            // 
            // YearText
            // 
            this.YearText.Location = new System.Drawing.Point(121, 114);
            this.YearText.MaxLength = 50;
            this.YearText.Name = "YearText";
            this.YearText.Size = new System.Drawing.Size(121, 23);
            this.YearText.TabIndex = 63;
            // 
            // OpenAdvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.YearText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.SaveAdvButton);
            this.Controls.Add(this.MotorText);
            this.Controls.Add(this.GearBoxText);
            this.Controls.Add(this.TypeDriveText);
            this.Controls.Add(this.SteeringWheelText);
            this.Controls.Add(this.KmAgeText);
            this.Controls.Add(this.BodyComboBox);
            this.Controls.Add(this.ModelText);
            this.Controls.Add(this.BrandText);
            this.Controls.Add(this.TextAboutCar);
            this.Controls.Add(this.AboutCarLabel);
            this.Controls.Add(this.MotorLabel);
            this.Controls.Add(this.GearBoxLabel);
            this.Controls.Add(this.TypeDriveLabel);
            this.Controls.Add(this.LeftOrRightSteeringWheelLabel);
            this.Controls.Add(this.KmAgeLabel);
            this.Controls.Add(this.BodyTypeLabel);
            this.Controls.Add(this.YearRelease);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.BackToMainFormButton);
            this.Controls.Add(this.DeletePictureButton);
            this.Controls.Add(this.OpenFileDialogButton);
            this.Controls.Add(this.ImageCar);
            this.Name = "OpenAdvert";
            ((System.ComponentModel.ISupportInitialize)(this.ImageCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PriceText;
        private Label PriceLabel;
        private Button SaveAdvButton;
        private ComboBox MotorText;
        private ComboBox GearBoxText;
        private ComboBox TypeDriveText;
        private ComboBox SteeringWheelText;
        private TextBox KmAgeText;
        private ComboBox BodyComboBox;
        private TextBox ModelText;
        private TextBox BrandText;
        private TextBox TextAboutCar;
        private Label AboutCarLabel;
        private Label MotorLabel;
        private Label GearBoxLabel;
        private Label TypeDriveLabel;
        private Label LeftOrRightSteeringWheelLabel;
        private Label KmAgeLabel;
        private Label BodyTypeLabel;
        private Label YearRelease;
        private Label ModelLabel;
        private Label BrandLabel;
        private Button BackToMainFormButton;
        private Button DeletePictureButton;
        private Button OpenFileDialogButton;
        private PictureBox ImageCar;
        private TextBox StatusText;
        private Label label1;
        private TextBox YearText;
    }
}