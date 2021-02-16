using System;
using System.Windows.Forms;

namespace Наследование
{
    public partial class WatchJuice : Form
    {
        public WatchJuice(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private MainForm mainForm;

        private void WatchJuice_Load(object sender, EventArgs e)
        {
            int count = 0;
            dataGridView1.RowCount = mainForm.juiceCount;
            for (int i = 0; i < mainForm.Sum; i++)
            {
                var drink = mainForm.drinksList[i];
                if (drink is Juice)
                {
                    var info = drink.InfoToField();
                    dataGridView1[0, count].Value = count+1;
                    dataGridView1[1, count].Value = info["name"];
                    dataGridView1[2, count].Value = info["volume"];
                    dataGridView1[3, count].Value = info["type"];
                    dataGridView1[4, count].Value = info["pulp"];
                    count++;
                }
            }
        }
    }
}
