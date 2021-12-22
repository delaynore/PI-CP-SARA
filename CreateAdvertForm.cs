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
        public CreateAdvertForm()
        {
            InitializeComponent();
        }

        private void BackToMainFormButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateAdvertForm_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            for (int i = 1950; i < dateTime.Year; i++)
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
    }
}
