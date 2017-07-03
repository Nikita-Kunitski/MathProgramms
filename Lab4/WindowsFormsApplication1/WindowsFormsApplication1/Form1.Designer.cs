namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DoubleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AccountNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Classic = new System.Windows.Forms.RadioButton();
            this.ClassicPost = new System.Windows.Forms.RadioButton();
            this.FreeChoise = new System.Windows.Forms.RadioButton();
            this.InternetDeposit = new System.Windows.Forms.RadioButton();
            this.DateCreateDeposit = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BirthDay = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Series = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SMSNotification_ = new System.Windows.Forms.CheckBox();
            this.InternetBanking_ = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.CreateDeposite = new System.Windows.Forms.Button();
            this.Balance_ = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(227, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Банк";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(296, 55);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(196, 20);
            this.Name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Фамилия";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(296, 97);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(196, 20);
            this.LastName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Отчество";
            // 
            // DoubleName
            // 
            this.DoubleName.Location = new System.Drawing.Point(297, 139);
            this.DoubleName.Name = "DoubleName";
            this.DoubleName.Size = new System.Drawing.Size(195, 20);
            this.DoubleName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Номер счета";
            // 
            // AccountNumber
            // 
            this.AccountNumber.Location = new System.Drawing.Point(32, 55);
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Size = new System.Drawing.Size(192, 20);
            this.AccountNumber.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Тип вклада:";
            // 
            // Classic
            // 
            this.Classic.AutoSize = true;
            this.Classic.Location = new System.Drawing.Point(35, 98);
            this.Classic.Name = "Classic";
            this.Classic.Size = new System.Drawing.Size(140, 17);
            this.Classic.TabIndex = 10;
            this.Classic.TabStop = true;
            this.Classic.Text = "Классик безотзывный";
            this.Classic.UseVisualStyleBackColor = true;
            // 
            // ClassicPost
            // 
            this.ClassicPost.AutoSize = true;
            this.ClassicPost.Location = new System.Drawing.Point(35, 114);
            this.ClassicPost.Name = "ClassicPost";
            this.ClassicPost.Size = new System.Drawing.Size(173, 17);
            this.ClassicPost.TabIndex = 11;
            this.ClassicPost.TabStop = true;
            this.ClassicPost.Text = "Классик почтовый отзывный";
            this.ClassicPost.UseVisualStyleBackColor = true;
            // 
            // FreeChoise
            // 
            this.FreeChoise.AutoSize = true;
            this.FreeChoise.Location = new System.Drawing.Point(35, 130);
            this.FreeChoise.Name = "FreeChoise";
            this.FreeChoise.Size = new System.Drawing.Size(117, 17);
            this.FreeChoise.TabIndex = 12;
            this.FreeChoise.TabStop = true;
            this.FreeChoise.Text = "Свободный выбор";
            this.FreeChoise.UseVisualStyleBackColor = true;
            // 
            // InternetDeposit
            // 
            this.InternetDeposit.AutoSize = true;
            this.InternetDeposit.Location = new System.Drawing.Point(35, 145);
            this.InternetDeposit.Name = "InternetDeposit";
            this.InternetDeposit.Size = new System.Drawing.Size(203, 17);
            this.InternetDeposit.TabIndex = 13;
            this.InternetDeposit.TabStop = true;
            this.InternetDeposit.Text = "Интернет-депозит-тренд отзывный";
            this.InternetDeposit.UseVisualStyleBackColor = true;
            // 
            // DateCreateDeposit
            // 
            this.DateCreateDeposit.Location = new System.Drawing.Point(31, 231);
            this.DateCreateDeposit.Name = "DateCreateDeposit";
            this.DateCreateDeposit.Size = new System.Drawing.Size(200, 20);
            this.DateCreateDeposit.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата открытия депозита";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Дата Рождения";
            // 
            // BirthDay
            // 
            this.BirthDay.Location = new System.Drawing.Point(297, 221);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(195, 20);
            this.BirthDay.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Паспортные данные:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Серия";
            // 
            // Series
            // 
            this.Series.Location = new System.Drawing.Point(299, 280);
            this.Series.Name = "Series";
            this.Series.Size = new System.Drawing.Size(35, 20);
            this.Series.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Номер";
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(337, 280);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(155, 20);
            this.Number.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Баланс счета:";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Balance.Location = new System.Drawing.Point(72, 186);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(0, 24);
            this.Balance.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Дополнительные услуги";
            // 
            // SMSNotification_
            // 
            this.SMSNotification_.AutoSize = true;
            this.SMSNotification_.Location = new System.Drawing.Point(38, 277);
            this.SMSNotification_.Name = "SMSNotification_";
            this.SMSNotification_.Size = new System.Drawing.Size(115, 17);
            this.SMSNotification_.TabIndex = 26;
            this.SMSNotification_.Text = "СМС оповещения";
            this.SMSNotification_.UseVisualStyleBackColor = true;
            // 
            // InternetBanking_
            // 
            this.InternetBanking_.AutoSize = true;
            this.InternetBanking_.Location = new System.Drawing.Point(38, 295);
            this.InternetBanking_.Name = "InternetBanking_";
            this.InternetBanking_.Size = new System.Drawing.Size(118, 17);
            this.InternetBanking_.TabIndex = 27;
            this.InternetBanking_.Text = "Интернет-банкинг";
            this.InternetBanking_.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(297, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Телефон";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(296, 178);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(196, 20);
            this.Phone.TabIndex = 29;
            // 
            // CreateDeposite
            // 
            this.CreateDeposite.Location = new System.Drawing.Point(38, 330);
            this.CreateDeposite.Name = "CreateDeposite";
            this.CreateDeposite.Size = new System.Drawing.Size(114, 23);
            this.CreateDeposite.TabIndex = 30;
            this.CreateDeposite.Text = "Создать";
            this.CreateDeposite.UseVisualStyleBackColor = true;
            this.CreateDeposite.Click += new System.EventHandler(this.Create);
            // 
            // Balance_
            // 
            this.Balance_.Location = new System.Drawing.Point(32, 188);
            this.Balance_.Name = "Balance_";
            this.Balance_.Size = new System.Drawing.Size(199, 20);
            this.Balance_.TabIndex = 32;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 370);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 238);
            this.listBox1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 45);
            this.button1.TabIndex = 34;
            this.button1.Text = "Действия над депозитом";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 671);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Balance_);
            this.Controls.Add(this.CreateDeposite);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.InternetBanking_);
            this.Controls.Add(this.SMSNotification_);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Series);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BirthDay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateCreateDeposit);
            this.Controls.Add(this.InternetDeposit);
            this.Controls.Add(this.FreeChoise);
            this.Controls.Add(this.ClassicPost);
            this.Controls.Add(this.Classic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AccountNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DoubleName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lab_7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DoubleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AccountNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Classic;
        private System.Windows.Forms.RadioButton ClassicPost;
        private System.Windows.Forms.RadioButton FreeChoise;
        private System.Windows.Forms.RadioButton InternetDeposit;
        private System.Windows.Forms.DateTimePicker DateCreateDeposit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker BirthDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Series;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox SMSNotification_;
        private System.Windows.Forms.CheckBox InternetBanking_;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Button CreateDeposite;
        private System.Windows.Forms.TextBox Balance_;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

