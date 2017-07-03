using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Create(object sender, EventArgs e)
        {
            if (AccountNumber.Text == string.Empty
                && Classic.Checked == false //проверка на пустоту полей
                && ClassicPost.Checked == false && FreeChoise.Checked == false && InternetDeposit.Checked == false 
                && Balance_.Text == string.Empty
                && SMSNotification_.Checked == false && InternetBanking_.Checked == false
                && Name.Text == string.Empty 
                && LastName.Text == string.Empty 
                && DoubleName.Text == string.Empty
                && Phone.Text == string.Empty 
                && Series.Text == string.Empty 
                && Number.Text == string.Empty)
                MessageBox.Show("Заполните поля!");
            else {
                    if (AccountNumber.Text == string.Empty) //проверка на номер депозита
                    {
                        MessageBox.Show("Заполните поле: Номер депозита");
                        return;
                    }

                    if (Classic.Checked == false && ClassicPost.Checked == false && FreeChoise.Checked == false
                        && InternetDeposit.Checked == false) //проверка на тип депозита
                    {
                        MessageBox.Show("Выберите тип депозита!");
                        return;
                    }

                    if (Balance_.Text == string.Empty) //проверка на баланс
                    {
                        MessageBox.Show("Введите баланс!");
                        return;
                    }

                    if (Name.Text == string.Empty) //проверка на Имя 
                    {
                        MessageBox.Show("Введите имя!");
                        return;
                    }

                    if (LastName.Text == string.Empty) //проверка на фамилию
                    {
                        MessageBox.Show("Введите фамилию!");
                        return;
                    }

                    if (DoubleName.Text == string.Empty) //проверка на фамилию
                    {
                        MessageBox.Show("Введите отчество!");
                        return;
                    }

                    if (Phone.Text == string.Empty) //проверка на телефон
                    {
                        MessageBox.Show("Введите телефон!");
                        return;
                    }

                    if (Series.Text == string.Empty) //проверка на серию
                    {
                        MessageBox.Show("Введите серию паспорта!");
                        return;
                    }

                    if (Number.Text == string.Empty) //проверка на номер
                    {
                        MessageBox.Show("Введите номер паспорта!");
                        return;
                    }
                listBox1.Items.Add("№"+AccountNumber.Text);
                if (Classic.Checked == true)
                    listBox1.Items.Add(Classic.Text);
                if(ClassicPost.Checked == true)
                    listBox1.Items.Add(ClassicPost.Text);
                if(FreeChoise.Checked == true)
                    listBox1.Items.Add(FreeChoise.Text);
                if(InternetDeposit.Checked == true)
                    listBox1.Items.Add(InternetDeposit.Text);
                listBox1.Items.Add("Баланс:"+AccountNumber.Text);
                listBox1.Items.Add(Name.Text);
                listBox1.Items.Add(LastName.Text);
                listBox1.Items.Add(DoubleName.Text);
                listBox1.Items.Add(Phone.Text);
                listBox1.Items.Add(Series.Text);
                listBox1.Items.Add(Number.Text);
                listBox1.Items.Add("Дата открытия депозита:");
                listBox1.Items.Add(DateCreateDeposit.Text);
                listBox1.Items.Add("Дата рождения:");
                listBox1.Items.Add(BirthDay.Text);
                MessageBox.Show("Депозит открыт!");
                }
                
        }
    }
}
