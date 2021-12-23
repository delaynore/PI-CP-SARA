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
    public partial class CatalogForm : Form
    {
        private Form parentForm;
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter dataAdapter = null;
        private DataSet dataSet = null;
        public CatalogForm(Form form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private async void CatalogForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString);
            try
            {
                await sqlConnection.OpenAsync();
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           

        }
        private void LoadData()
        {
            try
            {
                dataAdapter = new SqlDataAdapter("SELECT Brand as 'Марка', Model as 'Модель', Year as 'Год выпуска', Price as 'Цена' FROM Adverts", sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Adverts");
                dataGridView1.DataSource = dataSet.Tables["Adverts"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
