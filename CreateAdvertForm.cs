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
        private SqlConnection sqlConnection = null;
        private string ImagePath = null;
        private Form parentForm;
        public CreateAdvertForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void BackToMainFormButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
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

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString);
            sqlConnection.Open();
        }

        private void YearsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveAdvButton_Click(object sender, EventArgs e)
        {

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
    }
}
