using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CourseWorkSofa
{
	public partial class Form2 : Form
	{
		public Form2() => InitializeComponent();

		public string GetDistrict => District.Text;
		public string GetDate => Date.Text;

		void TextBox_Click(object sender, EventArgs e) => (sender as TextBox).BackColor = Color.White;

		bool CheckOnCorrectTextBoxDistrict(TextBox tb) => string.IsNullOrEmpty(tb.Text) || !Regex.IsMatch(tb.Text, @"^\s*$") && Regex.IsMatch(tb.Text, @"^[а-яА-Яa-zA-Z ]+$") || (tb.BackColor = Color.Red) != Color.Red;
		bool CheckOnCorrectTextBoxDate(TextBox tb) => string.IsNullOrEmpty(tb.Text) || DateTime.TryParse(tb.Text, out _) || (tb.BackColor = Color.Red) != Color.Red;

		void button1_Click(object sender, System.EventArgs e) => DialogResult = CheckOnCorrectTextBoxDistrict(District) & CheckOnCorrectTextBoxDate(Date) ? DialogResult.OK : DialogResult.None;
	}
}