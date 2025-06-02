namespace WinFormsApp1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			pictureBox1 = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			button1 = new Button();
			textBox1 = new TextBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
			pictureBox1.Location = new Point(210, 91);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(160, 136);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
			label1.Location = new Point(147, 38);
			label1.Name = "label1";
			label1.Size = new Size(293, 32);
			label1.TabIndex = 1;
			label1.Text = "Welcome Contoso Setup";
			label1.TextAlign = ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14F);
			label2.Location = new Point(60, 247);
			label2.Name = "label2";
			label2.Size = new Size(534, 25);
			label2.TabIndex = 2;
			label2.Text = "This wizard will guide you through the installation of Contoso.";
			label2.TextAlign = ContentAlignment.BottomCenter;
			// 
			// button1
			// 
			button1.Font = new Font("Calibri", 13.875F);
			button1.Location = new Point(453, 304);
			button1.Name = "button1";
			button1.Size = new Size(166, 45);
			button1.TabIndex = 3;
			button1.Text = "Continue";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.BackColor = SystemColors.Control;
			textBox1.Location = new Point(11, 284);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(608, 10);
			textBox1.TabIndex = 4;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(631, 361);
			Controls.Add(textBox1);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Contoso Installer";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private Button button1;
		private TextBox textBox1;
	}
}
