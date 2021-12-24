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
    public partial class OpenAdvert : Form
    {
           
        public OpenAdvert(int index, SqlConnection sqlConnection, Form form)
        {
            InitializeComponent();
            Info(index,sqlConnection);
            parrentForm = form;
        }
        private Form parrentForm;
        public void Info(int index, SqlConnection sqlConnection)
        {
            var cmd = new SqlCommand($"SELECT * FROM Adverts WHERE Id = {index}", sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                BrandText.Text = reader["Brand"].ToString();
                ModelText.Text = reader["Model"].ToString();
                YearText.Text = reader["Year"].ToString();
                BodyComboBox.Text = reader["Body"].ToString();
                KmAgeText.Text = reader["KmAge"].ToString();
                SteeringWheelText.Text = reader["SteeringWheel"].ToString();
                TypeDriveText.Text = reader["TypeDrive"].ToString();
                GearBoxText.Text = reader["GearBox"].ToString();
                MotorText.Text = reader["Motor"].ToString();
                PriceText.Text = reader["Price"].ToString();
                TextAboutCar.Text = reader["Description"].ToString();
                StatusText.Text = reader["SaleStatus"].ToString();
                ImageCar.Image = Image.FromFile(reader["ImagePath"].ToString());
            }
            reader.Close();
        }

        private void BackToMainFormButton_Click(object sender, EventArgs e)
        {
            parrentForm.Show();
            this.Close();
        }
    }
}
