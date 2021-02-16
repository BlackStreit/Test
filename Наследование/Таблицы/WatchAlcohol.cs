using System;
using System.Windows.Forms;

namespace Наследование.Таблицы
{
    public partial class WatchAlcohol : Form
    {
        private MainForm mainForm;

        public WatchAlcohol(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void WatchAlcohol_Load(object sender, EventArgs e)
        {
            int count = 0;
            dataGridView1.RowCount = mainForm.alcoholCount;
            for (int i = 0; i < mainForm.Sum; i++)
            {
                var drink = mainForm.drinksList[i];
                if (drink is Alcohol)
                {
                    var info = drink.InfoToField();
                    dataGridView1[0, count].Value = count + 1;
                    dataGridView1[1, count].Value = info["name"];
                    dataGridView1[2, count].Value = info["volume"];
                    dataGridView1[3, count].Value = info["type"];
                    dataGridView1[4, count].Value = info["fortress"];
                    dataGridView1[5, count].Value = info["cost"];
                    count++;
                }
            }
        }
    }
}
