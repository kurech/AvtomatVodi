using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvtomatVodi
{
    public partial class Form1 : Form
    {
        public bool card = true;
        public int balance = 240;
        public int time = 0;
        public bool isActiveBottle = false;
        public int numLitersUser = 0;
        public int numLiters = 0;
        public bool isActiveAddition = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void Cancel()
        {
            textBox1.Text = "Приложите карту";
            card = true;
            isActiveBottle = false;
            isActiveAddition = false;
            pictureBox1.Image = null;
            numLiters = 0;
            time = 0;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (isActiveBottle == true && isActiveAddition == false)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = $"Ваш баланс {balance} руб";
            }

            if (isActiveAddition == true)
            {
                textBox1.Text = $"Вложите купюру";
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            isActiveBottle = true;
            numLitersUser = 1;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            pictureBox1.Image = Properties.Resources.b1;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            isActiveBottle = true;
            numLitersUser = 5;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            pictureBox1.Image = Properties.Resources.b5;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            isActiveBottle = true;
            numLitersUser = 10;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            pictureBox1.Image = Properties.Resources.b10;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            isActiveBottle = true;
            numLitersUser = 20;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            pictureBox1.Image = Properties.Resources.b20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numLiters = 1;
            button5.Enabled = true;
            textBox1.Text = "Выбран 1 литр";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time == 1)
            {
                pictureBox1.Image = null;
                textBox1.Text = $"Ваш баланс {balance} руб";
                switch (numLitersUser)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.b1half;
                        break;
                    case 5:
                        pictureBox1.Image = Properties.Resources.b5half;
                        break;
                    case 10:
                        pictureBox1.Image = Properties.Resources.b10half;
                        break;
                    case 20:
                        pictureBox1.Image = Properties.Resources.b20half;
                        break;
                }
            }
            if (time == 2)
            {
                pictureBox1.Image = null;
                textBox1.Text = $"Ваш баланс {balance} руб";
                switch (numLitersUser)
                {
                    case 1:
                        if (numLitersUser == numLiters)
                            pictureBox1.Image = Properties.Resources.b1full;
                        else
                            pictureBox1.Image = Properties.Resources.b1half;
                        break;
                    case 5:
                        if (numLitersUser == numLiters)
                            pictureBox1.Image = Properties.Resources.b5full;
                        else
                            pictureBox1.Image = Properties.Resources.b5half;
                        break;
                    case 10:
                        if (numLitersUser == numLiters)
                            pictureBox1.Image = Properties.Resources.b10full;
                        else
                            pictureBox1.Image = Properties.Resources.b10half;
                        break;
                    case 20:
                        if (numLitersUser == numLiters)
                            pictureBox1.Image = Properties.Resources.b20full;
                        else
                            pictureBox1.Image = Properties.Resources.b20half;
                        break;
                }
            }
            if (time == 3)
            {
                textBox1.Text = "Заберите бутылку";
            }
            if (time == 4)
            {
                timer1.Stop();
                timer1.Enabled = false;
                Cancel();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (numLiters)
            {
                case 1:
                    if (balance >= 5 && numLitersUser >= 1)
                    {
                        balance -= 5;
                        textBox1.Text = $"Остаток {balance}";
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        Cancel();
                    }
                    break;
                case 5:
                    if (balance >= 25 && numLitersUser >= 5)
                    {
                        balance -= 25;
                        textBox1.Text = $"Остаток {balance}";
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        Cancel();
                    }
                    break;
                case 10:
                    if (balance >= 50 && numLitersUser >= 10)
                    {
                        balance -= 50;
                        textBox1.Text = $"Остаток {balance}";
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        Cancel();
                    }
                    break;
                case 20:
                    if (balance >= 100 && numLitersUser >= 20)
                    {
                        balance -= 100;
                        textBox1.Text = $"Остаток {balance}";
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        Cancel();
                    }
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numLiters = 5;
            button5.Enabled = true;
            textBox1.Text = "Выбрано 5 литров";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numLiters = 10;
            button5.Enabled = true;
            textBox1.Text = "Выбрано 10 литров";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numLiters = 20;
            button5.Enabled = true;
            textBox1.Text = "Выбрано 20 литров";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Cancel();
            isActiveBottle = true;
            isActiveAddition = true;
            textBox1.Text = "Приложите карту";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            balance += int.Parse(button12.Text);
            isActiveAddition = false;
            Cancel();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            balance += int.Parse(button13.Text);
            isActiveAddition = false;
            Cancel();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            balance += int.Parse(button15.Text);
            isActiveAddition = false;
            Cancel();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            balance += int.Parse(button14.Text);
            isActiveAddition = false;
            Cancel();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            balance = 20;
        }
    }
}
