
namespace CourseWorkSofa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Diagnosis = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.District = new System.Windows.Forms.TextBox();
            this.Doctor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Age = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 26);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1164, 669);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::CourseWorkSofa.Properties.Resources._20_Boho_Sun_Desktop_Wallpapers_Pink_Digital_Wallpapers_Etsy;
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Diagnosis);
            this.tabPage1.Controls.Add(this.Date);
            this.tabPage1.Controls.Add(this.District);
            this.tabPage1.Controls.Add(this.Doctor);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Age);
            this.tabPage1.Controls.Add(this.Lastname);
            this.tabPage1.Controls.Add(this.Firstname);
            this.tabPage1.Controls.Add(this.Surname);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.tabPage1.Size = new System.Drawing.Size(1156, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Регистрация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Diagnosis
            // 
            this.Diagnosis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Diagnosis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.Diagnosis.Location = new System.Drawing.Point(410, 435);
            this.Diagnosis.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.Size = new System.Drawing.Size(269, 35);
            this.Diagnosis.TabIndex = 23;
            this.Diagnosis.Click += new System.EventHandler(this.Control_Click);
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.Date.Location = new System.Drawing.Point(410, 322);
            this.Date.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(269, 35);
            this.Date.TabIndex = 22;
            this.Date.Click += new System.EventHandler(this.Control_Click);
            // 
            // District
            // 
            this.District.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.District.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.District.Location = new System.Drawing.Point(410, 266);
            this.District.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.District.Name = "District";
            this.District.Size = new System.Drawing.Size(269, 35);
            this.District.TabIndex = 21;
            this.District.Click += new System.EventHandler(this.Control_Click);
            // 
            // Doctor
            // 
            this.Doctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Doctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.Doctor.FormattingEnabled = true;
            this.Doctor.Items.AddRange(new object[] {
            "Аллерголог",
            "Кардиолог",
            "Травматолог",
            "Физиотерапевт",
            "Рентгенолог",
            "Терапевт",
            "Педиатр",
            "Хирург",
            "Психиатр",
            "Офтальмолог",
            "Стоматолог"});
            this.Doctor.Location = new System.Drawing.Point(410, 378);
            this.Doctor.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(269, 36);
            this.Doctor.TabIndex = 20;
            this.Doctor.Click += new System.EventHandler(this.Control_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.button1.Location = new System.Drawing.Point(410, 531);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "Зарегистрироватся";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Age
            // 
            this.Age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.Age.Location = new System.Drawing.Point(410, 210);
            this.Age.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(269, 35);
            this.Age.TabIndex = 11;
            this.Age.Click += new System.EventHandler(this.Control_Click);
            // 
            // Lastname
            // 
            this.Lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.Lastname.Location = new System.Drawing.Point(410, 154);
            this.Lastname.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(269, 35);
            this.Lastname.TabIndex = 9;
            this.Lastname.Click += new System.EventHandler(this.Control_Click);
            // 
            // Firstname
            // 
            this.Firstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.Firstname.Location = new System.Drawing.Point(410, 98);
            this.Firstname.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(269, 35);
            this.Firstname.TabIndex = 8;
            this.Firstname.Click += new System.EventHandler(this.Control_Click);
            // 
            // Surname
            // 
            this.Surname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(141)))), ((int)(((byte)(138)))));
            this.Surname.Location = new System.Drawing.Point(410, 42);
            this.Surname.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(269, 35);
            this.Surname.TabIndex = 7;
            this.Surname.Click += new System.EventHandler(this.Control_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.Display);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.tabPage2.Size = new System.Drawing.Size(1156, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Список пациентов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(79)))));
            this.button4.Location = new System.Drawing.Point(248, 540);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 49);
            this.button4.TabIndex = 10;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Display
            // 
            this.Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Display.BackgroundImage = global::CourseWorkSofa.Properties.Resources._20_Boho_Sun_Desktop_Wallpapers_Pink_Digital_Wallpapers_Etsy;
            this.Display.BackgroundImageTiled = true;
            this.Display.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.Display.ForeColor = System.Drawing.Color.Black;
            this.Display.HideSelection = false;
            this.Display.Location = new System.Drawing.Point(11, 16);
            this.Display.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(1137, 507);
            this.Display.TabIndex = 0;
            this.Display.UseCompatibleStateImageBehavior = false;
            this.Display.View = System.Windows.Forms.View.Details;
            this.Display.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Display_ColumnClick);
            this.Display.VisibleChanged += new System.EventHandler(this.Display_VisibleChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фамилия";
            this.columnHeader3.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Отчество";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Возраст";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Район";
            this.columnHeader6.Width = 132;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Дата";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Врач";
            this.columnHeader8.Width = 116;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Диагноз";
            this.columnHeader9.Width = 123;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(79)))));
            this.button2.Location = new System.Drawing.Point(9, 540);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "Фильтр";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(242, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(242, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Диагноз";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(79)))));
            this.label3.Location = new System.Drawing.Point(242, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Врач";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(79)))));
            this.label4.Location = new System.Drawing.Point(239, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Дата обращения";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(79)))));
            this.label5.Location = new System.Drawing.Point(242, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 28);
            this.label5.TabIndex = 28;
            this.label5.Text = "Район проживания";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(79)))));
            this.label6.Location = new System.Drawing.Point(242, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 28);
            this.label6.TabIndex = 29;
            this.label6.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(79)))));
            this.label7.Location = new System.Drawing.Point(242, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 28);
            this.label7.TabIndex = 30;
            this.label7.Text = "Имя";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(90)))), ((int)(((byte)(79)))));
            this.label8.Location = new System.Drawing.Point(242, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 28);
            this.label8.TabIndex = 31;
            this.label8.Text = "Возраст";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 722);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Phenomena Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Form1";
            this.Text = "Поликлиника";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox Age;
		private System.Windows.Forms.TextBox Lastname;
		private System.Windows.Forms.TextBox Firstname;
		private System.Windows.Forms.TextBox Surname;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ListView Display;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox District;
		private System.Windows.Forms.ComboBox Doctor;
		private System.Windows.Forms.TextBox Date;
		private System.Windows.Forms.TextBox Diagnosis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

