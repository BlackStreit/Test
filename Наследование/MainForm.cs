using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Наследование.Таблицы;
using System.Drawing;

namespace Наследование
{
    public partial class MainForm : Form
    {
        public List<Drink> drinksList = new List<Drink>();
        public int juiceCount;
        public int sodaCount;
        public int alcoholCount;
        public bool isEdit = false;
        private bool isLoad = true;
        private bool isDown;
        private Drink search;
        private ushort balance;
        private Dictionary<int, Drink> drinksType = new Dictionary<int, Drink>();
        public int Sum
        {
            get
            {
                return juiceCount + sodaCount + alcoholCount;
            }
        }
        public MainForm()
        {
            InitializeComponent();
            if (File.Exists("Save.txt"))
            {
                LoadFile();
            }
            balanceOut.Text = "На вашем балансе 0";
            ShowInfo();
        }

        private void Save()
        {
            FileStream file = new FileStream("Save.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(file);

            foreach (var drink in drinksList)
            {
                if (drink is Juice)
                {
                    var save = drink.InfoToField();
                    sw.WriteLine($"{save["name"]}|{save["volume"]}|{save["type"]}|{save["pulp"]}|{save["cost"]}|0");
                }
                else if (drink is Soda)
                {
                    var save = drink.InfoToField();
                    sw.WriteLine($"{save["name"]}|{save["volume"]}|{save["type"]}|{save["count"]}|{save["cost"]}|1");
                }
                else if (drink is Alcohol)
                {
                    var save = drink.InfoToField();
                    sw.WriteLine($"{save["name"]}|{save["volume"]}|{save["type"]}|{save["fortress"]}|{save["cost"]}|2");
                }
            }
            sw.Close();
        }

        private void LoadFile()
        {
            FileStream file = new FileStream("Save.txt", FileMode.Open);
            StreamReader sr = new StreamReader(file);
            string ln = "";
            while (!sr.EndOfStream)
            {
                ln = sr.ReadLine();
                string[] word = ln.Split('|');
                if (word[5] == "0")
                {
                    drinksList.Add(new Juice(word[0], word[1], word[2], word[3], word[4]));
                }
                if (word[5] == "1")
                {
                    drinksList.Add(new Soda(word[0], word[1], word[2], word[3], word[4]));
                }
                if (word[5] == "2")
                {
                    drinksList.Add(new Alcohol(word[0], word[1], word[2], word[3], word[4]));
                }
            }
            sr.Close();
        }

        public void ShowInfo()
        {
            drinksType.Clear();
            getDrinks.Controls.Clear();
            juiceCount = 0;
            sodaCount = 0;
            alcoholCount = 0;
            byte tag = 0;
            foreach (var drink in drinksList)
            {
                if (drink is Juice)
                {
                    juiceCount++;
                }
                else if (drink is Soda)
                {
                    sodaCount++;
                }
                else if (drink is Alcohol)
                {
                    alcoholCount++;
                }
                if (Sum < 17)
                {
                    drinksType.Add(tag, drink);
                    Button getButton = new Button();
                    getButton.Tag = tag;
                    getButton.Name = "Pos" + tag;
                    getButton.Dock = DockStyle.Fill;
                    getButton.Click += new EventHandler(getDrink_Click);
                    getButton.Text = drink.name;
                    getDrinks.Controls.Add(getButton);
                }
                tag++;
            }
            if (isLoad)
            {
                txtOut.Text = "Привет, Братик!";
            }
            if (isLoad == false)
            {
                if (juiceCount == 0 && sodaCount == 0 && alcoholCount == 0)
                {
                    txtOut.Text = "У меня больше нет напитков, Братик";
                }
            }
            txtInfo.Text = "\tСок\tГазировка\tАлкоголь";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format($"\t {juiceCount}\t       {sodaCount}\t                      {alcoholCount}");
        }

        private void addDrink_Click(object sender, EventArgs e)
        {
            AddDrink ad = new AddDrink(this);
            ad.Show();
        }

        private void watchButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            Form w;
            if (Convert.ToInt32(button.Tag) == 0)
            {
                if (juiceCount == 0)
                {
                    MessageBox.Show("У меня нет сока...");
                    return;
                }
                w = new WatchJuice(this);
            }
            else if(Convert.ToInt32(button.Tag) == 1)
            {
                if (sodaCount == 0)
                {
                    MessageBox.Show("У меня нет газировки...");
                    return;
                }
                w = new WatchSoda(this);
            }
            else
            {
                if (alcoholCount == 0)
                {
                    MessageBox.Show("У меня нет алкоголя...");
                    return;
                }
                DialogResult result = MessageBox.Show(
                "Вам уже исполнилось 18",
                "",
                 MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }
                ShowInfo();
                w = new WatchAlcohol(this);
            }
            w.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isEdit == true)
            {
                DialogResult result = MessageBox.Show(
               "Вы хотите сохранить данные?",
               "",
                MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Save();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Вы уверены, что хотите отчисть автомат?",
              "",
               MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                drinksList.Clear();
                juiceCount = 0;
                sodaCount = 0;
                alcoholCount = 0;
                outBox.Image = null;
                label4.Text = null;
                ShowInfo();
                isEdit = true;
                txtOut.Text = "Ты опустошил меня, Братик...";
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            ShowInfo();
            if ((juiceCount != 0 || alcoholCount != 0 || sodaCount != 0) && isLoad == false)
            {
                txtOut.Text = "Я готова к работе, Братик!";
            }
            if (juiceCount == 0 && alcoholCount == 0 && sodaCount == 0 && isLoad == false)
            {
                txtOut.Text = "Я пуста...";
                label4.Text = "Я не могу тебе ничего дать, Братик...";
                outBox.Image = null;
            }
            isLoad = false;
        }

        private void txtInfo_MouseMove(object sender, MouseEventArgs e)
        {
            outBox.Focus();
        }

        private void txtOut_MouseMove(object sender, MouseEventArgs e)
        {
            outBox.Focus();
        }

        private void coin_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void coin_MouseMove(object sender, MouseEventArgs e)
        {
            var c = sender as Control;
            if (isDown)
            {
                var point = PointToClient(MousePosition);
                c.Location = new Point(point.X - c.Width / 2, point.Y - c.Height / 2);
            }
        }

        private void coin_MouseUp(object sender, MouseEventArgs e)
        {
            var c = sender as Control;
            isDown = false;
            var box = sender as PictureBox;
            if (Convert.ToInt32(box.Tag) == 0)
            {
                if ((c.Location.X + 40 >= pictureBox3.Location.X && c.Location.X <= pictureBox3.Location.X + 50)
                        && (c.Location.Y + 40 >= pictureBox3.Location.Y && c.Location.Y <= pictureBox3.Location.Y + 207))
                {
                    balance += 100;
                    box.Location = new Point(796, 320);
                }
            }
            else
            {
                if ((c.Location.X + 40 >= pictureBox3.Location.X && c.Location.X <= pictureBox3.Location.X + 50)
                        && (c.Location.Y + 40 >= pictureBox3.Location.Y && c.Location.Y <= pictureBox3.Location.Y + 207))
                {
                    balance += 1000;
                    box.Location = new Point(796, 441);
                }
            }
            balanceOut.Text = $"На вашем балансе {balance}";
        }

        private void getDrink_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            for(int i = 0; i < 16; i++)
            {
                if(i == Convert.ToInt32(button.Tag))
                {
                    if (drinksType[i].GetType() == typeof(Alcohol))
                    {
                        DialogResult result = MessageBox.Show(
            "Вам уже исполнилось 18",
            "",
             MessageBoxButtons.YesNo);

                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                    txtOut.Text = drinksType[i].getInfo();
                    search = drinksType[i];
                    break;
                }
            }
            button.Focus();
        }

        private void byeButton_Click(object sender, EventArgs e)
        {
            if (txtOut.Text == "Успешно!" || txtOut.Text == "Привет, Братик!"||
                txtOut.Text == "Ты ничего не выбрал, Братик!")
            {
                txtOut.Text = "Ты ничего не выбрал, Братик!";
                return;
            }
            if (balance < search.cost)
            {
                txtOut.Text = "Пополни баланс, Братик!";
                return;
            }
            outBox.Image = search.getImage();
            label4.Text = search.getLableText();
            balance -= search.cost;
            for (int i = 0; i < Sum; i++)
            {
                if (drinksList[i].Equals(search))
                {
                    drinksList.RemoveAt(i);
                    txtOut.Text = "Успешно!";
                    isEdit = true;
                    break;
                }
            }
            balanceOut.Text = $"На вашем балансе {balance}";
            ShowInfo();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
