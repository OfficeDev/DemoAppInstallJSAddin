namespace WinFormsApp1
{
	partial class Form4
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
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
			textBox2.Location = new Point(45, 81);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(544, 181);
			textBox2.TabIndex = 10;
			textBox2.Text = "Contoso service has been successfully installed on your computer.\r\n\r\nYou can now use the program. \r\n\r\nPlease open the Office Word to complete your experience with Contoso Web Add-in.\r\n";
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// textBox1
			// 
			textBox1.BackColor = SystemColors.Control;
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
			textBox1.Location = new Point(171, 12);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(352, 75);
			textBox1.TabIndex = 9;
			textBox1.Text = "Installation Complete";
			// 
			// textBox3
			// 
			textBox3.BackColor = SystemColors.Control;
			textBox3.Location = new Point(-10, 278);
			textBox3.Multiline = true;
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(629, 8);
			textBox3.TabIndex = 14;
			// 
			// button1
			// 
			button1.Font = new Font("Calibri", 13.875F);
			button1.Location = new Point(455, 304);
			button1.Name = "button1";
			button1.Size = new Size(134, 45);
			button1.TabIndex = 1;
			button1.Text = "Get Started";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form4
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(631, 361);
			Controls.Add(textBox3);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form4";
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
	}
}