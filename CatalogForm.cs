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
    public partial class CatalogForm : BorderLessForm
    {
        private Form parentForm;
        private SqlConnection? sqlConnection = null;
        private SqlCommandBuilder? sqlCommandBuilder = null;
        private SqlDataAdapter? dataAdapter = null;
        private DataSet? dataSet = null;
        public CatalogForm(Form form)
        {
            HeaderBackColor = Color.White;
            Moveable = true;
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
                dataAdapter = new SqlDataAdapter("SELECT Id as 'Номер объявления', Brand as 'Марка', Model as 'Модель', Year as 'Год выпуска', Price as 'Цена', 'Delete' as [Delete] FROM Adverts", sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Adverts");
                dataGridView1.DataSource = dataSet.Tables["Adverts"];

              for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkcell = new DataGridViewLinkCell();

                    dataGridView1[5, i] = linkcell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadData()
        {
            try
            {
                dataSet.Tables["Adverts"].Clear();
                dataAdapter.Fill(dataSet, "Adverts");
                dataGridView1.DataSource = dataSet.Tables["Adverts"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkcell = new DataGridViewLinkCell();

                    dataGridView1[5, i] = linkcell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 5)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалиь эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes);
                        {
                            int rowIndex = e.RowIndex;
                            dataGridView1.Rows.RemoveAt(rowIndex);
                            dataSet.Tables["Adverts"].Rows[rowIndex].Delete();
                            SqlCommand command = new SqlCommand($"DELETE FROM Adverts WHERE Id ={rowIndex}",sqlConnection);
                            dataAdapter.Update(dataSet, "Adverts");
                        }
                        ReloadData();
                    }
                    
                }

            }
            catch
            {

            }
        }

        private void toolStripUpdate_Click(object sender, EventArgs e)
        {
            ReloadData();
        }
    }
}
