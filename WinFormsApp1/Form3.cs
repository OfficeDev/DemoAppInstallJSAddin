using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WinFormsApp1
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
			SetTimer();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SetTimer()
		{
			// Create a timer with a two second interval.
			progressTimer.Interval = 1000;
			progressTimer.Tick += new EventHandler(TimerEventProcessorProgress);
			progressTimer.Start();
		}

		private void TimerEventProcessorProgress(Object myObject, EventArgs myEventArgs)
		{
			if (this.time < 5)
			{
				this.textBox2.Text = String.Format(this.progressStr, this.time * 20);
				this.time++;
			}
			else
			{
				progressTimer.Stop();
				this.myTimer.Interval = 1000;
				myTimer.Tick += new EventHandler(TimerEventProcessor);
				myTimer.Start();
			}
		}

		private void TimerEventProcessor(Object myObject,
										  EventArgs myEventArgs)
		{
			myTimer.Stop();
			if (this.shouldShowLast)
			{
				this.Hide();
				Form4 frm = new Form4();
				frm.ShowDialog();
				frm.BringToFront();
				this.shouldShowLast = false;
			}
		}
		bool shouldShowLast = true;
		int time = 1;
		System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
		System.Windows.Forms.Timer progressTimer = new System.Windows.Forms.Timer();
	}
}
