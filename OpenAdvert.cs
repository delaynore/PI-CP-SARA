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
           
        public OpenAdvert(int index, SqlConnection sqlConnection)
        {
            InitializeComponent();
            Info(index,sqlConnection);
        }

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
                //KmAgeText.Text = reader["KmAge"].ToString();
                SteeringWheelText.Text = reader["SteeringWheel"].ToString();
                TypeDriveText.Text = reader["TypeDrive"].ToString();
                GearBoxText.Text = reader["GearBox"].ToString();
                MotorText.Text = reader["Motor"].ToString();
                PriceText.Text = reader["Price"].ToString();
                TextAboutCar.Text = reader["Discryption"].ToString();
                StatusText.Text = reader["SellStatus"].ToString();
            }
        }
        

        
    }
}
