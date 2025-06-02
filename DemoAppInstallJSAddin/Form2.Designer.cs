namespace WinFormsApp1
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			pictureBox1 = new PictureBox();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			checkBox1 = new CheckBox();
			linkLabel1 = new LinkLabel();
			textBox3 = new TextBox();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
			pictureBox1.Location = new Point(37, 67);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(151, 186);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// textBox1
			// 
			textBox1.BackColor = SystemColors.Control;
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
			textBox1.Location = new Point(234, 49);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(356, 68);
			textBox1.TabIndex = 100;
			textBox1.Text = "Welcome! Enjoy your journey with Contoso application";
			// 
			// textBox2
			// 
			textBox2.BackColor = SystemColors.Control;
			textBox2.BorderStyle = BorderStyle.None;
			textBox2.Font = new Font("Segoe UI", 14F);
			textBox2.Location = new Point(234, 132);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(367, 75);
			textBox2.TabIndex = 6;
			textBox2.Text = "Create, run, and share your Office Add-in code snippets from within Excel, Word, or PowerPoint.";
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Font = new Font("Segoe UI", 12F);
			checkBox1.Location = new Point(234, 213);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(290, 25);
			checkBox1.TabIndex = 1;
			checkBox1.Text = "Accept to install Contoso Web Add-in ";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Font = new Font("Segoe UI", 12F);
			linkLabel1.Location = new Point(530, 217);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(60, 21);
			linkLabel1.TabIndex = 8;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Privacy";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// textBox3
			// 
			textBox3.BackColor = SystemColors.Control;
			textBox3.Location = new Point(-1, 285);
			textBox3.Multiline = true;
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(639, 10);
			textBox3.TabIndex = 10;
			// 
			// button1
			// 
			button1.Font = new Font("Calibri", 13.875F);
			button1.Location = new Point(453, 301);
			button1.Name = "button1";
			button1.Size = new Size(166, 45);
			button1.TabIndex = 9;
			button1.Text = "Continue";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(631, 361);
			Controls.Add(textBox3);
			Controls.Add(button1);
			Controls.Add(linkLabel1);
			Controls.Add(checkBox1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(pictureBox1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form2";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Contoso Installer";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private TextBox textBox1;
		private TextBox textBox2;
		private CheckBox checkBox1;
		private LinkLabel linkLabel1;
		private TextBox textBox3;
		private Button button1;
	}
}