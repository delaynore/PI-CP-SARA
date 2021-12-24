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
        private SqlConnection sqlConnection;
        private int index;
        public OpenAdvert(int indx, SqlConnection connection, Form form)
        {
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
                try
                {
                    ImageCar.Image = Image.FromFile(reader["ImagePath"].ToString());
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
            parrentForm.Show();
            this.Close();
        }

        private void OpenAdvert_Load(object sender, EventArgs e)
        {
            CnahgeStateContols();
            Info(index, sqlConnection);
        }
        private void CnahgeStateContols()
        {
            BrandText.ReadOnly = !BrandText.ReadOnly;
            ModelText.ReadOnly = !ModelText.ReadOnly;
            YearText.ReadOnly = !YearText.ReadOnly;
            BodyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            KmAgeText.ReadOnly = !KmAgeText.ReadOnly;
            //SteeringWheelText.ReadOnly = !SteeringWheelText.ReadOnly;
            //TypeDriveText.ReadOnly = !TypeDriveText.ReadOnly;
            //GearBoxText.ReadOnly = !GearBoxText.ReadOnly;
            //MotorText.ReadOnly = !MotorText.ReadOnly;
            PriceText.ReadOnly = !PriceText.ReadOnly;
            StatusText.ReadOnly = !StatusText.ReadOnly;
            TextAboutCar.ReadOnly = !TextAboutCar.ReadOnly;
        }
    }
}
