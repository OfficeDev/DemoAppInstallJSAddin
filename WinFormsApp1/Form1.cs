namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form2 frm2 = new Form2();
			frm2.ShowDialog();
			frm2.BringToFront();

		}
	}
}
