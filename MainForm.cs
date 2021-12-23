using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class MainForm : Form
    {
        private string title = "О приложении";
        private string info = 
            "Приложение ''САРА'' создано для оптимизации деятельности " +
            "\nработы салонов по продажам автомобилей." +
            "\nПриложение имеет структуру для создания объявления и " +
            "\nв последующем сохраняет его в базу данных." +
            "\nТаким образом, приложение оптимизирует деятельность " +
            "\nменеджеров салона и ускоряет их работу с клиентами.";


        public MainForm()
        {
            InitializeComponent();
        }
        private Point MouseHook;
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            else
            {
                Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateAdvertButton_Click(object sender, EventArgs e)
        {
            var createAdvForm = new CreateAdvertForm(this);
            createAdvForm.Show();
            this.Hide();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            var formInfo = new Information(title, info);
            formInfo.ShowDialog();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            var catalogForm = new CatalogForm(this);
            catalogForm.Show();
            this.Hide();
        }
    }
}
