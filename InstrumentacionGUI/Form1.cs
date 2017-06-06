using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;

namespace InstrumentacionGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			content.Controls.Add(InstrumentacionGUI.Sensor_tab.Instance);
			InstrumentacionGUI.Sensor_tab.Instance.Dock = DockStyle.Fill;

			content.Controls.Add(InstrumentacionGUI.ControlLed_tab.Instance);
			InstrumentacionGUI.ControlLed_tab.Instance.Dock = DockStyle.Fill; 

			content.Controls.Add(InstrumentacionGUI.Calc_tab.Instance);
			InstrumentacionGUI.Calc_tab.Instance.Dock = DockStyle.Fill;

			content.Controls.Add(InstrumentacionGUI.Config_tab.Instance);
			InstrumentacionGUI.Config_tab.Instance.Dock = DockStyle.Fill;

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void bunifuCustomLabel1_Click(object sender, EventArgs e)
		{

		}

		private void bunifuCustomLabel9_Click(object sender, EventArgs e)
		{
			InstrumentacionGUI.Sensor_tab.Instance.BringToFront();
		}

		private void bunifuCustomLabel12_Click(object sender, EventArgs e)
		{

		}

		private void bunifuImageButton6_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void bunifuImageButton7_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void content_Paint(object sender, PaintEventArgs e)
		{

		}

		private void bunifuCustomLabel10_Click(object sender, EventArgs e)
		{
			InstrumentacionGUI.ControlLed_tab.Instance.BringToFront();
		}

		private void bunifuCustomLabel11_Click(object sender, EventArgs e)
		{
			InstrumentacionGUI.Calc_tab.Instance.BringToFront();
		}

		private void bunifuImageButton3_Click(object sender, EventArgs e)
		{
			InstrumentacionGUI.Config_tab.Instance.BringToFront();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
