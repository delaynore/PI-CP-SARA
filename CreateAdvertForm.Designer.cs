﻿namespace MyApp
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
            this.OpenFileDialogButton.Click += new System.EventHandler(this.OpenFileDialogButton_Click);
            // 
            // DeletePictureButton
            // 
            this.DeletePictureButton.Location = new System.Drawing.Point(496, 232);
            this.DeletePictureButton.Name = "DeletePictureButton";
            this.DeletePictureButton.Size = new System.Drawing.Size(160, 32);
            this.DeletePictureButton.TabIndex = 2;
            this.DeletePictureButton.Text = "Удалить фото";
            this.DeletePictureButton.UseVisualStyleBackColor = true;
            this.DeletePictureButton.Click += new System.EventHandler(this.DeletePictureButton_Click);
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
            this.InfoCreateAdvButton.Click += new System.EventHandler(this.InfoCreateAdvButton_Click);
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Location = new System.Drawing.Point(62, 77);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(43, 15);
            this.BrandLabel.TabIndex = 5;
            this.BrandLabel.Text = "Марка";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(55, 111);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(50, 15);
            this.ModelLabel.TabIndex = 6;
            this.ModelLabel.Text = "Модель";
            // 
            // YearRelease
            // 
            this.YearRelease.AutoSize = true;
            this.YearRelease.Location = new System.Drawing.Point(30, 145);
            this.YearRelease.Name = "YearRelease";
            this.YearRelease.Size = new System.Drawing.Size(75, 15);
            this.YearRelease.TabIndex = 7;
            this.YearRelease.Text = "Год выпуска";
            // 
            // BodyTypeLabel
            // 
            this.BodyTypeLabel.AutoSize = true;
            this.BodyTypeLabel.Location = new System.Drawing.Point(67, 179);
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
            this.KmAgeLabel.Location = new System.Drawing.Point(57, 213);
            this.KmAgeLabel.Name = "KmAgeLabel";
            this.KmAgeLabel.Size = new System.Drawing.Size(48, 15);
            this.KmAgeLabel.TabIndex = 10;
            this.KmAgeLabel.Text = "Пробег";
            // 
            // LeftOrRightSteeringWheelLabel
            // 
            this.LeftOrRightSteeringWheelLabel.AutoSize = true;
            this.LeftOrRightSteeringWheelLabel.Location = new System.Drawing.Point(49, 247);
            this.LeftOrRightSteeringWheelLabel.Name = "LeftOrRightSteeringWheelLabel";
            this.LeftOrRightSteeringWheelLabel.Size = new System.Drawing.Size(56, 15);
            this.LeftOrRightSteeringWheelLabel.TabIndex = 11;
            this.LeftOrRightSteeringWheelLabel.Text = "Тип руля";
            // 
            // TypeDriveLabel
            // 
            this.TypeDriveLabel.AutoSize = true;
            this.TypeDriveLabel.Location = new System.Drawing.Point(56, 281);
            this.TypeDriveLabel.Name = "TypeDriveLabel";
            this.TypeDriveLabel.Size = new System.Drawing.Size(49, 15);
            this.TypeDriveLabel.TabIndex = 12;
            this.TypeDriveLabel.Text = "Привод";
            // 
            // GearBoxLabel
            // 
            this.GearBoxLabel.AutoSize = true;
            this.GearBoxLabel.Location = new System.Drawing.Point(3, 315);
            this.GearBoxLabel.Name = "GearBoxLabel";
            this.GearBoxLabel.Size = new System.Drawing.Size(102, 15);
            this.GearBoxLabel.TabIndex = 13;
            this.GearBoxLabel.Text = "Коробка передач";
            // 
            // MotorLabel
            // 
            this.MotorLabel.AutoSize = true;
            this.MotorLabel.Location = new System.Drawing.Point(42, 349);
            this.MotorLabel.Name = "MotorLabel";
            this.MotorLabel.Size = new System.Drawing.Size(63, 15);
            this.MotorLabel.TabIndex = 14;
            this.MotorLabel.Text = "Двигатель";
            // 
            // AboutCarLabel
            // 
            this.AboutCarLabel.AutoSize = true;
            this.AboutCarLabel.Location = new System.Drawing.Point(317, 265);
            this.AboutCarLabel.Name = "AboutCarLabel";
            this.AboutCarLabel.Size = new System.Drawing.Size(66, 15);
            this.AboutCarLabel.TabIndex = 15;
            this.AboutCarLabel.Text = "Состояние";
            // 
            // TextAboutCar
            // 
            this.TextAboutCar.Location = new System.Drawing.Point(317, 283);
            this.TextAboutCar.Multiline = true;
            this.TextAboutCar.Name = "TextAboutCar";
            this.TextAboutCar.PlaceholderText = "Расскажите о машине";
            this.TextAboutCar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextAboutCar.Size = new System.Drawing.Size(339, 120);
            this.TextAboutCar.TabIndex = 16;
            // 
            // BrandText
            // 
            this.BrandText.Location = new System.Drawing.Point(115, 74);
            this.BrandText.Name = "BrandText";
            this.BrandText.Size = new System.Drawing.Size(158, 23);
            this.BrandText.TabIndex = 17;
            // 
            // ModelText
            // 
            this.ModelText.Location = new System.Drawing.Point(115, 108);
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(158, 23);
            this.ModelText.TabIndex = 18;
            // 
            // YearsComboBox
            // 
            this.YearsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearsComboBox.FormattingEnabled = true;
            this.YearsComboBox.Location = new System.Drawing.Point(115, 142);
            this.YearsComboBox.Name = "YearsComboBox";
            this.YearsComboBox.Size = new System.Drawing.Size(158, 23);
            this.YearsComboBox.TabIndex = 19;
            this.YearsComboBox.SelectedIndexChanged += new System.EventHandler(this.YearsComboBox_SelectedIndexChanged);
            // 
            // BodyComboBox
            // 
            this.BodyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BodyComboBox.FormattingEnabled = true;
            this.BodyComboBox.Items.AddRange(new object[] {
            "Внедорожник",
            "Кабриолет",
            "Купе",
            "Седан",
            "Универсал",
            "Хетчбек"});
            this.BodyComboBox.Location = new System.Drawing.Point(115, 176);
            this.BodyComboBox.Name = "BodyComboBox";
            this.BodyComboBox.Size = new System.Drawing.Size(121, 23);
            this.BodyComboBox.Sorted = true;
            this.BodyComboBox.TabIndex = 20;
            // 
            // KmAgeText
            // 
            this.KmAgeText.Location = new System.Drawing.Point(115, 210);
            this.KmAgeText.Name = "KmAgeText";
            this.KmAgeText.Size = new System.Drawing.Size(121, 23);
            this.KmAgeText.TabIndex = 21;
            // 
            // SteeringWheelText
            // 
            this.SteeringWheelText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SteeringWheelText.FormattingEnabled = true;
            this.SteeringWheelText.Items.AddRange(new object[] {
            "Левый",
            "Правый"});
            this.SteeringWheelText.Location = new System.Drawing.Point(115, 244);
            this.SteeringWheelText.Name = "SteeringWheelText";
            this.SteeringWheelText.Size = new System.Drawing.Size(121, 23);
            this.SteeringWheelText.TabIndex = 22;
            // 
            // TypeDriveText
            // 
            this.TypeDriveText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeDriveText.FormattingEnabled = true;
            this.TypeDriveText.Items.AddRange(new object[] {
            "Передний",
            "Задний",
            "Полный"});
            this.TypeDriveText.Location = new System.Drawing.Point(115, 278);
            this.TypeDriveText.Name = "TypeDriveText";
            this.TypeDriveText.Size = new System.Drawing.Size(121, 23);
            this.TypeDriveText.TabIndex = 23;
            // 
            // GearBoxText
            // 
            this.GearBoxText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GearBoxText.FormattingEnabled = true;
            this.GearBoxText.Items.AddRange(new object[] {
            "Механическая",
            "Автомат",
            "Робот"});
            this.GearBoxText.Location = new System.Drawing.Point(115, 312);
            this.GearBoxText.Name = "GearBoxText";
            this.GearBoxText.Size = new System.Drawing.Size(121, 23);
            this.GearBoxText.TabIndex = 24;
            // 
            // MotorText
            // 
            this.MotorText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MotorText.FormattingEnabled = true;
            this.MotorText.Items.AddRange(new object[] {
            "Бензиновый",
            "Дизельный"});
            this.MotorText.Location = new System.Drawing.Point(115, 346);
            this.MotorText.Name = "MotorText";
            this.MotorText.Size = new System.Drawing.Size(121, 23);
            this.MotorText.TabIndex = 25;
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.Location = new System.Drawing.Point(8, 416);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(128, 24);
            this.ClearFormButton.TabIndex = 26;
            this.ClearFormButton.Text = "Очистить";
            this.ClearFormButton.UseVisualStyleBackColor = true;
            this.ClearFormButton.Click += new System.EventHandler(this.ClearFormButton_Click);
            // 
            // SaveAdvButton
            // 
            this.SaveAdvButton.Location = new System.Drawing.Point(480, 416);
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
            this.PriceLabel.Location = new System.Drawing.Point(70, 383);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(35, 15);
            this.PriceLabel.TabIndex = 28;
            this.PriceLabel.Text = "Цена";
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(115, 380);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(121, 23);
            this.PriceText.TabIndex = 29;
            // 
            // CreateAdvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(670, 452);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateAdvertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать обьявление";
            this.Load += new System.EventHandler(this.CreateAdvertForm_Load);
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
    }
}