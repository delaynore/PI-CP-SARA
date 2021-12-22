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
    public partial class CreateAdvertForm : Form
    {
        private SqlConnection? sqlConnection = null;
        private string? ImagePath = null;
        private Form parentForm;
        private string title = "Справка";
        private string info = ""; // написать текст
        public CreateAdvertForm(Form form)
        {
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
            for (int i = 1950; i < dateTime.Year + 1; i++)
            {
                YearsComboBox.Items.Add(i);
            }

            
        }

        private void YearsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveAdvButton_Click(object sender, EventArgs e)
        {
            if (AllFieldsAreFilled())
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString);
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                if (sqlConnection.State == ConnectionState.Open)
                {
                    var adv = new Advertisiment(new Car(BrandText.Text,
                        ModelText.Text,
                        int.Parse(YearsComboBox.Text),
                        Convert.ToInt32(KmAgeText.Text),
                        MotorText.Text,
                        GearBoxText.Text,
                        BodyComboBox.Text,
                        SteeringWheelText.Text),
                        Convert.ToInt32(PriceText.Text),
                        Status.OnSale,
                        new Bitmap(ImageCar.Image)
                        );
                    sqlConnection.Close();

                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены"); // добавить
            }
        }
        private bool AllFieldsAreFilled()
        {
            if (BrandText.Text == null || ModelText.Text == null
                || YearsComboBox.Text == null || BodyComboBox.Text == null
                || KmAgeText.Text == null || SteeringWheelText.Text == null
                || TypeDriveText.Text == null || GearBoxText.Text == null
                || MotorText.Text == null || ImagePath == null
                || TextAboutCar.Text == null || TextAboutCar.Text == null 
                || PriceText.Text == null) return false;
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
    }
}
