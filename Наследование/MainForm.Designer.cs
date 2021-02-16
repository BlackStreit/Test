namespace Наследование
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.addDrink = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.balanceOut = new System.Windows.Forms.Label();
            this.getDrinks = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.byeButton = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.outBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.watchSoda = new System.Windows.Forms.Button();
            this.watchButton = new System.Windows.Forms.Button();
            this.watchAlcohol = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfo.Location = new System.Drawing.Point(383, 45);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(283, 45);
            this.txtInfo.TabIndex = 10;
            this.txtInfo.TabStop = false;
            this.txtInfo.Tag = "8";
            this.txtInfo.Text = "";
            this.txtInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtInfo_MouseMove);
            // 
            // txtOut
            // 
            this.txtOut.BackColor = System.Drawing.Color.LightGray;
            this.txtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOut.Location = new System.Drawing.Point(720, 122);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(240, 101);
            this.txtOut.TabIndex = 2;
            this.txtOut.TabStop = false;
            this.txtOut.Text = "";
            this.txtOut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtOut_MouseMove);
            // 
            // addDrink
            // 
            this.addDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDrink.Location = new System.Drawing.Point(1074, 31);
            this.addDrink.Name = "addDrink";
            this.addDrink.Size = new System.Drawing.Size(131, 38);
            this.addDrink.TabIndex = 1;
            this.addDrink.Tag = "";
            this.addDrink.Text = "Добавить напиток";
            this.addDrink.UseVisualStyleBackColor = true;
            this.addDrink.Click += new System.EventHandler(this.addDrink_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.watchSoda, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.watchButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.watchAlcohol, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(915, 531);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 138);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(994, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Посмотреть";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(438, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Меня зовут Юи-Тян!";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(91, 31);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(131, 38);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Tag = "";
            this.deleteButton.Text = "Очистить автомат";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // balanceOut
            // 
            this.balanceOut.AutoSize = true;
            this.balanceOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceOut.Location = new System.Drawing.Point(739, 56);
            this.balanceOut.Name = "balanceOut";
            this.balanceOut.Size = new System.Drawing.Size(165, 20);
            this.balanceOut.TabIndex = 24;
            this.balanceOut.Text = "На вашем балансе 0";
            // 
            // getDrinks
            // 
            this.getDrinks.ColumnCount = 4;
            this.getDrinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.getDrinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.getDrinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.getDrinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.getDrinks.Location = new System.Drawing.Point(389, 114);
            this.getDrinks.Name = "getDrinks";
            this.getDrinks.RowCount = 4;
            this.getDrinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.getDrinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.getDrinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.getDrinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.getDrinks.Size = new System.Drawing.Size(307, 324);
            this.getDrinks.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(451, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 26;
            // 
            // byeButton
            // 
            this.byeButton.Location = new System.Drawing.Point(774, 248);
            this.byeButton.Name = "byeButton";
            this.byeButton.Size = new System.Drawing.Size(132, 50);
            this.byeButton.TabIndex = 27;
            this.byeButton.Text = "Купить";
            this.byeButton.UseVisualStyleBackColor = true;
            this.byeButton.Click += new System.EventHandler(this.byeButton_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.Transparent;
            this.coin.Image = global::Наследование.Properties.Resources.coin;
            this.coin.Location = new System.Drawing.Point(796, 320);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(97, 87);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin.TabIndex = 23;
            this.coin.TabStop = false;
            this.coin.Tag = "0";
            this.coin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.coin_MouseDown);
            this.coin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.coin_MouseMove);
            this.coin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.coin_MouseUp);
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Transparent;
            this.coin1.Image = global::Наследование.Properties.Resources.f4923d689e0789c4f2f5f2eba2e33052;
            this.coin1.Location = new System.Drawing.Point(796, 441);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(97, 87);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin1.TabIndex = 28;
            this.coin1.TabStop = false;
            this.coin1.Tag = "1";
            this.coin1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.coin_MouseDown);
            this.coin1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.coin_MouseMove);
            this.coin1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.coin_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(338, 91);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 207);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Наследование.Properties.Resources.RightGirl;
            this.pictureBox2.Location = new System.Drawing.Point(974, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 322);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // outBox
            // 
            this.outBox.Location = new System.Drawing.Point(415, 475);
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(233, 227);
            this.outBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outBox.TabIndex = 17;
            this.outBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Наследование.Properties.Resources.LeftGirl;
            this.pictureBox1.Location = new System.Drawing.Point(21, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // watchSoda
            // 
            this.watchSoda.BackgroundImage = global::Наследование.Properties.Resources.watchSodaButton;
            this.watchSoda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.watchSoda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watchSoda.FlatAppearance.BorderSize = 0;
            this.watchSoda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchSoda.Location = new System.Drawing.Point(108, 3);
            this.watchSoda.Name = "watchSoda";
            this.watchSoda.Size = new System.Drawing.Size(99, 132);
            this.watchSoda.TabIndex = 6;
            this.watchSoda.Tag = "1";
            this.watchSoda.UseVisualStyleBackColor = true;
            this.watchSoda.Click += new System.EventHandler(this.watchButton_Click);
            // 
            // watchButton
            // 
            this.watchButton.BackgroundImage = global::Наследование.Properties.Resources.watchJuiceButton;
            this.watchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.watchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watchButton.FlatAppearance.BorderSize = 0;
            this.watchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchButton.Location = new System.Drawing.Point(3, 3);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(99, 132);
            this.watchButton.TabIndex = 5;
            this.watchButton.Tag = "0";
            this.watchButton.UseVisualStyleBackColor = true;
            this.watchButton.Click += new System.EventHandler(this.watchButton_Click);
            // 
            // watchAlcohol
            // 
            this.watchAlcohol.BackgroundImage = global::Наследование.Properties.Resources.watchAlcoholButton;
            this.watchAlcohol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.watchAlcohol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watchAlcohol.FlatAppearance.BorderSize = 0;
            this.watchAlcohol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchAlcohol.Location = new System.Drawing.Point(213, 3);
            this.watchAlcohol.Name = "watchAlcohol";
            this.watchAlcohol.Size = new System.Drawing.Size(99, 132);
            this.watchAlcohol.TabIndex = 7;
            this.watchAlcohol.Tag = "2";
            this.watchAlcohol.UseVisualStyleBackColor = true;
            this.watchAlcohol.Click += new System.EventHandler(this.watchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 713);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.byeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getDrinks);
            this.Controls.Add(this.balanceOut);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.addDrink);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtInfo);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.RichTextBox txtOut;
        private System.Windows.Forms.Button addDrink;
        private System.Windows.Forms.Button watchButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button watchSoda;
        private System.Windows.Forms.Button watchAlcohol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox outBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label balanceOut;
        private System.Windows.Forms.TableLayoutPanel getDrinks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button byeButton;
        private System.Windows.Forms.PictureBox coin1;
    }
}

