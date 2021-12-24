using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace MyApp
{
    public partial class CreateAdvertForm : BorderLessForm
    {
        private SqlConnection? sqlConnection = null;
        private string? ImagePath = null;
        private Form parentForm;
        #region
        private string title = "Справка";
        private string info = 
            "В данном окне у вас есть возможность сделать собственное объявление и сохранить его в базе данных." +
            "\n----------------------------------------------------------------------------------------------------------------------------" +
            "\nДля сохранения в базе данных потребуется инициализация всех полей:" +
            "\n\n'Марка' - в данном поле нужно указать марку автомобиля." +
            "\n'Модель' - в данном поле нужно указать модель автомобиля." +
            "\n'Год выпуска' - в данном поле нужно указать год автомобиля." +
            "\n'Кузов' - в данном поле нужно указать кузов автомобиля." +
            "\n'Пробег' - в данном поле нужно указать пробег автомобиля." +
            "\n'Тип руля' - в данном поле нужно указать тип руля автомобиля." +
            "\n'Привод' - в данном поле нужно указать привод автомобиля." +
            "\n'Коробка преедач' - в данном поле нужно указать коробку передач автомобиля." +
            "\n'Двигатель' - в данном поле нужно указать двигатель автомобиля." +
            "\n'Цена' - в данном поле нужно указать цену автомобиля." +
            "\n'Состояние' - в данном поле нужно анписать подробное описание автомобиля." +
            "\n----------------------------------------------------------------------------------------------------------------------------" +
            "\nКнопка 'Очистить' удаляет информацию из заполненных полей." +
            "\nКнопка 'Загрузить'. С помощью данной кнопки у вас есть возможность загрузить фото автомобиля." +
            "\nКнопка 'Удалить фото' удаляет фото автомобиля" +
            "\nКнопка 'Сохранить' сохраняет информацию в базу данных. (Для сохранения должны быть заполнены все поля)\n" +
            "  ";
        #endregion 
        public CreateAdvertForm(Form form)
        {
            HeaderBackColor = Color.White;
            Moveable = true;
            Resizeable = false;
            InitializeComponent();
            parentForm = form;
        }

        private void BackToMainFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Show();
        }

        private void CreateAdvertForm_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            for (int i = dateTime.Year; i >= 1950; i--)
            {
                YearsComboBox.Items.Add(i);
            }

            
        }

        private void YearsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void SaveAdvButton_Click(object sender, EventArgs e)
        {
            if (AllFieldsAreFilled() && AllFieldsFilledCorrectly())
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString);
                try
                {
                    await sqlConnection.OpenAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                if (sqlConnection.State == ConnectionState.Open)
                {

                    if (CopyImageToProjectFolder() == true)
                    {
                        var sqlCommand = new SqlCommand("INSERT INTO [Adverts]" +
                            " (Brand, Model, Year, Body, KmAge, SteeringWheel, TypeDrive, GearBox, Motor, Price, ImagePath, Description, SaleStatus)" +
                            "VALUES(@Brand, @Model, @Year, @Body, @KmAge, @SteeringWheel, @TypeDrive, @GearBox, @Motor, @Price, @ImagePath, @Description, @SaleStatus)", sqlConnection);
                        var adv = new Advertisiment(
                            new Car(BrandText.Text,
                                ModelText.Text,
                                int.Parse(YearsComboBox.Text),
                                Convert.ToInt32(KmAgeText.Text),
                                MotorText.Text,
                                GearBoxText.Text,
                                BodyComboBox.Text,
                                SteeringWheelText.Text,
                                TypeDriveText.Text),
                            Convert.ToInt32(PriceText.Text),
                            Status.OnSale,
                            new Bitmap(ImageCar.Image),
                            TextAboutCar.Text
                            );
                        sqlCommand.Parameters.AddWithValue("@Brand", adv.Car.Brand);
                        sqlCommand.Parameters.AddWithValue("@Model", adv.Car.Model);
                        sqlCommand.Parameters.AddWithValue("@Year", adv.Car.YearRelease);
                        sqlCommand.Parameters.AddWithValue("@Type", adv.Car.Body);
                        sqlCommand.Parameters.AddWithValue("@KmAge", adv.Car.KmAge);
                        sqlCommand.Parameters.AddWithValue("@SteeringWheel", adv.Car.SteeringWheel);
                        sqlCommand.Parameters.AddWithValue("@TypeDrive", adv.Car.TypeDrive);
                        sqlCommand.Parameters.AddWithValue("@GearBox", adv.Car.GearBox);
                        sqlCommand.Parameters.AddWithValue("@Motor", adv.Car.Motor);
                        sqlCommand.Parameters.AddWithValue("@Price", adv.Price);
                        sqlCommand.Parameters.AddWithValue("@ImagePath", ImagePath);
                        sqlCommand.Parameters.AddWithValue("@Description", adv.Description);
                        sqlCommand.Parameters.AddWithValue("@SaleStatus", adv.SaleStatus.ToString());
                        try
                        {
                            await sqlCommand.ExecuteNonQueryAsync();
                            var result = MessageBox.Show("Обьявление успешно создано\n Хотите создать еще одно обьявление?", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                ClearFormButton_Click(sender, e);
                            }
                            else
                            {
                                BackToMainFormButton_Click(sender, e);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        sqlConnection.Close();
                    }
                    sqlConnection.Close();

                }
            }
            
        }
        private bool CopyImageToProjectFolder()
        {
            var folderPath = Path.GetDirectoryName(Application.ExecutablePath);
            var dir = new DirectoryInfo($"{folderPath}\\images");
            if (!dir.Exists)
            {
                dir.Create();
            }
            try
            {
                string dest = string.Format($"{dir.FullName}\\{Path.GetFileName(ImagePath)}");
                File.Copy(ImagePath, dest);
                ImagePath = $".\\image\\{Path.GetFileName(ImagePath)}";
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(String.Format("Картинка с таким именем существует, измените название"), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool AllFieldsFilledCorrectly()
        {
            int a;
            if (!int.TryParse(KmAgeText.Text, out a))
            {
                MessageBox.Show(String.Format("В поле 'Пробег' дожно быть целое число"), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(PriceText.Text, out a))
            {
                MessageBox.Show(String.Format("В поле 'Цена' дожно быть целое число"), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool AllFieldsAreFilled()
        {
            if (BrandText.Text == null || ModelText.Text == null
                || YearsComboBox.Text == null || BodyComboBox.Text == null
                || KmAgeText.Text == null || SteeringWheelText.Text == null
                || TypeDriveText.Text == null || GearBoxText.Text == null
                || MotorText.Text == null || ImagePath == null
                || TextAboutCar.Text == null || TextAboutCar.Text == null
                || PriceText.Text == null)
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void ClearFormButton_Click(object sender, EventArgs e)
        {
            BrandText.Text = null;
            ModelText.Text = null;
            YearsComboBox.Text = null;
            BodyComboBox.Text = null;
            KmAgeText.Text = null;
            SteeringWheelText.Text = null;
            TypeDriveText.Text = null;
            GearBoxText.Text = null;
            MotorText.Text = null;
            ImagePath = null;
            ImageCar.Image = null;
            TextAboutCar.Text = null;
            PriceText.Text = null;
        }

        private void OpenFileDialogButton_Click(object sender, EventArgs e)
        {
            var openFileDialog= new OpenFileDialog();
            openFileDialog.Filter = "Изображения |*.jpeg; *.jpg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageCar.Image = Image.FromFile(openFileDialog.FileName);
                ImagePath = openFileDialog.FileName;
            }
        }

        private void DeletePictureButton_Click(object sender, EventArgs e)
        {
            ImageCar.Image = null;
            ImagePath = null;
        }

        private void InfoCreateAdvButton_Click(object sender, EventArgs e)
        {
            var formInfo = new Information(title, info);
            formInfo.ShowDialog();
        }

        private void MotorText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
            parentForm.Close();
        }
    }
}
