using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class OpenAdvert : BorderLessForm
    {
        private SqlConnection sqlConnection;
        private int index;
        private string? ImagePath = null;
        public OpenAdvert(int indx, SqlConnection connection, Form form)
        {
            Resizeable = false;
            Moveable = true;
            HeaderBackColor = Color.White;
            InitializeComponent();
            sqlConnection = connection;
            parrentForm = form;
            index = indx;
        }
        private Form parrentForm;
        public void Info(int index, SqlConnection sqlConnection)
        {
            var cmd = new SqlCommand($"SELECT * FROM Adverts WHERE Id = {index}", sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label2.Text = reader["Brand"].ToString();
                label3.Text = reader["Model"].ToString();
                label4.Text = reader["Year"].ToString();
                label5.Text = reader["Body"].ToString();
                label6.Text = reader["KmAge"].ToString();
                label7.Text = reader["SteeringWheel"].ToString();
                label8.Text = reader["TypeDrive"].ToString();
                label9.Text = reader["GearBox"].ToString();
                label10.Text = reader["Motor"].ToString();
                label11.Text = reader["Price"].ToString();
                label1.Text = reader["Description"].ToString();
                label12.Text = reader["SaleStatus"].ToString();
                ImagePath = reader["ImagePath"].ToString();
                try
                {
                    ImageCar.Image = Image.FromFile(ImagePath);
                }
                catch (Exception)
                {
                    ImageCar.Image = Resource1.mainIcon;
                }
            }
            reader.Close();
        }

        private void BackToMainFormButton_Click(object sender, EventArgs e)
        {
            if (BackToMainFormButton.Text == "Назад") 
            {
                parrentForm.Show();
                Close();
            }
            else if (BackToMainFormButton.Text == "Отменить")
            {
                
                BackToMainFormButton.Text = "Назад";
                ChangeState();
            }
        }

        private void OpenAdvert_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            for (int i = dateTime.Year; i >= 1950; i--)
            {
                YearsComboBox.Items.Add(i);
            }
            Info(index, sqlConnection);
        }
       

        private void DeletePictureButton_Click(object sender, EventArgs e)
        {
            ImageCar.Image = null;
            ImagePath = null;
        }
        private void ChangeState()
        {
            Edit.Visible = !Edit.Visible;
            label2.Visible = !label2.Visible;
            label3.Visible = !label3.Visible;
            label4.Visible = !label4.Visible;
            label5.Visible = !label5.Visible;
            label6.Visible = !label6.Visible;
            label7.Visible = !label7.Visible;
            label8.Visible = !label8.Visible;
            label9.Visible = !label9.Visible;
            label10.Visible = !label10.Visible;
            label11.Visible = !label11.Visible;
            label1.Visible = !label1.Visible;
            label12.Visible = !label12.Visible;

            DeletePictureButton.Visible = !DeletePictureButton.Visible;
            OpenFileDialogButton.Visible = !OpenFileDialogButton.Visible;
            SaveAdvButton.Visible = !SaveAdvButton.Visible;

            BrandText.Visible = !BrandText.Visible;
            ModelText.Visible = !ModelText.Visible;
            YearsComboBox.Visible = !YearsComboBox.Visible;
            BodyComboBox.Visible = !BodyComboBox.Visible;
            KmAgeText.Visible = !KmAgeText.Visible;
            SteeringWheelText.Visible = !SteeringWheelText.Visible;
            TypeDriveText.Visible = !TypeDriveText.Visible;
            GearBoxText.Visible = !GearBoxText.Visible;
            MotorText.Visible = !MotorText.Visible;
            PriceText.Visible = !PriceText.Visible;
            textBox1.Visible = !textBox1.Visible;

        }
        private void Edit_Click(object sender, EventArgs e)
        {
            BrandText.Text = label2.Text;
            ModelText.Text = label3.Text;
            YearsComboBox.Text = label4.Text;
            BodyComboBox.Text = label5.Text;
            KmAgeText.Text = label6.Text;
            SteeringWheelText.Text = label7.Text;
            TypeDriveText.Text = label8.Text;
            GearBoxText.Text = label9.Text;
            MotorText.Text = label10.Text;
            PriceText.Text = label11.Text;
            textBox1.Text = label1.Text;

            ChangeState();
            BackToMainFormButton.Text = "Отменить";
        }

        private void OpenFileDialogButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения |*.jpeg; *.jpg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageCar.Image = Image.FromFile(openFileDialog.FileName);
                ImagePath = openFileDialog.FileName;
            }
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
                            textBox1.Text
                            );
                    var sqlCommand = new SqlCommand("INSERT INTO [Adverts]" +
                            " (Brand, Model, Year, Body, KmAge, SteeringWheel, TypeDrive, GearBox, Motor, Price, ImagePath, Description, SaleStatus)" +
                            "VALUES(@Brand, @Model, @Year, @Body, @KmAge, @SteeringWheel, @TypeDrive, @GearBox, @Motor, @Price, @ImagePath, @Description, @SaleStatus)", sqlConnection);                 

                    sqlCommand.Parameters.AddWithValue("@Brand", adv.Car.Brand);
                    sqlCommand.Parameters.AddWithValue("@Model", adv.Car.Model);
                    sqlCommand.Parameters.AddWithValue("@Year", adv.Car.YearRelease);
                    sqlCommand.Parameters.AddWithValue("@Body", adv.Car.Body);
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
                        var sqlcmd = new SqlCommand($"Delete FROM Adverts WHERE Id={index}",sqlConnection);
                        await sqlcmd.ExecuteNonQueryAsync();
                        MessageBox.Show("Обьявление изменено", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    sqlConnection.Close();

                }
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
                || textBox1.Text == null || PriceText.Text == null)
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
