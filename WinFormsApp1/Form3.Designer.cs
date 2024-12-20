namespace WinFormsApp1
{
	partial class Form3
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			textBox3 = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// textBox2
			// 
			textBox2.BackColor = SystemColors.Control;
			textBox2.BorderStyle = BorderStyle.None;
			textBox2.Font = new Font("Segoe UI", 14F);
			textBox2.Location = new Point(59, 103);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(544, 205);
			textBox2.TabIndex = 8;
			textBox2.Text = "Please wait while Contoso is being installed on your computer.\r\n\r\nProgress:\r\n\r\n Installing the App and copying the files... 10%\r\n";
			// 
			// textBox1
			// 
			textBox1.BackColor = SystemColors.Control;
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
			textBox1.Location = new Point(221, 52);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(352, 75);
			textBox1.TabIndex = 7;
			textBox1.Text = "Installing Contoso";
			// 
			// textBox3
			// 
			textBox3.BackColor = SystemColors.Control;
			textBox3.Font = new Font("Calibri", 13.875F);
			textBox3.Location = new Point(-11, 281);
			textBox3.Multiline = true;
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(661, 8);
			textBox3.TabIndex = 12;
			// 
			// button1
			// 
			button1.Font = new Font("Calibri", 13.875F);
			button1.ForeColor = Color.Black;
			button1.Location = new Point(437, 304);
			button1.Name = "button1";
			button1.Size = new Size(166, 45);
			button1.TabIndex = 1;
			button1.Text = "Continue";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form3
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(631, 361);
			Controls.Add(textBox3);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			ForeColor = Color.Coral;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form3";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Contoso Installer";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox2;
		private TextBox textBox1;
		private TextBox textBox3;
		private Button button1;
		private String progressStr = "Please wait while Contoso is being installed on your computer.\r\n\r\nProgress:\r\n\r\n     Installing the App and copying the files... {0}%";
		//private System.Windows.Forms.Timer processTimer;
	}
}