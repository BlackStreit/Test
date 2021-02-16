using System;
using System.Drawing;
using System.Windows.Forms;

namespace Наследование
{
    public partial class AddDrink : Form
    {
        private MainForm mainForm;

        public AddDrink(MainForm mainForm)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            this.mainForm = mainForm;
        }

        private void getRandomJuice_Click(object sender, EventArgs e)
        {
            mainForm.drinksList.Add(new Juice());
            mainForm.juiceCount++;
            MessageBox.Show("Успешно");
            mainForm.isEdit = true;
            mainForm.ShowInfo();
        }

        private void addRandomSoda_Click(object sender, EventArgs e)
        {
            mainForm.drinksList.Add(new Soda());
            mainForm.sodaCount++;
            MessageBox.Show("Успешно");
            mainForm.isEdit = true;
            mainForm.ShowInfo();
        }

        private void addRandomAlcohol_Click(object sender, EventArgs e)
        {
            mainForm.drinksList.Add(new Alcohol());
            mainForm.alcoholCount++;
            MessageBox.Show("Успешно");
            mainForm.isEdit = true;
            mainForm.ShowInfo();
        }

        private void addJuice_Click(object sender, EventArgs e)
        {
            nameJuice.BackColor = Color.White;
            pulpFalse.BackColor = Color.White;
            pultTrue.BackColor = Color.White;
            if (nameJuice.Text=="" || (pulpFalse.Checked==false && pultTrue.Checked == false))
            {
                if(nameJuice.Text == "")
                {
                    nameJuice.BackColor = Color.Red;
                }
                if(pulpFalse.Checked == false && pultTrue.Checked == false)
                {
                    pulpFalse.BackColor = Color.Red;
                    pultTrue.BackColor = Color.Red;
                }
                return;
            }
            mainForm.juiceCount++;
            string name = nameJuice.Text;
            double volume = (double)numericUpDown1.Value;
            fruits f = fruits.apple;
            switch (comboBox1.Text) {
                case "Апельсин":
                    f = fruits.orange;
                    break;
                case "Яблоко":
                    f = fruits.apple;
                    break;
                case "Мультифрукт":
                    f = fruits.multifruts;
                    break;
                case "Томат":
                    f = fruits.tomatos;
                    break;
            }
            bool pulp = pultTrue.Checked;
            ushort cost = (ushort)numericUpDown6.Value;
            mainForm.drinksList.Add(new Juice(volume, f, pulp, name, cost));
            nameJuice.Clear();
            numericUpDown1.Value = 1;
            comboBox1.SelectedIndex = 0;
            pulpFalse.Checked = false;
            pultTrue.Checked = false;
            mainForm.isEdit = true;
            MessageBox.Show("Успешно");
            mainForm.ShowInfo();
        }

        private void addSoda_Click(object sender, EventArgs e)
        {
            nameSoda.BackColor = Color.White;
            if(nameSoda.Text == "")
            {
                nameSoda.BackColor = Color.Red;
                return;
            }
            mainForm.sodaCount++;
            string name = nameSoda.Text;
            double volume = (double)numericUpDown2.Value;
            sodaType s = sodaType.cocaCola;
            switch (comboBox2.Text)
            {
                case "Кока-Кола":
                    s = sodaType.cocaCola;
                    break;
                case "Пепси":
                    s = sodaType.pepsi;
                    break;
                case "Тархун":
                    s =sodaType.tarragon;
                    break;
                case "Фанта":
                    s = sodaType.fanta;
                    break;
            }
            int bubleCount = (int)numericUpDown5.Value;
            ushort cost = (ushort)numericUpDown7.Value;
            mainForm.drinksList.Add(new Soda(volume, bubleCount, s, name, cost));
            nameSoda.Clear();
            numericUpDown2.Value = 1;
            numericUpDown5.Value = 1;
            comboBox2.SelectedIndex = 0;
            mainForm.isEdit = true;
            MessageBox.Show("Успешно");
            mainForm.ShowInfo();
        }

        private void addAlcohol_Click(object sender, EventArgs e)
        {
            nameAlcohol.BackColor = Color.White;
            if (nameAlcohol.Text == "")
            {
                nameAlcohol.BackColor = Color.Red;
                return;
            }
            mainForm.alcoholCount++;
            string name = nameAlcohol.Text;
            double volume = (int)numericUpDown3.Value;
            alcoholType a = alcoholType.beer;
            switch (comboBox3.Text)
            {
                case "Виски":
                    a = alcoholType.whiskey;
                    break;
                case "Водка":
                    a = alcoholType.vodka;
                    break;
                case "Джин":
                    a = alcoholType.gin;
                    break;
                case "Пиво":
                    a = alcoholType.beer;
                    break;
            }
            int fortress = (int)numericUpDown4.Value;
            ushort cost = (ushort)numericUpDown8.Value;
            mainForm.drinksList.Add(new Alcohol(volume, fortress, a, name, cost));
            nameAlcohol.Clear();
            numericUpDown3.Value = 1;
            numericUpDown4.Value = 1;
            comboBox3.SelectedIndex = 0;
            mainForm.isEdit = true;
            MessageBox.Show("Успешно");
            mainForm.ShowInfo();
        }
    }
}
