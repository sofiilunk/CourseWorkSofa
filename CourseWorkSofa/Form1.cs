using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkSofa
{
	public partial class Form1 : Form
	{
		const string FILENAME = "Patients.json";

		struct Patient
		{
			public string surname;
			public string name;
			public string lastname;
			public string age;
			public string district;
			public string date;
			public string doctor;
			public string diagnosis;
		}

		public Form1()
		{
			Task.Run(() =>
			{
				if (!File.Exists(FILENAME))
				{
					File.Create(FILENAME);
				}
			});

			using (var form4 = new Form4())
			{
				form4.ShowDialog();
			}

			InitializeComponent();
		}

		async Task WriteToFile<T>(List<T> data)
		{
			using (var streamWriter = new StreamWriter(FILENAME, false))
			{
				await streamWriter.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
			}
		}

		async Task<List<T>> ReadFromFile<T>()
		{
			using (var streamReader = new StreamReader(FILENAME))
			{
				return await Task.Run(async () => JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
			}
		}

		async Task AddToFile<T>(T data)
		{
			var datas = await ReadFromFile<T>();
			datas.Add(data);
			await WriteToFile(datas);
		}

		async Task DeleteFromFileAt<T>(int index)
		{
			var datas = await ReadFromFile<T>();
			datas.RemoveAt(index);
			await WriteToFile(datas);
		}

		bool CheckOnCorrectTextBox(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") && Regex.IsMatch(tb.Text, @"^[а-яА-Яa-zA-Z ]+$") || (tb.BackColor = Color.Red) != Color.Red;
		bool CheckOnCorrectComboBox(ComboBox cb) => !(cb.SelectedItem is null) || (cb.BackColor = Color.Red) != Color.Red;

		bool CheckOnCorrectAge(TextBox tb) => uint.TryParse(Age.Text, out _) || (tb.BackColor = Color.Red) != Color.Red;
		bool CheckOnCorrectDate(TextBox tb) => DateTime.TryParse(Date.Text, out _) || (tb.BackColor = Color.Red) != Color.Red;

		bool CheckOnCorrectFields =>
			CheckOnCorrectTextBox(Surname) &
			CheckOnCorrectTextBox(Firstname) &
			CheckOnCorrectTextBox(Lastname) &
			CheckOnCorrectAge(Age) &
			CheckOnCorrectTextBox(District) &
			CheckOnCorrectDate(Date) &
			CheckOnCorrectTextBox(Diagnosis) &
			CheckOnCorrectComboBox(Doctor);

		async void Button1_Click(object sender, EventArgs e)
		{
			if (CheckOnCorrectFields)
			{
				await AddToFile(new Patient
				{
					surname = Surname.Text,
					name = Firstname.Text,
					lastname = Lastname.Text,
					age = Age.Text,
					district = District.Text,
					date = Date.Text,
					diagnosis = Diagnosis.Text,
					doctor = Doctor.SelectedItem as string
				});

				ClearAllField();

				MessageBox.Show("Клиент зарегистрирован");
				return;
			}

			MessageBox.Show("Введите корректные данные");
		}

		void ClearAllField()
		{
			Firstname.Text = Surname.Text = Lastname.Text = Age.Text = District.Text = Date.Text = Diagnosis.Text = default;
			Doctor.SelectedIndex = -1;
		}

		void DisplayData(List<Patient> patients)
		{
			Display.Items.Clear();

			var i = 0;
			foreach (var patient in patients)
			{
				var listViewItem = new ListViewItem(i.ToString());
				listViewItem.SubItems.Add(patient.surname);
				listViewItem.SubItems.Add(patient.name);
				listViewItem.SubItems.Add(patient.lastname);
				listViewItem.SubItems.Add(patient.age);
				listViewItem.SubItems.Add(patient.district);
				listViewItem.SubItems.Add(patient.date);
				listViewItem.SubItems.Add(patient.doctor);
				listViewItem.SubItems.Add(patient.diagnosis);

				Display.Items.Add(listViewItem);
				++i;
			}
		}

		async void Display_VisibleChanged(object sender, EventArgs e) => DisplayData(await ReadFromFile<Patient>());

		void Control_Click(object sender, EventArgs e) => (sender as Control).BackColor = Color.White;

		async void Button4_Click(object sender, EventArgs e)
		{
			using (var form3 = new Form3())
			{
				if (form3.ShowDialog() == DialogResult.OK)
				{
					try
					{
						await DeleteFromFileAt<Patient>(form3.GetDelIndex);
						DisplayData(await ReadFromFile<Patient>());
					}
					catch (ArgumentOutOfRangeException)
					{
						MessageBox.Show("Пользователя с таким ID не существует");
					}
				}
			}
		}

		class ListViewItemComparer : IComparer
		{
			public int col;
			public int Compare(object x, object y) => string.Compare((x as ListViewItem).SubItems[col].Text, (y as ListViewItem).SubItems[col].Text);
		}

		void Display_ColumnClick(object sender, ColumnClickEventArgs e) => Display.ListViewItemSorter = new ListViewItemComparer { col = e.Column };

		async void Button2_Click(object sender, EventArgs e)
		{
			using (var form2 = new Form2())
			{
				if (form2.ShowDialog() == DialogResult.OK)
				{
					var queryResult =
						from patient in await ReadFromFile<Patient>()
						where
							!string.IsNullOrEmpty(form2.GetDate) ? patient.date == form2.GetDate : false ||
							string.IsNullOrEmpty(form2.GetDistrict) || patient.district == form2.GetDistrict
						select patient;

					DisplayData(queryResult.ToList());
				}
			}
		}
	}
}
